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
            this.infoPnl = new System.Windows.Forms.Panel();
            this.sellTicketBtn = new System.Windows.Forms.Button();
            this.makeReportBtn = new System.Windows.Forms.Button();
            this.searchByCustomer = new System.Windows.Forms.Button();
            this.searchByFlightBtn = new System.Windows.Forms.Button();
            this.changeRuleBtn = new System.Windows.Forms.Button();
            this.contentPnl = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // infoPnl
            // 
            this.infoPnl.Location = new System.Drawing.Point(12, 288);
            this.infoPnl.Name = "infoPnl";
            this.infoPnl.Size = new System.Drawing.Size(199, 243);
            this.infoPnl.TabIndex = 0;
            // 
            // sellTicketBtn
            // 
            this.sellTicketBtn.Location = new System.Drawing.Point(4, 18);
            this.sellTicketBtn.Name = "sellTicketBtn";
            this.sellTicketBtn.Size = new System.Drawing.Size(151, 36);
            this.sellTicketBtn.TabIndex = 1;
            this.sellTicketBtn.Text = "Bán vé";
            this.sellTicketBtn.UseVisualStyleBackColor = true;
            this.sellTicketBtn.Click += new System.EventHandler(this.sellTicketBtn_Click);
            // 
            // makeReportBtn
            // 
            this.makeReportBtn.Location = new System.Drawing.Point(4, 60);
            this.makeReportBtn.Name = "makeReportBtn";
            this.makeReportBtn.Size = new System.Drawing.Size(151, 36);
            this.makeReportBtn.TabIndex = 2;
            this.makeReportBtn.Text = "Lập báo cáo";
            this.makeReportBtn.UseVisualStyleBackColor = true;
            // 
            // searchByCustomer
            // 
            this.searchByCustomer.Location = new System.Drawing.Point(4, 102);
            this.searchByCustomer.Name = "searchByCustomer";
            this.searchByCustomer.Size = new System.Drawing.Size(151, 36);
            this.searchByCustomer.TabIndex = 3;
            this.searchByCustomer.Text = "Tra cứu theo KH";
            this.searchByCustomer.UseVisualStyleBackColor = true;
            // 
            // searchByFlightBtn
            // 
            this.searchByFlightBtn.Location = new System.Drawing.Point(4, 144);
            this.searchByFlightBtn.Name = "searchByFlightBtn";
            this.searchByFlightBtn.Size = new System.Drawing.Size(151, 36);
            this.searchByFlightBtn.TabIndex = 4;
            this.searchByFlightBtn.Text = "Tra cứu theo CBay";
            this.searchByFlightBtn.UseVisualStyleBackColor = true;
            // 
            // changeRuleBtn
            // 
            this.changeRuleBtn.Location = new System.Drawing.Point(4, 186);
            this.changeRuleBtn.Name = "changeRuleBtn";
            this.changeRuleBtn.Size = new System.Drawing.Size(151, 36);
            this.changeRuleBtn.TabIndex = 5;
            this.changeRuleBtn.Text = "Thay đổi quy định";
            this.changeRuleBtn.UseVisualStyleBackColor = true;
            // 
            // contentPnl
            // 
            this.contentPnl.Location = new System.Drawing.Point(267, 20);
            this.contentPnl.Name = "contentPnl";
            this.contentPnl.Size = new System.Drawing.Size(590, 511);
            this.contentPnl.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 36);
            this.button1.TabIndex = 7;
            this.button1.Text = "Thay đổi quy định";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 543);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.contentPnl);
            this.Controls.Add(this.changeRuleBtn);
            this.Controls.Add(this.searchByFlightBtn);
            this.Controls.Add(this.searchByCustomer);
            this.Controls.Add(this.makeReportBtn);
            this.Controls.Add(this.sellTicketBtn);
            this.Controls.Add(this.infoPnl);
            this.Name = "StaffForm";
            this.Text = "Nhân viên";
            this.ResumeLayout(false);

        }

        #endregion

        private Panel infoPnl;
        private Button sellTicketBtn;
        private Button makeReportBtn;
        private Button searchByCustomer;
        private Button searchByFlightBtn;
        private Button changeRuleBtn;
        private Panel contentPnl;
        private Button button1;
    }
}