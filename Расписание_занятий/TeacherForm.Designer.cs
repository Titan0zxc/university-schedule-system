namespace Расписание_занятий
{
    partial class TeacherForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.scheduleGrid = new System.Windows.Forms.DataGridView();
            this.comboSubject = new System.Windows.Forms.ComboBox();
            this.comboLessonType = new System.Windows.Forms.ComboBox();
            this.comboAuditorium = new System.Windows.Forms.ComboBox();
            this.comboGroup = new System.Windows.Forms.ComboBox();
            this.comboDay = new System.Windows.Forms.ComboBox();
            this.checkNumerator = new System.Windows.Forms.CheckBox();
            this.checkHalfGroup = new System.Windows.Forms.CheckBox();
            this.btnAddLesson = new System.Windows.Forms.Button();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.btnExportWord = new System.Windows.Forms.Button();
            this.numericPair = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEditLesson = new System.Windows.Forms.Button();
            this.btnDeleteLesson = new System.Windows.Forms.Button();
            this.btnReturnToLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPair)).BeginInit();
            this.SuspendLayout();
            // 
            // scheduleGrid
            // 
            this.scheduleGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scheduleGrid.Location = new System.Drawing.Point(12, 257);
            this.scheduleGrid.Name = "scheduleGrid";
            this.scheduleGrid.RowHeadersWidth = 62;
            this.scheduleGrid.RowTemplate.Height = 28;
            this.scheduleGrid.Size = new System.Drawing.Size(1622, 495);
            this.scheduleGrid.TabIndex = 0;
            // 
            // comboSubject
            // 
            this.comboSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboSubject.FormattingEnabled = true;
            this.comboSubject.Location = new System.Drawing.Point(506, 10);
            this.comboSubject.Name = "comboSubject";
            this.comboSubject.Size = new System.Drawing.Size(164, 37);
            this.comboSubject.TabIndex = 1;
            // 
            // comboLessonType
            // 
            this.comboLessonType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboLessonType.FormattingEnabled = true;
            this.comboLessonType.Location = new System.Drawing.Point(506, 72);
            this.comboLessonType.Name = "comboLessonType";
            this.comboLessonType.Size = new System.Drawing.Size(164, 37);
            this.comboLessonType.TabIndex = 2;
            // 
            // comboAuditorium
            // 
            this.comboAuditorium.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboAuditorium.FormattingEnabled = true;
            this.comboAuditorium.Location = new System.Drawing.Point(506, 129);
            this.comboAuditorium.Name = "comboAuditorium";
            this.comboAuditorium.Size = new System.Drawing.Size(164, 37);
            this.comboAuditorium.TabIndex = 3;
            // 
            // comboGroup
            // 
            this.comboGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboGroup.FormattingEnabled = true;
            this.comboGroup.Location = new System.Drawing.Point(506, 184);
            this.comboGroup.Name = "comboGroup";
            this.comboGroup.Size = new System.Drawing.Size(164, 37);
            this.comboGroup.TabIndex = 4;
            // 
            // comboDay
            // 
            this.comboDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboDay.FormattingEnabled = true;
            this.comboDay.Location = new System.Drawing.Point(874, 10);
            this.comboDay.Name = "comboDay";
            this.comboDay.Size = new System.Drawing.Size(162, 37);
            this.comboDay.TabIndex = 5;
            // 
            // checkNumerator
            // 
            this.checkNumerator.AutoSize = true;
            this.checkNumerator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkNumerator.Location = new System.Drawing.Point(709, 188);
            this.checkNumerator.Name = "checkNumerator";
            this.checkNumerator.Size = new System.Drawing.Size(179, 33);
            this.checkNumerator.TabIndex = 7;
            this.checkNumerator.Text = "Числитель?";
            this.checkNumerator.UseVisualStyleBackColor = true;
            // 
            // checkHalfGroup
            // 
            this.checkHalfGroup.AutoSize = true;
            this.checkHalfGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkHalfGroup.Location = new System.Drawing.Point(709, 133);
            this.checkHalfGroup.Name = "checkHalfGroup";
            this.checkHalfGroup.Size = new System.Drawing.Size(163, 33);
            this.checkHalfGroup.TabIndex = 8;
            this.checkHalfGroup.Text = "Подгруппа";
            this.checkHalfGroup.UseVisualStyleBackColor = true;
            // 
            // btnAddLesson
            // 
            this.btnAddLesson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddLesson.Location = new System.Drawing.Point(1059, 12);
            this.btnAddLesson.Name = "btnAddLesson";
            this.btnAddLesson.Size = new System.Drawing.Size(280, 56);
            this.btnAddLesson.TabIndex = 9;
            this.btnAddLesson.Text = "Добавить занятие";
            this.btnAddLesson.UseVisualStyleBackColor = true;
            this.btnAddLesson.Click += new System.EventHandler(this.btnAddLesson_Click);
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExportExcel.Location = new System.Drawing.Point(12, 12);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(275, 44);
            this.btnExportExcel.TabIndex = 10;
            this.btnExportExcel.Text = "Экспорт в Excel";
            this.btnExportExcel.UseVisualStyleBackColor = true;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // btnExportWord
            // 
            this.btnExportWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExportWord.Location = new System.Drawing.Point(12, 75);
            this.btnExportWord.Name = "btnExportWord";
            this.btnExportWord.Size = new System.Drawing.Size(275, 42);
            this.btnExportWord.TabIndex = 11;
            this.btnExportWord.Text = "Экспорт в Word";
            this.btnExportWord.UseVisualStyleBackColor = true;
            this.btnExportWord.Click += new System.EventHandler(this.btnExportWord_Click);
            // 
            // numericPair
            // 
            this.numericPair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericPair.Location = new System.Drawing.Point(874, 72);
            this.numericPair.Name = "numericPair";
            this.numericPair.Size = new System.Drawing.Size(162, 35);
            this.numericPair.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(340, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "Предмет";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(340, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "Вид занятия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(340, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 29);
            this.label3.TabIndex = 15;
            this.label3.Text = "Аудитория";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(340, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 29);
            this.label4.TabIndex = 16;
            this.label4.Text = "Группа";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(704, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 29);
            this.label5.TabIndex = 17;
            this.label5.Text = "День недели";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(704, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 29);
            this.label6.TabIndex = 18;
            this.label6.Text = "Номер пары";
            // 
            // btnEditLesson
            // 
            this.btnEditLesson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditLesson.Location = new System.Drawing.Point(1059, 83);
            this.btnEditLesson.Name = "btnEditLesson";
            this.btnEditLesson.Size = new System.Drawing.Size(280, 53);
            this.btnEditLesson.TabIndex = 19;
            this.btnEditLesson.Text = "Редактировать расписание";
            this.btnEditLesson.UseVisualStyleBackColor = true;
            this.btnEditLesson.Click += new System.EventHandler(this.btnEditLesson_Click);
            // 
            // btnDeleteLesson
            // 
            this.btnDeleteLesson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteLesson.Location = new System.Drawing.Point(1059, 152);
            this.btnDeleteLesson.Name = "btnDeleteLesson";
            this.btnDeleteLesson.Size = new System.Drawing.Size(280, 49);
            this.btnDeleteLesson.TabIndex = 20;
            this.btnDeleteLesson.Text = "Удалить";
            this.btnDeleteLesson.UseVisualStyleBackColor = true;
            this.btnDeleteLesson.Click += new System.EventHandler(this.btnDeleteLesson_Click);
            // 
            // btnReturnToLogin
            // 
            this.btnReturnToLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReturnToLogin.Location = new System.Drawing.Point(1358, 12);
            this.btnReturnToLogin.Name = "btnReturnToLogin";
            this.btnReturnToLogin.Size = new System.Drawing.Size(265, 56);
            this.btnReturnToLogin.TabIndex = 21;
            this.btnReturnToLogin.Text = "Вернуться к началу";
            this.btnReturnToLogin.UseVisualStyleBackColor = true;
            this.btnReturnToLogin.Click += new System.EventHandler(this.btnReturnToLogin_Click);
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1646, 764);
            this.Controls.Add(this.btnReturnToLogin);
            this.Controls.Add(this.btnDeleteLesson);
            this.Controls.Add(this.btnEditLesson);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericPair);
            this.Controls.Add(this.btnExportWord);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.btnAddLesson);
            this.Controls.Add(this.checkHalfGroup);
            this.Controls.Add(this.checkNumerator);
            this.Controls.Add(this.comboDay);
            this.Controls.Add(this.comboGroup);
            this.Controls.Add(this.comboAuditorium);
            this.Controls.Add(this.comboLessonType);
            this.Controls.Add(this.comboSubject);
            this.Controls.Add(this.scheduleGrid);
            this.Name = "TeacherForm";
            this.Text = "TeacherForm";
            ((System.ComponentModel.ISupportInitialize)(this.scheduleGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPair)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView scheduleGrid;
        private System.Windows.Forms.ComboBox comboSubject;
        private System.Windows.Forms.ComboBox comboLessonType;
        private System.Windows.Forms.ComboBox comboAuditorium;
        private System.Windows.Forms.ComboBox comboGroup;
        private System.Windows.Forms.ComboBox comboDay;
        private System.Windows.Forms.CheckBox checkNumerator;
        private System.Windows.Forms.CheckBox checkHalfGroup;
        private System.Windows.Forms.Button btnAddLesson;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.Button btnExportWord;
        private System.Windows.Forms.NumericUpDown numericPair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEditLesson;
        private System.Windows.Forms.Button btnDeleteLesson;
        private System.Windows.Forms.Button btnReturnToLogin;
    }
}