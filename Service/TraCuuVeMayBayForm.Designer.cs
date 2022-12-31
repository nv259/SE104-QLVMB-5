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
            this.SanBayDen_comboBox = new System.Windows.Forms.ComboBox();
            this.NgayBay_datetime = new System.Windows.Forms.DateTimePicker();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.ChuyenBay_comboBox = new System.Windows.Forms.ComboBox();
            this.SanBayDi_comboBox = new System.Windows.Forms.ComboBox();
            this.FullInfo = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.NgayBay_chkBox = new System.Windows.Forms.CheckBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FullInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // SanBayDen_comboBox
            // 
            this.SanBayDen_comboBox.FormattingEnabled = true;
            this.SanBayDen_comboBox.Location = new System.Drawing.Point(818, 139);
            this.SanBayDen_comboBox.Name = "SanBayDen_comboBox";
            this.SanBayDen_comboBox.Size = new System.Drawing.Size(250, 28);
            this.SanBayDen_comboBox.TabIndex = 7;
            this.SanBayDen_comboBox.TabStop = false;
            this.SanBayDen_comboBox.SelectedIndexChanged += new System.EventHandler(this.SanBayDen_comboBox_SelectedIndexChanged);
            // 
            // NgayBay_datetime
            // 
            this.NgayBay_datetime.Location = new System.Drawing.Point(840, 84);
            this.NgayBay_datetime.Name = "NgayBay_datetime";
            this.NgayBay_datetime.Size = new System.Drawing.Size(228, 27);
            this.NgayBay_datetime.TabIndex = 9;
            this.NgayBay_datetime.ValueChanged += new System.EventHandler(this.NgayBay_datetime_ValueChanged);
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.White;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Location = new System.Drawing.Point(699, 142);
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
            this.textBox8.Location = new System.Drawing.Point(26, 142);
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
            this.textBox9.Location = new System.Drawing.Point(699, 87);
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
            // ChuyenBay_comboBox
            // 
            this.ChuyenBay_comboBox.FormattingEnabled = true;
            this.ChuyenBay_comboBox.Location = new System.Drawing.Point(139, 84);
            this.ChuyenBay_comboBox.Name = "ChuyenBay_comboBox";
            this.ChuyenBay_comboBox.Size = new System.Drawing.Size(250, 28);
            this.ChuyenBay_comboBox.TabIndex = 21;
            this.ChuyenBay_comboBox.SelectedIndexChanged += new System.EventHandler(this.ChuyenBay_comboBox_SelectedIndexChanged);
            // 
            // SanBayDi_comboBox
            // 
            this.SanBayDi_comboBox.FormattingEnabled = true;
            this.SanBayDi_comboBox.Location = new System.Drawing.Point(139, 139);
            this.SanBayDi_comboBox.Name = "SanBayDi_comboBox";
            this.SanBayDi_comboBox.Size = new System.Drawing.Size(250, 28);
            this.SanBayDi_comboBox.TabIndex = 22;
            this.SanBayDi_comboBox.SelectedIndexChanged += new System.EventHandler(this.SanBayDi_comboBox_SelectedIndexChanged);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FullInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.FullInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FullInfo.DefaultCellStyle = dataGridViewCellStyle2;
            this.FullInfo.EnableHeadersVisualStyles = false;
            this.FullInfo.GridColor = System.Drawing.Color.White;
            this.FullInfo.Location = new System.Drawing.Point(38, 186);
            this.FullInfo.MultiSelect = false;
            this.FullInfo.Name = "FullInfo";
            this.FullInfo.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FullInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.FullInfo.RowHeadersVisible = false;
            this.FullInfo.RowHeadersWidth = 51;
            this.FullInfo.RowTemplate.Height = 29;
            this.FullInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FullInfo.Size = new System.Drawing.Size(1030, 506);
            this.FullInfo.TabIndex = 23;
            this.FullInfo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            this.label1.Location = new System.Drawing.Point(383, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 50);
            this.label1.TabIndex = 24;
            this.label1.Text = "TRA CỨU VÉ MÁY BAY";
            // 
            // NgayBay_chkBox
            // 
            this.NgayBay_chkBox.AutoSize = true;
            this.NgayBay_chkBox.Location = new System.Drawing.Point(816, 90);
            this.NgayBay_chkBox.Name = "NgayBay_chkBox";
            this.NgayBay_chkBox.Size = new System.Drawing.Size(18, 17);
            this.NgayBay_chkBox.TabIndex = 46;
            this.NgayBay_chkBox.UseVisualStyleBackColor = true;
            this.NgayBay_chkBox.CheckedChanged += new System.EventHandler(this.NgayBay_chkBox_CheckedChanged);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Red;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Location = new System.Drawing.Point(971, 657);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(97, 35);
            this.deleteBtn.TabIndex = 47;
            this.deleteBtn.Text = "Hủy Vé";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // TraCuuVeMayBayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1099, 704);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.NgayBay_chkBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FullInfo);
            this.Controls.Add(this.SanBayDi_comboBox);
            this.Controls.Add(this.ChuyenBay_comboBox);
            this.Controls.Add(this.textBox16);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.NgayBay_datetime);
            this.Controls.Add(this.SanBayDen_comboBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TraCuuVeMayBayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tra cứu vé máy bay";
            ((System.ComponentModel.ISupportInitialize)(this.FullInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComboBox SanBayDen_comboBox;
        private DateTimePicker NgayBay_datetime;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox16;
        private ComboBox ChuyenBay_comboBox;
        private ComboBox SanBayDi_comboBox;
        private DataGridView FullInfo;
        private Label label1;
        private CheckBox NgayBay_chkBox;
        private Button deleteBtn;
    }
}