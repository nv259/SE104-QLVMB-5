namespace Service
{
    partial class ReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.totalIncome = new System.Windows.Forms.TextBox();
            this.exportToExcelBtn = new System.Windows.Forms.Button();
            this.monthComboBox = new System.Windows.Forms.ComboBox();
            this.reportYearBtn = new System.Windows.Forms.Button();
            this.reportMonthBtn = new System.Windows.Forms.Button();
            this.makeReportBtn = new System.Windows.Forms.Button();
            this.yearTxtBox = new System.Windows.Forms.TextBox();
            this.reportMonthDgv = new System.Windows.Forms.DataGridView();
            this.reportYearDgv = new System.Windows.Forms.DataGridView();
            this.Report_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.reportMonthDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportYearDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(728, 483);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(113, 20);
            this.textBox1.TabIndex = 17;
            this.textBox1.Text = "Tổng doanh thu:";
            // 
            // totalIncome
            // 
            this.totalIncome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalIncome.Location = new System.Drawing.Point(847, 481);
            this.totalIncome.Name = "totalIncome";
            this.totalIncome.Size = new System.Drawing.Size(194, 27);
            this.totalIncome.TabIndex = 16;
            // 
            // exportToExcelBtn
            // 
            this.exportToExcelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            this.exportToExcelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportToExcelBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exportToExcelBtn.ForeColor = System.Drawing.Color.White;
            this.exportToExcelBtn.Location = new System.Drawing.Point(870, 514);
            this.exportToExcelBtn.Name = "exportToExcelBtn";
            this.exportToExcelBtn.Size = new System.Drawing.Size(171, 31);
            this.exportToExcelBtn.TabIndex = 14;
            this.exportToExcelBtn.Text = "Chuyển sang file Excel";
            this.exportToExcelBtn.UseVisualStyleBackColor = false;
            this.exportToExcelBtn.Click += new System.EventHandler(this.exportToExcelBtn_Click);
            // 
            // monthComboBox
            // 
            this.monthComboBox.FormattingEnabled = true;
            this.monthComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.monthComboBox.Location = new System.Drawing.Point(189, 160);
            this.monthComboBox.Name = "monthComboBox";
            this.monthComboBox.Size = new System.Drawing.Size(88, 28);
            this.monthComboBox.TabIndex = 11;
            this.monthComboBox.Text = "Tháng";
            // 
            // reportYearBtn
            // 
            this.reportYearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            this.reportYearBtn.ForeColor = System.Drawing.Color.White;
            this.reportYearBtn.Location = new System.Drawing.Point(142, 114);
            this.reportYearBtn.Name = "reportYearBtn";
            this.reportYearBtn.Size = new System.Drawing.Size(135, 40);
            this.reportYearBtn.TabIndex = 10;
            this.reportYearBtn.Text = "Báo cáo năm";
            this.reportYearBtn.UseVisualStyleBackColor = false;
            this.reportYearBtn.Click += new System.EventHandler(this.reportYearBtn_Click);
            // 
            // reportMonthBtn
            // 
            this.reportMonthBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            this.reportMonthBtn.ForeColor = System.Drawing.Color.White;
            this.reportMonthBtn.Location = new System.Drawing.Point(12, 114);
            this.reportMonthBtn.Name = "reportMonthBtn";
            this.reportMonthBtn.Size = new System.Drawing.Size(124, 40);
            this.reportMonthBtn.TabIndex = 9;
            this.reportMonthBtn.Text = "Báo cáo tháng";
            this.reportMonthBtn.UseVisualStyleBackColor = false;
            this.reportMonthBtn.Click += new System.EventHandler(this.reportMonthBtn_Click);
            // 
            // makeReportBtn
            // 
            this.makeReportBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            this.makeReportBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.makeReportBtn.ForeColor = System.Drawing.Color.White;
            this.makeReportBtn.Location = new System.Drawing.Point(12, 194);
            this.makeReportBtn.Name = "makeReportBtn";
            this.makeReportBtn.Size = new System.Drawing.Size(265, 39);
            this.makeReportBtn.TabIndex = 18;
            this.makeReportBtn.Text = "Lập báo cáo";
            this.makeReportBtn.UseVisualStyleBackColor = false;
            this.makeReportBtn.Click += new System.EventHandler(this.makeReportBtn_Click);
            // 
            // yearTxtBox
            // 
            this.yearTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yearTxtBox.Location = new System.Drawing.Point(12, 161);
            this.yearTxtBox.Name = "yearTxtBox";
            this.yearTxtBox.PlaceholderText = "  Năm";
            this.yearTxtBox.Size = new System.Drawing.Size(171, 27);
            this.yearTxtBox.TabIndex = 19;
            // 
            // reportMonthDgv
            // 
            this.reportMonthDgv.AllowUserToAddRows = false;
            this.reportMonthDgv.AllowUserToDeleteRows = false;
            this.reportMonthDgv.AllowUserToResizeColumns = false;
            this.reportMonthDgv.AllowUserToResizeRows = false;
            this.reportMonthDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.reportMonthDgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.reportMonthDgv.BackgroundColor = System.Drawing.Color.White;
            this.reportMonthDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportMonthDgv.EnableHeadersVisualStyles = false;
            this.reportMonthDgv.Location = new System.Drawing.Point(283, 114);
            this.reportMonthDgv.MultiSelect = false;
            this.reportMonthDgv.Name = "reportMonthDgv";
            this.reportMonthDgv.ReadOnly = true;
            this.reportMonthDgv.RowHeadersWidth = 51;
            this.reportMonthDgv.RowTemplate.Height = 29;
            this.reportMonthDgv.Size = new System.Drawing.Size(758, 361);
            this.reportMonthDgv.TabIndex = 20;
            this.reportMonthDgv.TabStop = false;
            // 
            // reportYearDgv
            // 
            this.reportYearDgv.AllowUserToAddRows = false;
            this.reportYearDgv.AllowUserToDeleteRows = false;
            this.reportYearDgv.AllowUserToResizeColumns = false;
            this.reportYearDgv.AllowUserToResizeRows = false;
            this.reportYearDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.reportYearDgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.reportYearDgv.BackgroundColor = System.Drawing.Color.White;
            this.reportYearDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportYearDgv.EnableHeadersVisualStyles = false;
            this.reportYearDgv.Location = new System.Drawing.Point(283, 114);
            this.reportYearDgv.MultiSelect = false;
            this.reportYearDgv.Name = "reportYearDgv";
            this.reportYearDgv.ReadOnly = true;
            this.reportYearDgv.RowHeadersWidth = 51;
            this.reportYearDgv.RowTemplate.Height = 29;
            this.reportYearDgv.Size = new System.Drawing.Size(758, 361);
            this.reportYearDgv.TabIndex = 21;
            this.reportYearDgv.TabStop = false;
            // 
            // Report_label
            // 
            this.Report_label.AutoSize = true;
            this.Report_label.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Report_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            this.Report_label.Location = new System.Drawing.Point(400, 21);
            this.Report_label.Name = "Report_label";
            this.Report_label.Size = new System.Drawing.Size(265, 50);
            this.Report_label.TabIndex = 22;
            this.Report_label.Text = "LẬP BÁO CÁO";
            // 
            // ReportForm
            // 
            this.AcceptButton = this.makeReportBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1053, 557);
            this.Controls.Add(this.exportToExcelBtn);
            this.Controls.Add(this.Report_label);
            this.Controls.Add(this.reportYearDgv);
            this.Controls.Add(this.reportMonthDgv);
            this.Controls.Add(this.yearTxtBox);
            this.Controls.Add(this.makeReportBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.totalIncome);
            this.Controls.Add(this.monthComboBox);
            this.Controls.Add(this.reportYearBtn);
            this.Controls.Add(this.reportMonthBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ReportForm";
            this.Text = "Lập báo cáo";
            ((System.ComponentModel.ISupportInitialize)(this.reportMonthDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportYearDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private TextBox totalIncome;
        private Button exportToExcelBtn;
        private ComboBox monthComboBox;
        private Button reportYearBtn;
        private Button reportMonthBtn;
        private Button makeReportBtn;
        private TextBox yearTxtBox;
        private DataGridView reportMonthDgv;
        private DataGridView reportYearDgv;
        private Label label1;
        private Label Report_label;
    }
}