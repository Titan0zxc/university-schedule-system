namespace Расписание_занятий
{
    partial class RegisterForm
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
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.comboRole = new System.Windows.Forms.ComboBox();
            this.comboGroup = new System.Windows.Forms.ComboBox();
            this.comboTeacher = new System.Windows.Forms.ComboBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtLogin.Location = new System.Drawing.Point(442, 138);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(222, 35);
            this.txtLogin.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPassword.Location = new System.Drawing.Point(442, 197);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(222, 35);
            this.txtPassword.TabIndex = 1;
            // 
            // txtConfirm
            // 
            this.txtConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtConfirm.Location = new System.Drawing.Point(442, 253);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Size = new System.Drawing.Size(222, 35);
            this.txtConfirm.TabIndex = 2;
            // 
            // comboRole
            // 
            this.comboRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboRole.FormattingEnabled = true;
            this.comboRole.Location = new System.Drawing.Point(442, 319);
            this.comboRole.Name = "comboRole";
            this.comboRole.Size = new System.Drawing.Size(222, 37);
            this.comboRole.TabIndex = 3;
            this.comboRole.SelectedIndexChanged += new System.EventHandler(this.comboRole_SelectedIndexChanged);
            // 
            // comboGroup
            // 
            this.comboGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboGroup.FormattingEnabled = true;
            this.comboGroup.Location = new System.Drawing.Point(442, 379);
            this.comboGroup.Name = "comboGroup";
            this.comboGroup.Size = new System.Drawing.Size(222, 37);
            this.comboGroup.TabIndex = 4;
            // 
            // comboTeacher
            // 
            this.comboTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboTeacher.FormattingEnabled = true;
            this.comboTeacher.Location = new System.Drawing.Point(442, 444);
            this.comboTeacher.Name = "comboTeacher";
            this.comboTeacher.Size = new System.Drawing.Size(222, 37);
            this.comboTeacher.TabIndex = 5;
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRegister.Location = new System.Drawing.Point(243, 505);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(317, 45);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Зарегистрироваться";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(101, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Введите логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(101, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Введите пароль:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(101, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "Подтвердите пароль:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(101, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "Выберите роль:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(101, 387);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(269, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "Группа(для студента):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(101, 452);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(321, 29);
            this.label6.TabIndex = 12;
            this.label6.Text = "ФИО(для преподавателя):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(284, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(224, 32);
            this.label7.TabIndex = 13;
            this.label7.Text = "РЕГИСТРАЦИЯ";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 713);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.comboTeacher);
            this.Controls.Add(this.comboGroup);
            this.Controls.Add(this.comboRole);
            this.Controls.Add(this.txtConfirm);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtLogin);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.ComboBox comboRole;
        private System.Windows.Forms.ComboBox comboGroup;
        private System.Windows.Forms.ComboBox comboTeacher;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}