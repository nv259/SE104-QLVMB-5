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
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.showData_panel = new System.Windows.Forms.Panel();
            this.usernameTxtBox = new System.Windows.Forms.TextBox();
            this.fullNameTxtBox = new System.Windows.Forms.TextBox();
            this.idTxtBox = new System.Windows.Forms.TextBox();
            this.emailTxtBox = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
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
            this.panel2.Controls.Add(this.textBox11);
            this.panel2.Controls.Add(this.textBox10);
            this.panel2.Controls.Add(this.textBox9);
            this.panel2.Controls.Add(this.showData_panel);
            this.panel2.Controls.Add(this.textBox7);
            this.panel2.Location = new System.Drawing.Point(21, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(455, 239);
            this.panel2.TabIndex = 2;
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.Color.White;
            this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox11.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.textBox11.Location = new System.Drawing.Point(3, 10);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(133, 23);
            this.textBox11.TabIndex = 12;
            this.textBox11.TabStop = false;
            this.textBox11.Text = "Tên đăng nhập:";
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.Color.White;
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox10.Location = new System.Drawing.Point(3, 106);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(91, 23);
            this.textBox10.TabIndex = 2;
            this.textBox10.TabStop = false;
            this.textBox10.Text = "Họ và tên:";
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.White;
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox9.Location = new System.Drawing.Point(3, 157);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(62, 23);
            this.textBox9.TabIndex = 0;
            this.textBox9.TabStop = false;
            this.textBox9.Text = "Email:";
            // 
            // showData_panel
            // 
            this.showData_panel.Controls.Add(this.usernameTxtBox);
            this.showData_panel.Controls.Add(this.fullNameTxtBox);
            this.showData_panel.Controls.Add(this.idTxtBox);
            this.showData_panel.Controls.Add(this.emailTxtBox);
            this.showData_panel.Location = new System.Drawing.Point(152, 0);
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
            this.usernameTxtBox.TabStop = false;
            // 
            // fullNameTxtBox
            // 
            this.fullNameTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fullNameTxtBox.Location = new System.Drawing.Point(0, 102);
            this.fullNameTxtBox.Name = "fullNameTxtBox";
            this.fullNameTxtBox.Size = new System.Drawing.Size(285, 27);
            this.fullNameTxtBox.TabIndex = 1;
            this.fullNameTxtBox.TextChanged += new System.EventHandler(this.fullNameTxtBox_TextChanged);
            // 
            // idTxtBox
            // 
            this.idTxtBox.BackColor = System.Drawing.Color.White;
            this.idTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idTxtBox.Location = new System.Drawing.Point(3, 54);
            this.idTxtBox.Name = "idTxtBox";
            this.idTxtBox.Size = new System.Drawing.Size(282, 27);
            this.idTxtBox.TabIndex = 0;
            this.idTxtBox.TextChanged += new System.EventHandler(this.idTxtBox_TextChanged);
            // 
            // emailTxtBox
            // 
            this.emailTxtBox.BackColor = System.Drawing.Color.White;
            this.emailTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailTxtBox.Location = new System.Drawing.Point(3, 153);
            this.emailTxtBox.Name = "emailTxtBox";
            this.emailTxtBox.Size = new System.Drawing.Size(282, 27);
            this.emailTxtBox.TabIndex = 2;
            this.emailTxtBox.TextChanged += new System.EventHandler(this.emailTxtBox_TextChanged);
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.White;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.textBox7.Location = new System.Drawing.Point(3, 58);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(154, 23);
            this.textBox7.TabIndex = 0;
            this.textBox7.TabStop = false;
            this.textBox7.Text = "Định danh/CCCD:";
            // 
            // updateUserInfoBtn
            // 
            this.updateUserInfoBtn.Location = new System.Drawing.Point(423, 308);
            this.updateUserInfoBtn.Name = "updateUserInfoBtn";
            this.updateUserInfoBtn.Size = new System.Drawing.Size(133, 44);
            this.updateUserInfoBtn.TabIndex = 8;
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
            this.panel1.Size = new System.Drawing.Size(461, 239);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.White;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox8.Location = new System.Drawing.Point(3, 161);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(196, 23);
            this.textBox8.TabIndex = 13;
            this.textBox8.TabStop = false;
            this.textBox8.Text = "Nhập lại mật khẩu:";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
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
            this.textBox3.BackColor = System.Drawing.Color.White;
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
            this.textBox5.BackColor = System.Drawing.Color.White;
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
            this.panel3.Location = new System.Drawing.Point(664, 12);
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
            this.confirmnewPasswordTxtBox.TabIndex = 7;
            this.confirmnewPasswordTxtBox.UseSystemPasswordChar = true;
            this.confirmnewPasswordTxtBox.TextChanged += new System.EventHandler(this.textBox7_TextChanged_1);
            // 
            // changePasswordCkBox
            // 
            this.changePasswordCkBox.AutoSize = true;
            this.changePasswordCkBox.Location = new System.Drawing.Point(3, 207);
            this.changePasswordCkBox.Name = "changePasswordCkBox";
            this.changePasswordCkBox.Size = new System.Drawing.Size(120, 24);
            this.changePasswordCkBox.TabIndex = 4;
            this.changePasswordCkBox.Text = "Đổi mật khẩu";
            this.changePasswordCkBox.UseVisualStyleBackColor = true;
            this.changePasswordCkBox.CheckedChanged += new System.EventHandler(this.changePasswordCkBox_CheckedChanged);
            // 
            // phoneTxtBox
            // 
            this.phoneTxtBox.BackColor = System.Drawing.Color.White;
            this.phoneTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phoneTxtBox.Location = new System.Drawing.Point(3, 2);
            this.phoneTxtBox.Name = "phoneTxtBox";
            this.phoneTxtBox.Size = new System.Drawing.Size(281, 27);
            this.phoneTxtBox.TabIndex = 3;
            this.phoneTxtBox.TextChanged += new System.EventHandler(this.phoneTxtBox_TextChanged);
            // 
            // newPasswordTxtBox
            // 
            this.newPasswordTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newPasswordTxtBox.Location = new System.Drawing.Point(3, 102);
            this.newPasswordTxtBox.Name = "newPasswordTxtBox";
            this.newPasswordTxtBox.ReadOnly = true;
            this.newPasswordTxtBox.Size = new System.Drawing.Size(281, 27);
            this.newPasswordTxtBox.TabIndex = 6;
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
            this.oldPasswordTxtBox.TabIndex = 5;
            this.oldPasswordTxtBox.UseSystemPasswordChar = true;
            this.oldPasswordTxtBox.TextChanged += new System.EventHandler(this.oldPasswordTxtBox_TextChanged);
            // 
            // alert_txtBox
            // 
            this.alert_txtBox.BackColor = System.Drawing.Color.White;
            this.alert_txtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.alert_txtBox.Location = new System.Drawing.Point(173, 270);
            this.alert_txtBox.Name = "alert_txtBox";
            this.alert_txtBox.ReadOnly = true;
            this.alert_txtBox.Size = new System.Drawing.Size(653, 20);
            this.alert_txtBox.TabIndex = 6;
            this.alert_txtBox.TabStop = false;
            this.alert_txtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UserInfoForm
            // 
            this.AcceptButton = this.updateUserInfoBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(967, 364);
            this.Controls.Add(this.alert_txtBox);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.updateUserInfoBtn);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
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
        private Button updateUserInfoBtn;
        private Panel showData_panel;
        private TextBox usernameTxtBox;
        private TextBox fullNameTxtBox;
        private TextBox idTxtBox;
        private Panel panel1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox5;
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
        private TextBox textBox9;
        private TextBox textBox10;
        private TextBox textBox11;
    }
}