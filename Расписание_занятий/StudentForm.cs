using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;
using System.IO;

namespace Расписание_занятий
{
    public partial class StudentForm : Form
    {
        private readonly int groupId;
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        public StudentForm(int value)
        {
            InitializeComponent();
            this.groupId = value;
            MessageBox.Show($"Загружаем расписание для группы ID: {groupId}"); 
            LoadStudentSchedule();
        }

        private void LoadStudentSchedule()
        {
            try
            {
                DataTable resultTable = new DataTable();
                resultTable.Columns.Add("День недели");
                resultTable.Columns.Add("Пара");
                resultTable.Columns.Add("Предмет");
                resultTable.Columns.Add("Преподаватель");
                resultTable.Columns.Add("Аудитория");
                resultTable.Columns.Add("Неделя");
                resultTable.Columns.Add("Форма");

                var days = new[] { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Проверка существования группы
                    SqlCommand checkGroupCmd = new SqlCommand(
                        "SELECT COUNT(*) FROM Groups WHERE group_id = @groupId",
                        connection);
                    checkGroupCmd.Parameters.AddWithValue("@groupId", groupId);
                    int groupExists = (int)checkGroupCmd.ExecuteScalar();

                    if (groupExists == 0)
                    {
                        MessageBox.Show("Группа не найдена в базе данных");
                        return;
                    }

                    foreach (var day in days)
                    {
                        string query = @"
                    SELECT 
                        s.pair_number,
                        sub.name AS Предмет,
                        t.last_name + ' ' + t.first_name + ' ' + t.middle_name AS Преподаватель,
                        a.room_number + ' (' + a.building + ')' AS Аудитория,
                        CASE WHEN s.numerator = 1 THEN 'Числитель' ELSE 'Знаменатель' END AS Неделя,
                        CASE WHEN s.is_halfgroup = 1 THEN 'Полгруппа' ELSE 'Группа' END AS Форма
                    FROM Schedule s
                    JOIN Subjects sub ON sub.subject_id = s.subject_id
                    JOIN Teachers t ON t.teacher_id = s.teacher_id
                    JOIN Auditoriums a ON a.auditorium_id = s.auditorium_id
                    WHERE s.group_id = @groupId AND s.day_of_week = @day
                    ORDER BY s.pair_number";

                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@groupId", groupId);
                        cmd.Parameters.AddWithValue("@day", day);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            bool hasRows = false;
                            while (reader.Read())
                            {
                                hasRows = true;
                                resultTable.Rows.Add(
                                    day,
                                    reader["pair_number"],
                                    reader["Предмет"],
                                    reader["Преподаватель"],
                                    reader["Аудитория"],
                                    reader["Неделя"],
                                    reader["Форма"]
                                );
                            }

                            if (!hasRows)
                            {
                                resultTable.Rows.Add(day, "", "Нет занятий", "", "", "", "");
                            }
                        }
                    }
                }

                gridStudent.DataSource = resultTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке расписания: {ex.Message}");
            }
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            if (gridStudent.Rows.Count == 0) return;

            var excelApp = new Microsoft.Office.Interop.Excel.Application();
            var workbook = excelApp.Workbooks.Add();
            var worksheet = (Excel.Worksheet)workbook.Sheets[1];

            for (int i = 0; i < gridStudent.Columns.Count; i++)
                worksheet.Cells[1, i + 1] = gridStudent.Columns[i].HeaderText;

            for (int i = 0; i < gridStudent.Rows.Count; i++)
            {
                for (int j = 0; j < gridStudent.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = gridStudent.Rows[i].Cells[j].Value?.ToString();
                }
            }

            worksheet.Columns.AutoFit();
            excelApp.Visible = true;
        }

        private void btnExportWord_Click(object sender, EventArgs e)
        {
            if (gridStudent.Rows.Count == 0) return;

            var wordApp = new Word.Application();
            var doc = wordApp.Documents.Add();

            Word.Table wordTable = doc.Tables.Add(doc.Range(0, 0), gridStudent.Rows.Count + 1, gridStudent.Columns.Count);

            for (int i = 0; i < gridStudent.Columns.Count; i++)
                wordTable.Cell(1, i + 1).Range.Text = gridStudent.Columns[i].HeaderText;

            for (int i = 0; i < gridStudent.Rows.Count; i++)
            {
                for (int j = 0; j < gridStudent.Columns.Count; j++)
                {
                    wordTable.Cell(i + 2, j + 1).Range.Text = gridStudent.Rows[i].Cells[j].Value?.ToString();
                }
            }

            wordApp.Visible = true;
        }

        private void btnReturnToLogin_Click(object sender, EventArgs e)
        {
            this.Close();
            new FormLogin().Show();
        }
    }
}
