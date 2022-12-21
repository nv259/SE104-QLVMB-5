namespace Service
{
    partial class LogoutForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Acpt_Btn = new System.Windows.Forms.Button();
            this.Cncl_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(49, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(312, 24);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Bạn xác nhận muốn đăng xuất?";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Acpt_Btn
            // 
            this.Acpt_Btn.Location = new System.Drawing.Point(49, 108);
            this.Acpt_Btn.Name = "Acpt_Btn";
            this.Acpt_Btn.Size = new System.Drawing.Size(94, 29);
            this.Acpt_Btn.TabIndex = 1;
            this.Acpt_Btn.Text = "Xác nhận";
            this.Acpt_Btn.UseMnemonic = false;
            this.Acpt_Btn.UseVisualStyleBackColor = true;
            this.Acpt_Btn.Click += new System.EventHandler(this.Acpt_Btn_Click);
            // 
            // Cncl_Btn
            // 
            this.Cncl_Btn.Location = new System.Drawing.Point(267, 108);
            this.Cncl_Btn.Name = "Cncl_Btn";
            this.Cncl_Btn.Size = new System.Drawing.Size(94, 29);
            this.Cncl_Btn.TabIndex = 2;
            this.Cncl_Btn.Text = "Hủy";
            this.Cncl_Btn.UseMnemonic = false;
            this.Cncl_Btn.UseVisualStyleBackColor = true;
            this.Cncl_Btn.Click += new System.EventHandler(this.Cncl_Btn_Click);
            // 
            // LogoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 191);
            this.Controls.Add(this.Cncl_Btn);
            this.Controls.Add(this.Acpt_Btn);
            this.Controls.Add(this.textBox1);
            this.Name = "LogoutForm";
            this.Text = "Đăng xuất";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private Button Acpt_Btn;
        private Button Cncl_Btn;
    }
}