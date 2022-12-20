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
            this.shortUserInfoPnl = new System.Windows.Forms.Panel();
            this.cancelTicketBtn = new System.Windows.Forms.Button();
            this.changeInfoBtn = new System.Windows.Forms.Button();
            this.buyTicketBtn = new System.Windows.Forms.Button();
            this.danhSachVeLstBox = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
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
            // shortUserInfoPnl
            // 
            this.shortUserInfoPnl.BackColor = System.Drawing.Color.DarkGray;
            this.shortUserInfoPnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.shortUserInfoPnl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.shortUserInfoPnl.Location = new System.Drawing.Point(12, 31);
            this.shortUserInfoPnl.Name = "shortUserInfoPnl";
            this.shortUserInfoPnl.Size = new System.Drawing.Size(305, 262);
            this.shortUserInfoPnl.TabIndex = 4;
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
            this.danhSachVeLstBox.Location = new System.Drawing.Point(146, 204);
            this.danhSachVeLstBox.Name = "danhSachVeLstBox";
            this.danhSachVeLstBox.Size = new System.Drawing.Size(358, 284);
            this.danhSachVeLstBox.TabIndex = 8;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(252)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(800, 463);
            this.Controls.Add(this.danhSachVeLstBox);
            this.Controls.Add(this.buyTicketBtn);
            this.Controls.Add(this.changeInfoBtn);
            this.Controls.Add(this.cancelTicketBtn);
            this.Controls.Add(this.shortUserInfoPnl);
            this.Controls.Add(this.menuStrip1);
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private Panel shortUserInfoPnl;
        private Button cancelTicketBtn;
        private Button changeInfoBtn;
        private Button buyTicketBtn;
        private ListBox danhSachVeLstBox;
    }
}