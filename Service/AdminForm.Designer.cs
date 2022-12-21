namespace Service
{
    partial class AdminForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MainTab = new System.Windows.Forms.TabControl();
            this.StatementTab = new System.Windows.Forms.TabPage();
            this.findBtn = new System.Windows.Forms.Button();
            this.searchTxtBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.showData_panel = new System.Windows.Forms.Panel();
            this.userName_txtBox = new System.Windows.Forms.TextBox();
            this.email_txtBox = new System.Windows.Forms.TextBox();
            this.phone_txtBox = new System.Windows.Forms.TextBox();
            this.Name_txtBox = new System.Windows.Forms.TextBox();
            this.ID_txtBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Add_btn = new System.Windows.Forms.Button();
            this.userRole_comboBox = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.resetBtn = new System.Windows.Forms.Button();
            this.txtBox4 = new System.Windows.Forms.TextBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.user_dtgv = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.MainTab.SuspendLayout();
            this.StatementTab.SuspendLayout();
            this.panel1.SuspendLayout();
            this.showData_panel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_dtgv)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTab
            // 
            this.MainTab.Controls.Add(this.StatementTab);
            this.MainTab.Controls.Add(this.tabPage1);
            this.MainTab.Location = new System.Drawing.Point(6, 6);
            this.MainTab.Name = "MainTab";
            this.MainTab.SelectedIndex = 0;
            this.MainTab.Size = new System.Drawing.Size(1032, 552);
            this.MainTab.TabIndex = 1;
            // 
            // StatementTab
            // 
            this.StatementTab.Controls.Add(this.findBtn);
            this.StatementTab.Controls.Add(this.searchTxtBox);
            this.StatementTab.Controls.Add(this.panel1);
            this.StatementTab.Location = new System.Drawing.Point(4, 29);
            this.StatementTab.Name = "StatementTab";
            this.StatementTab.Padding = new System.Windows.Forms.Padding(3);
            this.StatementTab.Size = new System.Drawing.Size(1024, 519);
            this.StatementTab.TabIndex = 1;
            this.StatementTab.Text = "Tài khoản";
            this.StatementTab.UseVisualStyleBackColor = true;
            // 
            // findBtn
            // 
            this.findBtn.Location = new System.Drawing.Point(296, 36);
            this.findBtn.Name = "findBtn";
            this.findBtn.Size = new System.Drawing.Size(53, 27);
            this.findBtn.TabIndex = 2;
            this.findBtn.Text = "Tìm kiếm";
            this.findBtn.UseVisualStyleBackColor = true;
            this.findBtn.Click += new System.EventHandler(this.findBtn_Click);
            // 
            // searchTxtBox
            // 
            this.searchTxtBox.Location = new System.Drawing.Point(3, 36);
            this.searchTxtBox.Name = "searchTxtBox";
            this.searchTxtBox.PlaceholderText = "Tìm kiếm theo tên đăng nhập";
            this.searchTxtBox.Size = new System.Drawing.Size(287, 27);
            this.searchTxtBox.TabIndex = 1;
            this.searchTxtBox.TextChanged += new System.EventHandler(this.findBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.showData_panel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.user_dtgv);
            this.panel1.Location = new System.Drawing.Point(0, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 450);
            this.panel1.TabIndex = 0;
            // 
            // showData_panel
            // 
            this.showData_panel.Controls.Add(this.userName_txtBox);
            this.showData_panel.Controls.Add(this.email_txtBox);
            this.showData_panel.Controls.Add(this.phone_txtBox);
            this.showData_panel.Controls.Add(this.Name_txtBox);
            this.showData_panel.Controls.Add(this.ID_txtBox);
            this.showData_panel.Location = new System.Drawing.Point(804, 3);
            this.showData_panel.Name = "showData_panel";
            this.showData_panel.Size = new System.Drawing.Size(219, 277);
            this.showData_panel.TabIndex = 2;
            // 
            // userName_txtBox
            // 
            this.userName_txtBox.BackColor = System.Drawing.Color.LightGray;
            this.userName_txtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userName_txtBox.Location = new System.Drawing.Point(2, 9);
            this.userName_txtBox.Name = "userName_txtBox";
            this.userName_txtBox.Size = new System.Drawing.Size(214, 27);
            this.userName_txtBox.TabIndex = 19;
            // 
            // email_txtBox
            // 
            this.email_txtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.email_txtBox.Location = new System.Drawing.Point(2, 241);
            this.email_txtBox.Name = "email_txtBox";
            this.email_txtBox.ReadOnly = true;
            this.email_txtBox.Size = new System.Drawing.Size(214, 27);
            this.email_txtBox.TabIndex = 18;
            // 
            // phone_txtBox
            // 
            this.phone_txtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phone_txtBox.Location = new System.Drawing.Point(2, 181);
            this.phone_txtBox.Name = "phone_txtBox";
            this.phone_txtBox.ReadOnly = true;
            this.phone_txtBox.Size = new System.Drawing.Size(214, 27);
            this.phone_txtBox.TabIndex = 17;
            // 
            // Name_txtBox
            // 
            this.Name_txtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Name_txtBox.Location = new System.Drawing.Point(2, 121);
            this.Name_txtBox.Name = "Name_txtBox";
            this.Name_txtBox.ReadOnly = true;
            this.Name_txtBox.Size = new System.Drawing.Size(214, 27);
            this.Name_txtBox.TabIndex = 15;
            // 
            // ID_txtBox
            // 
            this.ID_txtBox.BackColor = System.Drawing.SystemColors.Control;
            this.ID_txtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ID_txtBox.Location = new System.Drawing.Point(2, 64);
            this.ID_txtBox.Name = "ID_txtBox";
            this.ID_txtBox.Size = new System.Drawing.Size(214, 27);
            this.ID_txtBox.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Add_btn);
            this.panel2.Controls.Add(this.userRole_comboBox);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.resetBtn);
            this.panel2.Controls.Add(this.txtBox4);
            this.panel2.Controls.Add(this.deleteBtn);
            this.panel2.Controls.Add(this.updateBtn);
            this.panel2.Controls.Add(this.textBox10);
            this.panel2.Controls.Add(this.textBox6);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(606, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(419, 442);
            this.panel2.TabIndex = 1;
            // 
            // Add_btn
            // 
            this.Add_btn.Location = new System.Drawing.Point(196, 344);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(94, 29);
            this.Add_btn.TabIndex = 21;
            this.Add_btn.Text = "Thêm";
            this.Add_btn.UseVisualStyleBackColor = true;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // userRole_comboBox
            // 
            this.userRole_comboBox.FormattingEnabled = true;
            this.userRole_comboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.userRole_comboBox.Location = new System.Drawing.Point(198, 293);
            this.userRole_comboBox.Name = "userRole_comboBox";
            this.userRole_comboBox.Size = new System.Drawing.Size(115, 28);
            this.userRole_comboBox.TabIndex = 20;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.textBox3.Location = new System.Drawing.Point(35, 292);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(70, 23);
            this.textBox3.TabIndex = 19;
            this.textBox3.TabStop = false;
            this.textBox3.Text = "Quyền:";
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(302, 344);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(94, 29);
            this.resetBtn.TabIndex = 13;
            this.resetBtn.Text = "Đặt lại";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // txtBox4
            // 
            this.txtBox4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox4.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.txtBox4.Location = new System.Drawing.Point(35, 3);
            this.txtBox4.Name = "txtBox4";
            this.txtBox4.ReadOnly = true;
            this.txtBox4.Size = new System.Drawing.Size(157, 23);
            this.txtBox4.TabIndex = 12;
            this.txtBox4.TabStop = false;
            this.txtBox4.Text = "Tên đăng nhập:";
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(196, 379);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(94, 29);
            this.deleteBtn.TabIndex = 4;
            this.deleteBtn.Text = "Xóa";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(302, 379);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(94, 29);
            this.updateBtn.TabIndex = 3;
            this.updateBtn.Text = "Cập nhật";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox10.Location = new System.Drawing.Point(35, 233);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(66, 23);
            this.textBox10.TabIndex = 8;
            this.textBox10.TabStop = false;
            this.textBox10.Text = "Email:";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox6.Location = new System.Drawing.Point(35, 173);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(123, 23);
            this.textBox6.TabIndex = 6;
            this.textBox6.TabStop = false;
            this.textBox6.Text = "Số điện thoại:";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox4.Location = new System.Drawing.Point(35, 115);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(91, 23);
            this.textBox4.TabIndex = 2;
            this.textBox4.TabStop = false;
            this.textBox4.Text = "Họ và tên:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(35, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(157, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Định danh / CCCD:";
            // 
            // user_dtgv
            // 
            this.user_dtgv.AllowUserToAddRows = false;
            this.user_dtgv.AllowUserToDeleteRows = false;
            this.user_dtgv.AllowUserToOrderColumns = true;
            this.user_dtgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.user_dtgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.user_dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.user_dtgv.Location = new System.Drawing.Point(3, 9);
            this.user_dtgv.Name = "user_dtgv";
            this.user_dtgv.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.user_dtgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.user_dtgv.RowHeadersWidth = 51;
            this.user_dtgv.RowTemplate.Height = 29;
            this.user_dtgv.Size = new System.Drawing.Size(588, 441);
            this.user_dtgv.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1024, 519);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Đăng xuất";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 564);
            this.Controls.Add(this.MainTab);
            this.Name = "AdminForm";
            this.Text = "Admin";
            this.MainTab.ResumeLayout(false);
            this.StatementTab.ResumeLayout(false);
            this.StatementTab.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.showData_panel.ResumeLayout(false);
            this.showData_panel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_dtgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl MainTab;
        private TabPage StatementTab;
        private Button findBtn;
        private TextBox searchTxtBox;
        private Panel panel1;
        private Panel showData_panel;
        private TextBox userName_txtBox;
        private TextBox email_txtBox;
        private TextBox phone_txtBox;
        private TextBox Name_txtBox;
        private TextBox ID_txtBox;
        private Panel panel2;
        private Button resetBtn;
        private TextBox txtBox4;
        private Button deleteBtn;
        private Button updateBtn;
        private TextBox textBox10;
        private TextBox textBox6;
        private TextBox textBox4;
        private TextBox textBox1;
        private DataGridView user_dtgv;
        private TextBox textBox3;
        private ComboBox userRole_comboBox;
        private Button Add_btn;
        private TabPage tabPage1;
    }
}