namespace Service
{
    partial class StaffForm
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
            this.RecordFlightBtn = new System.Windows.Forms.Button();
            this.makeReportBtn = new System.Windows.Forms.Button();
            this.changeRuleBtn = new System.Windows.Forms.Button();
            this.traCuuBtn = new System.Windows.Forms.Button();
            this.saleBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RecordFlightBtn
            // 
            this.RecordFlightBtn.Location = new System.Drawing.Point(28, 19);
            this.RecordFlightBtn.Name = "RecordFlightBtn";
            this.RecordFlightBtn.Size = new System.Drawing.Size(159, 42);
            this.RecordFlightBtn.TabIndex = 0;
            this.RecordFlightBtn.Text = "Ghi nhận chuyến bay";
            this.RecordFlightBtn.UseVisualStyleBackColor = true;
            this.RecordFlightBtn.Click += new System.EventHandler(this.RecordFlightBtn_Click);
            // 
            // makeReportBtn
            // 
            this.makeReportBtn.Location = new System.Drawing.Point(28, 67);
            this.makeReportBtn.Name = "makeReportBtn";
            this.makeReportBtn.Size = new System.Drawing.Size(159, 42);
            this.makeReportBtn.TabIndex = 1;
            this.makeReportBtn.Text = "Lập Báo Cáo";
            this.makeReportBtn.UseVisualStyleBackColor = true;
            this.makeReportBtn.Click += new System.EventHandler(this.makeReportBtn_Click);
            // 
            // changeRuleBtn
            // 
            this.changeRuleBtn.Location = new System.Drawing.Point(28, 115);
            this.changeRuleBtn.Name = "changeRuleBtn";
            this.changeRuleBtn.Size = new System.Drawing.Size(159, 42);
            this.changeRuleBtn.TabIndex = 2;
            this.changeRuleBtn.Text = "Thay đổi quy định";
            this.changeRuleBtn.UseVisualStyleBackColor = true;
            this.changeRuleBtn.Click += new System.EventHandler(this.changeRuleBtn_Click);
            // 
            // traCuuBtn
            // 
            this.traCuuBtn.Location = new System.Drawing.Point(28, 163);
            this.traCuuBtn.Name = "traCuuBtn";
            this.traCuuBtn.Size = new System.Drawing.Size(159, 42);
            this.traCuuBtn.TabIndex = 3;
            this.traCuuBtn.Text = "Tra cứu";
            this.traCuuBtn.UseVisualStyleBackColor = true;
            this.traCuuBtn.Click += new System.EventHandler(this.traCuuBtn_Click);
            // 
            // saleBtn
            // 
            this.saleBtn.Location = new System.Drawing.Point(28, 211);
            this.saleBtn.Name = "saleBtn";
            this.saleBtn.Size = new System.Drawing.Size(159, 42);
            this.saleBtn.TabIndex = 4;
            this.saleBtn.Text = "Bán vé";
            this.saleBtn.UseVisualStyleBackColor = true;
            this.saleBtn.Click += new System.EventHandler(this.saleBtn_Click);
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 262);
            this.Controls.Add(this.saleBtn);
            this.Controls.Add(this.traCuuBtn);
            this.Controls.Add(this.changeRuleBtn);
            this.Controls.Add(this.makeReportBtn);
            this.Controls.Add(this.RecordFlightBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StaffForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Button RecordFlightBtn;
        private Button makeReportBtn;
        private Button changeRuleBtn;
        private Button traCuuBtn;
        private Button saleBtn;
    }
}