namespace Service
{
    partial class AddUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUserForm));
            this.username_txtBox = new System.Windows.Forms.TextBox();
            this.userRole_comboBox = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtBox4 = new System.Windows.Forms.TextBox();
            this.Add_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // username_txtBox
            // 
            this.username_txtBox.BackColor = System.Drawing.Color.White;
            this.username_txtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.username_txtBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.username_txtBox.Location = new System.Drawing.Point(12, 41);
            this.username_txtBox.Name = "username_txtBox";
            this.username_txtBox.Size = new System.Drawing.Size(209, 30);
            this.username_txtBox.TabIndex = 22;
            // 
            // userRole_comboBox
            // 
            this.userRole_comboBox.FormattingEnabled = true;
            this.userRole_comboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.userRole_comboBox.Location = new System.Drawing.Point(271, 41);
            this.userRole_comboBox.Name = "userRole_comboBox";
            this.userRole_comboBox.Size = new System.Drawing.Size(105, 28);
            this.userRole_comboBox.TabIndex = 24;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            this.textBox3.Location = new System.Drawing.Point(271, 12);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(57, 23);
            this.textBox3.TabIndex = 23;
            this.textBox3.TabStop = false;
            this.textBox3.Text = "Quyền:";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBox4
            // 
            this.txtBox4.BackColor = System.Drawing.Color.White;
            this.txtBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            this.txtBox4.Location = new System.Drawing.Point(12, 12);
            this.txtBox4.Name = "txtBox4";
            this.txtBox4.ReadOnly = true;
            this.txtBox4.Size = new System.Drawing.Size(126, 23);
            this.txtBox4.TabIndex = 21;
            this.txtBox4.TabStop = false;
            this.txtBox4.Text = "Tên đăng nhập:";
            this.txtBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Add_btn
            // 
            this.Add_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            this.Add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Add_btn.Location = new System.Drawing.Point(270, 82);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(106, 29);
            this.Add_btn.TabIndex = 25;
            this.Add_btn.Text = "Thêm";
            this.Add_btn.UseVisualStyleBackColor = false;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(393, 123);
            this.Controls.Add(this.Add_btn);
            this.Controls.Add(this.username_txtBox);
            this.Controls.Add(this.userRole_comboBox);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtBox4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddUserForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm người dùng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox userName_txtBox;
        private ComboBox userRole_comboBox;
        private TextBox textBox3;
        private TextBox txtBox4;
        private Button Add_btn;
        private TextBox username_txtBox;
    }
}