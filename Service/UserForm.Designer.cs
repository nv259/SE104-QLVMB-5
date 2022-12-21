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
            this.publicAnnoucementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelTicketBtn = new System.Windows.Forms.Button();
            this.buyTicketBtn = new System.Windows.Forms.Button();
            this.userInfo_pnl = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.phoneNumber_txtBox = new System.Windows.Forms.TextBox();
            this.ID_txtBox = new System.Windows.Forms.TextBox();
            this.email_txtBox = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.userName_txtBox = new System.Windows.Forms.TextBox();
            this.fullName_txtBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ticketBoughtDgv = new System.Windows.Forms.DataGridView();
            this.flightDgv = new System.Windows.Forms.DataGridView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.userInfo_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBoughtDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(252)))), ((int)(((byte)(254)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.publicAnnoucementToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1340, 28);
            this.menuStrip1.TabIndex = 0;
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
            // cancelTicketBtn
            // 
            this.cancelTicketBtn.BackColor = System.Drawing.Color.Red;
            this.cancelTicketBtn.Location = new System.Drawing.Point(989, 603);
            this.cancelTicketBtn.Name = "cancelTicketBtn";
            this.cancelTicketBtn.Size = new System.Drawing.Size(134, 49);
            this.cancelTicketBtn.TabIndex = 5;
            this.cancelTicketBtn.Text = "Hủy vé";
            this.cancelTicketBtn.UseVisualStyleBackColor = false;
            // 
            // buyTicketBtn
            // 
            this.buyTicketBtn.BackColor = System.Drawing.Color.SpringGreen;
            this.buyTicketBtn.Location = new System.Drawing.Point(253, 603);
            this.buyTicketBtn.Name = "buyTicketBtn";
            this.buyTicketBtn.Size = new System.Drawing.Size(241, 62);
            this.buyTicketBtn.TabIndex = 7;
            this.buyTicketBtn.Text = "Đặt vé";
            this.buyTicketBtn.UseVisualStyleBackColor = false;
            // 
            // userInfo_pnl
            // 
            this.userInfo_pnl.BackColor = System.Drawing.Color.PaleTurquoise;
            this.userInfo_pnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.userInfo_pnl.Controls.Add(this.pictureBox1);
            this.userInfo_pnl.Controls.Add(this.phoneNumber_txtBox);
            this.userInfo_pnl.Controls.Add(this.ID_txtBox);
            this.userInfo_pnl.Controls.Add(this.email_txtBox);
            this.userInfo_pnl.Controls.Add(this.textBox4);
            this.userInfo_pnl.Controls.Add(this.userName_txtBox);
            this.userInfo_pnl.Controls.Add(this.fullName_txtBox);
            this.userInfo_pnl.Controls.Add(this.textBox1);
            this.userInfo_pnl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userInfo_pnl.Location = new System.Drawing.Point(610, 56);
            this.userInfo_pnl.Name = "userInfo_pnl";
            this.userInfo_pnl.Size = new System.Drawing.Size(477, 181);
            this.userInfo_pnl.TabIndex = 9;
            this.userInfo_pnl.Click += new System.EventHandler(this.userInfo_pnl_Paint_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Service.Properties.Resources.user;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(17, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 87);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.userInfo_pnl_Paint_1);
            // 
            // phoneNumber_txtBox
            // 
            this.phoneNumber_txtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.phoneNumber_txtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phoneNumber_txtBox.Enabled = false;
            this.phoneNumber_txtBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.phoneNumber_txtBox.Location = new System.Drawing.Point(287, 139);
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
            this.ID_txtBox.Enabled = false;
            this.ID_txtBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ID_txtBox.Location = new System.Drawing.Point(160, 139);
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
            this.email_txtBox.Enabled = false;
            this.email_txtBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.email_txtBox.Location = new System.Drawing.Point(160, 95);
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
            this.textBox4.Location = new System.Drawing.Point(102, 97);
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
            this.userName_txtBox.Enabled = false;
            this.userName_txtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.userName_txtBox.Location = new System.Drawing.Point(-1, -1);
            this.userName_txtBox.Multiline = true;
            this.userName_txtBox.Name = "userName_txtBox";
            this.userName_txtBox.PlaceholderText = "display_name";
            this.userName_txtBox.ReadOnly = true;
            this.userName_txtBox.Size = new System.Drawing.Size(475, 36);
            this.userName_txtBox.TabIndex = 2;
            this.userName_txtBox.TabStop = false;
            this.userName_txtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fullName_txtBox
            // 
            this.fullName_txtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.fullName_txtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fullName_txtBox.Enabled = false;
            this.fullName_txtBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fullName_txtBox.ForeColor = System.Drawing.Color.White;
            this.fullName_txtBox.Location = new System.Drawing.Point(160, 52);
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
            this.textBox1.Location = new System.Drawing.Point(102, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(52, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Name";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ticketBoughtDgv
            // 
            this.ticketBoughtDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ticketBoughtDgv.Location = new System.Drawing.Point(610, 262);
            this.ticketBoughtDgv.Name = "ticketBoughtDgv";
            this.ticketBoughtDgv.RowHeadersWidth = 51;
            this.ticketBoughtDgv.RowTemplate.Height = 29;
            this.ticketBoughtDgv.Size = new System.Drawing.Size(477, 308);
            this.ticketBoughtDgv.TabIndex = 10;
            this.ticketBoughtDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ticketBoughtDgv_CellContentClick);
            // 
            // flightDgv
            // 
            this.flightDgv.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.flightDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.flightDgv.Location = new System.Drawing.Point(25, 90);
            this.flightDgv.Name = "flightDgv";
            this.flightDgv.RowHeadersWidth = 51;
            this.flightDgv.RowTemplate.Height = 29;
            this.flightDgv.Size = new System.Drawing.Size(747, 501);
            this.flightDgv.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(25, 56);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(747, 36);
            this.textBox2.TabIndex = 10;
            this.textBox2.TabStop = false;
            this.textBox2.Text = "Danh sách chuyến bay";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox3.Location = new System.Drawing.Point(812, 282);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(471, 36);
            this.textBox3.TabIndex = 12;
            this.textBox3.TabStop = false;
            this.textBox3.Text = "Danh sách vé đã đặt";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1099, 689);
            this.Controls.Add(this.flightDgv);
            this.Controls.Add(this.ticketBoughtDgv);
            this.Controls.Add(this.userInfo_pnl);
            this.Controls.Add(this.buyTicketBtn);
            this.Controls.Add(this.cancelTicketBtn);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.userInfo_pnl.ResumeLayout(false);
            this.userInfo_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBoughtDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightDgv)).EndInit();
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
        private Button buyTicketBtn;
        private Panel userInfo_pnl;
        private TextBox phoneNumber_txtBox;
        private TextBox ID_txtBox;
        private TextBox email_txtBox;
        private TextBox textBox4;
        private TextBox userName_txtBox;
        private TextBox fullName_txtBox;
        private TextBox textBox1;
        private DataGridView ticketBoughtDgv;
        private DataGridView flightDgv;
        private PictureBox pictureBox1;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}