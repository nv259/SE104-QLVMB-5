namespace Service
{
    partial class DatVeForm
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
            this.flightListLstBox = new System.Windows.Forms.ListBox();
            this.fromComboBox = new System.Windows.Forms.ComboBox();
            this.toComboBox = new System.Windows.Forms.ComboBox();
            this.ngayBayDtp = new System.Windows.Forms.DateTimePicker();
            this.flightInfoLstBox = new System.Windows.Forms.ListBox();
            this.infoTicketLstBox = new System.Windows.Forms.ListBox();
            this.ticketPickComboBox = new System.Windows.Forms.ComboBox();
            this.datVeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flightListLstBox
            // 
            this.flightListLstBox.FormattingEnabled = true;
            this.flightListLstBox.ItemHeight = 20;
            this.flightListLstBox.Location = new System.Drawing.Point(45, 101);
            this.flightListLstBox.Name = "flightListLstBox";
            this.flightListLstBox.Size = new System.Drawing.Size(339, 424);
            this.flightListLstBox.TabIndex = 0;
            // 
            // fromComboBox
            // 
            this.fromComboBox.FormattingEnabled = true;
            this.fromComboBox.Location = new System.Drawing.Point(45, 32);
            this.fromComboBox.Name = "fromComboBox";
            this.fromComboBox.Size = new System.Drawing.Size(157, 28);
            this.fromComboBox.TabIndex = 1;
            this.fromComboBox.Text = "Bay từ";
            // 
            // toComboBox
            // 
            this.toComboBox.FormattingEnabled = true;
            this.toComboBox.Location = new System.Drawing.Point(224, 32);
            this.toComboBox.Name = "toComboBox";
            this.toComboBox.Size = new System.Drawing.Size(160, 28);
            this.toComboBox.TabIndex = 2;
            this.toComboBox.Text = "Bay đến";
            // 
            // ngayBayDtp
            // 
            this.ngayBayDtp.Location = new System.Drawing.Point(45, 66);
            this.ngayBayDtp.Name = "ngayBayDtp";
            this.ngayBayDtp.Size = new System.Drawing.Size(339, 27);
            this.ngayBayDtp.TabIndex = 3;
            this.ngayBayDtp.Value = new System.DateTime(2022, 12, 20, 10, 39, 37, 0);
            // 
            // flightInfoLstBox
            // 
            this.flightInfoLstBox.FormattingEnabled = true;
            this.flightInfoLstBox.ItemHeight = 20;
            this.flightInfoLstBox.Location = new System.Drawing.Point(420, 34);
            this.flightInfoLstBox.Name = "flightInfoLstBox";
            this.flightInfoLstBox.Size = new System.Drawing.Size(309, 184);
            this.flightInfoLstBox.TabIndex = 4;
            // 
            // infoTicketLstBox
            // 
            this.infoTicketLstBox.FormattingEnabled = true;
            this.infoTicketLstBox.ItemHeight = 20;
            this.infoTicketLstBox.Location = new System.Drawing.Point(422, 241);
            this.infoTicketLstBox.Name = "infoTicketLstBox";
            this.infoTicketLstBox.Size = new System.Drawing.Size(306, 104);
            this.infoTicketLstBox.TabIndex = 5;
            // 
            // ticketPickComboBox
            // 
            this.ticketPickComboBox.FormattingEnabled = true;
            this.ticketPickComboBox.Location = new System.Drawing.Point(427, 358);
            this.ticketPickComboBox.Name = "ticketPickComboBox";
            this.ticketPickComboBox.Size = new System.Drawing.Size(296, 28);
            this.ticketPickComboBox.TabIndex = 6;
            this.ticketPickComboBox.Text = "Chọn loại vé";
            // 
            // datVeBtn
            // 
            this.datVeBtn.Location = new System.Drawing.Point(503, 434);
            this.datVeBtn.Name = "datVeBtn";
            this.datVeBtn.Size = new System.Drawing.Size(158, 62);
            this.datVeBtn.TabIndex = 7;
            this.datVeBtn.Text = "Đặt vé";
            this.datVeBtn.UseVisualStyleBackColor = true;
            // 
            // DatVeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 549);
            this.Controls.Add(this.datVeBtn);
            this.Controls.Add(this.ticketPickComboBox);
            this.Controls.Add(this.infoTicketLstBox);
            this.Controls.Add(this.flightInfoLstBox);
            this.Controls.Add(this.ngayBayDtp);
            this.Controls.Add(this.toComboBox);
            this.Controls.Add(this.fromComboBox);
            this.Controls.Add(this.flightListLstBox);
            this.Name = "DatVeForm";
            this.Text = "Đặt vé";
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox flightListLstBox;
        private ComboBox fromComboBox;
        private ComboBox toComboBox;
        private DateTimePicker ngayBayDtp;
        private ListBox flightInfoLstBox;
        private ListBox infoTicketLstBox;
        private ComboBox ticketPickComboBox;
        private Button datVeBtn;
    }
}