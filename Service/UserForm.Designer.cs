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
            this.userInfo_pnl = new System.Windows.Forms.Panel();
            this.pwd_pnl = new System.Windows.Forms.Panel();
            this.funding_pnl = new System.Windows.Forms.Panel();
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
            // userInfo_pnl
            // 
            this.userInfo_pnl.BackColor = System.Drawing.Color.PaleTurquoise;
            this.userInfo_pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userInfo_pnl.Location = new System.Drawing.Point(12, 54);
            this.userInfo_pnl.Name = "userInfo_pnl";
            this.userInfo_pnl.Size = new System.Drawing.Size(446, 181);
            this.userInfo_pnl.TabIndex = 1;
            // 
            // pwd_pnl
            // 
            this.pwd_pnl.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pwd_pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pwd_pnl.Location = new System.Drawing.Point(12, 241);
            this.pwd_pnl.Name = "pwd_pnl";
            this.pwd_pnl.Size = new System.Drawing.Size(446, 210);
            this.pwd_pnl.TabIndex = 2;
            // 
            // funding_pnl
            // 
            this.funding_pnl.BackColor = System.Drawing.Color.DarkGray;
            this.funding_pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.funding_pnl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.funding_pnl.Location = new System.Drawing.Point(492, 54);
            this.funding_pnl.Name = "funding_pnl";
            this.funding_pnl.Size = new System.Drawing.Size(305, 262);
            this.funding_pnl.TabIndex = 4;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(252)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(800, 463);
            this.Controls.Add(this.funding_pnl);
            this.Controls.Add(this.pwd_pnl);
            this.Controls.Add(this.userInfo_pnl);
            this.Controls.Add(this.menuStrip1);
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private Panel userInfo_pnl;
        private Panel pwd_pnl;
        private Panel funding_pnl;
    }
}