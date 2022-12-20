namespace Service
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.PhoneNumber_txtBox = new System.Windows.Forms.TextBox();
            this.ID_txtBox = new System.Windows.Forms.TextBox();
            this.alert_txtBox = new System.Windows.Forms.TextBox();
            this.regBtn = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.confirmPwd_txtBox = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.pwd_txtBox = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.username_txtBox = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.email_txtBox = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.firstName_txtBox = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateBlue;
            this.panel1.Controls.Add(this.PhoneNumber_txtBox);
            this.panel1.Controls.Add(this.ID_txtBox);
            this.panel1.Controls.Add(this.alert_txtBox);
            this.panel1.Controls.Add(this.regBtn);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.confirmPwd_txtBox);
            this.panel1.Controls.Add(this.textBox11);
            this.panel1.Controls.Add(this.pwd_txtBox);
            this.panel1.Controls.Add(this.textBox9);
            this.panel1.Controls.Add(this.username_txtBox);
            this.panel1.Controls.Add(this.textBox7);
            this.panel1.Controls.Add(this.email_txtBox);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.firstName_txtBox);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 550);
            this.panel1.TabIndex = 1;
            // 
            // PhoneNumber_txtBox
            // 
            this.PhoneNumber_txtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PhoneNumber_txtBox.Location = new System.Drawing.Point(323, 373);
            this.PhoneNumber_txtBox.Name = "PhoneNumber_txtBox";
            this.PhoneNumber_txtBox.PlaceholderText = "      Số điện thoại";
            this.PhoneNumber_txtBox.Size = new System.Drawing.Size(145, 27);
            this.PhoneNumber_txtBox.TabIndex = 14;
            this.PhoneNumber_txtBox.TextChanged += new System.EventHandler(this.PhoneNumber_txtBox_TextChanged);
            // 
            // ID_txtBox
            // 
            this.ID_txtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ID_txtBox.Location = new System.Drawing.Point(161, 373);
            this.ID_txtBox.Name = "ID_txtBox";
            this.ID_txtBox.PlaceholderText = "   Định danh / CCCD";
            this.ID_txtBox.Size = new System.Drawing.Size(156, 27);
            this.ID_txtBox.TabIndex = 13;
            // 
            // alert_txtBox
            // 
            this.alert_txtBox.BackColor = System.Drawing.Color.SlateBlue;
            this.alert_txtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.alert_txtBox.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.alert_txtBox.ForeColor = System.Drawing.Color.Red;
            this.alert_txtBox.Location = new System.Drawing.Point(48, 455);
            this.alert_txtBox.Name = "alert_txtBox";
            this.alert_txtBox.ReadOnly = true;
            this.alert_txtBox.Size = new System.Drawing.Size(407, 20);
            this.alert_txtBox.TabIndex = 15;
            this.alert_txtBox.TabStop = false;
            // 
            // regBtn
            // 
            this.regBtn.AutoSize = true;
            this.regBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.regBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.regBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.regBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.regBtn.ForeColor = System.Drawing.Color.Gray;
            this.regBtn.Location = new System.Drawing.Point(323, 487);
            this.regBtn.Name = "regBtn";
            this.regBtn.Size = new System.Drawing.Size(132, 35);
            this.regBtn.TabIndex = 16;
            this.regBtn.Text = "Đăng ký";
            this.regBtn.UseVisualStyleBackColor = true;
            this.regBtn.Click += new System.EventHandler(this.regBtn_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.BackColor = System.Drawing.Color.SlateBlue;
            this.checkBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox2.ForeColor = System.Drawing.Color.White;
            this.checkBox2.Location = new System.Drawing.Point(140, 425);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(348, 24);
            this.checkBox2.TabIndex = 15;
            this.checkBox2.Text = "Tôi đã đọc và đồng ý với các điều khoản dịch vụ";
            this.checkBox2.UseVisualStyleBackColor = false;
            // 
            // confirmPwd_txtBox
            // 
            this.confirmPwd_txtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.confirmPwd_txtBox.Location = new System.Drawing.Point(161, 311);
            this.confirmPwd_txtBox.Name = "confirmPwd_txtBox";
            this.confirmPwd_txtBox.Size = new System.Drawing.Size(307, 27);
            this.confirmPwd_txtBox.TabIndex = 11;
            this.confirmPwd_txtBox.UseSystemPasswordChar = true;
            this.confirmPwd_txtBox.TextChanged += new System.EventHandler(this.confirmPwd_txtBox_TextChanged);
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.Color.SlateBlue;
            this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox11.ForeColor = System.Drawing.Color.White;
            this.textBox11.Location = new System.Drawing.Point(-52, 311);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(206, 20);
            this.textBox11.TabIndex = 10;
            this.textBox11.TabStop = false;
            this.textBox11.Text = "Xác nhận mật khẩu";
            this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pwd_txtBox
            // 
            this.pwd_txtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pwd_txtBox.Location = new System.Drawing.Point(161, 244);
            this.pwd_txtBox.Name = "pwd_txtBox";
            this.pwd_txtBox.Size = new System.Drawing.Size(307, 27);
            this.pwd_txtBox.TabIndex = 9;
            this.pwd_txtBox.UseSystemPasswordChar = true;
            this.pwd_txtBox.TextChanged += new System.EventHandler(this.pwd_txtBox_TextChanged);
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.SlateBlue;
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox9.ForeColor = System.Drawing.Color.White;
            this.textBox9.Location = new System.Drawing.Point(14, 247);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(141, 20);
            this.textBox9.TabIndex = 8;
            this.textBox9.TabStop = false;
            this.textBox9.Text = "Mật khẩu";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // username_txtBox
            // 
            this.username_txtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.username_txtBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.username_txtBox.Location = new System.Drawing.Point(161, 181);
            this.username_txtBox.Name = "username_txtBox";
            this.username_txtBox.PlaceholderText = "     nguyenvana123";
            this.username_txtBox.Size = new System.Drawing.Size(307, 27);
            this.username_txtBox.TabIndex = 7;
            this.username_txtBox.TextChanged += new System.EventHandler(this.username_txtBox_TextChanged);
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.SlateBlue;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox7.ForeColor = System.Drawing.Color.White;
            this.textBox7.Location = new System.Drawing.Point(14, 181);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(141, 20);
            this.textBox7.TabIndex = 6;
            this.textBox7.TabStop = false;
            this.textBox7.Text = "Tên đăng nhập";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // email_txtBox
            // 
            this.email_txtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.email_txtBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.email_txtBox.Location = new System.Drawing.Point(161, 118);
            this.email_txtBox.Name = "email_txtBox";
            this.email_txtBox.PlaceholderText = "     example@gmail.com";
            this.email_txtBox.Size = new System.Drawing.Size(307, 27);
            this.email_txtBox.TabIndex = 5;
            this.email_txtBox.TextChanged += new System.EventHandler(this.email_txtBox_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.SlateBlue;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox5.ForeColor = System.Drawing.Color.White;
            this.textBox5.Location = new System.Drawing.Point(14, 121);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(141, 20);
            this.textBox5.TabIndex = 4;
            this.textBox5.TabStop = false;
            this.textBox5.Text = "Email";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // firstName_txtBox
            // 
            this.firstName_txtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.firstName_txtBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.firstName_txtBox.Location = new System.Drawing.Point(161, 62);
            this.firstName_txtBox.Name = "firstName_txtBox";
            this.firstName_txtBox.PlaceholderText = "     Nguyễn Văn A";
            this.firstName_txtBox.Size = new System.Drawing.Size(307, 27);
            this.firstName_txtBox.TabIndex = 2;
            this.firstName_txtBox.TextChanged += new System.EventHandler(this.firstName_txtBox_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.SlateBlue;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(14, 65);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(141, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.TabStop = false;
            this.textBox2.Text = "Họ và tên";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(500, 32);
            this.textBox1.TabIndex = 0;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "ĐĂNG KÝ";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RegisterForm
            // 
            this.AcceptButton = this.regBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(501, 554);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TextBox PhoneNumber_txtBox;
        private TextBox ID_txtBox;
        private TextBox alert_txtBox;
        private Button regBtn;
        private CheckBox checkBox2;
        private TextBox confirmPwd_txtBox;
        private TextBox textBox11;
        private TextBox pwd_txtBox;
        private TextBox textBox9;
        private TextBox username_txtBox;
        private TextBox textBox7;
        private TextBox email_txtBox;
        private TextBox textBox5;
        private TextBox firstName_txtBox;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}