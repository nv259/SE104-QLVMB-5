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
            this.Password_txtBox = new System.Windows.Forms.TextBox();
            this.Login_Btn = new System.Windows.Forms.Button();
            this.Register_Btn = new System.Windows.Forms.Button();
            this.rmb_chkBox = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ForgetPassword_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Username_txtBox
            // 
            this.Username_txtBox.Location = new System.Drawing.Point(105, 49);
            this.Username_txtBox.MaxLength = 255;
            this.Username_txtBox.Name = "Username_txtBox";
            this.Username_txtBox.PlaceholderText = "  username";
            this.Username_txtBox.Size = new System.Drawing.Size(427, 27);
            this.Username_txtBox.TabIndex = 0;
            // 
            // Password_txtBox
            // 
            this.Password_txtBox.Location = new System.Drawing.Point(105, 99);
            this.Password_txtBox.MaxLength = 255;
            this.Password_txtBox.Name = "Password_txtBox";
            this.Password_txtBox.PlaceholderText = "  password";
            this.Password_txtBox.Size = new System.Drawing.Size(427, 27);
            this.Password_txtBox.TabIndex = 1;
            this.Password_txtBox.UseSystemPasswordChar = true;
            // 
            // Login_Btn
            // 
            this.Login_Btn.BackColor = System.Drawing.Color.White;
            this.Login_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login_Btn.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.Login_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_Btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Login_Btn.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Login_Btn.Location = new System.Drawing.Point(105, 186);
            this.Login_Btn.Name = "Login_Btn";
            this.Login_Btn.Size = new System.Drawing.Size(427, 63);
            this.Login_Btn.TabIndex = 2;
            this.Login_Btn.Text = "Đăng Nhập";
            this.Login_Btn.UseVisualStyleBackColor = false;
            this.Login_Btn.Click += new System.EventHandler(this.login_Btn_Click);
            // 
            // Register_Btn
            // 
            this.Register_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Register_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Register_Btn.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Register_Btn.Location = new System.Drawing.Point(105, 272);
            this.Register_Btn.Name = "Register_Btn";
            this.Register_Btn.Size = new System.Drawing.Size(427, 30);
            this.Register_Btn.TabIndex = 3;
            this.Register_Btn.Text = "Đăng Ký";
            this.Register_Btn.UseVisualStyleBackColor = true;
            this.Register_Btn.Click += new System.EventHandler(this.Register_Btn_Click);
            // 
            // rmb_chkBox
            // 
            this.rmb_chkBox.AutoSize = true;
            this.rmb_chkBox.BackColor = System.Drawing.Color.Transparent;
            this.rmb_chkBox.BackgroundImage = global::Service.Properties.Resources.login_background_1;
            this.rmb_chkBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rmb_chkBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rmb_chkBox.ForeColor = System.Drawing.Color.RoyalBlue;
            this.rmb_chkBox.Location = new System.Drawing.Point(105, 142);
            this.rmb_chkBox.Name = "rmb_chkBox";
            this.rmb_chkBox.Size = new System.Drawing.Size(82, 24);
            this.rmb_chkBox.TabIndex = 4;
            this.rmb_chkBox.Text = "Ghi nhớ";
            this.rmb_chkBox.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Service.Properties.Resources.login_background_1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::Service.Properties.Resources.login_background_1;
            this.pictureBox1.Location = new System.Drawing.Point(-6, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(667, 378);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // ForgetPassword_label
            // 
            this.ForgetPassword_label.AutoSize = true;
            this.ForgetPassword_label.BackColor = System.Drawing.Color.Transparent;
            this.ForgetPassword_label.Location = new System.Drawing.Point(136, 344);
            this.ForgetPassword_label.Name = "ForgetPassword_label";
            this.ForgetPassword_label.Size = new System.Drawing.Size(362, 20);
            this.ForgetPassword_label.TabIndex = 15;
            this.ForgetPassword_label.Text = "Nếu quên mật khẩu, liên hệ với admin để được hỗ trợ";
            // 
            // LoginForm
            // 
            this.AcceptButton = this.Login_Btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(658, 373);
            this.Controls.Add(this.ForgetPassword_label);
            this.Controls.Add(this.rmb_chkBox);
            this.Controls.Add(this.Register_Btn);
            this.Controls.Add(this.Login_Btn);
            this.Controls.Add(this.Password_txtBox);
            this.Controls.Add(this.Username_txtBox);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Username_txtBox;
        private TextBox Password_txtBox;
        private Button Login_Btn;
        private Button Register_Btn;
        private CheckBox rmb_chkBox;
        private PictureBox pictureBox1;
        private Label ForgetPassword_label;
    }
}