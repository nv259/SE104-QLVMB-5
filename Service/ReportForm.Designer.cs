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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.totalIncome = new System.Windows.Forms.TextBox();
            this.reportYearDgv = new System.Windows.Forms.DataGridView();
            this.exportToExcelBtn = new System.Windows.Forms.Button();
            this.reportMonthDgv = new System.Windows.Forms.DataGridView();
            this.monthComboBox = new System.Windows.Forms.ComboBox();
            this.reportYearBtn = new System.Windows.Forms.Button();
            this.reportMonthBtn = new System.Windows.Forms.Button();
            this.makeReportBtn = new System.Windows.Forms.Button();
            this.yearTxtBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.reportYearDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportMonthDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(549, 409);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(113, 27);
            this.textBox1.TabIndex = 17;
            this.textBox1.Text = "Tổng doanh thu:";
            // 
            // totalIncome
            // 
            this.totalIncome.Location = new System.Drawing.Point(668, 409);
            this.totalIncome.Name = "totalIncome";
            this.totalIncome.Size = new System.Drawing.Size(169, 27);
            this.totalIncome.TabIndex = 16;
            // 
            // reportYearDgv
            // 
            this.reportYearDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.reportYearDgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.reportYearDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.reportYearDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportYearDgv.Location = new System.Drawing.Point(226, 12);
            this.reportYearDgv.Name = "reportYearDgv";
            this.reportYearDgv.RowHeadersVisible = false;
            this.reportYearDgv.RowHeadersWidth = 51;
            this.reportYearDgv.RowTemplate.Height = 29;
            this.reportYearDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.reportYearDgv.Size = new System.Drawing.Size(611, 391);
            this.reportYearDgv.StandardTab = true;
            this.reportYearDgv.TabIndex = 15;
            // 
            // exportToExcelBtn
            // 
            this.exportToExcelBtn.Location = new System.Drawing.Point(226, 409);
            this.exportToExcelBtn.Name = "exportToExcelBtn";
            this.exportToExcelBtn.Size = new System.Drawing.Size(138, 27);
            this.exportToExcelBtn.TabIndex = 14;
            this.exportToExcelBtn.Text = "Export to excel";
            this.exportToExcelBtn.UseVisualStyleBackColor = true;
            this.exportToExcelBtn.Click += new System.EventHandler(this.exportToExcelBtn_Click);
            // 
            // reportMonthDgv
            // 
            this.reportMonthDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.reportMonthDgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.reportMonthDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.reportMonthDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportMonthDgv.Location = new System.Drawing.Point(226, 12);
            this.reportMonthDgv.Name = "reportMonthDgv";
            this.reportMonthDgv.RowHeadersVisible = false;
            this.reportMonthDgv.RowHeadersWidth = 51;
            this.reportMonthDgv.RowTemplate.Height = 29;
            this.reportMonthDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.reportMonthDgv.Size = new System.Drawing.Size(611, 391);
            this.reportMonthDgv.TabIndex = 13;
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
            this.monthComboBox.Location = new System.Drawing.Point(12, 127);
            this.monthComboBox.Name = "monthComboBox";
            this.monthComboBox.Size = new System.Drawing.Size(88, 28);
            this.monthComboBox.TabIndex = 11;
            this.monthComboBox.Text = "Tháng";
            // 
            // reportYearBtn
            // 
            this.reportYearBtn.Location = new System.Drawing.Point(12, 58);
            this.reportYearBtn.Name = "reportYearBtn";
            this.reportYearBtn.Size = new System.Drawing.Size(187, 40);
            this.reportYearBtn.TabIndex = 10;
            this.reportYearBtn.Text = "Báo cáo năm";
            this.reportYearBtn.UseVisualStyleBackColor = true;
            this.reportYearBtn.Click += new System.EventHandler(this.reportYearBtn_Click);
            // 
            // reportMonthBtn
            // 
            this.reportMonthBtn.Location = new System.Drawing.Point(12, 12);
            this.reportMonthBtn.Name = "reportMonthBtn";
            this.reportMonthBtn.Size = new System.Drawing.Size(187, 40);
            this.reportMonthBtn.TabIndex = 9;
            this.reportMonthBtn.Text = "Báo cáo tháng";
            this.reportMonthBtn.UseVisualStyleBackColor = true;
            this.reportMonthBtn.Click += new System.EventHandler(this.reportMonthBtn_Click);
            // 
            // makeReportBtn
            // 
            this.makeReportBtn.Location = new System.Drawing.Point(12, 183);
            this.makeReportBtn.Name = "makeReportBtn";
            this.makeReportBtn.Size = new System.Drawing.Size(187, 61);
            this.makeReportBtn.TabIndex = 18;
            this.makeReportBtn.Text = "Lập báo cáo";
            this.makeReportBtn.UseVisualStyleBackColor = true;
            this.makeReportBtn.Click += new System.EventHandler(this.makeReportBtn_Click);
            // 
            // yearTxtBox
            // 
            this.yearTxtBox.Location = new System.Drawing.Point(106, 128);
            this.yearTxtBox.Name = "yearTxtBox";
            this.yearTxtBox.PlaceholderText = "Năm";
            this.yearTxtBox.Size = new System.Drawing.Size(93, 27);
            this.yearTxtBox.TabIndex = 19;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 448);
            this.Controls.Add(this.yearTxtBox);
            this.Controls.Add(this.makeReportBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.totalIncome);
            this.Controls.Add(this.reportYearDgv);
            this.Controls.Add(this.exportToExcelBtn);
            this.Controls.Add(this.reportMonthDgv);
            this.Controls.Add(this.monthComboBox);
            this.Controls.Add(this.reportYearBtn);
            this.Controls.Add(this.reportMonthBtn);
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            ((System.ComponentModel.ISupportInitialize)(this.reportYearDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportMonthDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private TextBox totalIncome;
        private DataGridView reportYearDgv;
        private Button exportToExcelBtn;
        private DataGridView reportMonthDgv;
        private ComboBox monthComboBox;
        private Button reportYearBtn;
        private Button reportMonthBtn;
        private Button makeReportBtn;
        private TextBox yearTxtBox;
    }
}