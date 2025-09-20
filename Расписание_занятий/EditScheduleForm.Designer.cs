namespace Расписание_занятий
{
    partial class EditScheduleForm
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
            this.btnSave = new System.Windows.Forms.Button();
            this.comboSubject = new System.Windows.Forms.ComboBox();
            this.comboLessonType = new System.Windows.Forms.ComboBox();
            this.comboTeacher = new System.Windows.Forms.ComboBox();
            this.comboAuditorium = new System.Windows.Forms.ComboBox();
            this.comboGroup = new System.Windows.Forms.ComboBox();
            this.comboDay = new System.Windows.Forms.ComboBox();
            this.numericPair = new System.Windows.Forms.NumericUpDown();
            this.checkNumerator = new System.Windows.Forms.CheckBox();
            this.checkHalfGroup = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericPair)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Location = new System.Drawing.Point(12, 499);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(147, 46);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // comboSubject
            // 
            this.comboSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboSubject.FormattingEnabled = true;
            this.comboSubject.Location = new System.Drawing.Point(256, 88);
            this.comboSubject.Name = "comboSubject";
            this.comboSubject.Size = new System.Drawing.Size(376, 37);
            this.comboSubject.TabIndex = 1;
            this.comboSubject.SelectedIndexChanged += new System.EventHandler(this.comboSubject_SelectedIndexChanged);
            // 
            // comboLessonType
            // 
            this.comboLessonType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboLessonType.FormattingEnabled = true;
            this.comboLessonType.Location = new System.Drawing.Point(256, 141);
            this.comboLessonType.Name = "comboLessonType";
            this.comboLessonType.Size = new System.Drawing.Size(376, 37);
            this.comboLessonType.TabIndex = 2;
            this.comboLessonType.SelectedIndexChanged += new System.EventHandler(this.comboLessonType_SelectedIndexChanged);
            // 
            // comboTeacher
            // 
            this.comboTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboTeacher.FormattingEnabled = true;
            this.comboTeacher.Location = new System.Drawing.Point(256, 193);
            this.comboTeacher.Name = "comboTeacher";
            this.comboTeacher.Size = new System.Drawing.Size(376, 37);
            this.comboTeacher.TabIndex = 3;
            this.comboTeacher.SelectedIndexChanged += new System.EventHandler(this.comboTeacher_SelectedIndexChanged);
            // 
            // comboAuditorium
            // 
            this.comboAuditorium.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboAuditorium.FormattingEnabled = true;
            this.comboAuditorium.Location = new System.Drawing.Point(256, 239);
            this.comboAuditorium.Name = "comboAuditorium";
            this.comboAuditorium.Size = new System.Drawing.Size(376, 37);
            this.comboAuditorium.TabIndex = 4;
            this.comboAuditorium.SelectedIndexChanged += new System.EventHandler(this.comboAuditorium_SelectedIndexChanged);
            // 
            // comboGroup
            // 
            this.comboGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboGroup.FormattingEnabled = true;
            this.comboGroup.Location = new System.Drawing.Point(256, 291);
            this.comboGroup.Name = "comboGroup";
            this.comboGroup.Size = new System.Drawing.Size(376, 37);
            this.comboGroup.TabIndex = 5;
            this.comboGroup.SelectedIndexChanged += new System.EventHandler(this.comboGroup_SelectedIndexChanged);
            // 
            // comboDay
            // 
            this.comboDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboDay.FormattingEnabled = true;
            this.comboDay.Location = new System.Drawing.Point(256, 344);
            this.comboDay.Name = "comboDay";
            this.comboDay.Size = new System.Drawing.Size(376, 37);
            this.comboDay.TabIndex = 6;
            this.comboDay.SelectedIndexChanged += new System.EventHandler(this.comboDay_SelectedIndexChanged);
            // 
            // numericPair
            // 
            this.numericPair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericPair.Location = new System.Drawing.Point(846, 91);
            this.numericPair.Name = "numericPair";
            this.numericPair.Size = new System.Drawing.Size(120, 35);
            this.numericPair.TabIndex = 7;
            // 
            // checkNumerator
            // 
            this.checkNumerator.AutoSize = true;
            this.checkNumerator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkNumerator.Location = new System.Drawing.Point(690, 145);
            this.checkNumerator.Name = "checkNumerator";
            this.checkNumerator.Size = new System.Drawing.Size(179, 33);
            this.checkNumerator.TabIndex = 8;
            this.checkNumerator.Text = "Числитель?";
            this.checkNumerator.UseVisualStyleBackColor = true;
            // 
            // checkHalfGroup
            // 
            this.checkHalfGroup.AutoSize = true;
            this.checkHalfGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkHalfGroup.Location = new System.Drawing.Point(690, 197);
            this.checkHalfGroup.Name = "checkHalfGroup";
            this.checkHalfGroup.Size = new System.Drawing.Size(175, 33);
            this.checkHalfGroup.TabIndex = 9;
            this.checkHalfGroup.Text = "Подгруппа?";
            this.checkHalfGroup.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(685, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Номер пары";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(38, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "Предмет:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(38, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "Тип занятия:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(38, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 29);
            this.label4.TabIndex = 13;
            this.label4.Text = "Преподаватель:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(38, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 29);
            this.label5.TabIndex = 14;
            this.label5.Text = "Аудитория:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(38, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 29);
            this.label6.TabIndex = 15;
            this.label6.Text = "Группа:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(38, 352);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 29);
            this.label7.TabIndex = 16;
            this.label7.Text = "День недели:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.Location = new System.Drawing.Point(948, 499);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(122, 46);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // EditScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 570);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkHalfGroup);
            this.Controls.Add(this.checkNumerator);
            this.Controls.Add(this.numericPair);
            this.Controls.Add(this.comboDay);
            this.Controls.Add(this.comboGroup);
            this.Controls.Add(this.comboAuditorium);
            this.Controls.Add(this.comboTeacher);
            this.Controls.Add(this.comboLessonType);
            this.Controls.Add(this.comboSubject);
            this.Controls.Add(this.btnSave);
            this.Name = "EditScheduleForm";
            this.Text = "EditScheduleForm";
            this.Load += new System.EventHandler(this.EditScheduleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericPair)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox comboSubject;
        private System.Windows.Forms.ComboBox comboLessonType;
        private System.Windows.Forms.ComboBox comboTeacher;
        private System.Windows.Forms.ComboBox comboAuditorium;
        private System.Windows.Forms.ComboBox comboGroup;
        private System.Windows.Forms.ComboBox comboDay;
        private System.Windows.Forms.NumericUpDown numericPair;
        private System.Windows.Forms.CheckBox checkNumerator;
        private System.Windows.Forms.CheckBox checkHalfGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCancel;
    }
}