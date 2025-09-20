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
    public partial class RegisterForm: Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        private SqlConnection connection;
        public RegisterForm()
        {
            InitializeComponent();
            LoadRoles();
            LoadGroupAndTeacher();
        }

        private void LoadRoles()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT role_id, name FROM Roles", connection);
                DataTable roleTable = new DataTable();
                adapter.Fill(roleTable);

                comboRole.DataSource = roleTable;
                comboRole.DisplayMember = "name";
                comboRole.ValueMember = "role_id";
            }

            comboRole.SelectedIndexChanged += comboRole_SelectedIndexChanged;
        }

        private void LoadGroupAndTeacher()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Teachers
                SqlDataAdapter adapter1 = new SqlDataAdapter("SELECT teacher_id, last_name + ' ' + first_name + ' ' + middle_name AS full_name FROM Teachers", connection);
                DataTable tTable = new DataTable();
                adapter1.Fill(tTable);
                comboTeacher.DataSource = tTable;
                comboTeacher.DisplayMember = "full_name";
                comboTeacher.ValueMember = "teacher_id";
                comboTeacher.Visible = false;

                // Groups
                SqlDataAdapter adapter2 = new SqlDataAdapter("SELECT group_id, name FROM Groups", connection);
                DataTable gTable = new DataTable();
                adapter2.Fill(gTable);
                comboGroup.DataSource = gTable;
                comboGroup.DisplayMember = "name";
                comboGroup.ValueMember = "group_id";
                comboGroup.Visible = false;
            }
        }

        private void comboRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboRole.SelectedValue == null) return;

            int roleId = Convert.ToInt32(comboRole.SelectedValue);

            comboGroup.Visible = (roleId == 3);      // Студент
            comboTeacher.Visible = (roleId == 2);    // Преподаватель
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text.Trim();
            string pass = txtPassword.Text;
            string confirm = txtConfirm.Text;

            if (login == "" || pass == "" || confirm == "")
            {
                MessageBox.Show("Заполните все поля");
                return;
            }

            if (pass != confirm)
            {
                MessageBox.Show("Пароли не совпадают");
                return;
            }

            int roleId = Convert.ToInt32(comboRole.SelectedValue);
            object teacherId = DBNull.Value;
            object groupId = DBNull.Value;

            if (roleId == 2) // Преподаватель
                teacherId = comboTeacher.SelectedValue;
            else if (roleId == 3) // Студент
                groupId = comboGroup.SelectedValue;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(@"
            INSERT INTO Users (login, password, role_id, teacher_id, group_id)
            VALUES (@login, @pass, @role, @teacher_id, @group_id)", connection);

                command.Parameters.AddWithValue("@login", login);
                command.Parameters.AddWithValue("@pass", pass);
                command.Parameters.AddWithValue("@role", roleId);
                command.Parameters.AddWithValue("@teacher_id", teacherId ?? DBNull.Value);
                command.Parameters.AddWithValue("@group_id", groupId ?? DBNull.Value);

                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Регистрация успешна!");
                    this.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Ошибка регистрации: " + ex.Message);
                }
            }
        }
    }
}
