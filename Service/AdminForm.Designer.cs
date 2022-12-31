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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.Add_btn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.userRole_comboBox = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtBox4 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.user_dtgv = new System.Windows.Forms.DataGridView();
            this.MainTab = new System.Windows.Forms.TabControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.publicAnnoucementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatementTab.SuspendLayout();
            this.panel1.SuspendLayout();
            this.showData_panel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_dtgv)).BeginInit();
            this.MainTab.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatementTab
            // 
            this.StatementTab.BackColor = System.Drawing.Color.White;
            this.StatementTab.Controls.Add(this.findBtn);
            this.StatementTab.Controls.Add(this.searchTxtBox);
            this.StatementTab.Controls.Add(this.panel1);
            this.StatementTab.Location = new System.Drawing.Point(4, 29);
            this.StatementTab.Name = "StatementTab";
            this.StatementTab.Padding = new System.Windows.Forms.Padding(3);
            this.StatementTab.Size = new System.Drawing.Size(1024, 519);
            this.StatementTab.TabIndex = 1;
            this.StatementTab.Text = "Tài khoản";
            // 
            // findBtn
            // 
            this.findBtn.Location = new System.Drawing.Point(282, 36);
            this.findBtn.Name = "findBtn";
            this.findBtn.Size = new System.Drawing.Size(53, 27);
            this.findBtn.TabIndex = 2;
            this.findBtn.Text = "Tìm kiếm";
            this.findBtn.UseVisualStyleBackColor = true;
            this.findBtn.Click += new System.EventHandler(this.findBtn_Click);
            // 
            // searchTxtBox
            // 
            this.searchTxtBox.Location = new System.Drawing.Point(6, 36);
            this.searchTxtBox.Name = "searchTxtBox";
            this.searchTxtBox.PlaceholderText = "Tìm kiếm theo tên đăng nhập";
            this.searchTxtBox.Size = new System.Drawing.Size(270, 27);
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
            this.showData_panel.Location = new System.Drawing.Point(799, -5);
            this.showData_panel.Name = "showData_panel";
            this.showData_panel.Size = new System.Drawing.Size(212, 285);
            this.showData_panel.TabIndex = 2;
            // 
            // userName_txtBox
            // 
            this.userName_txtBox.BackColor = System.Drawing.Color.White;
            this.userName_txtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userName_txtBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.userName_txtBox.Location = new System.Drawing.Point(0, 6);
            this.userName_txtBox.Name = "userName_txtBox";
            this.userName_txtBox.ReadOnly = true;
            this.userName_txtBox.Size = new System.Drawing.Size(209, 30);
            this.userName_txtBox.TabIndex = 19;
            // 
            // email_txtBox
            // 
            this.email_txtBox.BackColor = System.Drawing.Color.White;
            this.email_txtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.email_txtBox.Location = new System.Drawing.Point(2, 241);
            this.email_txtBox.Name = "email_txtBox";
            this.email_txtBox.ReadOnly = true;
            this.email_txtBox.Size = new System.Drawing.Size(209, 27);
            this.email_txtBox.TabIndex = 18;
            // 
            // phone_txtBox
            // 
            this.phone_txtBox.BackColor = System.Drawing.Color.White;
            this.phone_txtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phone_txtBox.Location = new System.Drawing.Point(2, 181);
            this.phone_txtBox.Name = "phone_txtBox";
            this.phone_txtBox.ReadOnly = true;
            this.phone_txtBox.Size = new System.Drawing.Size(209, 27);
            this.phone_txtBox.TabIndex = 17;
            // 
            // Name_txtBox
            // 
            this.Name_txtBox.BackColor = System.Drawing.Color.White;
            this.Name_txtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Name_txtBox.Location = new System.Drawing.Point(2, 121);
            this.Name_txtBox.Name = "Name_txtBox";
            this.Name_txtBox.ReadOnly = true;
            this.Name_txtBox.Size = new System.Drawing.Size(209, 27);
            this.Name_txtBox.TabIndex = 15;
            // 
            // ID_txtBox
            // 
            this.ID_txtBox.BackColor = System.Drawing.Color.White;
            this.ID_txtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ID_txtBox.Location = new System.Drawing.Point(2, 64);
            this.ID_txtBox.Name = "ID_txtBox";
            this.ID_txtBox.ReadOnly = true;
            this.ID_txtBox.Size = new System.Drawing.Size(209, 27);
            this.ID_txtBox.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.userRole_comboBox);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.txtBox4);
            this.panel2.Controls.Add(this.textBox10);
            this.panel2.Controls.Add(this.textBox6);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(661, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(357, 438);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.Add_btn);
            this.panel3.Controls.Add(this.resetBtn);
            this.panel3.Controls.Add(this.deleteBtn);
            this.panel3.Controls.Add(this.updateBtn);
            this.panel3.Location = new System.Drawing.Point(133, 359);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(223, 78);
            this.panel3.TabIndex = 22;
            // 
            // Add_btn
            // 
            this.Add_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            this.Add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Add_btn.Location = new System.Drawing.Point(4, 6);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(106, 29);
            this.Add_btn.TabIndex = 21;
            this.Add_btn.Text = "Thêm";
            this.Add_btn.UseVisualStyleBackColor = false;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            this.resetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetBtn.ForeColor = System.Drawing.Color.White;
            this.resetBtn.Location = new System.Drawing.Point(116, 6);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(101, 29);
            this.resetBtn.TabIndex = 13;
            this.resetBtn.Text = "Đặt lại";
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Location = new System.Drawing.Point(4, 41);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(106, 29);
            this.deleteBtn.TabIndex = 4;
            this.deleteBtn.Text = "Xóa";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.ForeColor = System.Drawing.Color.White;
            this.updateBtn.Location = new System.Drawing.Point(116, 41);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(101, 29);
            this.updateBtn.TabIndex = 3;
            this.updateBtn.Text = "Cập nhật";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // userRole_comboBox
            // 
            this.userRole_comboBox.FormattingEnabled = true;
            this.userRole_comboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.userRole_comboBox.Location = new System.Drawing.Point(140, 281);
            this.userRole_comboBox.Name = "userRole_comboBox";
            this.userRole_comboBox.Size = new System.Drawing.Size(115, 28);
            this.userRole_comboBox.TabIndex = 20;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            this.textBox3.Location = new System.Drawing.Point(61, 281);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(70, 23);
            this.textBox3.TabIndex = 19;
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
            this.txtBox4.Location = new System.Drawing.Point(-24, -1);
            this.txtBox4.Name = "txtBox4";
            this.txtBox4.ReadOnly = true;
            this.txtBox4.Size = new System.Drawing.Size(157, 23);
            this.txtBox4.TabIndex = 12;
            this.txtBox4.TabStop = false;
            this.txtBox4.Text = "Tên đăng nhập:";
            this.txtBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.Color.White;
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            this.textBox10.Location = new System.Drawing.Point(65, 232);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(66, 23);
            this.textBox10.TabIndex = 8;
            this.textBox10.TabStop = false;
            this.textBox10.Text = "Email:";
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.White;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            this.textBox6.Location = new System.Drawing.Point(10, 172);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(123, 23);
            this.textBox6.TabIndex = 6;
            this.textBox6.TabStop = false;
            this.textBox6.Text = "Số điện thoại:";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.White;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            this.textBox4.Location = new System.Drawing.Point(41, 112);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(91, 23);
            this.textBox4.TabIndex = 2;
            this.textBox4.TabStop = false;
            this.textBox4.Text = "Họ và tên:";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            this.textBox1.Location = new System.Drawing.Point(-24, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(157, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Mã định danh:";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // user_dtgv
            // 
            this.user_dtgv.AllowUserToAddRows = false;
            this.user_dtgv.AllowUserToDeleteRows = false;
            this.user_dtgv.AllowUserToOrderColumns = true;
            this.user_dtgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.user_dtgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.user_dtgv.BackgroundColor = System.Drawing.Color.White;
            this.user_dtgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.user_dtgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.user_dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.user_dtgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.user_dtgv.Location = new System.Drawing.Point(6, 3);
            this.user_dtgv.Name = "user_dtgv";
            this.user_dtgv.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.user_dtgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.user_dtgv.RowHeadersVisible = false;
            this.user_dtgv.RowHeadersWidth = 55;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.user_dtgv.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.user_dtgv.RowTemplate.Height = 29;
            this.user_dtgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.user_dtgv.Size = new System.Drawing.Size(649, 438);
            this.user_dtgv.TabIndex = 0;
            // 
            // MainTab
            // 
            this.MainTab.Controls.Add(this.StatementTab);
            this.MainTab.Location = new System.Drawing.Point(6, 6);
            this.MainTab.Name = "MainTab";
            this.MainTab.SelectedIndex = 0;
            this.MainTab.Size = new System.Drawing.Size(1032, 552);
            this.MainTab.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.publicAnnoucementToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1044, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // publicAnnoucementToolStripMenuItem
            // 
            this.publicAnnoucementToolStripMenuItem.Name = "publicAnnoucementToolStripMenuItem";
            this.publicAnnoucementToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.publicAnnoucementToolStripMenuItem.Text = "Public Annoucement";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1044, 564);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.MainTab);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.StatementTab.ResumeLayout(false);
            this.StatementTab.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.showData_panel.ResumeLayout(false);
            this.showData_panel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.user_dtgv)).EndInit();
            this.MainTab.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private Panel panel3;
        private Button Add_btn;
        private Button resetBtn;
        private Button deleteBtn;
        private Button updateBtn;
        private ComboBox userRole_comboBox;
        private TextBox textBox3;
        private TextBox txtBox4;
        private TextBox textBox10;
        private TextBox textBox6;
        private TextBox textBox4;
        private TextBox textBox1;
        private DataGridView user_dtgv;
        private TabControl MainTab;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem publicAnnoucementToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}