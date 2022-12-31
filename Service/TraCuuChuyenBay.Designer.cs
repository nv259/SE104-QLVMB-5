namespace Service
{
    partial class TraCuuChuyenBay
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
            this.ChuyenBay_comboBox = new System.Windows.Forms.ComboBox();
            this.SanBayDi_comboBox = new System.Windows.Forms.ComboBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.NgayBay_datetime = new System.Windows.Forms.DateTimePicker();
            this.SanBayDen_comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FullInfo = new System.Windows.Forms.DataGridView();
            this.NgayBay_chkBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.FullInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // ChuyenBay_comboBox
            // 
            this.ChuyenBay_comboBox.FormattingEnabled = true;
            this.ChuyenBay_comboBox.Location = new System.Drawing.Point(152, 102);
            this.ChuyenBay_comboBox.Name = "ChuyenBay_comboBox";
            this.ChuyenBay_comboBox.Size = new System.Drawing.Size(250, 28);
            this.ChuyenBay_comboBox.TabIndex = 44;
            this.ChuyenBay_comboBox.SelectedIndexChanged += new System.EventHandler(this.ChuyenBay_comboBox_SelectedIndexChanged);
            // 
            // SanBayDi_comboBox
            // 
            this.SanBayDi_comboBox.FormattingEnabled = true;
            this.SanBayDi_comboBox.Location = new System.Drawing.Point(152, 158);
            this.SanBayDi_comboBox.Name = "SanBayDi_comboBox";
            this.SanBayDi_comboBox.Size = new System.Drawing.Size(250, 28);
            this.SanBayDi_comboBox.TabIndex = 43;
            this.SanBayDi_comboBox.SelectedIndexChanged += new System.EventHandler(this.SanBayDi_comboBox_SelectedIndexChanged);
            // 
            // textBox16
            // 
            this.textBox16.BackColor = System.Drawing.Color.White;
            this.textBox16.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox16.Location = new System.Drawing.Point(39, 106);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(90, 20);
            this.textBox16.TabIndex = 42;
            this.textBox16.TabStop = false;
            this.textBox16.Text = "Chuyến bay:";
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.White;
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Location = new System.Drawing.Point(777, 106);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(82, 20);
            this.textBox9.TabIndex = 41;
            this.textBox9.TabStop = false;
            this.textBox9.Text = "Ngày bay:";
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.White;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Location = new System.Drawing.Point(39, 161);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(82, 20);
            this.textBox8.TabIndex = 40;
            this.textBox8.TabStop = false;
            this.textBox8.Text = "Bay từ:";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.White;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Location = new System.Drawing.Point(777, 161);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(82, 20);
            this.textBox7.TabIndex = 39;
            this.textBox7.TabStop = false;
            this.textBox7.Text = "Bay đến:";
            // 
            // NgayBay_datetime
            // 
            this.NgayBay_datetime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.NgayBay_datetime.Location = new System.Drawing.Point(920, 103);
            this.NgayBay_datetime.Name = "NgayBay_datetime";
            this.NgayBay_datetime.Size = new System.Drawing.Size(226, 27);
            this.NgayBay_datetime.TabIndex = 38;
            this.NgayBay_datetime.ValueChanged += new System.EventHandler(this.NgayBay_datetime_ValueChanged);
            // 
            // SanBayDen_comboBox
            // 
            this.SanBayDen_comboBox.FormattingEnabled = true;
            this.SanBayDen_comboBox.Location = new System.Drawing.Point(896, 158);
            this.SanBayDen_comboBox.Name = "SanBayDen_comboBox";
            this.SanBayDen_comboBox.Size = new System.Drawing.Size(250, 28);
            this.SanBayDen_comboBox.TabIndex = 37;
            this.SanBayDen_comboBox.SelectedIndexChanged += new System.EventHandler(this.SanBayDen_comboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            this.label1.Location = new System.Drawing.Point(392, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 50);
            this.label1.TabIndex = 36;
            this.label1.Text = "TRA CỨU CHUYẾN BAY";
            // 
            // FullInfo
            // 
            this.FullInfo.AllowUserToAddRows = false;
            this.FullInfo.AllowUserToDeleteRows = false;
            this.FullInfo.AllowUserToResizeColumns = false;
            this.FullInfo.AllowUserToResizeRows = false;
            this.FullInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FullInfo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.FullInfo.BackgroundColor = System.Drawing.Color.White;
            this.FullInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FullInfo.EnableHeadersVisualStyles = false;
            this.FullInfo.Location = new System.Drawing.Point(39, 215);
            this.FullInfo.MultiSelect = false;
            this.FullInfo.Name = "FullInfo";
            this.FullInfo.ReadOnly = true;
            this.FullInfo.RowHeadersWidth = 51;
            this.FullInfo.RowTemplate.Height = 29;
            this.FullInfo.Size = new System.Drawing.Size(1107, 466);
            this.FullInfo.TabIndex = 35;
            this.FullInfo.TabStop = false;
            // 
            // NgayBay_chkBox
            // 
            this.NgayBay_chkBox.AutoSize = true;
            this.NgayBay_chkBox.Location = new System.Drawing.Point(896, 108);
            this.NgayBay_chkBox.Name = "NgayBay_chkBox";
            this.NgayBay_chkBox.Size = new System.Drawing.Size(18, 17);
            this.NgayBay_chkBox.TabIndex = 45;
            this.NgayBay_chkBox.UseVisualStyleBackColor = true;
            this.NgayBay_chkBox.CheckedChanged += new System.EventHandler(this.NgayBay_chkBox_CheckedChanged);
            // 
            // TraCuuChuyenBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1183, 711);
            this.Controls.Add(this.NgayBay_chkBox);
            this.Controls.Add(this.ChuyenBay_comboBox);
            this.Controls.Add(this.SanBayDi_comboBox);
            this.Controls.Add(this.textBox16);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.NgayBay_datetime);
            this.Controls.Add(this.SanBayDen_comboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FullInfo);
            this.Name = "TraCuuChuyenBay";
            this.Text = "TraCuuChuyenBay";
            ((System.ComponentModel.ISupportInitialize)(this.FullInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox ChuyenBay_comboBox;
        private ComboBox SanBayDi_comboBox;
        private TextBox textBox16;
        private TextBox textBox9;
        private TextBox textBox8;
        private TextBox textBox7;
        private DateTimePicker NgayBay_datetime;
        private ComboBox SanBayDen_comboBox;
        private Label label1;
        private DataGridView FullInfo;
        private CheckBox NgayBay_chkBox;
    }
}