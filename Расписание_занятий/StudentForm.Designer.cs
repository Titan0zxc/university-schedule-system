namespace Расписание_занятий
{
    partial class StudentForm
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
            this.gridStudent = new System.Windows.Forms.DataGridView();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.btnExportWord = new System.Windows.Forms.Button();
            this.btnReturnToLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // gridStudent
            // 
            this.gridStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridStudent.Location = new System.Drawing.Point(12, 87);
            this.gridStudent.Name = "gridStudent";
            this.gridStudent.RowHeadersWidth = 62;
            this.gridStudent.RowTemplate.Height = 28;
            this.gridStudent.Size = new System.Drawing.Size(1440, 629);
            this.gridStudent.TabIndex = 0;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExportExcel.Location = new System.Drawing.Point(12, 22);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(242, 48);
            this.btnExportExcel.TabIndex = 1;
            this.btnExportExcel.Text = "Экспорт Exsel";
            this.btnExportExcel.UseVisualStyleBackColor = true;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // btnExportWord
            // 
            this.btnExportWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExportWord.Location = new System.Drawing.Point(277, 22);
            this.btnExportWord.Name = "btnExportWord";
            this.btnExportWord.Size = new System.Drawing.Size(236, 48);
            this.btnExportWord.TabIndex = 2;
            this.btnExportWord.Text = "Экспорт Word";
            this.btnExportWord.UseVisualStyleBackColor = true;
            this.btnExportWord.Click += new System.EventHandler(this.btnExportWord_Click);
            // 
            // btnReturnToLogin
            // 
            this.btnReturnToLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReturnToLogin.Location = new System.Drawing.Point(545, 22);
            this.btnReturnToLogin.Name = "btnReturnToLogin";
            this.btnReturnToLogin.Size = new System.Drawing.Size(288, 48);
            this.btnReturnToLogin.TabIndex = 3;
            this.btnReturnToLogin.Text = "Вернуться к началу";
            this.btnReturnToLogin.UseVisualStyleBackColor = true;
            this.btnReturnToLogin.Click += new System.EventHandler(this.btnReturnToLogin_Click);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1464, 728);
            this.Controls.Add(this.btnReturnToLogin);
            this.Controls.Add(this.btnExportWord);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.gridStudent);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            ((System.ComponentModel.ISupportInitialize)(this.gridStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridStudent;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.Button btnExportWord;
        private System.Windows.Forms.Button btnReturnToLogin;
    }
}