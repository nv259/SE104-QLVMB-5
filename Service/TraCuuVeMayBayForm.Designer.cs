namespace Service
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TraCuuVeMayBayForm));
            this.to_comboBox = new System.Windows.Forms.ComboBox();
            this.flightdate_Dtp = new System.Windows.Forms.DateTimePicker();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.flight_comboBox = new System.Windows.Forms.ComboBox();
            this.from_comboBox = new System.Windows.Forms.ComboBox();
            this.bookinglist_Dgv = new System.Windows.Forms.DataGridView();
            this.LookUp_label = new System.Windows.Forms.Label();
            this.flightdate_chkBox = new System.Windows.Forms.CheckBox();
            this.delete_Btn = new System.Windows.Forms.Button();
            this.BookingDate_txtBox = new System.Windows.Forms.TextBox();
            this.bookingdate_Dtp = new System.Windows.Forms.DateTimePicker();
            this.bookingdate_chkBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.bookinglist_Dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // to_comboBox
            // 
            this.to_comboBox.FormattingEnabled = true;
            this.to_comboBox.Location = new System.Drawing.Point(139, 168);
            this.to_comboBox.Name = "to_comboBox";
            this.to_comboBox.Size = new System.Drawing.Size(250, 28);
            this.to_comboBox.TabIndex = 7;
            this.to_comboBox.TabStop = false;
            this.to_comboBox.SelectedIndexChanged += new System.EventHandler(this.to_comboBox_SelectedIndexChanged);
            // 
            // flightdate_Dtp
            // 
            this.flightdate_Dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.flightdate_Dtp.Location = new System.Drawing.Point(840, 84);
            this.flightdate_Dtp.Name = "flightdate_Dtp";
            this.flightdate_Dtp.Size = new System.Drawing.Size(228, 27);
            this.flightdate_Dtp.TabIndex = 9;
            this.flightdate_Dtp.TabStop = false;
            this.flightdate_Dtp.ValueChanged += new System.EventHandler(this.flightdate_Dtp_ValueChanged);
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.White;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Location = new System.Drawing.Point(26, 171);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(82, 20);
            this.textBox7.TabIndex = 10;
            this.textBox7.TabStop = false;
            this.textBox7.Text = "Bay đến:";
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.White;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Location = new System.Drawing.Point(26, 128);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(82, 20);
            this.textBox8.TabIndex = 11;
            this.textBox8.TabStop = false;
            this.textBox8.Text = "Bay từ:";
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.White;
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Location = new System.Drawing.Point(719, 87);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(82, 20);
            this.textBox9.TabIndex = 12;
            this.textBox9.TabStop = false;
            this.textBox9.Text = "Ngày bay:";
            // 
            // textBox16
            // 
            this.textBox16.BackColor = System.Drawing.Color.White;
            this.textBox16.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox16.Location = new System.Drawing.Point(26, 87);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(90, 20);
            this.textBox16.TabIndex = 19;
            this.textBox16.TabStop = false;
            this.textBox16.Text = "Chuyến bay:";
            // 
            // flight_comboBox
            // 
            this.flight_comboBox.FormattingEnabled = true;
            this.flight_comboBox.Location = new System.Drawing.Point(139, 84);
            this.flight_comboBox.Name = "flight_comboBox";
            this.flight_comboBox.Size = new System.Drawing.Size(250, 28);
            this.flight_comboBox.TabIndex = 21;
            this.flight_comboBox.TabStop = false;
            this.flight_comboBox.SelectedIndexChanged += new System.EventHandler(this.flight_comboBox_SelectedIndexChanged);
            // 
            // from_comboBox
            // 
            this.from_comboBox.FormattingEnabled = true;
            this.from_comboBox.Location = new System.Drawing.Point(139, 125);
            this.from_comboBox.Name = "from_comboBox";
            this.from_comboBox.Size = new System.Drawing.Size(250, 28);
            this.from_comboBox.TabIndex = 22;
            this.from_comboBox.TabStop = false;
            this.from_comboBox.SelectedIndexChanged += new System.EventHandler(this.from_comboBox_SelectedIndexChanged);
            // 
            // bookinglist_Dgv
            // 
            this.bookinglist_Dgv.AllowUserToAddRows = false;
            this.bookinglist_Dgv.AllowUserToDeleteRows = false;
            this.bookinglist_Dgv.AllowUserToResizeColumns = false;
            this.bookinglist_Dgv.AllowUserToResizeRows = false;
            this.bookinglist_Dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bookinglist_Dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.bookinglist_Dgv.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bookinglist_Dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.bookinglist_Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bookinglist_Dgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.bookinglist_Dgv.EnableHeadersVisualStyles = false;
            this.bookinglist_Dgv.GridColor = System.Drawing.Color.White;
            this.bookinglist_Dgv.Location = new System.Drawing.Point(26, 222);
            this.bookinglist_Dgv.MultiSelect = false;
            this.bookinglist_Dgv.Name = "bookinglist_Dgv";
            this.bookinglist_Dgv.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bookinglist_Dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.bookinglist_Dgv.RowHeadersVisible = false;
            this.bookinglist_Dgv.RowHeadersWidth = 51;
            this.bookinglist_Dgv.RowTemplate.Height = 29;
            this.bookinglist_Dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bookinglist_Dgv.Size = new System.Drawing.Size(1042, 470);
            this.bookinglist_Dgv.TabIndex = 23;
            this.bookinglist_Dgv.TabStop = false;
            // 
            // LookUp_label
            // 
            this.LookUp_label.AutoSize = true;
            this.LookUp_label.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LookUp_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            this.LookUp_label.Location = new System.Drawing.Point(349, 9);
            this.LookUp_label.Name = "LookUp_label";
            this.LookUp_label.Size = new System.Drawing.Size(407, 50);
            this.LookUp_label.TabIndex = 24;
            this.LookUp_label.Text = "TRA CỨU VÉ MÁY BAY";
            // 
            // flightdate_chkBox
            // 
            this.flightdate_chkBox.AutoSize = true;
            this.flightdate_chkBox.Location = new System.Drawing.Point(816, 90);
            this.flightdate_chkBox.Name = "flightdate_chkBox";
            this.flightdate_chkBox.Size = new System.Drawing.Size(18, 17);
            this.flightdate_chkBox.TabIndex = 46;
            this.flightdate_chkBox.UseVisualStyleBackColor = true;
            this.flightdate_chkBox.CheckedChanged += new System.EventHandler(this.flightdate_chkBox_CheckedChanged);
            // 
            // delete_Btn
            // 
            this.delete_Btn.BackColor = System.Drawing.Color.Red;
            this.delete_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delete_Btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.delete_Btn.ForeColor = System.Drawing.Color.White;
            this.delete_Btn.Location = new System.Drawing.Point(971, 657);
            this.delete_Btn.Name = "delete_Btn";
            this.delete_Btn.Size = new System.Drawing.Size(97, 35);
            this.delete_Btn.TabIndex = 47;
            this.delete_Btn.Text = "Hủy Vé";
            this.delete_Btn.UseVisualStyleBackColor = false;
            this.delete_Btn.Click += new System.EventHandler(this.delete_Btn_Click);
            // 
            // BookingDate_txtBox
            // 
            this.BookingDate_txtBox.BackColor = System.Drawing.Color.White;
            this.BookingDate_txtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BookingDate_txtBox.Location = new System.Drawing.Point(719, 128);
            this.BookingDate_txtBox.Name = "BookingDate_txtBox";
            this.BookingDate_txtBox.Size = new System.Drawing.Size(82, 20);
            this.BookingDate_txtBox.TabIndex = 48;
            this.BookingDate_txtBox.TabStop = false;
            this.BookingDate_txtBox.Text = "Ngày đặt vé:";
            // 
            // bookingdate_Dtp
            // 
            this.bookingdate_Dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.bookingdate_Dtp.Location = new System.Drawing.Point(840, 123);
            this.bookingdate_Dtp.Name = "bookingdate_Dtp";
            this.bookingdate_Dtp.Size = new System.Drawing.Size(228, 27);
            this.bookingdate_Dtp.TabIndex = 49;
            this.bookingdate_Dtp.TabStop = false;
            this.bookingdate_Dtp.ValueChanged += new System.EventHandler(this.bookingdate_Dtp_ValueChanged);
            // 
            // bookingdate_chkBox
            // 
            this.bookingdate_chkBox.AutoSize = true;
            this.bookingdate_chkBox.Location = new System.Drawing.Point(816, 131);
            this.bookingdate_chkBox.Name = "bookingdate_chkBox";
            this.bookingdate_chkBox.Size = new System.Drawing.Size(18, 17);
            this.bookingdate_chkBox.TabIndex = 50;
            this.bookingdate_chkBox.UseVisualStyleBackColor = true;
            this.bookingdate_chkBox.CheckedChanged += new System.EventHandler(this.bookingdate_chkBox_CheckedChanged);
            // 
            // TraCuuVeMayBayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1099, 704);
            this.Controls.Add(this.bookingdate_chkBox);
            this.Controls.Add(this.bookingdate_Dtp);
            this.Controls.Add(this.BookingDate_txtBox);
            this.Controls.Add(this.delete_Btn);
            this.Controls.Add(this.flightdate_chkBox);
            this.Controls.Add(this.LookUp_label);
            this.Controls.Add(this.bookinglist_Dgv);
            this.Controls.Add(this.from_comboBox);
            this.Controls.Add(this.flight_comboBox);
            this.Controls.Add(this.textBox16);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.flightdate_Dtp);
            this.Controls.Add(this.to_comboBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TraCuuVeMayBayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tra cứu vé máy bay";
            ((System.ComponentModel.ISupportInitialize)(this.bookinglist_Dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComboBox to_comboBox;
        private DateTimePicker flightdate_Dtp;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox16;
        private ComboBox flight_comboBox;
        private ComboBox from_comboBox;
        private DataGridView bookinglist_Dgv;
        private Label LookUp_label;
        private CheckBox flightdate_chkBox;
        private Button delete_Btn;
        private TextBox BookingDate_txtBox;
        private DateTimePicker bookingdate_Dtp;
        private CheckBox bookingdate_chkBox;
    }
}