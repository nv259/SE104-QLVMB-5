namespace Service
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.Username_txtBox = new System.Windows.Forms.TextBox();
            this.PasswordtxtBox = new System.Windows.Forms.TextBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.rmb_txtBox = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.langBox = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Username_txtBox
            // 
            this.Username_txtBox.Location = new System.Drawing.Point(12, 53);
            this.Username_txtBox.MaxLength = 255;
            this.Username_txtBox.Name = "Username_txtBox";
            this.Username_txtBox.PlaceholderText = "  username";
            this.Username_txtBox.Size = new System.Drawing.Size(427, 27);
            this.Username_txtBox.TabIndex = 0;
            // 
            // PasswordtxtBox
            // 
            this.PasswordtxtBox.Location = new System.Drawing.Point(12, 110);
            this.PasswordtxtBox.MaxLength = 255;
            this.PasswordtxtBox.Name = "PasswordtxtBox";
            this.PasswordtxtBox.PlaceholderText = "  password";
            this.PasswordtxtBox.Size = new System.Drawing.Size(427, 27);
            this.PasswordtxtBox.TabIndex = 1;
            this.PasswordtxtBox.UseSystemPasswordChar = true;
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.White;
            this.LoginBtn.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginBtn.ForeColor = System.Drawing.Color.RoyalBlue;
            this.LoginBtn.Location = new System.Drawing.Point(12, 203);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(427, 63);
            this.LoginBtn.TabIndex = 2;
            this.LoginBtn.Text = "Đăng Nhập";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterBtn.ForeColor = System.Drawing.Color.RoyalBlue;
            this.RegisterBtn.Location = new System.Drawing.Point(12, 272);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(427, 30);
            this.RegisterBtn.TabIndex = 3;
            this.RegisterBtn.Text = "Đăng Ký";
            this.RegisterBtn.UseVisualStyleBackColor = true;
            this.RegisterBtn.Click += new System.EventHandler(this.regBtn_click);
            // 
            // rmb_txtBox
            // 
            this.rmb_txtBox.AutoSize = true;
            this.rmb_txtBox.BackColor = System.Drawing.Color.Transparent;
            this.rmb_txtBox.BackgroundImage = global::Service.Properties.Resources.login_background_1;
            this.rmb_txtBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rmb_txtBox.ForeColor = System.Drawing.Color.RoyalBlue;
            this.rmb_txtBox.Location = new System.Drawing.Point(12, 160);
            this.rmb_txtBox.Name = "rmb_txtBox";
            this.rmb_txtBox.Size = new System.Drawing.Size(82, 24);
            this.rmb_txtBox.TabIndex = 4;
            this.rmb_txtBox.Text = "Ghi nhớ";
            this.rmb_txtBox.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(12, 321);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(110, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = " Quên mật khẩu?";
            // 
            // langBox
            // 
            this.langBox.AccessibleDescription = "Language ?";
            this.langBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.langBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.langBox.BackColor = System.Drawing.Color.White;
            this.langBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.langBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.langBox.ForeColor = System.Drawing.Color.Black;
            this.langBox.FormattingEnabled = true;
            this.langBox.Items.AddRange(new object[] {
            "Vietnamese",
            "English",
            "Spanish"});
            this.langBox.Location = new System.Drawing.Point(288, 313);
            this.langBox.Name = "langBox";
            this.langBox.Size = new System.Drawing.Size(151, 28);
            this.langBox.TabIndex = 11;
            this.langBox.Text = "Việt Nam";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Service.Properties.Resources.login_background_1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::Service.Properties.Resources.login_background_1;
            this.pictureBox1.Location = new System.Drawing.Point(-6, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(669, 378);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.LoginBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(658, 373);
            this.Controls.Add(this.langBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rmb_txtBox);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.PasswordtxtBox);
            this.Controls.Add(this.Username_txtBox);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Username_txtBox;
        private TextBox PasswordtxtBox;
        private Button LoginBtn;
        private Button RegisterBtn;
        private CheckBox rmb_txtBox;
        private TextBox textBox1;
        private ComboBox langBox;
        private PictureBox pictureBox1;
        private string path = @".\pwd.txt";
    }
}