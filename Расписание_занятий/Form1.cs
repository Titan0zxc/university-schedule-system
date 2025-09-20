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
using System.Diagnostics;

namespace Расписание_занятий
{
    public partial class Form1 : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        private SqlConnection connection;
        private object joinType;


        public Form1()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString); // <== ОБЯЗАТЕЛЬНО!
            LoadClients(); // Загружаем данные при запуске формы
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadComboBoxData();
            comboReportField.Items.Clear();
            comboReportField.Items.Add("Преподаватель");
            comboReportField.Items.Add("Группа");
            comboReportField.Items.Add("Аудитория");
            comboReportField.Items.Add("День недели");
            comboReportField.Items.Add("Предмет");
            comboReportField.SelectedIndex = 0;

            comboJoinType.Items.Clear();
            comboJoinType.Items.Add("По общему - INNER JOIN");
            comboJoinType.Items.Add("По левой таблице - LEFT JOIN");
            comboJoinType.SelectedIndex = 0;

            comboJoinAdvanced.Items.Add("INNER JOIN");
            comboJoinAdvanced.Items.Add("LEFT JOIN");
            comboJoinAdvanced.Items.Add("FULL OUTER JOIN"); // главное отличие
            comboJoinAdvanced.SelectedIndex = 0;

        }
        private void LoadClients()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("Соединение установлено!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка подключения: " + ex.Message);
                }
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void LoadComboBoxData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Предметы
                using (SqlCommand cmd = new SqlCommand("SELECT subject_id, name FROM Subjects", connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    comboSubject.DataSource = table;
                    comboSubject.DisplayMember = "name";
                    comboSubject.ValueMember = "subject_id";
                }

                // Вид занятия
                using (SqlCommand cmd = new SqlCommand("SELECT lesson_type_id, name FROM LessonTypes", connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    comboLessonType.DataSource = table;
                    comboLessonType.DisplayMember = "name";
                    comboLessonType.ValueMember = "lesson_type_id";
                }

                // Преподаватели
                using (SqlCommand cmd = new SqlCommand("SELECT teacher_id, last_name + ' ' + first_name + ' ' + middle_name AS full_name FROM Teachers", connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    comboTeacher.DataSource = table;
                    comboTeacher.DisplayMember = "full_name";
                    comboTeacher.ValueMember = "teacher_id";
                }

                // Группы
                using (SqlCommand cmd = new SqlCommand("SELECT group_id, name FROM Groups", connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    comboGroup.DataSource = table;
                    comboGroup.DisplayMember = "name";
                    comboGroup.ValueMember = "group_id";
                }

                // Аудитории
                using (SqlCommand cmd = new SqlCommand("SELECT auditorium_id, room_number + ' (' + building + ')' AS room FROM Auditoriums", connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    comboAuditorium.DataSource = table;
                    comboAuditorium.DisplayMember = "room";
                    comboAuditorium.ValueMember = "auditorium_id";
                }
            }

            // Дни недели (ручной список)
            comboDayOfWeek.Items.Clear();
            comboDayOfWeek.Items.AddRange(new string[]
            {
        "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота"
            });
            comboDayOfWeek.SelectedIndex = 0;

            // Загрузка групп для фильтра (отдельно, чтобы не мешать comboGroup на вкладке "добавить занятие")
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT group_id, name FROM Groups", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                comboGroupFilter.DataSource = table;
                comboGroupFilter.DisplayMember = "name";
                comboGroupFilter.ValueMember = "group_id";
            }
        }

        private void btnAddSchedule_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(
                        @"INSERT INTO Schedule 
                    (subject_id, lesson_type_id, teacher_id, auditorium_id, group_id, day_of_week, pair_number, numerator, is_halfgroup)
                  VALUES 
                    (@subject, @type, @teacher, @auditorium, @group, @day, @pair, @numerator, @halfgroup)", connection);

                    command.Parameters.AddWithValue("@subject", comboSubject.SelectedValue);
                    command.Parameters.AddWithValue("@type", comboLessonType.SelectedValue);
                    command.Parameters.AddWithValue("@teacher", comboTeacher.SelectedValue);
                    command.Parameters.AddWithValue("@group", comboGroup.SelectedValue);
                    command.Parameters.AddWithValue("@auditorium", comboAuditorium.SelectedValue);
                    command.Parameters.AddWithValue("@day", comboDayOfWeek.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@pair", (int)numericPairNumber.Value);
                    command.Parameters.AddWithValue("@numerator", checkNumerator.Checked);
                    command.Parameters.AddWithValue("@halfgroup", checkHalfGroup.Checked);

                    command.ExecuteNonQuery();

                    MessageBox.Show("Занятие добавлено!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении занятия:\n" + ex.Message);
            }
            LoadSchedule();
        }
        private void LoadSchedule()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                SELECT 
                    s.schedule_id AS [ID],
                    sub.name AS [Предмет],
                    lt.name AS [Вид занятия],
                    t.last_name + ' ' + t.first_name + ' ' + t.middle_name AS [Преподаватель],
                    g.name AS [Группа],
                    s.day_of_week AS [День],
                    s.pair_number AS [Пара],
                    CASE WHEN s.numerator = 1 THEN 'Числитель' ELSE 'Знаменатель' END AS [Неделя],
                    CASE WHEN s.is_halfgroup = 1 THEN 'Полгруппа' ELSE 'Группа' END AS [Форма],
                    a.room_number + ' (' + a.building + ')' AS [Аудитория]
                FROM Schedule s
                JOIN Subjects sub ON sub.subject_id = s.subject_id
                JOIN LessonTypes lt ON lt.lesson_type_id = s.lesson_type_id
                JOIN Teachers t ON t.teacher_id = s.teacher_id
                JOIN Groups g ON g.group_id = s.group_id
                JOIN Auditoriums a ON a.auditorium_id = s.auditorium_id
                ORDER BY s.day_of_week, s.pair_number
            ";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    scheduleGrid.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки расписания:\n" + ex.Message);
            }
        }

        private void btnLoadSchedule_Click(object sender, EventArgs e)
        {
            LoadSchedule();
        }
        private void LoadScheduleForGroup(int groupId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                SELECT 
                    s.schedule_id AS [ID],
                    sub.name AS [Предмет],
                    lt.name AS [Вид занятия],
                    t.last_name + ' ' + t.first_name + ' ' + t.middle_name AS [Преподаватель],
                    g.name AS [Группа],
                    s.day_of_week AS [День],
                    s.pair_number AS [Пара],
                    CASE WHEN s.numerator = 1 THEN 'Числитель' ELSE 'Знаменатель' END AS [Неделя],
                    CASE WHEN s.is_halfgroup = 1 THEN 'Полгруппа' ELSE 'Группа' END AS [Форма],
                    a.room_number + ' (' + a.building + ')' AS [Аудитория]
                FROM Schedule s
                JOIN Subjects sub ON sub.subject_id = s.subject_id
                JOIN LessonTypes lt ON lt.lesson_type_id = s.lesson_type_id
                JOIN Teachers t ON t.teacher_id = s.teacher_id
                JOIN Groups g ON g.group_id = s.group_id
                JOIN Auditoriums a ON a.auditorium_id = s.auditorium_id
                WHERE s.group_id = @groupId
                ORDER BY s.day_of_week, s.pair_number";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@groupId", groupId);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    scheduleGrid.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка фильтрации по группе:\n" + ex.Message);
            }
        }

        private void btnFilterByGroup_Click(object sender, EventArgs e)
        {
            int selectedGroupId = Convert.ToInt32(comboGroupFilter.SelectedValue);
            LoadScheduleForGroup(selectedGroupId);
        }
        //private void ExportToWord(DataTable dataTable)
        //{
        //    var wordApp = new Word.Application();
        //    wordApp.Visible = true;
        //    var doc = wordApp.Documents.Add();

        //    // Добавление заголовка
        //    var paragraph = doc.Paragraphs.Add();
        //    paragraph.Range.Text = "Отчет по расписанию";
        //    paragraph.Range.Font.Size = 16;
        //    paragraph.Range.Font.Bold = 1;
        //    paragraph.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
        //    paragraph.Range.InsertParagraphAfter();

        //    // Добавление таблицы
        //    Word.Table table = doc.Tables.Add(paragraph.Range, dataTable.Rows.Count + 1, dataTable.Columns.Count);
        //    table.Borders.Enable = 1;

        //    // Заголовки столбцов
        //    for (int i = 0; i < dataTable.Columns.Count; i++)
        //    {
        //        table.Cell(1, i + 1).Range.Text = dataTable.Columns[i].ColumnName;
        //        table.Cell(1, i + 1).Range.Bold = 1;
        //        table.Cell(1, i + 1).Range.Shading.BackgroundPatternColor = Word.WdColor.wdColorGray25;
        //    }

        //    // Данные
        //    for (int i = 0; i < dataTable.Rows.Count; i++)
        //    {
        //        for (int j = 0; j < dataTable.Columns.Count; j++)
        //        {
        //            table.Cell(i + 2, j + 1).Range.Text = dataTable.Rows[i][j].ToString();
        //        }
        //    }

        //    // Сохранение документа
        //    object filename = @"C:\Reports\ScheduleReport.docx";
        //    doc.SaveAs2(ref filename);
        //    doc.Close();
        //    wordApp.Quit();
        //}
        private void btnExportToExcel_Click(object sender, EventArgs e)
        {

            //У меня нет Excel, поэтому просто вытаскиваю из ExportScheduleToCsv файл.csv




            //if (scheduleGrid.Rows.Count == 0)
            //{
            //    MessageBox.Show("Нет данных для экспорта.");
            //    return;
            //}

            //Excel.Application excelApp = new Excel.Application();
            //excelApp.Visible = true;

            //Excel.Workbook workbook = excelApp.Workbooks.Add();
            //Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets[1];

            //// Заголовки
            //for (int i = 0; i < scheduleGrid.Columns.Count; i++)
            //{
            //    worksheet.Cells[1, i + 1] = scheduleGrid.Columns[i].HeaderText;
            //}

            //// Данные
            //for (int i = 0; i < scheduleGrid.Rows.Count; i++)
            //{
            //    for (int j = 0; j < scheduleGrid.Columns.Count; j++)
            //    {
            //        worksheet.Cells[i + 2, j + 1] = scheduleGrid.Rows[i].Cells[j].Value?.ToString();
            //    }
            //}

            //// Автоподбор ширины
            //worksheet.Columns.AutoFit();

            //MessageBox.Show("Экспорт завершен!");
            ExportScheduleToCsv();
        }

        private void ExportScheduleToCsv()
        {
            if (scheduleGrid.Rows.Count == 0)
            {
                MessageBox.Show("Нет данных для экспорта.");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "CSV файл (*.csv)|*.csv",
                Title = "Сохранить расписание",
                FileName = "Расписание.csv"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName, false, Encoding.UTF8))
                    {
                        // Заголовки
                        for (int i = 0; i < scheduleGrid.Columns.Count; i++)
                        {
                            sw.Write(scheduleGrid.Columns[i].HeaderText);
                            if (i < scheduleGrid.Columns.Count - 1)
                                sw.Write(";");
                        }
                        sw.WriteLine();

                        // Данные
                        foreach (DataGridViewRow row in scheduleGrid.Rows)
                        {
                            if (!row.IsNewRow)
                            {
                                for (int i = 0; i < scheduleGrid.Columns.Count; i++)
                                {
                                    sw.Write(row.Cells[i].Value?.ToString());
                                    if (i < scheduleGrid.Columns.Count - 1)
                                        sw.Write(";");
                                }
                                sw.WriteLine();
                            }
                        }
                    }

                    MessageBox.Show("Экспорт завершён успешно!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при экспорте: " + ex.Message);
                }
            }
        }

        private void LoadGroupedReport(string criterion, string joinType)
        {
            string tableToQueryFrom = "Schedule s";
            string joinClause = "";
            string havingClause = "";

            try
            {
                string selectField = "", groupField = "";
                List<string> selectedFields = new List<string>();

                // Определяем, что выбрано
                switch (criterion)
                {
                    case "Преподаватель":
                        selectField = "t.last_name + ' ' + t.first_name + ' ' + t.middle_name";
                        groupField = "t.last_name, t.first_name, t.middle_name";

                        if (joinType.Contains("LEFT"))
                        {
                            tableToQueryFrom = "Teachers t";
                            joinClause = "LEFT JOIN Schedule s ON t.teacher_id = s.teacher_id";
                        }
                        else
                        {
                            tableToQueryFrom = "Schedule s";
                            joinClause = "INNER JOIN Teachers t ON s.teacher_id = t.teacher_id";
                        }
                        break;

                    case "Группа":
                        selectField = "g.name";
                        tableToQueryFrom = "Schedule s";
                        joinClause = $"{joinType} Groups g ON s.group_id = g.group_id";
                        groupField = "g.name";
                        break;

                    case "Аудитория":
                        selectField = "a.room_number + ' (' + a.building + ')'";
                        tableToQueryFrom = "Schedule s";
                        joinClause = $"{joinType} Auditoriums a ON s.auditorium_id = a.auditorium_id";
                        groupField = "a.room_number, a.building";
                        break;

                    case "День недели":
                        selectField = "s.day_of_week";
                        tableToQueryFrom = "Schedule s";
                        groupField = "s.day_of_week";
                        joinClause = "";
                        break;

                    case "Предмет":
                        selectField = "sub.name";
                        tableToQueryFrom = "Schedule s";
                        joinClause = $"{joinType} Subjects sub ON s.subject_id = sub.subject_id";
                        groupField = "sub.name";
                        break;

                    //case "Группы (отчет с HAVING)":
                    //    selectField = "g.name";
                    //    tableToQueryFrom = "Groups g";
                    //    joinClause = "LEFT JOIN Schedule s ON g.group_id = s.group_id";
                    //    groupField = "g.name";
                    //    break;

                    default:
                        MessageBox.Show("Выберите корректный критерий.");
                        return;
                }

                // Метрики
                if (checkTotal.Checked)
                    selectedFields.Add("COUNT(s.schedule_id) AS [Всего занятий]");
                if (checkNumerator1.Checked)
                    selectedFields.Add("SUM(CASE WHEN s.numerator = 1 THEN 1 ELSE 0 END) AS [Числитель]");
                if (checkDenominator1.Checked)
                    selectedFields.Add("SUM(CASE WHEN s.numerator = 0 THEN 1 ELSE 0 END) AS [Знаменатель]");

                if (selectedFields.Count == 0)
                {
                    MessageBox.Show("Выберите хотя бы один параметр для отчета.");
                    return;
                }

                // HAVING
                //int minCount = (int)numericMinCount.Value;

                //if (minCount > 0 && criterion == "Группы (отчет с HAVING)")
                //{
                //    havingClause = $"HAVING COUNT(s.schedule_id) >= {minCount}";
                //}
                //else if (minCount > 0 && joinType.Contains("INNER"))
                //{
                //    havingClause = $"HAVING COUNT(s.schedule_id) >= {minCount}";
                //}
                //// ⚠️ Для LEFT JOIN по умолчанию HAVING НЕ ДОБАВЛЯЕМ, иначе убьём нули

                string selectClause = $"{selectField} AS [Критерий], " + string.Join(", ", selectedFields);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = $@"
                SELECT {selectClause}
                FROM {tableToQueryFrom}
                {joinClause}
                GROUP BY {groupField}
                {havingClause}
                ORDER BY [Критерий]";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    scheduleGrid.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при формировании отчета:\n" + ex.Message);
            }
        }


        private void btnLoadTeacherReport_Click(object sender, EventArgs e)
        {
            string selectedCriterion = comboReportField.SelectedItem.ToString();

            // Корректно извлекаем тип соединения
            string selectedJoinTypeText = comboJoinType.SelectedItem.ToString();
            string actualJoinType = selectedJoinTypeText.Contains("LEFT") ? "LEFT JOIN" : "INNER JOIN";

            LoadGroupedReport(selectedCriterion, actualJoinType);
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnFilterByGroupword_Click_Click(object sender, EventArgs e)
        {
            ExportScheduleToWord();
        }

        private void ExportScheduleToWord()
        {
            if (scheduleGrid.Rows.Count == 0)
            {
                MessageBox.Show("Нет данных для экспорта.");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Word документ (*.docx)|*.docx",
                Title = "Сохранить расписание",
                FileName = "Расписание.docx"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Создаем приложение Word
                    Word.Application wordApp = new Word.Application();
                    Word.Document doc = wordApp.Documents.Add();

                    // Добавляем таблицу
                    int rows = scheduleGrid.Rows.Count + 1; // +1 — заголовки
                    int cols = scheduleGrid.Columns.Count;

                    Word.Table table = doc.Tables.Add(doc.Range(0, 0), rows, cols);
                    table.Borders.Enable = 1;

                    // Заголовки
                    for (int c = 0; c < cols; c++)
                    {
                        table.Cell(1, c + 1).Range.Text = scheduleGrid.Columns[c].HeaderText;
                        table.Cell(1, c + 1).Range.Bold = 1;
                    }

                    // Данные
                    for (int r = 0; r < scheduleGrid.Rows.Count; r++)
                    {
                        for (int c = 0; c < cols; c++)
                        {
                            var value = scheduleGrid.Rows[r].Cells[c].Value?.ToString() ?? "";
                            table.Cell(r + 2, c + 1).Range.Text = value;
                        }
                    }

                    // Сохраняем
                    doc.SaveAs2(saveFileDialog.FileName);
                    doc.Close();
                    wordApp.Quit();

                    MessageBox.Show("Экспорт в Word завершён успешно!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при экспорте в Word: " + ex.Message);
                }
            }
        }

        private void comboDayOfWeek_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboJoinType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboReportField_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdvancedReport_Click(object sender, EventArgs e)
        {
            LoadAdvancedReport();
        }
        private void LoadAdvancedReport()
        {
            try
            {
                List<string> groupFields = new List<string>();
                List<string> selectFields = new List<string>();
                List<string> joins = new List<string>();

                string baseTable = "Schedule s";
                string whereClause = "";
                string havingClause = "";

                // Группировка
                if (checkGroupByGroup.Checked)
                {
                    selectFields.Add("g.name AS [Группа]");
                    groupFields.Add("g.name");
                    joins.Add($"{comboJoinAdvanced.SelectedItem} Groups g ON s.group_id = g.group_id");
                }

                if (checkGroupByTeacher.Checked)
                {
                    selectFields.Add("t.last_name + ' ' + t.first_name + ' ' + t.middle_name AS [Преподаватель]");
                    groupFields.Add("t.last_name, t.first_name, t.middle_name");
                    joins.Add($"{comboJoinAdvanced.SelectedItem} Teachers t ON s.teacher_id = t.teacher_id");
                }

                if (checkGroupBySubject.Checked)
                {
                    selectFields.Add("sub.name AS [Предмет]");
                    groupFields.Add("sub.name");
                    joins.Add($"{comboJoinAdvanced.SelectedItem} Subjects sub ON s.subject_id = sub.subject_id");
                }

                if (checkGroupByDay.Checked)
                {
                    selectFields.Add("s.day_of_week AS [День недели]");
                    groupFields.Add("s.day_of_week");
                }

                // Метрики
                List<string> metrics = new List<string>();

                if (checkTotal.Checked)
                    metrics.Add("COUNT(s.schedule_id) AS [Всего занятий]");
                if (checkNumerator1.Checked)
                    metrics.Add("SUM(CASE WHEN s.numerator = 1 THEN 1 ELSE 0 END) AS [Числитель]");
                if (checkDenominator1.Checked)
                    metrics.Add("SUM(CASE WHEN s.numerator = 0 THEN 1 ELSE 0 END) AS [Знаменатель]");

                if (groupFields.Count == 0 || metrics.Count == 0)
                {
                    MessageBox.Show("Выберите хотя бы один критерий группировки и один параметр для отчета.");
                    return;
                }

                // HAVING по количеству
                if (numericMinCountAdvanced.Value > 0)
                {
                    havingClause = $"HAVING COUNT(s.schedule_id) >= {numericMinCountAdvanced.Value}";
                }

                string query = $@"
            SELECT 
                {string.Join(", ", selectFields.Concat(metrics))}
            FROM {baseTable}
            {string.Join("\n", joins)}
            GROUP BY {string.Join(", ", groupFields)}
            {havingClause}
            ORDER BY {string.Join(", ", groupFields)}";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    scheduleGrid.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при формировании сложного отчета:\n" + ex.Message);
            }
        }

        private void btnAdminEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (scheduleGrid.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Выберите занятие для редактирования");
                    return;
                }

                DataGridViewRow selectedRow = scheduleGrid.SelectedRows[0];

                // Правильная проверка наличия столбца и значения
                if (!selectedRow.DataGridView.Columns.Contains("ID") || selectedRow.Cells["ID"].Value == null)
                {
                    MessageBox.Show("Не удалось определить ID выбранного занятия");
                    return;
                }

                int scheduleId;
                if (!int.TryParse(selectedRow.Cells["ID"].Value.ToString(), out scheduleId))
                {
                    MessageBox.Show("Некорректный ID занятия");
                    return;
                }

                // Отладочная информация
                Debug.WriteLine($"Открываем занятие с ID: {scheduleId}");
                Console.WriteLine($"Открываем занятие с ID: {scheduleId}");

                EditScheduleForm editForm = new EditScheduleForm(scheduleId);
                editForm.FormClosed += (s, args) => LoadSchedule();
                editForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при открытии формы редактирования: {ex.ToString()}");
            }
        }

        private void btnAdminDelete_Click(object sender, EventArgs e)
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
                            "DELETE FROM Schedule WHERE schedule_id = @id",
                            conn);
                        cmd.Parameters.AddWithValue("@id", scheduleId);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Занятие удалено");
                            LoadSchedule();
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
