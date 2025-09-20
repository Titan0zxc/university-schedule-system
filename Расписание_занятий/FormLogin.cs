using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;



namespace Расписание_занятий
{
    public partial class FormLogin: Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        private SqlConnection connection;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text.Trim();
            string password = txtPassword.Text.Trim();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(@"
            SELECT u.user_id, u.role_id, r.name AS role_name, u.teacher_id, u.group_id
            FROM Users u
            JOIN Roles r ON r.role_id = u.role_id
            WHERE u.login = @login AND u.password = @password", conn);

                cmd.Parameters.AddWithValue("@login", login);
                cmd.Parameters.AddWithValue("@password", password); 

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string role = reader["role_name"].ToString();

                    int? teacherId = reader["teacher_id"] == DBNull.Value ? (int?)null : Convert.ToInt32(reader["teacher_id"]);
                    int? groupId = reader["group_id"] == DBNull.Value ? (int?)null : Convert.ToInt32(reader["group_id"]);

                    this.Hide();

                    switch (role)
                    {
                        case "Admin":
                        case "Администратор":
                            new Form1().Show(); break;

                        case "Teacher":
                        case "Преподаватель":
                            if (teacherId.HasValue)
                                new TeacherForm(teacherId.Value).Show();
                            else
                                MessageBox.Show("Для преподавателя не задан teacher_id.");
                            break;

                        case "Student":
                        case "Студент":
                            if (groupId.HasValue)
                                new StudentForm(groupId.Value).Show();
                            else
                                MessageBox.Show("Для студента не задан group_id.");
                            break;

                        default:
                            MessageBox.Show("Неизвестная роль: " + role);
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль.");
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }
    }
}
