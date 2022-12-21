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
            this.components = new System.ComponentModel.Container();
            this.flightListLstBox = new System.Windows.Forms.ListBox();
            this.fromComboBox = new System.Windows.Forms.ComboBox();
            this.toComboBox = new System.Windows.Forms.ComboBox();
            this.ngayBayDtp = new System.Windows.Forms.DateTimePicker();
            this.infoTicketLstBox = new System.Windows.Forms.ListBox();
            this.ticketPickComboBox = new System.Windows.Forms.ComboBox();
            this.datVeBtn = new System.Windows.Forms.Button();
            this.airportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Find_Btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.airportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // flightListLstBox
            // 
            this.flightListLstBox.FormattingEnabled = true;
            this.flightListLstBox.ItemHeight = 20;
            this.flightListLstBox.Location = new System.Drawing.Point(45, 141);
            this.flightListLstBox.Name = "flightListLstBox";
            this.flightListLstBox.Size = new System.Drawing.Size(459, 384);
            this.flightListLstBox.TabIndex = 0;
            this.flightListLstBox.SelectedIndexChanged += new System.EventHandler(this.flightListLstBox_SelectedIndexChanged);
            // 
            // fromComboBox
            // 
            this.fromComboBox.FormattingEnabled = true;
            this.fromComboBox.Location = new System.Drawing.Point(45, 32);
            this.fromComboBox.Name = "fromComboBox";
            this.fromComboBox.Size = new System.Drawing.Size(212, 28);
            this.fromComboBox.TabIndex = 1;
            this.fromComboBox.SelectedIndexChanged += new System.EventHandler(this.fromComboBox_SelectedIndexChanged);
            // 
            // toComboBox
            // 
            this.toComboBox.FormattingEnabled = true;
            this.toComboBox.Location = new System.Drawing.Point(278, 32);
            this.toComboBox.Name = "toComboBox";
            this.toComboBox.Size = new System.Drawing.Size(226, 28);
            this.toComboBox.TabIndex = 2;
            this.toComboBox.Text = "Bay đến";
            this.toComboBox.SelectedIndexChanged += new System.EventHandler(this.toComboBox_SelectedIndexChanged);
            // 
            // ngayBayDtp
            // 
            this.ngayBayDtp.Location = new System.Drawing.Point(45, 66);
            this.ngayBayDtp.MinDate = new System.DateTime(2022, 12, 21, 11, 25, 7, 0);
            this.ngayBayDtp.Name = "ngayBayDtp";
            this.ngayBayDtp.Size = new System.Drawing.Size(459, 27);
            this.ngayBayDtp.TabIndex = 3;
            this.ngayBayDtp.Value = new System.DateTime(2022, 12, 21, 11, 25, 7, 0);
            this.ngayBayDtp.ValueChanged += new System.EventHandler(this.ngayBayDtp_ValueChanged);
            // 
            // infoTicketLstBox
            // 
            this.infoTicketLstBox.FormattingEnabled = true;
            this.infoTicketLstBox.ItemHeight = 20;
            this.infoTicketLstBox.Location = new System.Drawing.Point(534, 248);
            this.infoTicketLstBox.Name = "infoTicketLstBox";
            this.infoTicketLstBox.Size = new System.Drawing.Size(408, 104);
            this.infoTicketLstBox.TabIndex = 5;
            // 
            // ticketPickComboBox
            // 
            this.ticketPickComboBox.FormattingEnabled = true;
            this.ticketPickComboBox.Location = new System.Drawing.Point(534, 358);
            this.ticketPickComboBox.Name = "ticketPickComboBox";
            this.ticketPickComboBox.Size = new System.Drawing.Size(398, 28);
            this.ticketPickComboBox.TabIndex = 6;
            this.ticketPickComboBox.Text = "Chọn loại vé";
            // 
            // datVeBtn
            // 
            this.datVeBtn.Location = new System.Drawing.Point(679, 445);
            this.datVeBtn.Name = "datVeBtn";
            this.datVeBtn.Size = new System.Drawing.Size(158, 62);
            this.datVeBtn.TabIndex = 7;
            this.datVeBtn.Text = "Đặt vé";
            this.datVeBtn.UseVisualStyleBackColor = true;
            // 
            // airportBindingSource
            // 
            this.airportBindingSource.DataSource = typeof(DataAccess.DTO.Airport);
            // 
            // Find_Btn
            // 
            this.Find_Btn.Location = new System.Drawing.Point(164, 106);
            this.Find_Btn.Name = "Find_Btn";
            this.Find_Btn.Size = new System.Drawing.Size(221, 29);
            this.Find_Btn.TabIndex = 8;
            this.Find_Btn.Text = "Tìm kiếm";
            this.Find_Btn.UseVisualStyleBackColor = true;
            this.Find_Btn.Click += new System.EventHandler(this.Find_Btn_Click);
            // 
            // DatVeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 549);
            this.Controls.Add(this.Find_Btn);
            this.Controls.Add(this.datVeBtn);
            this.Controls.Add(this.ticketPickComboBox);
            this.Controls.Add(this.infoTicketLstBox);
            this.Controls.Add(this.ngayBayDtp);
            this.Controls.Add(this.toComboBox);
            this.Controls.Add(this.fromComboBox);
            this.Controls.Add(this.flightListLstBox);
            this.Name = "DatVeForm";
            this.Text = "Đặt vé";
            this.Load += new System.EventHandler(this.DatVeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.airportBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox flightListLstBox;
        private ComboBox fromComboBox;
        private ComboBox toComboBox;
        private DateTimePicker ngayBayDtp;
        private ListBox infoTicketLstBox;
        private ComboBox ticketPickComboBox;
        private Button datVeBtn;
        private BindingSource airportBindingSource;
        private Button Find_Btn;
    }
}