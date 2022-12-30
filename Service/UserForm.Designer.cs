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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.publicAnnoucementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.flightDgv = new System.Windows.Forms.DataGridView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.LookUpBtn = new System.Windows.Forms.Button();
            this.settingBtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.userInfo_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(1277, 28);
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
            // buyTicketBtn
            // 
            this.buyTicketBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            this.buyTicketBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buyTicketBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buyTicketBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buyTicketBtn.Location = new System.Drawing.Point(752, 237);
            this.buyTicketBtn.Name = "buyTicketBtn";
            this.buyTicketBtn.Size = new System.Drawing.Size(168, 295);
            this.buyTicketBtn.TabIndex = 7;
            this.buyTicketBtn.Text = "    Đặt vé";
            this.buyTicketBtn.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.buyTicketBtn.UseVisualStyleBackColor = false;
            this.buyTicketBtn.Click += new System.EventHandler(this.buyTicketBtn_Click);
            // 
            // userInfo_pnl
            // 
            this.userInfo_pnl.BackColor = System.Drawing.Color.White;
            this.userInfo_pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userInfo_pnl.Controls.Add(this.pictureBox1);
            this.userInfo_pnl.Controls.Add(this.phoneNumber_txtBox);
            this.userInfo_pnl.Controls.Add(this.ID_txtBox);
            this.userInfo_pnl.Controls.Add(this.email_txtBox);
            this.userInfo_pnl.Controls.Add(this.textBox4);
            this.userInfo_pnl.Controls.Add(this.userName_txtBox);
            this.userInfo_pnl.Controls.Add(this.fullName_txtBox);
            this.userInfo_pnl.Controls.Add(this.textBox1);
            this.userInfo_pnl.ForeColor = System.Drawing.Color.RoyalBlue;
            this.userInfo_pnl.Location = new System.Drawing.Point(752, 37);
            this.userInfo_pnl.Name = "userInfo_pnl";
            this.userInfo_pnl.Size = new System.Drawing.Size(516, 194);
            this.userInfo_pnl.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Service.Properties.Resources.user;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(13, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 87);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // phoneNumber_txtBox
            // 
            this.phoneNumber_txtBox.BackColor = System.Drawing.Color.White;
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
            this.ID_txtBox.BackColor = System.Drawing.Color.White;
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
            this.email_txtBox.BackColor = System.Drawing.Color.White;
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
            this.textBox4.BackColor = System.Drawing.Color.White;
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
            this.userName_txtBox.BackColor = System.Drawing.Color.White;
            this.userName_txtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userName_txtBox.Enabled = false;
            this.userName_txtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.userName_txtBox.Location = new System.Drawing.Point(13, 10);
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
            this.fullName_txtBox.BackColor = System.Drawing.Color.White;
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
            this.textBox1.BackColor = System.Drawing.Color.White;
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
            // flightDgv
            // 
            this.flightDgv.AllowUserToAddRows = false;
            this.flightDgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            this.flightDgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.flightDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.flightDgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.flightDgv.BackgroundColor = System.Drawing.Color.White;
            this.flightDgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.flightDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.flightDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.flightDgv.DefaultCellStyle = dataGridViewCellStyle8;
            this.flightDgv.GridColor = System.Drawing.Color.DimGray;
            this.flightDgv.Location = new System.Drawing.Point(21, 70);
            this.flightDgv.Name = "flightDgv";
            this.flightDgv.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.flightDgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.flightDgv.RowHeadersVisible = false;
            this.flightDgv.RowHeadersWidth = 51;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.flightDgv.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.flightDgv.RowTemplate.Height = 29;
            this.flightDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.flightDgv.Size = new System.Drawing.Size(674, 462);
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
            // LookUpBtn
            // 
            this.LookUpBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            this.LookUpBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LookUpBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LookUpBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LookUpBtn.Location = new System.Drawing.Point(926, 237);
            this.LookUpBtn.Name = "LookUpBtn";
            this.LookUpBtn.Size = new System.Drawing.Size(168, 295);
            this.LookUpBtn.TabIndex = 12;
            this.LookUpBtn.Text = "    Tra cứu";
            this.LookUpBtn.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.LookUpBtn.UseVisualStyleBackColor = false;
            this.LookUpBtn.Click += new System.EventHandler(this.LookUpBtn_Click);
            // 
            // settingBtn
            // 
            this.settingBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            this.settingBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.settingBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.settingBtn.Location = new System.Drawing.Point(1100, 237);
            this.settingBtn.Name = "settingBtn";
            this.settingBtn.Size = new System.Drawing.Size(168, 295);
            this.settingBtn.TabIndex = 13;
            this.settingBtn.Text = "    Cài đặt";
            this.settingBtn.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.settingBtn.UseVisualStyleBackColor = false;
            this.settingBtn.Click += new System.EventHandler(this.settingBtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            this.pictureBox2.BackgroundImage = global::Service.Properties.Resources.booking;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Location = new System.Drawing.Point(786, 334);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(103, 92);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Enabled = false;
            this.pictureBox3.ErrorImage = global::Service.Properties.Resources.look_up1;
            this.pictureBox3.Image = global::Service.Properties.Resources.look_up1;
            this.pictureBox3.Location = new System.Drawing.Point(960, 334);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(103, 92);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.LookUpBtn_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Enabled = false;
            this.pictureBox4.Location = new System.Drawing.Point(1138, 334);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(103, 92);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(13, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 495);
            this.panel1.TabIndex = 17;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.White;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            this.textBox5.Location = new System.Drawing.Point(328, 21);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(302, 27);
            this.textBox5.TabIndex = 18;
            this.textBox5.TabStop = false;
            this.textBox5.Text = "Danh sách các chuyến bay sắp tới";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1277, 540);
            this.Controls.Add(this.flightDgv);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.settingBtn);
            this.Controls.Add(this.LookUpBtn);
            this.Controls.Add(this.userInfo_pnl);
            this.Controls.Add(this.buyTicketBtn);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.userInfo_pnl.ResumeLayout(false);
            this.userInfo_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
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
        private Button buyTicketBtn;
        private Panel userInfo_pnl;
        private TextBox phoneNumber_txtBox;
        private TextBox ID_txtBox;
        private TextBox email_txtBox;
        private TextBox textBox4;
        private TextBox userName_txtBox;
        private TextBox fullName_txtBox;
        private TextBox textBox1;
        private DataGridView flightDgv;
        private PictureBox pictureBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button LookUpBtn;
        private Button settingBtn;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Panel panel1;
        private TextBox textBox5;
    }
}