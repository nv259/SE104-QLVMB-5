namespace Service
{
    partial class LichChuyenBayForm
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
            this.CreatedDate_txtBox = new System.Windows.Forms.TextBox();
            this.CreatedDate1_txtBox = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.MaChuyenBay1_txtBox = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.GiaVe1_txtBox = new System.Windows.Forms.TextBox();
            this.NgayGioBay1_txtBox = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.ThoiGianBay1_txtBox = new System.Windows.Forms.TextBox();
            this.HangVe_grid = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.RecordBtn = new System.Windows.Forms.Button();
            this.alert_txtBox = new System.Windows.Forms.TextBox();
            this.SanBayDi1_listBox = new System.Windows.Forms.ComboBox();
            this.SanBayDen1_listBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.HangVe_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // CreatedDate_txtBox
            // 
            this.CreatedDate_txtBox.BackColor = System.Drawing.SystemColors.Control;
            this.CreatedDate_txtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CreatedDate_txtBox.Location = new System.Drawing.Point(12, 12);
            this.CreatedDate_txtBox.Name = "CreatedDate_txtBox";
            this.CreatedDate_txtBox.Size = new System.Drawing.Size(194, 20);
            this.CreatedDate_txtBox.TabIndex = 0;
            this.CreatedDate_txtBox.TabStop = false;
            this.CreatedDate_txtBox.Text = "Ngày nhận lịch chuyến bay:";
            // 
            // CreatedDate1_txtBox
            // 
            this.CreatedDate1_txtBox.Location = new System.Drawing.Point(202, 9);
            this.CreatedDate1_txtBox.Name = "CreatedDate1_txtBox";
            this.CreatedDate1_txtBox.Size = new System.Drawing.Size(178, 27);
            this.CreatedDate1_txtBox.TabIndex = 1;
            this.CreatedDate1_txtBox.TabStop = false;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(12, 62);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(115, 20);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "Mã chuyến bay:";
            // 
            // MaChuyenBay1_txtBox
            // 
            this.MaChuyenBay1_txtBox.Location = new System.Drawing.Point(123, 59);
            this.MaChuyenBay1_txtBox.Name = "MaChuyenBay1_txtBox";
            this.MaChuyenBay1_txtBox.Size = new System.Drawing.Size(266, 27);
            this.MaChuyenBay1_txtBox.TabIndex = 3;
            this.MaChuyenBay1_txtBox.TextChanged += new System.EventHandler(this.MaChuyenBay1_txtBox_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Control;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Location = new System.Drawing.Point(12, 95);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(115, 20);
            this.textBox5.TabIndex = 4;
            this.textBox5.Text = "Sân bay đi:";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.Control;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Location = new System.Drawing.Point(420, 95);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(94, 20);
            this.textBox6.TabIndex = 5;
            this.textBox6.Text = "Sân bay đến:";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.Control;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Location = new System.Drawing.Point(420, 62);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(94, 20);
            this.textBox7.TabIndex = 6;
            this.textBox7.Text = "Giá vé:";
            // 
            // GiaVe1_txtBox
            // 
            this.GiaVe1_txtBox.Location = new System.Drawing.Point(520, 59);
            this.GiaVe1_txtBox.Name = "GiaVe1_txtBox";
            this.GiaVe1_txtBox.Size = new System.Drawing.Size(268, 27);
            this.GiaVe1_txtBox.TabIndex = 9;
            this.GiaVe1_txtBox.TextChanged += new System.EventHandler(this.GiaVe1_txtBox_TextChanged);
            // 
            // NgayGioBay1_txtBox
            // 
            this.NgayGioBay1_txtBox.Location = new System.Drawing.Point(123, 125);
            this.NgayGioBay1_txtBox.Name = "NgayGioBay1_txtBox";
            this.NgayGioBay1_txtBox.PlaceholderText = "dd-MM-yyyy hh:mm";
            this.NgayGioBay1_txtBox.Size = new System.Drawing.Size(266, 27);
            this.NgayGioBay1_txtBox.TabIndex = 10;
            this.NgayGioBay1_txtBox.TabStop = false;
            this.NgayGioBay1_txtBox.TextChanged += new System.EventHandler(this.NgayGioBay1_txtBox_TextChanged);
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.SystemColors.Control;
            this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox12.Location = new System.Drawing.Point(12, 125);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(115, 20);
            this.textBox12.TabIndex = 11;
            this.textBox12.Text = "Ngày - giờ bay:";
            // 
            // textBox13
            // 
            this.textBox13.BackColor = System.Drawing.SystemColors.Control;
            this.textBox13.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox13.Location = new System.Drawing.Point(420, 128);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(94, 20);
            this.textBox13.TabIndex = 12;
            this.textBox13.Text = "Thời gian bay:";
            // 
            // ThoiGianBay1_txtBox
            // 
            this.ThoiGianBay1_txtBox.Location = new System.Drawing.Point(520, 125);
            this.ThoiGianBay1_txtBox.Name = "ThoiGianBay1_txtBox";
            this.ThoiGianBay1_txtBox.PlaceholderText = "hh:mm";
            this.ThoiGianBay1_txtBox.Size = new System.Drawing.Size(268, 27);
            this.ThoiGianBay1_txtBox.TabIndex = 13;
            this.ThoiGianBay1_txtBox.TabStop = false;
            this.ThoiGianBay1_txtBox.TextChanged += new System.EventHandler(this.ThoiGianBay1_txtBox_TextChanged);
            // 
            // HangVe_grid
            // 
            this.HangVe_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HangVe_grid.Location = new System.Drawing.Point(12, 177);
            this.HangVe_grid.Name = "HangVe_grid";
            this.HangVe_grid.RowHeadersWidth = 51;
            this.HangVe_grid.RowTemplate.Height = 29;
            this.HangVe_grid.Size = new System.Drawing.Size(776, 226);
            this.HangVe_grid.TabIndex = 14;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 425);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(776, 234);
            this.dataGridView2.TabIndex = 15;
            // 
            // RecordBtn
            // 
            this.RecordBtn.Location = new System.Drawing.Point(286, 734);
            this.RecordBtn.Name = "RecordBtn";
            this.RecordBtn.Size = new System.Drawing.Size(216, 43);
            this.RecordBtn.TabIndex = 16;
            this.RecordBtn.Text = "Ghi Nhận";
            this.RecordBtn.UseVisualStyleBackColor = true;
            // 
            // alert_txtBox
            // 
            this.alert_txtBox.BackColor = System.Drawing.SystemColors.Control;
            this.alert_txtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.alert_txtBox.Location = new System.Drawing.Point(12, 681);
            this.alert_txtBox.Name = "alert_txtBox";
            this.alert_txtBox.Size = new System.Drawing.Size(776, 20);
            this.alert_txtBox.TabIndex = 17;
            this.alert_txtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SanBayDi1_listBox
            // 
            this.SanBayDi1_listBox.FormattingEnabled = true;
            this.SanBayDi1_listBox.Location = new System.Drawing.Point(123, 91);
            this.SanBayDi1_listBox.Name = "SanBayDi1_listBox";
            this.SanBayDi1_listBox.Size = new System.Drawing.Size(266, 28);
            this.SanBayDi1_listBox.TabIndex = 20;
            this.SanBayDi1_listBox.SelectedIndexChanged += new System.EventHandler(this.SanBayDi1_listBox_SelectedIndexChanged);
            // 
            // SanBayDen1_listBox
            // 
            this.SanBayDen1_listBox.FormattingEnabled = true;
            this.SanBayDen1_listBox.Location = new System.Drawing.Point(520, 92);
            this.SanBayDen1_listBox.Name = "SanBayDen1_listBox";
            this.SanBayDen1_listBox.Size = new System.Drawing.Size(268, 28);
            this.SanBayDen1_listBox.TabIndex = 21;
            this.SanBayDen1_listBox.SelectedIndexChanged += new System.EventHandler(this.SanBayDen1_listBox_SelectedIndexChanged);
            // 
            // LichChuyenBayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 789);
            this.Controls.Add(this.SanBayDen1_listBox);
            this.Controls.Add(this.SanBayDi1_listBox);
            this.Controls.Add(this.alert_txtBox);
            this.Controls.Add(this.RecordBtn);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.HangVe_grid);
            this.Controls.Add(this.ThoiGianBay1_txtBox);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.NgayGioBay1_txtBox);
            this.Controls.Add(this.GiaVe1_txtBox);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.MaChuyenBay1_txtBox);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.CreatedDate1_txtBox);
            this.Controls.Add(this.CreatedDate_txtBox);
            this.Name = "LichChuyenBayForm";
            this.Text = "Nhận lịch chuyến bay";
            this.Load += new System.EventHandler(this.LichChuyenBayForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HangVe_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox CreatedDate_txtBox;
        private TextBox CreatedDate1_txtBox;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox10;
        private TextBox NgayGioBay1_txtBox;
        private TextBox textBox12;
        private TextBox textBox13;
        private TextBox ThoiGianBay1_txtBox;
        private DataGridView HangVe_grid;
        private DataGridView dataGridView2;
        private Button RecordBtn;
        private TextBox alert_txtBox;
        private TextBox MaChuyenBay1_txtBox;
        private TextBox GiaVe1_txtBox;
        private TextBox SanBayDi1_txtBox;
        private ComboBox SanBayDi1_listBox;
        private ComboBox SanBayDen1_listBox;
    }
}