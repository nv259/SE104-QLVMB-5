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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TraCuuChuyenBay));
            this.flight_comboBox = new System.Windows.Forms.ComboBox();
            this.from_comboBox = new System.Windows.Forms.ComboBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.flightdate_Dtp = new System.Windows.Forms.DateTimePicker();
            this.to_comboBox = new System.Windows.Forms.ComboBox();
            this.LookUp_label = new System.Windows.Forms.Label();
            this.flight_Dgv = new System.Windows.Forms.DataGridView();
            this.flightdate_chkBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.flight_Dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // flight_comboBox
            // 
            this.flight_comboBox.FormattingEnabled = true;
            this.flight_comboBox.Location = new System.Drawing.Point(152, 102);
            this.flight_comboBox.Name = "flight_comboBox";
            this.flight_comboBox.Size = new System.Drawing.Size(250, 28);
            this.flight_comboBox.TabIndex = 44;
            this.flight_comboBox.SelectedIndexChanged += new System.EventHandler(this.flight_comboBox_SelectedIndexChanged);
            // 
            // from_comboBox
            // 
            this.from_comboBox.FormattingEnabled = true;
            this.from_comboBox.Location = new System.Drawing.Point(152, 158);
            this.from_comboBox.Name = "from_comboBox";
            this.from_comboBox.Size = new System.Drawing.Size(250, 28);
            this.from_comboBox.TabIndex = 43;
            this.from_comboBox.SelectedIndexChanged += new System.EventHandler(this.from_comboBox_SelectedIndexChanged);
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
            // flightdate_Dtp
            // 
            this.flightdate_Dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.flightdate_Dtp.Location = new System.Drawing.Point(920, 103);
            this.flightdate_Dtp.Name = "flightdate_Dtp";
            this.flightdate_Dtp.Size = new System.Drawing.Size(226, 27);
            this.flightdate_Dtp.TabIndex = 38;
            this.flightdate_Dtp.ValueChanged += new System.EventHandler(this.flightdate_Dtp_ValueChanged);
            // 
            // to_comboBox
            // 
            this.to_comboBox.FormattingEnabled = true;
            this.to_comboBox.Location = new System.Drawing.Point(896, 158);
            this.to_comboBox.Name = "to_comboBox";
            this.to_comboBox.Size = new System.Drawing.Size(250, 28);
            this.to_comboBox.TabIndex = 37;
            this.to_comboBox.SelectedIndexChanged += new System.EventHandler(this.to_comboBox_SelectedIndexChanged);
            // 
            // LookUp_label
            // 
            this.LookUp_label.AutoSize = true;
            this.LookUp_label.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LookUp_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            this.LookUp_label.Location = new System.Drawing.Point(392, 20);
            this.LookUp_label.Name = "LookUp_label";
            this.LookUp_label.Size = new System.Drawing.Size(421, 50);
            this.LookUp_label.TabIndex = 36;
            this.LookUp_label.Text = "TRA CỨU CHUYẾN BAY";
            // 
            // flight_Dgv
            // 
            this.flight_Dgv.AllowUserToAddRows = false;
            this.flight_Dgv.AllowUserToDeleteRows = false;
            this.flight_Dgv.AllowUserToResizeColumns = false;
            this.flight_Dgv.AllowUserToResizeRows = false;
            this.flight_Dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.flight_Dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.flight_Dgv.BackgroundColor = System.Drawing.Color.White;
            this.flight_Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.flight_Dgv.EnableHeadersVisualStyles = false;
            this.flight_Dgv.Location = new System.Drawing.Point(39, 215);
            this.flight_Dgv.MultiSelect = false;
            this.flight_Dgv.Name = "flight_Dgv";
            this.flight_Dgv.ReadOnly = true;
            this.flight_Dgv.RowHeadersWidth = 51;
            this.flight_Dgv.RowTemplate.Height = 29;
            this.flight_Dgv.Size = new System.Drawing.Size(1107, 466);
            this.flight_Dgv.TabIndex = 35;
            this.flight_Dgv.TabStop = false;
            // 
            // flightdate_chkBox
            // 
            this.flightdate_chkBox.AutoSize = true;
            this.flightdate_chkBox.Location = new System.Drawing.Point(896, 108);
            this.flightdate_chkBox.Name = "flightdate_chkBox";
            this.flightdate_chkBox.Size = new System.Drawing.Size(18, 17);
            this.flightdate_chkBox.TabIndex = 45;
            this.flightdate_chkBox.UseVisualStyleBackColor = true;
            this.flightdate_chkBox.CheckedChanged += new System.EventHandler(this.flightdate_chkBox_CheckedChanged);
            // 
            // TraCuuChuyenBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1183, 711);
            this.Controls.Add(this.flightdate_chkBox);
            this.Controls.Add(this.flight_comboBox);
            this.Controls.Add(this.from_comboBox);
            this.Controls.Add(this.textBox16);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.flightdate_Dtp);
            this.Controls.Add(this.to_comboBox);
            this.Controls.Add(this.LookUp_label);
            this.Controls.Add(this.flight_Dgv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TraCuuChuyenBay";
            this.Text = "Tra cứu chuyến bay";
            ((System.ComponentModel.ISupportInitialize)(this.flight_Dgv)).EndInit();
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
        private ComboBox flight_comboBox;
        private ComboBox from_comboBox;
        private DateTimePicker flightdate_Dtp;
        private ComboBox to_comboBox;
        private Label LookUp_label;
        private CheckBox flightdate_chkBox;
        private DataGridView flight_Dgv;
    }
}