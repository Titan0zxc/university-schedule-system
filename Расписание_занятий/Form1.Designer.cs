namespace Расписание_занятий
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnAdvancedReport = new System.Windows.Forms.Button();
            this.comboJoinAdvanced = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.numericMinCountAdvanced = new System.Windows.Forms.NumericUpDown();
            this.checkGroupBySubject = new System.Windows.Forms.CheckBox();
            this.checkGroupByDay = new System.Windows.Forms.CheckBox();
            this.checkGroupByTeacher = new System.Windows.Forms.CheckBox();
            this.checkGroupByGroup = new System.Windows.Forms.CheckBox();
            this.labelGroupBy = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnFilterByGroupword_Click = new System.Windows.Forms.Button();
            this.checkDenominator1 = new System.Windows.Forms.CheckBox();
            this.checkNumerator1 = new System.Windows.Forms.CheckBox();
            this.checkTotal = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboJoinType = new System.Windows.Forms.ComboBox();
            this.comboReportField = new System.Windows.Forms.ComboBox();
            this.btnShowReport = new System.Windows.Forms.Button();
            this.btnExportToExcel = new System.Windows.Forms.Button();
            this.btnFilterByGroup = new System.Windows.Forms.Button();
            this.comboGroupFilter = new System.Windows.Forms.ComboBox();
            this.labelGroupFilter = new System.Windows.Forms.Label();
            this.scheduleGrid = new System.Windows.Forms.DataGridView();
            this.btnLoadSchedule = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.numericPairNumber = new System.Windows.Forms.NumericUpDown();
            this.btnAddSchedule = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.checkHalfGroup = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkNumerator = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboDayOfWeek = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboAuditorium = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboGroup = new System.Windows.Forms.ComboBox();
            this.comboSubject = new System.Windows.Forms.ComboBox();
            this.comboTeacher = new System.Windows.Forms.ComboBox();
            this.comboLessonType = new System.Windows.Forms.ComboBox();
            this.btnAdminEdit = new System.Windows.Forms.Button();
            this.btnAdminDelete = new System.Windows.Forms.Button();
            this.btnReturnToLogin = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericMinCountAdvanced)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleGrid)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPairNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 64);
            this.button1.TabIndex = 0;
            this.button1.Text = "Проверка соединения";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(236, 9);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1898, 1030);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnAdvancedReport);
            this.tabPage1.Controls.Add(this.comboJoinAdvanced);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.numericMinCountAdvanced);
            this.tabPage1.Controls.Add(this.checkGroupBySubject);
            this.tabPage1.Controls.Add(this.checkGroupByDay);
            this.tabPage1.Controls.Add(this.checkGroupByTeacher);
            this.tabPage1.Controls.Add(this.checkGroupByGroup);
            this.tabPage1.Controls.Add(this.labelGroupBy);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.btnFilterByGroupword_Click);
            this.tabPage1.Controls.Add(this.checkDenominator1);
            this.tabPage1.Controls.Add(this.checkNumerator1);
            this.tabPage1.Controls.Add(this.checkTotal);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.comboJoinType);
            this.tabPage1.Controls.Add(this.comboReportField);
            this.tabPage1.Controls.Add(this.btnShowReport);
            this.tabPage1.Controls.Add(this.btnExportToExcel);
            this.tabPage1.Controls.Add(this.btnFilterByGroup);
            this.tabPage1.Controls.Add(this.comboGroupFilter);
            this.tabPage1.Controls.Add(this.labelGroupFilter);
            this.tabPage1.Controls.Add(this.scheduleGrid);
            this.tabPage1.Controls.Add(this.btnLoadSchedule);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1890, 992);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Расписание";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnAdvancedReport
            // 
            this.btnAdvancedReport.Location = new System.Drawing.Point(1297, 145);
            this.btnAdvancedReport.Name = "btnAdvancedReport";
            this.btnAdvancedReport.Size = new System.Drawing.Size(280, 45);
            this.btnAdvancedReport.TabIndex = 28;
            this.btnAdvancedReport.Text = "Сформировать отчет ";
            this.btnAdvancedReport.UseVisualStyleBackColor = true;
            this.btnAdvancedReport.Click += new System.EventHandler(this.btnAdvancedReport_Click);
            // 
            // comboJoinAdvanced
            // 
            this.comboJoinAdvanced.FormattingEnabled = true;
            this.comboJoinAdvanced.Location = new System.Drawing.Point(1564, 6);
            this.comboJoinAdvanced.Name = "comboJoinAdvanced";
            this.comboJoinAdvanced.Size = new System.Drawing.Size(232, 33);
            this.comboJoinAdvanced.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1294, 46);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(186, 25);
            this.label13.TabIndex = 26;
            this.label13.Text = "Минимум занятий";
            // 
            // numericMinCountAdvanced
            // 
            this.numericMinCountAdvanced.Location = new System.Drawing.Point(1486, 44);
            this.numericMinCountAdvanced.Name = "numericMinCountAdvanced";
            this.numericMinCountAdvanced.Size = new System.Drawing.Size(59, 30);
            this.numericMinCountAdvanced.TabIndex = 25;
            // 
            // checkGroupBySubject
            // 
            this.checkGroupBySubject.AutoSize = true;
            this.checkGroupBySubject.Location = new System.Drawing.Point(1497, 112);
            this.checkGroupBySubject.Name = "checkGroupBySubject";
            this.checkGroupBySubject.Size = new System.Drawing.Size(126, 29);
            this.checkGroupBySubject.TabIndex = 24;
            this.checkGroupBySubject.Text = "Предмет";
            this.checkGroupBySubject.UseVisualStyleBackColor = true;
            // 
            // checkGroupByDay
            // 
            this.checkGroupByDay.AutoSize = true;
            this.checkGroupByDay.Location = new System.Drawing.Point(1497, 80);
            this.checkGroupByDay.Name = "checkGroupByDay";
            this.checkGroupByDay.Size = new System.Drawing.Size(160, 29);
            this.checkGroupByDay.TabIndex = 23;
            this.checkGroupByDay.Text = "День недели";
            this.checkGroupByDay.UseVisualStyleBackColor = true;
            // 
            // checkGroupByTeacher
            // 
            this.checkGroupByTeacher.AutoSize = true;
            this.checkGroupByTeacher.Location = new System.Drawing.Point(1297, 110);
            this.checkGroupByTeacher.Name = "checkGroupByTeacher";
            this.checkGroupByTeacher.Size = new System.Drawing.Size(183, 29);
            this.checkGroupByTeacher.TabIndex = 22;
            this.checkGroupByTeacher.Text = "Преподаватель";
            this.checkGroupByTeacher.UseVisualStyleBackColor = true;
            // 
            // checkGroupByGroup
            // 
            this.checkGroupByGroup.AutoSize = true;
            this.checkGroupByGroup.Location = new System.Drawing.Point(1297, 74);
            this.checkGroupByGroup.Name = "checkGroupByGroup";
            this.checkGroupByGroup.Size = new System.Drawing.Size(102, 29);
            this.checkGroupByGroup.TabIndex = 21;
            this.checkGroupByGroup.Text = "Группа";
            this.checkGroupByGroup.UseVisualStyleBackColor = true;
            // 
            // labelGroupBy
            // 
            this.labelGroupBy.AutoSize = true;
            this.labelGroupBy.Location = new System.Drawing.Point(1294, 12);
            this.labelGroupBy.Name = "labelGroupBy";
            this.labelGroupBy.Size = new System.Drawing.Size(246, 25);
            this.labelGroupBy.TabIndex = 20;
            this.labelGroupBy.Text = "Группировка по(12 лаба):";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(600, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(399, 25);
            this.label12.TabIndex = 19;
            this.label12.Text = "Фильтрация группы по критерию лаба 11";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(283, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(311, 25);
            this.label11.TabIndex = 18;
            this.label11.Text = "Фильтрация таблицы по группе";
            // 
            // btnFilterByGroupword_Click
            // 
            this.btnFilterByGroupword_Click.Location = new System.Drawing.Point(6, 127);
            this.btnFilterByGroupword_Click.Name = "btnFilterByGroupword_Click";
            this.btnFilterByGroupword_Click.Size = new System.Drawing.Size(217, 50);
            this.btnFilterByGroupword_Click.TabIndex = 17;
            this.btnFilterByGroupword_Click.Text = "Экспорт в Word";
            this.btnFilterByGroupword_Click.UseVisualStyleBackColor = true;
            this.btnFilterByGroupword_Click.Click += new System.EventHandler(this.btnFilterByGroupword_Click_Click);
            // 
            // checkDenominator1
            // 
            this.checkDenominator1.AutoSize = true;
            this.checkDenominator1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkDenominator1.Location = new System.Drawing.Point(1120, 128);
            this.checkDenominator1.Name = "checkDenominator1";
            this.checkDenominator1.Size = new System.Drawing.Size(166, 29);
            this.checkDenominator1.TabIndex = 14;
            this.checkDenominator1.Text = "Знаменатель";
            this.checkDenominator1.UseVisualStyleBackColor = true;
            // 
            // checkNumerator1
            // 
            this.checkNumerator1.AutoSize = true;
            this.checkNumerator1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkNumerator1.Location = new System.Drawing.Point(1120, 88);
            this.checkNumerator1.Name = "checkNumerator1";
            this.checkNumerator1.Size = new System.Drawing.Size(140, 29);
            this.checkNumerator1.TabIndex = 2;
            this.checkNumerator1.Text = "Числитель";
            this.checkNumerator1.UseVisualStyleBackColor = true;
            // 
            // checkTotal
            // 
            this.checkTotal.AutoSize = true;
            this.checkTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkTotal.Location = new System.Drawing.Point(1120, 47);
            this.checkTotal.Name = "checkTotal";
            this.checkTotal.Size = new System.Drawing.Size(172, 29);
            this.checkTotal.TabIndex = 13;
            this.checkTotal.Text = "Всего занятий";
            this.checkTotal.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(600, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(180, 25);
            this.label9.TabIndex = 12;
            this.label9.Text = "Тип объединения:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(600, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 25);
            this.label8.TabIndex = 11;
            this.label8.Text = "По критерию?";
            // 
            // comboJoinType
            // 
            this.comboJoinType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboJoinType.FormattingEnabled = true;
            this.comboJoinType.Location = new System.Drawing.Point(802, 101);
            this.comboJoinType.Name = "comboJoinType";
            this.comboJoinType.Size = new System.Drawing.Size(310, 33);
            this.comboJoinType.TabIndex = 10;
            this.comboJoinType.SelectedIndexChanged += new System.EventHandler(this.comboJoinType_SelectedIndexChanged);
            // 
            // comboReportField
            // 
            this.comboReportField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboReportField.FormattingEnabled = true;
            this.comboReportField.Location = new System.Drawing.Point(802, 49);
            this.comboReportField.Name = "comboReportField";
            this.comboReportField.Size = new System.Drawing.Size(310, 33);
            this.comboReportField.TabIndex = 9;
            this.comboReportField.SelectedIndexChanged += new System.EventHandler(this.comboReportField_SelectedIndexChanged);
            // 
            // btnShowReport
            // 
            this.btnShowReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShowReport.Location = new System.Drawing.Point(605, 140);
            this.btnShowReport.Name = "btnShowReport";
            this.btnShowReport.Size = new System.Drawing.Size(310, 42);
            this.btnShowReport.TabIndex = 8;
            this.btnShowReport.Text = "Объединение";
            this.btnShowReport.UseVisualStyleBackColor = true;
            this.btnShowReport.Click += new System.EventHandler(this.btnLoadTeacherReport_Click);
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExportToExcel.Location = new System.Drawing.Point(6, 68);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Size = new System.Drawing.Size(217, 50);
            this.btnExportToExcel.TabIndex = 7;
            this.btnExportToExcel.Text = "Экспорт в Excel";
            this.btnExportToExcel.UseVisualStyleBackColor = true;
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // btnFilterByGroup
            // 
            this.btnFilterByGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFilterByGroup.Location = new System.Drawing.Point(288, 75);
            this.btnFilterByGroup.Name = "btnFilterByGroup";
            this.btnFilterByGroup.Size = new System.Drawing.Size(213, 43);
            this.btnFilterByGroup.TabIndex = 6;
            this.btnFilterByGroup.Text = "Показать";
            this.btnFilterByGroup.UseVisualStyleBackColor = true;
            this.btnFilterByGroup.Click += new System.EventHandler(this.btnFilterByGroup_Click);
            // 
            // comboGroupFilter
            // 
            this.comboGroupFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboGroupFilter.FormattingEnabled = true;
            this.comboGroupFilter.Location = new System.Drawing.Point(374, 33);
            this.comboGroupFilter.Name = "comboGroupFilter";
            this.comboGroupFilter.Size = new System.Drawing.Size(172, 33);
            this.comboGroupFilter.TabIndex = 5;
            // 
            // labelGroupFilter
            // 
            this.labelGroupFilter.AutoSize = true;
            this.labelGroupFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGroupFilter.Location = new System.Drawing.Point(286, 36);
            this.labelGroupFilter.Name = "labelGroupFilter";
            this.labelGroupFilter.Size = new System.Drawing.Size(82, 25);
            this.labelGroupFilter.TabIndex = 4;
            this.labelGroupFilter.Text = "Группа:";
            // 
            // scheduleGrid
            // 
            this.scheduleGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scheduleGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.scheduleGrid.Location = new System.Drawing.Point(3, 200);
            this.scheduleGrid.Name = "scheduleGrid";
            this.scheduleGrid.RowHeadersWidth = 62;
            this.scheduleGrid.RowTemplate.Height = 28;
            this.scheduleGrid.Size = new System.Drawing.Size(1884, 789);
            this.scheduleGrid.TabIndex = 2;
            // 
            // btnLoadSchedule
            // 
            this.btnLoadSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLoadSchedule.Location = new System.Drawing.Point(6, 12);
            this.btnLoadSchedule.Name = "btnLoadSchedule";
            this.btnLoadSchedule.Size = new System.Drawing.Size(217, 50);
            this.btnLoadSchedule.TabIndex = 3;
            this.btnLoadSchedule.Text = "Обновить таблицу";
            this.btnLoadSchedule.UseVisualStyleBackColor = true;
            this.btnLoadSchedule.Click += new System.EventHandler(this.btnLoadSchedule_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.numericPairNumber);
            this.tabPage2.Controls.Add(this.btnAddSchedule);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.checkHalfGroup);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.checkNumerator);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.comboDayOfWeek);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.comboAuditorium);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.comboGroup);
            this.tabPage2.Controls.Add(this.comboSubject);
            this.tabPage2.Controls.Add(this.comboTeacher);
            this.tabPage2.Controls.Add(this.comboLessonType);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1890, 992);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Добавить занятие";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Предмет";
            // 
            // numericPairNumber
            // 
            this.numericPairNumber.Location = new System.Drawing.Point(267, 46);
            this.numericPairNumber.Name = "numericPairNumber";
            this.numericPairNumber.Size = new System.Drawing.Size(120, 30);
            this.numericPairNumber.TabIndex = 17;
            // 
            // btnAddSchedule
            // 
            this.btnAddSchedule.Location = new System.Drawing.Point(27, 465);
            this.btnAddSchedule.Name = "btnAddSchedule";
            this.btnAddSchedule.Size = new System.Drawing.Size(277, 34);
            this.btnAddSchedule.TabIndex = 20;
            this.btnAddSchedule.Text = "Добавить занятие";
            this.btnAddSchedule.UseVisualStyleBackColor = true;
            this.btnAddSchedule.Click += new System.EventHandler(this.btnAddSchedule_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Вид занятия";
            // 
            // checkHalfGroup
            // 
            this.checkHalfGroup.AutoSize = true;
            this.checkHalfGroup.Location = new System.Drawing.Point(267, 132);
            this.checkHalfGroup.Name = "checkHalfGroup";
            this.checkHalfGroup.Size = new System.Drawing.Size(146, 29);
            this.checkHalfGroup.TabIndex = 19;
            this.checkHalfGroup.Text = "Подгруппа?";
            this.checkHalfGroup.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Преподаватель";
            // 
            // checkNumerator
            // 
            this.checkNumerator.AutoSize = true;
            this.checkNumerator.Location = new System.Drawing.Point(267, 97);
            this.checkNumerator.Name = "checkNumerator";
            this.checkNumerator.Size = new System.Drawing.Size(151, 29);
            this.checkNumerator.TabIndex = 18;
            this.checkNumerator.Text = "Числитель?";
            this.checkNumerator.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Группа";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Аудитория";
            // 
            // comboDayOfWeek
            // 
            this.comboDayOfWeek.FormattingEnabled = true;
            this.comboDayOfWeek.Location = new System.Drawing.Point(27, 408);
            this.comboDayOfWeek.Name = "comboDayOfWeek";
            this.comboDayOfWeek.Size = new System.Drawing.Size(204, 33);
            this.comboDayOfWeek.TabIndex = 16;
            this.comboDayOfWeek.SelectedIndexChanged += new System.EventHandler(this.comboDayOfWeek_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "День недели";
            // 
            // comboAuditorium
            // 
            this.comboAuditorium.FormattingEnabled = true;
            this.comboAuditorium.Location = new System.Drawing.Point(27, 329);
            this.comboAuditorium.Name = "comboAuditorium";
            this.comboAuditorium.Size = new System.Drawing.Size(204, 33);
            this.comboAuditorium.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(263, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Номер пары";
            // 
            // comboGroup
            // 
            this.comboGroup.FormattingEnabled = true;
            this.comboGroup.Location = new System.Drawing.Point(27, 264);
            this.comboGroup.Name = "comboGroup";
            this.comboGroup.Size = new System.Drawing.Size(204, 33);
            this.comboGroup.TabIndex = 14;
            // 
            // comboSubject
            // 
            this.comboSubject.FormattingEnabled = true;
            this.comboSubject.Location = new System.Drawing.Point(27, 43);
            this.comboSubject.Name = "comboSubject";
            this.comboSubject.Size = new System.Drawing.Size(204, 33);
            this.comboSubject.TabIndex = 11;
            // 
            // comboTeacher
            // 
            this.comboTeacher.FormattingEnabled = true;
            this.comboTeacher.Location = new System.Drawing.Point(27, 193);
            this.comboTeacher.Name = "comboTeacher";
            this.comboTeacher.Size = new System.Drawing.Size(204, 33);
            this.comboTeacher.TabIndex = 13;
            // 
            // comboLessonType
            // 
            this.comboLessonType.FormattingEnabled = true;
            this.comboLessonType.Location = new System.Drawing.Point(27, 116);
            this.comboLessonType.Name = "comboLessonType";
            this.comboLessonType.Size = new System.Drawing.Size(204, 33);
            this.comboLessonType.TabIndex = 12;
            // 
            // btnAdminEdit
            // 
            this.btnAdminEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdminEdit.Location = new System.Drawing.Point(12, 89);
            this.btnAdminEdit.Name = "btnAdminEdit";
            this.btnAdminEdit.Size = new System.Drawing.Size(218, 88);
            this.btnAdminEdit.TabIndex = 2;
            this.btnAdminEdit.Text = "Редактировать расписание";
            this.btnAdminEdit.UseVisualStyleBackColor = true;
            this.btnAdminEdit.Click += new System.EventHandler(this.btnAdminEdit_Click);
            // 
            // btnAdminDelete
            // 
            this.btnAdminDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdminDelete.Location = new System.Drawing.Point(12, 188);
            this.btnAdminDelete.Name = "btnAdminDelete";
            this.btnAdminDelete.Size = new System.Drawing.Size(218, 80);
            this.btnAdminDelete.TabIndex = 3;
            this.btnAdminDelete.Text = "Удалить расписание ";
            this.btnAdminDelete.UseVisualStyleBackColor = true;
            this.btnAdminDelete.Click += new System.EventHandler(this.btnAdminDelete_Click);
            // 
            // btnReturnToLogin
            // 
            this.btnReturnToLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReturnToLogin.Location = new System.Drawing.Point(12, 284);
            this.btnReturnToLogin.Name = "btnReturnToLogin";
            this.btnReturnToLogin.Size = new System.Drawing.Size(218, 98);
            this.btnReturnToLogin.TabIndex = 4;
            this.btnReturnToLogin.Text = "Возврат к началу";
            this.btnReturnToLogin.UseVisualStyleBackColor = true;
            this.btnReturnToLogin.Click += new System.EventHandler(this.btnReturnToLogin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2146, 1030);
            this.Controls.Add(this.btnReturnToLogin);
            this.Controls.Add(this.btnAdminDelete);
            this.Controls.Add(this.btnAdminEdit);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericMinCountAdvanced)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleGrid)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPairNumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView scheduleGrid;
        private System.Windows.Forms.Button btnLoadSchedule;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboSubject;
        private System.Windows.Forms.ComboBox comboLessonType;
        private System.Windows.Forms.ComboBox comboTeacher;
        private System.Windows.Forms.ComboBox comboGroup;
        private System.Windows.Forms.ComboBox comboAuditorium;
        private System.Windows.Forms.ComboBox comboDayOfWeek;
        private System.Windows.Forms.NumericUpDown numericPairNumber;
        private System.Windows.Forms.CheckBox checkNumerator;
        private System.Windows.Forms.CheckBox checkHalfGroup;
        private System.Windows.Forms.Button btnAddSchedule;
        private System.Windows.Forms.Button btnFilterByGroup;
        private System.Windows.Forms.ComboBox comboGroupFilter;
        private System.Windows.Forms.Label labelGroupFilter;
        private System.Windows.Forms.Button btnExportToExcel;
        private System.Windows.Forms.Button btnShowReport;
        private System.Windows.Forms.ComboBox comboReportField;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboJoinType;
        private System.Windows.Forms.CheckBox checkNumerator1;
        private System.Windows.Forms.CheckBox checkTotal;
        private System.Windows.Forms.CheckBox checkDenominator1;
        private System.Windows.Forms.Button btnFilterByGroupword_Click;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox checkGroupBySubject;
        private System.Windows.Forms.CheckBox checkGroupByDay;
        private System.Windows.Forms.CheckBox checkGroupByTeacher;
        private System.Windows.Forms.CheckBox checkGroupByGroup;
        private System.Windows.Forms.Label labelGroupBy;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numericMinCountAdvanced;
        private System.Windows.Forms.ComboBox comboJoinAdvanced;
        private System.Windows.Forms.Button btnAdvancedReport;
        private System.Windows.Forms.Button btnAdminEdit;
        private System.Windows.Forms.Button btnAdminDelete;
        private System.Windows.Forms.Button btnReturnToLogin;
    }
}

