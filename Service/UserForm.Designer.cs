namespace Service
{
    partial class UserForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.publicAnnoucementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelTicketBtn = new System.Windows.Forms.Button();
            this.changeInfoBtn = new System.Windows.Forms.Button();
            this.buyTicketBtn = new System.Windows.Forms.Button();
            this.danhSachVeLstBox = new System.Windows.Forms.ListBox();
            this.userInfo_pnl = new System.Windows.Forms.Panel();
            this.phoneNumber_txtBox = new System.Windows.Forms.TextBox();
            this.ID_txtBox = new System.Windows.Forms.TextBox();
            this.email_txtBox = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.userName_txtBox = new System.Windows.Forms.TextBox();
            this.fullName_txtBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.userInfo_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(252)))), ((int)(((byte)(254)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.staffToolStripMenuItem,
            this.publicAnnoucementToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(917, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // staffToolStripMenuItem
            // 
            this.staffToolStripMenuItem.Name = "staffToolStripMenuItem";
            this.staffToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.staffToolStripMenuItem.Text = "Staff";
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
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // cancelTicketBtn
            // 
            this.cancelTicketBtn.Location = new System.Drawing.Point(134, 395);
            this.cancelTicketBtn.Name = "cancelTicketBtn";
            this.cancelTicketBtn.Size = new System.Drawing.Size(111, 33);
            this.cancelTicketBtn.TabIndex = 5;
            this.cancelTicketBtn.Text = "Hủy vé";
            this.cancelTicketBtn.UseVisualStyleBackColor = true;
            // 
            // changeInfoBtn
            // 
            this.changeInfoBtn.Location = new System.Drawing.Point(589, 329);
            this.changeInfoBtn.Name = "changeInfoBtn";
            this.changeInfoBtn.Size = new System.Drawing.Size(99, 27);
            this.changeInfoBtn.TabIndex = 6;
            this.changeInfoBtn.Text = "Chỉnh sửa";
            this.changeInfoBtn.UseVisualStyleBackColor = true;
            // 
            // buyTicketBtn
            // 
            this.buyTicketBtn.Location = new System.Drawing.Point(524, 366);
            this.buyTicketBtn.Name = "buyTicketBtn";
            this.buyTicketBtn.Size = new System.Drawing.Size(241, 62);
            this.buyTicketBtn.TabIndex = 7;
            this.buyTicketBtn.Text = "Đặt vé";
            this.buyTicketBtn.UseVisualStyleBackColor = true;
            // 
            // danhSachVeLstBox
            // 
            this.danhSachVeLstBox.FormattingEnabled = true;
            this.danhSachVeLstBox.ItemHeight = 20;
            this.danhSachVeLstBox.Location = new System.Drawing.Point(-9, 63);
            this.danhSachVeLstBox.Name = "danhSachVeLstBox";
            this.danhSachVeLstBox.Size = new System.Drawing.Size(358, 284);
            this.danhSachVeLstBox.TabIndex = 8;
            // 
            // userInfo_pnl
            // 
            this.userInfo_pnl.BackColor = System.Drawing.Color.PaleTurquoise;
            this.userInfo_pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userInfo_pnl.Controls.Add(this.phoneNumber_txtBox);
            this.userInfo_pnl.Controls.Add(this.ID_txtBox);
            this.userInfo_pnl.Controls.Add(this.email_txtBox);
            this.userInfo_pnl.Controls.Add(this.textBox4);
            this.userInfo_pnl.Controls.Add(this.userName_txtBox);
            this.userInfo_pnl.Controls.Add(this.fullName_txtBox);
            this.userInfo_pnl.Controls.Add(this.textBox1);
            this.userInfo_pnl.Location = new System.Drawing.Point(459, 63);
            this.userInfo_pnl.Name = "userInfo_pnl";
            this.userInfo_pnl.Size = new System.Drawing.Size(446, 181);
            this.userInfo_pnl.TabIndex = 9;
            // 
            // phoneNumber_txtBox
            // 
            this.phoneNumber_txtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.phoneNumber_txtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phoneNumber_txtBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.phoneNumber_txtBox.Location = new System.Drawing.Point(258, 138);
            this.phoneNumber_txtBox.Name = "phoneNumber_txtBox";
            this.phoneNumber_txtBox.ReadOnly = true;
            this.phoneNumber_txtBox.Size = new System.Drawing.Size(183, 27);
            this.phoneNumber_txtBox.TabIndex = 8;
            this.phoneNumber_txtBox.TabStop = false;
            // 
            // ID_txtBox
            // 
            this.ID_txtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.ID_txtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ID_txtBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ID_txtBox.Location = new System.Drawing.Point(131, 138);
            this.ID_txtBox.Name = "ID_txtBox";
            this.ID_txtBox.ReadOnly = true;
            this.ID_txtBox.Size = new System.Drawing.Size(121, 27);
            this.ID_txtBox.TabIndex = 7;
            this.ID_txtBox.TabStop = false;
            // 
            // email_txtBox
            // 
            this.email_txtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.email_txtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.email_txtBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.email_txtBox.Location = new System.Drawing.Point(131, 94);
            this.email_txtBox.Name = "email_txtBox";
            this.email_txtBox.ReadOnly = true;
            this.email_txtBox.Size = new System.Drawing.Size(310, 27);
            this.email_txtBox.TabIndex = 5;
            this.email_txtBox.TabStop = false;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.PaleTurquoise;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox4.Location = new System.Drawing.Point(73, 96);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(52, 20);
            this.textBox4.TabIndex = 4;
            this.textBox4.TabStop = false;
            this.textBox4.Text = "Email";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // userName_txtBox
            // 
            this.userName_txtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.userName_txtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.userName_txtBox.Location = new System.Drawing.Point(-1, -1);
            this.userName_txtBox.Multiline = true;
            this.userName_txtBox.Name = "userName_txtBox";
            this.userName_txtBox.PlaceholderText = "display_name";
            this.userName_txtBox.ReadOnly = true;
            this.userName_txtBox.Size = new System.Drawing.Size(446, 36);
            this.userName_txtBox.TabIndex = 2;
            this.userName_txtBox.TabStop = false;
            this.userName_txtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fullName_txtBox
            // 
            this.fullName_txtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.fullName_txtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fullName_txtBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fullName_txtBox.ForeColor = System.Drawing.Color.White;
            this.fullName_txtBox.Location = new System.Drawing.Point(131, 51);
            this.fullName_txtBox.Name = "fullName_txtBox";
            this.fullName_txtBox.ReadOnly = true;
            this.fullName_txtBox.Size = new System.Drawing.Size(310, 27);
            this.fullName_txtBox.TabIndex = 3;
            this.fullName_txtBox.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(73, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(52, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Name";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(917, 516);
            this.Controls.Add(this.userInfo_pnl);
            this.Controls.Add(this.danhSachVeLstBox);
            this.Controls.Add(this.buyTicketBtn);
            this.Controls.Add(this.changeInfoBtn);
            this.Controls.Add(this.cancelTicketBtn);
            this.Controls.Add(this.menuStrip1);
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.userInfo_pnl.ResumeLayout(false);
            this.userInfo_pnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem adminToolStripMenuItem;
        private ToolStripMenuItem staffToolStripMenuItem;
        private ToolStripMenuItem publicAnnoucementToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Button cancelTicketBtn;
        private Button changeInfoBtn;
        private Button buyTicketBtn;
        private ListBox danhSachVeLstBox;
        private Panel userInfo_pnl;
        private TextBox phoneNumber_txtBox;
        private TextBox ID_txtBox;
        private TextBox email_txtBox;
        private TextBox textBox4;
        private TextBox userName_txtBox;
        private TextBox fullName_txtBox;
        private TextBox textBox1;
    }
}