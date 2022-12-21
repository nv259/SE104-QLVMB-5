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
            this.sellTicketBtn = new System.Windows.Forms.Button();
            this.makeReportBtn = new System.Windows.Forms.Button();
            this.changeRuleBtn = new System.Windows.Forms.Button();
            this.traCuuBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sellTicketBtn
            // 
            this.sellTicketBtn.Location = new System.Drawing.Point(28, 19);
            this.sellTicketBtn.Name = "sellTicketBtn";
            this.sellTicketBtn.Size = new System.Drawing.Size(159, 42);
            this.sellTicketBtn.TabIndex = 0;
            this.sellTicketBtn.Text = "Bán Vé";
            this.sellTicketBtn.UseVisualStyleBackColor = true;
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
            // 
            // traCuuBtn
            // 
            this.traCuuBtn.Location = new System.Drawing.Point(28, 163);
            this.traCuuBtn.Name = "traCuuBtn";
            this.traCuuBtn.Size = new System.Drawing.Size(159, 42);
            this.traCuuBtn.TabIndex = 3;
            this.traCuuBtn.Text = "Tra cứu";
            this.traCuuBtn.UseVisualStyleBackColor = true;
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 463);
            this.Controls.Add(this.traCuuBtn);
            this.Controls.Add(this.changeRuleBtn);
            this.Controls.Add(this.makeReportBtn);
            this.Controls.Add(this.sellTicketBtn);
            this.Name = "StaffForm";
            this.Text = "StaffForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Button sellTicketBtn;
        private Button makeReportBtn;
        private Button changeRuleBtn;
        private Button traCuuBtn;
    }
}