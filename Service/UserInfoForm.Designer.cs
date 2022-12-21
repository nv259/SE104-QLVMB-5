namespace Service
{
    partial class UserInfoForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBox4 = new System.Windows.Forms.TextBox();
            this.showData_panel = new System.Windows.Forms.Panel();
            this.usernameTxtBox = new System.Windows.Forms.TextBox();
            this.fullNameTxtBox = new System.Windows.Forms.TextBox();
            this.idTxtBox = new System.Windows.Forms.TextBox();
            this.emailTxtBox = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.updateUserInfoBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.confirmnewPasswordTxtBox = new System.Windows.Forms.TextBox();
            this.changePasswordCkBox = new System.Windows.Forms.CheckBox();
            this.phoneTxtBox = new System.Windows.Forms.TextBox();
            this.newPasswordTxtBox = new System.Windows.Forms.TextBox();
            this.oldPasswordTxtBox = new System.Windows.Forms.TextBox();
            this.alert_txtBox = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.showData_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtBox4);
            this.panel2.Controls.Add(this.showData_panel);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.textBox6);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(21, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(455, 239);
            this.panel2.TabIndex = 2;
            // 
            // txtBox4
            // 
            this.txtBox4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox4.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.txtBox4.Location = new System.Drawing.Point(3, 5);
            this.txtBox4.Name = "txtBox4";
            this.txtBox4.ReadOnly = true;
            this.txtBox4.Size = new System.Drawing.Size(133, 23);
            this.txtBox4.TabIndex = 12;
            this.txtBox4.TabStop = false;
            this.txtBox4.Text = "Tên đăng nhập:";
            // 
            // showData_panel
            // 
            this.showData_panel.Controls.Add(this.usernameTxtBox);
            this.showData_panel.Controls.Add(this.fullNameTxtBox);
            this.showData_panel.Controls.Add(this.idTxtBox);
            this.showData_panel.Controls.Add(this.emailTxtBox);
            this.showData_panel.Location = new System.Drawing.Point(163, 0);
            this.showData_panel.Name = "showData_panel";
            this.showData_panel.Size = new System.Drawing.Size(288, 239);
            this.showData_panel.TabIndex = 3;
            // 
            // usernameTxtBox
            // 
            this.usernameTxtBox.BackColor = System.Drawing.Color.LightGray;
            this.usernameTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameTxtBox.Location = new System.Drawing.Point(3, 6);
            this.usernameTxtBox.Name = "usernameTxtBox";
            this.usernameTxtBox.ReadOnly = true;
            this.usernameTxtBox.Size = new System.Drawing.Size(282, 27);
            this.usernameTxtBox.TabIndex = 19;
            // 
            // fullNameTxtBox
            // 
            this.fullNameTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fullNameTxtBox.Location = new System.Drawing.Point(3, 106);
            this.fullNameTxtBox.Name = "fullNameTxtBox";
            this.fullNameTxtBox.ReadOnly = true;
            this.fullNameTxtBox.Size = new System.Drawing.Size(282, 27);
            this.fullNameTxtBox.TabIndex = 15;
            this.fullNameTxtBox.TextChanged += new System.EventHandler(this.fullNameTxtBox_TextChanged);
            // 
            // idTxtBox
            // 
            this.idTxtBox.BackColor = System.Drawing.SystemColors.Control;
            this.idTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idTxtBox.Location = new System.Drawing.Point(3, 54);
            this.idTxtBox.Name = "idTxtBox";
            this.idTxtBox.Size = new System.Drawing.Size(282, 27);
            this.idTxtBox.TabIndex = 14;
            this.idTxtBox.TextChanged += new System.EventHandler(this.idTxtBox_TextChanged);
            // 
            // emailTxtBox
            // 
            this.emailTxtBox.BackColor = System.Drawing.SystemColors.Control;
            this.emailTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailTxtBox.Location = new System.Drawing.Point(3, 161);
            this.emailTxtBox.Name = "emailTxtBox";
            this.emailTxtBox.Size = new System.Drawing.Size(282, 27);
            this.emailTxtBox.TabIndex = 14;
            this.emailTxtBox.TextChanged += new System.EventHandler(this.emailTxtBox_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox4.Location = new System.Drawing.Point(3, 106);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(91, 23);
            this.textBox4.TabIndex = 2;
            this.textBox4.TabStop = false;
            this.textBox4.Text = "Họ và tên:";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox6.Location = new System.Drawing.Point(3, 161);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(62, 23);
            this.textBox6.TabIndex = 0;
            this.textBox6.TabStop = false;
            this.textBox6.Text = "Email:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(3, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(154, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Định danh / CCCD:";
            // 
            // updateUserInfoBtn
            // 
            this.updateUserInfoBtn.Location = new System.Drawing.Point(423, 308);
            this.updateUserInfoBtn.Name = "updateUserInfoBtn";
            this.updateUserInfoBtn.Size = new System.Drawing.Size(133, 44);
            this.updateUserInfoBtn.TabIndex = 3;
            this.updateUserInfoBtn.Text = "Cập nhật";
            this.updateUserInfoBtn.UseVisualStyleBackColor = true;
            this.updateUserInfoBtn.Click += new System.EventHandler(this.updateUserInfoBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox8);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Location = new System.Drawing.Point(497, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(493, 239);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox8.Location = new System.Drawing.Point(3, 161);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(196, 23);
            this.textBox8.TabIndex = 13;
            this.textBox8.TabStop = false;
            this.textBox8.Text = "Xác nhận mật khẩu mới:";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(3, 6);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(158, 23);
            this.textBox2.TabIndex = 12;
            this.textBox2.TabStop = false;
            this.textBox2.Text = "Số điện thoại:";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox3.Location = new System.Drawing.Point(3, 106);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(128, 23);
            this.textBox3.TabIndex = 4;
            this.textBox3.TabStop = false;
            this.textBox3.Text = "Mật khẩu mới:";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox5.Location = new System.Drawing.Point(3, 54);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(128, 23);
            this.textBox5.TabIndex = 2;
            this.textBox5.TabStop = false;
            this.textBox5.Text = "Mật khẩu cũ:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.confirmnewPasswordTxtBox);
            this.panel3.Controls.Add(this.changePasswordCkBox);
            this.panel3.Controls.Add(this.phoneTxtBox);
            this.panel3.Controls.Add(this.newPasswordTxtBox);
            this.panel3.Controls.Add(this.oldPasswordTxtBox);
            this.panel3.Location = new System.Drawing.Point(703, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(284, 234);
            this.panel3.TabIndex = 5;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // confirmnewPasswordTxtBox
            // 
            this.confirmnewPasswordTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.confirmnewPasswordTxtBox.Location = new System.Drawing.Point(3, 157);
            this.confirmnewPasswordTxtBox.Name = "confirmnewPasswordTxtBox";
            this.confirmnewPasswordTxtBox.ReadOnly = true;
            this.confirmnewPasswordTxtBox.Size = new System.Drawing.Size(281, 27);
            this.confirmnewPasswordTxtBox.TabIndex = 20;
            this.confirmnewPasswordTxtBox.UseSystemPasswordChar = true;
            this.confirmnewPasswordTxtBox.TextChanged += new System.EventHandler(this.textBox7_TextChanged_1);
            // 
            // changePasswordCkBox
            // 
            this.changePasswordCkBox.AutoSize = true;
            this.changePasswordCkBox.Location = new System.Drawing.Point(3, 207);
            this.changePasswordCkBox.Name = "changePasswordCkBox";
            this.changePasswordCkBox.Size = new System.Drawing.Size(120, 24);
            this.changePasswordCkBox.TabIndex = 13;
            this.changePasswordCkBox.Text = "Đổi mật khẩu";
            this.changePasswordCkBox.UseVisualStyleBackColor = true;
            this.changePasswordCkBox.CheckedChanged += new System.EventHandler(this.changePasswordCkBox_CheckedChanged);
            // 
            // phoneTxtBox
            // 
            this.phoneTxtBox.BackColor = System.Drawing.SystemColors.Control;
            this.phoneTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phoneTxtBox.Location = new System.Drawing.Point(3, 2);
            this.phoneTxtBox.Name = "phoneTxtBox";
            this.phoneTxtBox.Size = new System.Drawing.Size(281, 27);
            this.phoneTxtBox.TabIndex = 19;
            this.phoneTxtBox.TextChanged += new System.EventHandler(this.phoneTxtBox_TextChanged);
            // 
            // newPasswordTxtBox
            // 
            this.newPasswordTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newPasswordTxtBox.Location = new System.Drawing.Point(3, 102);
            this.newPasswordTxtBox.Name = "newPasswordTxtBox";
            this.newPasswordTxtBox.ReadOnly = true;
            this.newPasswordTxtBox.Size = new System.Drawing.Size(281, 27);
            this.newPasswordTxtBox.TabIndex = 16;
            this.newPasswordTxtBox.UseSystemPasswordChar = true;
            this.newPasswordTxtBox.TextChanged += new System.EventHandler(this.newPasswordTxtBox_TextChanged);
            // 
            // oldPasswordTxtBox
            // 
            this.oldPasswordTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.oldPasswordTxtBox.Location = new System.Drawing.Point(3, 50);
            this.oldPasswordTxtBox.Name = "oldPasswordTxtBox";
            this.oldPasswordTxtBox.ReadOnly = true;
            this.oldPasswordTxtBox.Size = new System.Drawing.Size(281, 27);
            this.oldPasswordTxtBox.TabIndex = 15;
            this.oldPasswordTxtBox.UseSystemPasswordChar = true;
            this.oldPasswordTxtBox.TextChanged += new System.EventHandler(this.oldPasswordTxtBox_TextChanged);
            // 
            // alert_txtBox
            // 
            this.alert_txtBox.BackColor = System.Drawing.SystemColors.Control;
            this.alert_txtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.alert_txtBox.Location = new System.Drawing.Point(173, 270);
            this.alert_txtBox.Name = "alert_txtBox";
            this.alert_txtBox.Size = new System.Drawing.Size(653, 20);
            this.alert_txtBox.TabIndex = 6;
            this.alert_txtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UserInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 364);
            this.Controls.Add(this.alert_txtBox);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.updateUserInfoBtn);
            this.Controls.Add(this.panel2);
            this.Name = "UserInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chỉnh sửa thông tin";
            this.Load += new System.EventHandler(this.UserInfoForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.showData_panel.ResumeLayout(false);
            this.showData_panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel2;
        private TextBox txtBox4;
        private Button updateUserInfoBtn;
        private TextBox textBox4;
        private TextBox textBox1;
        private Panel showData_panel;
        private TextBox usernameTxtBox;
        private TextBox fullNameTxtBox;
        private TextBox idTxtBox;
        private Panel panel1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox5;
        private TextBox textBox6;
        private Panel panel3;
        private TextBox phoneTxtBox;
        private TextBox newPasswordTxtBox;
        private TextBox oldPasswordTxtBox;
        private TextBox emailTxtBox;
        private CheckBox changePasswordCkBox;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox alert_txtBox;
        private TextBox confirmnewPasswordTxtBox;
    }
}