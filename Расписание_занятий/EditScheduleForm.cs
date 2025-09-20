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
    public partial class EditScheduleForm: Form
    {
        private readonly int scheduleId;
        private readonly int? teacherId; // null для администратора
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public EditScheduleForm(int scheduleId) : this(scheduleId, null) { }

        public EditScheduleForm(int scheduleId, int? teacherId)
        {
            InitializeComponent(); 
            this.scheduleId = scheduleId;
            this.teacherId = teacherId;

            // Перенесем LoadData в Load формы
            this.Load += (s, e) => LoadData();
        }
        private void LoadData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Загрузка данных для комбобоксов
                    LoadComboBoxData(conn);

                    // Загрузка данных текущего занятия
                    SqlCommand cmd = new SqlCommand(
                        @"SELECT s.*, 
                 t.last_name + ' ' + t.first_name + ' ' + t.middle_name AS teacher_name,
                 g.name AS group_name,
                 sub.name AS subject_name,
                 lt.name AS lesson_type_name,
                 a.room_number + ' (' + a.building + ')' AS auditorium_name
                 FROM Schedule s
                 JOIN Teachers t ON s.teacher_id = t.teacher_id
                 JOIN Groups g ON s.group_id = g.group_id
                 JOIN Subjects sub ON s.subject_id = sub.subject_id
                 JOIN LessonTypes lt ON s.lesson_type_id = lt.lesson_type_id
                 JOIN Auditoriums a ON s.auditorium_id = a.auditorium_id
                 WHERE s.schedule_id = @id", conn);

                    cmd.Parameters.AddWithValue("@id", scheduleId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Проверка прав преподавателя
                            if (teacherId.HasValue && Convert.ToInt32(reader["teacher_id"]) != teacherId.Value)
                            {
                                MessageBox.Show("У вас нет прав редактировать это занятие");
                                this.Close();
                                return;
                            }

                            // Заполнение полей формы
                            comboSubject.SelectedValue = reader["subject_id"];
                            comboLessonType.SelectedValue = reader["lesson_type_id"];

                            if (!teacherId.HasValue) // Только для администратора
                                comboTeacher.SelectedValue = reader["teacher_id"];

                            comboAuditorium.SelectedValue = reader["auditorium_id"];
                            comboGroup.SelectedValue = reader["group_id"];
                            comboDay.Text = reader["day_of_week"].ToString();
                            numericPair.Value = Convert.ToInt32(reader["pair_number"]);
                            checkNumerator.Checked = Convert.ToBoolean(reader["numerator"]);
                            checkHalfGroup.Checked = Convert.ToBoolean(reader["is_halfgroup"]);
                        }
                        else
                        {
                            MessageBox.Show("Занятие не найдено");
                            this.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}");
                this.Close();
            }
        }

        private void LoadComboBoxData(SqlConnection connection)
        {
            try
            {
                // Загрузка предметов
                string subjectsQuery = teacherId.HasValue
                    ? "SELECT subject_id, name FROM Subjects WHERE teacher_id = @teacherId"
                    : "SELECT subject_id, name FROM Subjects";

                SqlDataAdapter subjectsAdapter = new SqlDataAdapter(subjectsQuery, connection);

                if (teacherId.HasValue)
                    subjectsAdapter.SelectCommand.Parameters.AddWithValue("@teacherId", teacherId);

                DataTable subjectsTable = new DataTable();
                subjectsAdapter.Fill(subjectsTable);
                comboSubject.DataSource = subjectsTable;
                comboSubject.DisplayMember = "name";
                comboSubject.ValueMember = "subject_id";

                // Загрузка типов занятий
                SqlDataAdapter typesAdapter = new SqlDataAdapter(
                    "SELECT lesson_type_id, name FROM LessonTypes", connection);
                DataTable typesTable = new DataTable();
                typesAdapter.Fill(typesTable);
                comboLessonType.DataSource = typesTable;
                comboLessonType.DisplayMember = "name";
                comboLessonType.ValueMember = "lesson_type_id";

                // Загрузка преподавателей (только для администратора)
                if (!teacherId.HasValue)
                {
                    SqlDataAdapter teachersAdapter = new SqlDataAdapter(
                        "SELECT teacher_id, last_name + ' ' + first_name + ' ' + middle_name AS full_name FROM Teachers",
                        connection);
                    DataTable teachersTable = new DataTable();
                    teachersAdapter.Fill(teachersTable);
                    comboTeacher.DataSource = teachersTable;
                    comboTeacher.DisplayMember = "full_name";
                    comboTeacher.ValueMember = "teacher_id";
                }

                // Загрузка аудиторий
                SqlDataAdapter auditoriumsAdapter = new SqlDataAdapter(
                    "SELECT auditorium_id, room_number + ' (' + building + ')' AS room FROM Auditoriums",
                    connection);
                DataTable auditoriumsTable = new DataTable();
                auditoriumsAdapter.Fill(auditoriumsTable);
                comboAuditorium.DataSource = auditoriumsTable;
                comboAuditorium.DisplayMember = "room";
                comboAuditorium.ValueMember = "auditorium_id";

                // Загрузка групп
                SqlDataAdapter groupsAdapter = new SqlDataAdapter(
                    "SELECT group_id, name FROM Groups", connection);
                DataTable groupsTable = new DataTable();
                groupsAdapter.Fill(groupsTable);
                comboGroup.DataSource = groupsTable;
                comboGroup.DisplayMember = "name";
                comboGroup.ValueMember = "group_id";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных для выбора: {ex.Message}");
                this.Close();
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(@"
                UPDATE Schedule SET
                    subject_id = @subject,
                    lesson_type_id = @type,
                    teacher_id = @teacher,
                    auditorium_id = @aud,
                    group_id = @group,
                    day_of_week = @day,
                    pair_number = @pair,
                    numerator = @num,
                    is_halfgroup = @half
                WHERE schedule_id = @id", conn);

                    // Добавление параметров
                    cmd.Parameters.AddWithValue("@subject", comboSubject.SelectedValue);
                    cmd.Parameters.AddWithValue("@type", comboLessonType.SelectedValue);
                    cmd.Parameters.AddWithValue("@teacher",
                        teacherId.HasValue ? teacherId.Value : comboTeacher.SelectedValue);
                    cmd.Parameters.AddWithValue("@aud", comboAuditorium.SelectedValue);
                    cmd.Parameters.AddWithValue("@group", comboGroup.SelectedValue);
                    cmd.Parameters.AddWithValue("@day", comboDay.Text);
                    cmd.Parameters.AddWithValue("@pair", numericPair.Value);
                    cmd.Parameters.AddWithValue("@num", checkNumerator.Checked);
                    cmd.Parameters.AddWithValue("@half", checkHalfGroup.Checked);
                    cmd.Parameters.AddWithValue("@id", scheduleId);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Изменения сохранены");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Не удалось сохранить изменения");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении: {ex.Message}");
            }
        }

        private bool ValidateInput()
        {
            if (comboSubject.SelectedValue == null)
            {
                MessageBox.Show("Выберите предмет");
                return false;
            }

            if (comboLessonType.SelectedValue == null)
            {
                MessageBox.Show("Выберите тип занятия");
                return false;
            }

            if (!teacherId.HasValue && comboTeacher.SelectedValue == null)
            {
                MessageBox.Show("Выберите преподавателя");
                return false;
            }

            if (comboAuditorium.SelectedValue == null)
            {
                MessageBox.Show("Выберите аудиторию");
                return false;
            }

            if (comboGroup.SelectedValue == null)
            {
                MessageBox.Show("Выберите группу");
                return false;
            }

            if (string.IsNullOrEmpty(comboDay.Text))
            {
                MessageBox.Show("Выберите день недели");
                return false;
            }

            return true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void comboDay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboGroup_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboAuditorium_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EditScheduleForm_Load(object sender, EventArgs e)
        {

        }

        private void comboSubject_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboLessonType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboTeacher_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
