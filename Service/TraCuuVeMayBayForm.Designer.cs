﻿namespace Service
{
    partial class TraCuuVeMayBayForm
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
            this.FullInfo = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.SanBayDen_comboBox = new System.Windows.Forms.ComboBox();
            this.NgayBay_datetime = new System.Windows.Forms.DateTimePicker();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.TenDangNhap_txtBox = new System.Windows.Forms.TextBox();
            this.HoVaTen_txtBox = new System.Windows.Forms.TextBox();
            this.Email_txtBox = new System.Windows.Forms.TextBox();
            this.NgaySinh_txtBox = new System.Windows.Forms.TextBox();
            this.MaDinhDanh_txtBox = new System.Windows.Forms.TextBox();
            this.SoDienThoai_txtBox = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.ChuyenBay_comboBox = new System.Windows.Forms.ComboBox();
            this.SanBayDi_comboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.FullInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // FullInfo
            // 
            this.FullInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FullInfo.Location = new System.Drawing.Point(39, 278);
            this.FullInfo.Name = "FullInfo";
            this.FullInfo.RowHeadersWidth = 51;
            this.FullInfo.RowTemplate.Height = 29;
            this.FullInfo.Size = new System.Drawing.Size(1072, 596);
            this.FullInfo.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(39, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Tên đăng nhập:";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(730, 62);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Email:";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(39, 54);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(82, 20);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = "Họ và tên:";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Control;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(39, 104);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(111, 20);
            this.textBox4.TabIndex = 4;
            this.textBox4.Text = "Mã định danh:";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Control;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(730, 15);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(125, 20);
            this.textBox5.TabIndex = 5;
            this.textBox5.Text = "Ngày sinh:";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.Control;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(730, 108);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(125, 20);
            this.textBox6.TabIndex = 6;
            this.textBox6.Text = "Số điện thoại:";
            // 
            // SanBayDen_comboBox
            // 
            this.SanBayDen_comboBox.FormattingEnabled = true;
            this.SanBayDen_comboBox.Location = new System.Drawing.Point(861, 222);
            this.SanBayDen_comboBox.Name = "SanBayDen_comboBox";
            this.SanBayDen_comboBox.Size = new System.Drawing.Size(250, 28);
            this.SanBayDen_comboBox.TabIndex = 7;
            this.SanBayDen_comboBox.SelectedIndexChanged += new System.EventHandler(this.SanBayDen_comboBox_SelectedIndexChanged);
            // 
            // NgayBay_datetime
            // 
            this.NgayBay_datetime.Location = new System.Drawing.Point(861, 169);
            this.NgayBay_datetime.Name = "NgayBay_datetime";
            this.NgayBay_datetime.Size = new System.Drawing.Size(250, 27);
            this.NgayBay_datetime.TabIndex = 9;
            this.NgayBay_datetime.ValueChanged += new System.EventHandler(this.NgayBay_datetime_ValueChanged);
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.Control;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Location = new System.Drawing.Point(730, 225);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(82, 20);
            this.textBox7.TabIndex = 10;
            this.textBox7.Text = "Bay đến:";
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.SystemColors.Control;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Enabled = false;
            this.textBox8.Location = new System.Drawing.Point(39, 225);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(82, 20);
            this.textBox8.TabIndex = 11;
            this.textBox8.Text = "Bay từ:";
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.SystemColors.Control;
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Enabled = false;
            this.textBox9.Location = new System.Drawing.Point(730, 179);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(82, 20);
            this.textBox9.TabIndex = 12;
            this.textBox9.Text = "Ngày bay:";
            // 
            // TenDangNhap_txtBox
            // 
            this.TenDangNhap_txtBox.Enabled = false;
            this.TenDangNhap_txtBox.Location = new System.Drawing.Point(153, 12);
            this.TenDangNhap_txtBox.Name = "TenDangNhap_txtBox";
            this.TenDangNhap_txtBox.Size = new System.Drawing.Size(232, 27);
            this.TenDangNhap_txtBox.TabIndex = 13;
            this.TenDangNhap_txtBox.TabStop = false;
            // 
            // HoVaTen_txtBox
            // 
            this.HoVaTen_txtBox.Enabled = false;
            this.HoVaTen_txtBox.Location = new System.Drawing.Point(153, 55);
            this.HoVaTen_txtBox.Name = "HoVaTen_txtBox";
            this.HoVaTen_txtBox.Size = new System.Drawing.Size(232, 27);
            this.HoVaTen_txtBox.TabIndex = 14;
            // 
            // Email_txtBox
            // 
            this.Email_txtBox.Enabled = false;
            this.Email_txtBox.Location = new System.Drawing.Point(861, 59);
            this.Email_txtBox.Name = "Email_txtBox";
            this.Email_txtBox.Size = new System.Drawing.Size(250, 27);
            this.Email_txtBox.TabIndex = 15;
            // 
            // NgaySinh_txtBox
            // 
            this.NgaySinh_txtBox.Enabled = false;
            this.NgaySinh_txtBox.Location = new System.Drawing.Point(861, 12);
            this.NgaySinh_txtBox.Name = "NgaySinh_txtBox";
            this.NgaySinh_txtBox.Size = new System.Drawing.Size(250, 27);
            this.NgaySinh_txtBox.TabIndex = 16;
            // 
            // MaDinhDanh_txtBox
            // 
            this.MaDinhDanh_txtBox.Enabled = false;
            this.MaDinhDanh_txtBox.Location = new System.Drawing.Point(153, 101);
            this.MaDinhDanh_txtBox.Name = "MaDinhDanh_txtBox";
            this.MaDinhDanh_txtBox.Size = new System.Drawing.Size(232, 27);
            this.MaDinhDanh_txtBox.TabIndex = 17;
            // 
            // SoDienThoai_txtBox
            // 
            this.SoDienThoai_txtBox.Enabled = false;
            this.SoDienThoai_txtBox.Location = new System.Drawing.Point(861, 101);
            this.SoDienThoai_txtBox.Name = "SoDienThoai_txtBox";
            this.SoDienThoai_txtBox.Size = new System.Drawing.Size(250, 27);
            this.SoDienThoai_txtBox.TabIndex = 18;
            // 
            // textBox16
            // 
            this.textBox16.BackColor = System.Drawing.SystemColors.Control;
            this.textBox16.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox16.Enabled = false;
            this.textBox16.Location = new System.Drawing.Point(39, 174);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(90, 20);
            this.textBox16.TabIndex = 19;
            this.textBox16.Text = "Chuyến bay:";
            // 
            // ChuyenBay_comboBox
            // 
            this.ChuyenBay_comboBox.FormattingEnabled = true;
            this.ChuyenBay_comboBox.Location = new System.Drawing.Point(135, 171);
            this.ChuyenBay_comboBox.Name = "ChuyenBay_comboBox";
            this.ChuyenBay_comboBox.Size = new System.Drawing.Size(250, 28);
            this.ChuyenBay_comboBox.TabIndex = 21;
            this.ChuyenBay_comboBox.SelectedIndexChanged += new System.EventHandler(this.ChuyenBay_comboBox_SelectedIndexChanged);
            // 
            // SanBayDi_comboBox
            // 
            this.SanBayDi_comboBox.FormattingEnabled = true;
            this.SanBayDi_comboBox.Location = new System.Drawing.Point(135, 222);
            this.SanBayDi_comboBox.Name = "SanBayDi_comboBox";
            this.SanBayDi_comboBox.Size = new System.Drawing.Size(250, 28);
            this.SanBayDi_comboBox.TabIndex = 22;
            this.SanBayDi_comboBox.SelectedIndexChanged += new System.EventHandler(this.SanBayDi_comboBox_SelectedIndexChanged);
            // 
            // TraCuuVeMayBayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 886);
            this.Controls.Add(this.SanBayDi_comboBox);
            this.Controls.Add(this.ChuyenBay_comboBox);
            this.Controls.Add(this.textBox16);
            this.Controls.Add(this.SoDienThoai_txtBox);
            this.Controls.Add(this.MaDinhDanh_txtBox);
            this.Controls.Add(this.NgaySinh_txtBox);
            this.Controls.Add(this.Email_txtBox);
            this.Controls.Add(this.HoVaTen_txtBox);
            this.Controls.Add(this.TenDangNhap_txtBox);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.NgayBay_datetime);
            this.Controls.Add(this.SanBayDen_comboBox);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.FullInfo);
            this.Name = "TraCuuVeMayBayForm";
            this.Text = "Tra cứu vé máy bay";
            ((System.ComponentModel.ISupportInitialize)(this.FullInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView FullInfo;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private ComboBox SanBayDen_comboBox;
        private DateTimePicker NgayBay_datetime;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox TenDangNhap_txtBox;
        private TextBox HoVaTen_txtBox;
        private TextBox Email_txtBox;
        private TextBox NgaySinh_txtBox;
        private TextBox MaDinhDanh_txtBox;
        private TextBox SoDienThoai_txtBox;
        private TextBox textBox16;
        private ComboBox ChuyenBay_comboBox;
        private ComboBox SanBayDi_comboBox;
    }
}