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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInfoForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.showData_panel = new System.Windows.Forms.Panel();
            this.birthday_Dtp = new System.Windows.Forms.DateTimePicker();
            this.username_txtBox = new System.Windows.Forms.TextBox();
            this.fullname_txtBox = new System.Windows.Forms.TextBox();
            this.id_txtBox = new System.Windows.Forms.TextBox();
            this.email_txtBox = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.updateUserInfo_Btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.confirmnewPassword_txtBox = new System.Windows.Forms.TextBox();
            this.changePassword_chkBox = new System.Windows.Forms.CheckBox();
            this.phonenumber_txtBox = new System.Windows.Forms.TextBox();
            this.newPassword_txtBox = new System.Windows.Forms.TextBox();
            this.oldPassword_txtBox = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.showData_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.textBox11);
            this.panel2.Controls.Add(this.textBox10);
            this.panel2.Controls.Add(this.textBox9);
            this.panel2.Controls.Add(this.showData_panel);
            this.panel2.Controls.Add(this.textBox7);
            this.panel2.Location = new System.Drawing.Point(21, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(465, 239);
            this.panel2.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(3, 206);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(91, 23);
            this.textBox1.TabIndex = 13;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Ngày sinh:";
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
            this.showData_panel.Controls.Add(this.birthday_Dtp);
            this.showData_panel.Controls.Add(this.username_txtBox);
            this.showData_panel.Controls.Add(this.fullname_txtBox);
            this.showData_panel.Controls.Add(this.id_txtBox);
            this.showData_panel.Controls.Add(this.email_txtBox);
            this.showData_panel.Location = new System.Drawing.Point(177, 0);
            this.showData_panel.Name = "showData_panel";
            this.showData_panel.Size = new System.Drawing.Size(288, 239);
            this.showData_panel.TabIndex = 3;
            // 
            // birthday_Dtp
            // 
            this.birthday_Dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthday_Dtp.Location = new System.Drawing.Point(3, 202);
            this.birthday_Dtp.Name = "birthday_Dtp";
            this.birthday_Dtp.Size = new System.Drawing.Size(285, 27);
            this.birthday_Dtp.TabIndex = 20;
            this.birthday_Dtp.TabStop = false;
            // 
            // username_txtBox
            // 
            this.username_txtBox.BackColor = System.Drawing.Color.LightGray;
            this.username_txtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.username_txtBox.Location = new System.Drawing.Point(3, 6);
            this.username_txtBox.Name = "username_txtBox";
            this.username_txtBox.ReadOnly = true;
            this.username_txtBox.Size = new System.Drawing.Size(285, 27);
            this.username_txtBox.TabIndex = 19;
            this.username_txtBox.TabStop = false;
            // 
            // fullname_txtBox
            // 
            this.fullname_txtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fullname_txtBox.Location = new System.Drawing.Point(3, 102);
            this.fullname_txtBox.Name = "fullname_txtBox";
            this.fullname_txtBox.Size = new System.Drawing.Size(285, 27);
            this.fullname_txtBox.TabIndex = 1;
            this.fullname_txtBox.TabStop = false;
            // 
            // id_txtBox
            // 
            this.id_txtBox.BackColor = System.Drawing.Color.White;
            this.id_txtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.id_txtBox.Location = new System.Drawing.Point(3, 54);
            this.id_txtBox.Name = "id_txtBox";
            this.id_txtBox.Size = new System.Drawing.Size(285, 27);
            this.id_txtBox.TabIndex = 0;
            this.id_txtBox.TabStop = false;
            // 
            // email_txtBox
            // 
            this.email_txtBox.BackColor = System.Drawing.Color.White;
            this.email_txtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.email_txtBox.Location = new System.Drawing.Point(3, 153);
            this.email_txtBox.Name = "email_txtBox";
            this.email_txtBox.Size = new System.Drawing.Size(285, 27);
            this.email_txtBox.TabIndex = 2;
            this.email_txtBox.TabStop = false;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.White;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox7.Location = new System.Drawing.Point(3, 58);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(168, 23);
            this.textBox7.TabIndex = 0;
            this.textBox7.TabStop = false;
            this.textBox7.Text = "Mã định danh/CCCD:";
            // 
            // updateUserInfo_Btn
            // 
            this.updateUserInfo_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            this.updateUserInfo_Btn.ForeColor = System.Drawing.Color.White;
            this.updateUserInfo_Btn.Location = new System.Drawing.Point(420, 286);
            this.updateUserInfo_Btn.Name = "updateUserInfo_Btn";
            this.updateUserInfo_Btn.Size = new System.Drawing.Size(133, 44);
            this.updateUserInfo_Btn.TabIndex = 8;
            this.updateUserInfo_Btn.Text = "Cập nhật";
            this.updateUserInfo_Btn.UseVisualStyleBackColor = false;
            this.updateUserInfo_Btn.Click += new System.EventHandler(this.updateUserInfoBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox8);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Location = new System.Drawing.Point(503, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 239);
            this.panel1.TabIndex = 4;
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
            this.panel3.Controls.Add(this.confirmnewPassword_txtBox);
            this.panel3.Controls.Add(this.changePassword_chkBox);
            this.panel3.Controls.Add(this.phonenumber_txtBox);
            this.panel3.Controls.Add(this.newPassword_txtBox);
            this.panel3.Controls.Add(this.oldPassword_txtBox);
            this.panel3.Location = new System.Drawing.Point(687, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(271, 234);
            this.panel3.TabIndex = 5;
            // 
            // confirmnewPassword_txtBox
            // 
            this.confirmnewPassword_txtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.confirmnewPassword_txtBox.Location = new System.Drawing.Point(3, 157);
            this.confirmnewPassword_txtBox.Name = "confirmnewPassword_txtBox";
            this.confirmnewPassword_txtBox.Size = new System.Drawing.Size(268, 27);
            this.confirmnewPassword_txtBox.TabIndex = 7;
            this.confirmnewPassword_txtBox.TabStop = false;
            this.confirmnewPassword_txtBox.UseSystemPasswordChar = true;
            // 
            // changePassword_chkBox
            // 
            this.changePassword_chkBox.AutoSize = true;
            this.changePassword_chkBox.Location = new System.Drawing.Point(3, 207);
            this.changePassword_chkBox.Name = "changePassword_chkBox";
            this.changePassword_chkBox.Size = new System.Drawing.Size(120, 24);
            this.changePassword_chkBox.TabIndex = 4;
            this.changePassword_chkBox.TabStop = false;
            this.changePassword_chkBox.Text = "Đổi mật khẩu";
            this.changePassword_chkBox.UseVisualStyleBackColor = true;
            this.changePassword_chkBox.CheckedChanged += new System.EventHandler(this.changePasswordCkBox_CheckedChanged);
            // 
            // phonenumber_txtBox
            // 
            this.phonenumber_txtBox.BackColor = System.Drawing.Color.White;
            this.phonenumber_txtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phonenumber_txtBox.Location = new System.Drawing.Point(3, 2);
            this.phonenumber_txtBox.Name = "phonenumber_txtBox";
            this.phonenumber_txtBox.Size = new System.Drawing.Size(268, 27);
            this.phonenumber_txtBox.TabIndex = 3;
            this.phonenumber_txtBox.TabStop = false;
            // 
            // newPassword_txtBox
            // 
            this.newPassword_txtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newPassword_txtBox.Location = new System.Drawing.Point(3, 102);
            this.newPassword_txtBox.Name = "newPassword_txtBox";
            this.newPassword_txtBox.Size = new System.Drawing.Size(268, 27);
            this.newPassword_txtBox.TabIndex = 6;
            this.newPassword_txtBox.TabStop = false;
            this.newPassword_txtBox.UseSystemPasswordChar = true;
            // 
            // oldPassword_txtBox
            // 
            this.oldPassword_txtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.oldPassword_txtBox.Location = new System.Drawing.Point(3, 50);
            this.oldPassword_txtBox.Name = "oldPassword_txtBox";
            this.oldPassword_txtBox.Size = new System.Drawing.Size(268, 27);
            this.oldPassword_txtBox.TabIndex = 5;
            this.oldPassword_txtBox.TabStop = false;
            this.oldPassword_txtBox.UseSystemPasswordChar = true;
            // 
            // UserInfoForm
            // 
            this.AcceptButton = this.updateUserInfo_Btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(967, 364);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.updateUserInfo_Btn);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UserInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chỉnh sửa thông tin";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.showData_panel.ResumeLayout(false);
            this.showData_panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel2;
        private Button updateUserInfo_Btn;
        private Panel showData_panel;
        private TextBox username_txtBox;
        private TextBox fullname_txtBox;
        private TextBox id_txtBox;
        private Panel panel1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox5;
        private Panel panel3;
        private TextBox phonenumber_txtBox;
        private TextBox newPassword_txtBox;
        private TextBox oldPassword_txtBox;
        private TextBox email_txtBox;
        private CheckBox changePassword_chkBox;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox confirmnewPassword_txtBox;
        private TextBox textBox9;
        private TextBox textBox10;
        private TextBox textBox11;
        private TextBox textBox1;
        private TextBox NgaySinh_txtBox;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker birthday_Dtp;
    }
}