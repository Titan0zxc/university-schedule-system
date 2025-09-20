using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

public class ScheduleService
{
    private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

    public void LoadSchedule(DataGridView grid)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlDataAdapter adapter = new SqlDataAdapter(
                @"SELECT s.schedule_id, sub.name AS Предмет, lt.name AS Вид,
                         t.last_name + ' ' + t.first_name + ' ' + t.middle_name AS Преподаватель,
                         g.name AS Группа, s.day_of_week AS День, s.pair_number AS Пара,
                         CASE WHEN s.numerator = 1 THEN 'Числитель' ELSE 'Знаменатель' END AS Неделя,
                         CASE WHEN s.is_halfgroup = 1 THEN 'Полгруппа' ELSE 'Группа' END AS Полнота,
                         a.room_number + ' (' + a.building + ')' AS Аудитория
                  FROM Schedule s
                  JOIN Subjects sub ON sub.subject_id = s.subject_id
                  JOIN LessonTypes lt ON lt.lesson_type_id = s.lesson_type_id
                  JOIN Teachers t ON t.teacher_id = s.teacher_id
                  JOIN Auditoriums a ON a.auditorium_id = s.auditorium_id
                  JOIN Groups g ON g.group_id = s.group_id", connection);

            DataTable table = new DataTable();
            adapter.Fill(table);
            grid.DataSource = table;
        }
    }
}