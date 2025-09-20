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
    public partial class TeacherForm: Form
    {
        private readonly int teacherId;
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        public TeacherForm(int value)
        {
            InitializeComponent();
            this.teacherId = value; 

            // Загрузка данных в комбобоксы
            LoadComboBoxData();

            // Загрузка расписания
            LoadSchedule();
        }
        private void LoadComboBoxData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Загрузка предметов, которые ведет данный преподаватель (через расписание)
                string subjectsQuery = @"
            SELECT DISTINCT s.subject_id, sub.name 
            FROM Schedule s
            JOIN Subjects sub ON s.subject_id = sub.subject_id
            WHERE s.teacher_id = @teacherId
            ORDER BY sub.name";

                SqlDataAdapter subjectsAdapter = new SqlDataAdapter(subjectsQuery, connection);
                subjectsAdapter.SelectCommand.Parameters.AddWithValue("@teacherId", teacherId);
                DataTable subjectsTable = new DataTable();
                subjectsAdapter.Fill(subjectsTable);

                comboSubject.DataSource = subjectsTable;
                comboSubject.DisplayMember = "name";
                comboSubject.ValueMember = "subject_id";

                // Загрузка типов занятий
                SqlDataAdapter typesAdapter = new SqlDataAdapter(
                    "SELECT lesson_type_id, name FROM LessonTypes ORDER BY name", connection);
                DataTable typesTable = new DataTable();
                typesAdapter.Fill(typesTable);

                comboLessonType.DataSource = typesTable;
                comboLessonType.DisplayMember = "name";
                comboLessonType.ValueMember = "lesson_type_id";

                // Загрузка групп
                SqlDataAdapter groupsAdapter = new SqlDataAdapter(
                    "SELECT group_id, name FROM Groups ORDER BY name", connection);
                DataTable groupsTable = new DataTable();
                groupsAdapter.Fill(groupsTable);

                comboGroup.DataSource = groupsTable;
                comboGroup.DisplayMember = "name";
                comboGroup.ValueMember = "group_id";

                // Загрузка аудиторий
                SqlDataAdapter auditoriumsAdapter = new SqlDataAdapter(
                    "SELECT auditorium_id, room_number + ' (' + building + ')' AS room FROM Auditoriums ORDER BY room", connection);
                DataTable auditoriumsTable = new DataTable();
                auditoriumsAdapter.Fill(auditoriumsTable);

                comboAuditorium.DataSource = auditoriumsTable;
                comboAuditorium.DisplayMember = "room";
                comboAuditorium.ValueMember = "auditorium_id";
            }

            // Заполнение дней недели
            comboDay.Items.AddRange(new string[] {
        "Понедельник", "Вторник", "Среда",
        "Четверг", "Пятница", "Суббота", "Воскресенье"
    });
            comboDay.SelectedIndex = 0;
        }

        private void LoadSchedule()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(@"
                SELECT 
                    s.day_of_week AS [День недели],
                    s.pair_number AS [Пара],
                    sub.name AS [Предмет],
                    lt.name AS [Тип занятия],
                    g.name AS [Группа],
                    CASE WHEN s.numerator = 1 THEN 'Числитель' ELSE 'Знаменатель' END AS [Неделя],
                    CASE WHEN s.is_halfgroup = 1 THEN 'Полгруппа' ELSE 'Вся группа' END AS [Форма],
                    a.room_number + ' (' + a.building + ')' AS [Аудитория]
                FROM Schedule s
                JOIN Subjects sub ON sub.subject_id = s.subject_id
                JOIN LessonTypes lt ON lt.lesson_type_id = s.lesson_type_id
                JOIN Groups g ON g.group_id = s.group_id
                JOIN Auditoriums a ON a.auditorium_id = s.auditorium_id
                WHERE s.teacher_id = @teacherId
                ORDER BY 
                    CASE s.day_of_week
                        WHEN 'Понедельник' THEN 1
                        WHEN 'Вторник' THEN 2
                        WHEN 'Среда' THEN 3
                        WHEN 'Четверг' THEN 4
                        WHEN 'Пятница' THEN 5
                        WHEN 'Суббота' THEN 6
                        WHEN 'Воскресенье' THEN 7
                        ELSE 8
                    END,
                    s.pair_number
            ", connection);

                cmd.Parameters.AddWithValue("@teacherId", teacherId);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);

                scheduleGrid.DataSource = table;

                if (table.Rows.Count == 0)
                    MessageBox.Show("У вас пока нет занятий.");
            }
        }

        private void btnAddLesson_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(@"
                    INSERT INTO Schedule 
                    (subject_id, lesson_type_id, teacher_id, auditorium_id, group_id, day_of_week, pair_number, numerator, is_halfgroup)
                    VALUES (@subject, @type, @teacher, @aud, @group, @day, @pair, @num, @half)", conn);

                    cmd.Parameters.AddWithValue("@subject", comboSubject.SelectedValue);
                    cmd.Parameters.AddWithValue("@type", comboLessonType.SelectedValue);
                    cmd.Parameters.AddWithValue("@teacher", teacherId);
                    cmd.Parameters.AddWithValue("@aud", comboAuditorium.SelectedValue);
                    cmd.Parameters.AddWithValue("@group", comboGroup.SelectedValue);
                    cmd.Parameters.AddWithValue("@day", comboDay.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@pair", numericPair.Value);
                    cmd.Parameters.AddWithValue("@num", checkNumerator.Checked ? 1 : 0);
                    cmd.Parameters.AddWithValue("@half", checkHalfGroup.Checked ? 1 : 0);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Занятие добавлено.");
                        LoadSchedule();
                    }
                    else
                    {
                        MessageBox.Show("Не удалось добавить занятие.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении занятия: {ex.Message}");
            }
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            if (scheduleGrid.Rows.Count == 0)
            {
                MessageBox.Show("Нет данных для экспорта.");
                return;
            }

            Excel.Application excelApp = new Excel.Application();
            excelApp.Visible = true;

            Excel.Workbook workbook = excelApp.Workbooks.Add();
            Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets[1];

            // Заголовки
            for (int i = 0; i < scheduleGrid.Columns.Count; i++)
            {
                worksheet.Cells[1, i + 1] = scheduleGrid.Columns[i].HeaderText;
            }

            // Данные
            for (int i = 0; i < scheduleGrid.Rows.Count; i++)
            {
                for (int j = 0; j < scheduleGrid.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = scheduleGrid.Rows[i].Cells[j].Value?.ToString();
                }
            }

            // Автоподбор ширины
            worksheet.Columns.AutoFit();

            MessageBox.Show("Экспорт завершен!");
        }

        private void btnExportWord_Click(object sender, EventArgs e)
        {

        }

        private void btnEditLesson_Click(object sender, EventArgs e)
        {
            if (scheduleGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите занятие для редактирования");
                return;
            }

            DataGridViewRow selectedRow = scheduleGrid.SelectedRows[0];
            int scheduleId = Convert.ToInt32(selectedRow.Cells["ID"].Value); 

            // Создаем форму редактирования
            EditScheduleForm editForm = new EditScheduleForm(scheduleId, teacherId);
            editForm.FormClosed += (s, args) => LoadSchedule(); // Обновляем расписание после закрытия формы
            editForm.ShowDialog();
        }

        private void btnDeleteLesson_Click(object sender, EventArgs e)
        {
            if (scheduleGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите занятие для удаления");
                return;
            }

            if (MessageBox.Show("Вы уверены, что хотите удалить это занятие?",
                "Подтверждение удаления", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DataGridViewRow selectedRow = scheduleGrid.SelectedRows[0];
                int scheduleId = Convert.ToInt32(selectedRow.Cells["ID"].Value);

                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand(
                            "DELETE FROM Schedule WHERE schedule_id = @id AND teacher_id = @teacherId",
                            conn);
                        cmd.Parameters.AddWithValue("@id", scheduleId);
                        cmd.Parameters.AddWithValue("@teacherId", teacherId);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Занятие удалено");
                            LoadSchedule();
                        }
                        else
                        {
                            MessageBox.Show("Не удалось удалить занятие или у вас нет прав");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при удалении: {ex.Message}");
                }
            }
        }

        private void btnReturnToLogin_Click(object sender, EventArgs e)
        {
            this.Close();
            new FormLogin().Show();
        }
    }
}
