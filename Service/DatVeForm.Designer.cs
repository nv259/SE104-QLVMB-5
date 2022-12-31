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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatVeForm));
            this.flightListLstBox = new System.Windows.Forms.ListBox();
            this.fromComboBox = new System.Windows.Forms.ComboBox();
            this.toComboBox = new System.Windows.Forms.ComboBox();
            this.ngayBayDtp = new System.Windows.Forms.DateTimePicker();
            this.airportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filterPnl = new System.Windows.Forms.Panel();
            this.flightDtgv = new System.Windows.Forms.DataGridView();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.flightInfoPnl = new System.Windows.Forms.Panel();
            this.timeGoneTxtBox = new System.Windows.Forms.TextBox();
            this.timeGoTxtBox = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.ticketDtgv = new System.Windows.Forms.DataGridView();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.maChuyenBay_txtBox = new System.Windows.Forms.TextBox();
            this.intermediaryDtgv = new System.Windows.Forms.DataGridView();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.customInfoPnl = new System.Windows.Forms.Panel();
            this.ID_txtBox = new System.Windows.Forms.TextBox();
            this.ngSinhBox = new System.Windows.Forms.DateTimePicker();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.phone_txtBox = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.name_txtBox = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.bookingBtn = new System.Windows.Forms.Button();
            this.textBox13 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.airportBindingSource)).BeginInit();
            this.filterPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flightDtgv)).BeginInit();
            this.panel2.SuspendLayout();
            this.flightInfoPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketDtgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intermediaryDtgv)).BeginInit();
            this.customInfoPnl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flightListLstBox
            // 
            this.flightListLstBox.Enabled = false;
            this.flightListLstBox.FormattingEnabled = true;
            this.flightListLstBox.ItemHeight = 20;
            this.flightListLstBox.Location = new System.Drawing.Point(1097, 505);
            this.flightListLstBox.Name = "flightListLstBox";
            this.flightListLstBox.Size = new System.Drawing.Size(473, 384);
            this.flightListLstBox.TabIndex = 0;
            this.flightListLstBox.Visible = false;
            // 
            // fromComboBox
            // 
            this.fromComboBox.FormattingEnabled = true;
            this.fromComboBox.Location = new System.Drawing.Point(12, 51);
            this.fromComboBox.Name = "fromComboBox";
            this.fromComboBox.Size = new System.Drawing.Size(251, 28);
            this.fromComboBox.TabIndex = 1;
            this.fromComboBox.SelectedIndexChanged += new System.EventHandler(this.fromComboBox_SelectedIndexChanged);
            // 
            // toComboBox
            // 
            this.toComboBox.FormattingEnabled = true;
            this.toComboBox.Location = new System.Drawing.Point(306, 50);
            this.toComboBox.Name = "toComboBox";
            this.toComboBox.Size = new System.Drawing.Size(253, 28);
            this.toComboBox.TabIndex = 2;
            this.toComboBox.SelectedIndexChanged += new System.EventHandler(this.toComboBox_SelectedIndexChanged);
            // 
            // ngayBayDtp
            // 
            this.ngayBayDtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ngayBayDtp.Location = new System.Drawing.Point(159, 101);
            this.ngayBayDtp.Name = "ngayBayDtp";
            this.ngayBayDtp.Size = new System.Drawing.Size(400, 27);
            this.ngayBayDtp.TabIndex = 3;
            this.ngayBayDtp.Value = new System.DateTime(2022, 12, 31, 15, 0, 6, 969);
            this.ngayBayDtp.ValueChanged += new System.EventHandler(this.ngayBayDtp_ValueChanged);
            // 
            // airportBindingSource
            // 
            this.airportBindingSource.DataSource = typeof(DataAccess.DTO.Airport);
            // 
            // filterPnl
            // 
            this.filterPnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filterPnl.Controls.Add(this.flightDtgv);
            this.filterPnl.Controls.Add(this.textBox4);
            this.filterPnl.Controls.Add(this.textBox3);
            this.filterPnl.Controls.Add(this.textBox2);
            this.filterPnl.Controls.Add(this.fromComboBox);
            this.filterPnl.Controls.Add(this.toComboBox);
            this.filterPnl.Controls.Add(this.ngayBayDtp);
            this.filterPnl.Location = new System.Drawing.Point(10, 31);
            this.filterPnl.Name = "filterPnl";
            this.filterPnl.Size = new System.Drawing.Size(564, 347);
            this.filterPnl.TabIndex = 8;
            // 
            // flightDtgv
            // 
            this.flightDtgv.AllowUserToAddRows = false;
            this.flightDtgv.AllowUserToDeleteRows = false;
            this.flightDtgv.AllowUserToOrderColumns = true;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            this.flightDtgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.flightDtgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.flightDtgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.flightDtgv.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.flightDtgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.flightDtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.flightDtgv.Location = new System.Drawing.Point(3, 132);
            this.flightDtgv.Name = "flightDtgv";
            this.flightDtgv.ReadOnly = true;
            this.flightDtgv.RowHeadersVisible = false;
            this.flightDtgv.RowHeadersWidth = 51;
            this.flightDtgv.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.flightDtgv.RowTemplate.Height = 29;
            this.flightDtgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.flightDtgv.Size = new System.Drawing.Size(556, 210);
            this.flightDtgv.TabIndex = 14;
            this.flightDtgv.TabStop = false;
            this.flightDtgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.flightDtgv_CellClick);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.White;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            this.textBox4.Location = new System.Drawing.Point(12, 106);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(141, 20);
            this.textBox4.TabIndex = 13;
            this.textBox4.TabStop = false;
            this.textBox4.Text = "Thời gian khởi hành:";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            this.textBox3.Location = new System.Drawing.Point(306, 24);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(121, 20);
            this.textBox3.TabIndex = 12;
            this.textBox3.TabStop = false;
            this.textBox3.Text = "Sân bay đến:";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            this.textBox2.Location = new System.Drawing.Point(12, 25);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 11;
            this.textBox2.TabStop = false;
            this.textBox2.Text = "Sân bay đi:";
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(33, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(125, 35);
            this.panel2.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            this.textBox1.Location = new System.Drawing.Point(6, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(116, 27);
            this.textBox1.TabIndex = 10;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Bảng tra cứu";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.White;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            this.textBox5.Location = new System.Drawing.Point(624, 15);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(209, 27);
            this.textBox5.TabIndex = 12;
            this.textBox5.TabStop = false;
            this.textBox5.Text = "Thông tin chuyến bay";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // flightInfoPnl
            // 
            this.flightInfoPnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flightInfoPnl.Controls.Add(this.timeGoneTxtBox);
            this.flightInfoPnl.Controls.Add(this.timeGoTxtBox);
            this.flightInfoPnl.Controls.Add(this.textBox10);
            this.flightInfoPnl.Controls.Add(this.ticketDtgv);
            this.flightInfoPnl.Controls.Add(this.textBox9);
            this.flightInfoPnl.Controls.Add(this.maChuyenBay_txtBox);
            this.flightInfoPnl.Controls.Add(this.intermediaryDtgv);
            this.flightInfoPnl.Controls.Add(this.textBox6);
            this.flightInfoPnl.Controls.Add(this.textBox7);
            this.flightInfoPnl.Controls.Add(this.textBox8);
            this.flightInfoPnl.Location = new System.Drawing.Point(580, 31);
            this.flightInfoPnl.Name = "flightInfoPnl";
            this.flightInfoPnl.Size = new System.Drawing.Size(374, 562);
            this.flightInfoPnl.TabIndex = 11;
            // 
            // timeGoneTxtBox
            // 
            this.timeGoneTxtBox.BackColor = System.Drawing.Color.White;
            this.timeGoneTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeGoneTxtBox.Location = new System.Drawing.Point(195, 99);
            this.timeGoneTxtBox.Name = "timeGoneTxtBox";
            this.timeGoneTxtBox.ReadOnly = true;
            this.timeGoneTxtBox.Size = new System.Drawing.Size(173, 27);
            this.timeGoneTxtBox.TabIndex = 20;
            this.timeGoneTxtBox.TabStop = false;
            // 
            // timeGoTxtBox
            // 
            this.timeGoTxtBox.BackColor = System.Drawing.Color.White;
            this.timeGoTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeGoTxtBox.Location = new System.Drawing.Point(195, 44);
            this.timeGoTxtBox.Name = "timeGoTxtBox";
            this.timeGoTxtBox.ReadOnly = true;
            this.timeGoTxtBox.Size = new System.Drawing.Size(173, 27);
            this.timeGoTxtBox.TabIndex = 19;
            this.timeGoTxtBox.TabStop = false;
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.Color.White;
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            this.textBox10.Location = new System.Drawing.Point(4, 372);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(365, 27);
            this.textBox10.TabIndex = 18;
            this.textBox10.TabStop = false;
            this.textBox10.Text = "Hạng vé";
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ticketDtgv
            // 
            this.ticketDtgv.AllowUserToAddRows = false;
            this.ticketDtgv.AllowUserToDeleteRows = false;
            this.ticketDtgv.AllowUserToOrderColumns = true;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            this.ticketDtgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.ticketDtgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ticketDtgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.ticketDtgv.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ticketDtgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.ticketDtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ticketDtgv.Location = new System.Drawing.Point(4, 398);
            this.ticketDtgv.Name = "ticketDtgv";
            this.ticketDtgv.ReadOnly = true;
            this.ticketDtgv.RowHeadersVisible = false;
            this.ticketDtgv.RowHeadersWidth = 51;
            this.ticketDtgv.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ticketDtgv.RowTemplate.Height = 29;
            this.ticketDtgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ticketDtgv.Size = new System.Drawing.Size(365, 158);
            this.ticketDtgv.TabIndex = 17;
            this.ticketDtgv.TabStop = false;
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.White;
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            this.textBox9.Location = new System.Drawing.Point(4, 162);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(365, 27);
            this.textBox9.TabIndex = 16;
            this.textBox9.TabStop = false;
            this.textBox9.Text = "Sân bay trung gian";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // maChuyenBay_txtBox
            // 
            this.maChuyenBay_txtBox.BackColor = System.Drawing.Color.White;
            this.maChuyenBay_txtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maChuyenBay_txtBox.Location = new System.Drawing.Point(12, 44);
            this.maChuyenBay_txtBox.Name = "maChuyenBay_txtBox";
            this.maChuyenBay_txtBox.ReadOnly = true;
            this.maChuyenBay_txtBox.Size = new System.Drawing.Size(150, 27);
            this.maChuyenBay_txtBox.TabIndex = 15;
            this.maChuyenBay_txtBox.TabStop = false;
            // 
            // intermediaryDtgv
            // 
            this.intermediaryDtgv.AllowUserToAddRows = false;
            this.intermediaryDtgv.AllowUserToDeleteRows = false;
            this.intermediaryDtgv.AllowUserToOrderColumns = true;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            this.intermediaryDtgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.intermediaryDtgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.intermediaryDtgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.intermediaryDtgv.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.intermediaryDtgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.intermediaryDtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.intermediaryDtgv.Location = new System.Drawing.Point(4, 188);
            this.intermediaryDtgv.Name = "intermediaryDtgv";
            this.intermediaryDtgv.ReadOnly = true;
            this.intermediaryDtgv.RowHeadersVisible = false;
            this.intermediaryDtgv.RowHeadersWidth = 51;
            this.intermediaryDtgv.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.intermediaryDtgv.RowTemplate.Height = 29;
            this.intermediaryDtgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.intermediaryDtgv.Size = new System.Drawing.Size(365, 158);
            this.intermediaryDtgv.TabIndex = 14;
            this.intermediaryDtgv.TabStop = false;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.White;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            this.textBox6.Location = new System.Drawing.Point(195, 18);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(141, 20);
            this.textBox6.TabIndex = 13;
            this.textBox6.TabStop = false;
            this.textBox6.Text = "Giờ khởi hành";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.White;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            this.textBox7.Location = new System.Drawing.Point(195, 77);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(121, 20);
            this.textBox7.TabIndex = 12;
            this.textBox7.TabStop = false;
            this.textBox7.Text = "Giờ đến";
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.White;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            this.textBox8.Location = new System.Drawing.Point(12, 18);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(121, 20);
            this.textBox8.TabIndex = 11;
            this.textBox8.TabStop = false;
            this.textBox8.Text = "Chuyến bay:";
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.Color.White;
            this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            this.textBox11.Location = new System.Drawing.Point(24, 389);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(209, 27);
            this.textBox11.TabIndex = 14;
            this.textBox11.TabStop = false;
            this.textBox11.Text = "Thông tin khách hàng";
            this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // customInfoPnl
            // 
            this.customInfoPnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customInfoPnl.Controls.Add(this.ID_txtBox);
            this.customInfoPnl.Controls.Add(this.ngSinhBox);
            this.customInfoPnl.Controls.Add(this.textBox15);
            this.customInfoPnl.Controls.Add(this.phone_txtBox);
            this.customInfoPnl.Controls.Add(this.textBox12);
            this.customInfoPnl.Controls.Add(this.name_txtBox);
            this.customInfoPnl.Controls.Add(this.textBox16);
            this.customInfoPnl.Controls.Add(this.textBox17);
            this.customInfoPnl.Location = new System.Drawing.Point(10, 404);
            this.customInfoPnl.Name = "customInfoPnl";
            this.customInfoPnl.Size = new System.Drawing.Size(394, 189);
            this.customInfoPnl.TabIndex = 13;
            // 
            // ID_txtBox
            // 
            this.ID_txtBox.BackColor = System.Drawing.Color.White;
            this.ID_txtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ID_txtBox.Location = new System.Drawing.Point(226, 51);
            this.ID_txtBox.Name = "ID_txtBox";
            this.ID_txtBox.ReadOnly = true;
            this.ID_txtBox.Size = new System.Drawing.Size(163, 27);
            this.ID_txtBox.TabIndex = 20;
            this.ID_txtBox.TabStop = false;
            // 
            // ngSinhBox
            // 
            this.ngSinhBox.CustomFormat = "MM/dd/yyyy";
            this.ngSinhBox.Enabled = false;
            this.ngSinhBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ngSinhBox.Location = new System.Drawing.Point(11, 125);
            this.ngSinhBox.Name = "ngSinhBox";
            this.ngSinhBox.Size = new System.Drawing.Size(194, 27);
            this.ngSinhBox.TabIndex = 19;
            this.ngSinhBox.TabStop = false;
            this.ngSinhBox.Value = new System.DateTime(2022, 12, 21, 12, 43, 4, 0);
            // 
            // textBox15
            // 
            this.textBox15.BackColor = System.Drawing.Color.White;
            this.textBox15.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            this.textBox15.Location = new System.Drawing.Point(12, 99);
            this.textBox15.Name = "textBox15";
            this.textBox15.ReadOnly = true;
            this.textBox15.Size = new System.Drawing.Size(98, 20);
            this.textBox15.TabIndex = 18;
            this.textBox15.TabStop = false;
            this.textBox15.Text = "Ngày sinh:";
            // 
            // phone_txtBox
            // 
            this.phone_txtBox.BackColor = System.Drawing.Color.White;
            this.phone_txtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phone_txtBox.Location = new System.Drawing.Point(226, 125);
            this.phone_txtBox.Name = "phone_txtBox";
            this.phone_txtBox.ReadOnly = true;
            this.phone_txtBox.Size = new System.Drawing.Size(163, 27);
            this.phone_txtBox.TabIndex = 17;
            this.phone_txtBox.TabStop = false;
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.Color.White;
            this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            this.textBox12.Location = new System.Drawing.Point(226, 99);
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(121, 20);
            this.textBox12.TabIndex = 16;
            this.textBox12.TabStop = false;
            this.textBox12.Text = "Số điện thoại:";
            // 
            // name_txtBox
            // 
            this.name_txtBox.BackColor = System.Drawing.Color.White;
            this.name_txtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name_txtBox.Location = new System.Drawing.Point(12, 51);
            this.name_txtBox.Name = "name_txtBox";
            this.name_txtBox.ReadOnly = true;
            this.name_txtBox.Size = new System.Drawing.Size(193, 27);
            this.name_txtBox.TabIndex = 15;
            this.name_txtBox.TabStop = false;
            // 
            // textBox16
            // 
            this.textBox16.BackColor = System.Drawing.Color.White;
            this.textBox16.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox16.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            this.textBox16.Location = new System.Drawing.Point(226, 25);
            this.textBox16.Name = "textBox16";
            this.textBox16.ReadOnly = true;
            this.textBox16.Size = new System.Drawing.Size(163, 20);
            this.textBox16.TabIndex = 12;
            this.textBox16.TabStop = false;
            this.textBox16.Text = "Thẻ căn cước/CMND:";
            // 
            // textBox17
            // 
            this.textBox17.BackColor = System.Drawing.Color.White;
            this.textBox17.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox17.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            this.textBox17.Location = new System.Drawing.Point(12, 25);
            this.textBox17.Name = "textBox17";
            this.textBox17.ReadOnly = true;
            this.textBox17.Size = new System.Drawing.Size(98, 20);
            this.textBox17.TabIndex = 11;
            this.textBox17.TabStop = false;
            this.textBox17.Text = "Họ và tên:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ExitBtn);
            this.panel1.Controls.Add(this.resetBtn);
            this.panel1.Controls.Add(this.bookingBtn);
            this.panel1.Location = new System.Drawing.Point(406, 404);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 189);
            this.panel1.TabIndex = 15;
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ExitBtn.Location = new System.Drawing.Point(12, 114);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(137, 33);
            this.ExitBtn.TabIndex = 2;
            this.ExitBtn.Text = "Đóng";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            this.resetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resetBtn.ForeColor = System.Drawing.Color.White;
            this.resetBtn.Location = new System.Drawing.Point(12, 71);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(137, 33);
            this.resetBtn.TabIndex = 1;
            this.resetBtn.Text = "Hủy";
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // bookingBtn
            // 
            this.bookingBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            this.bookingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bookingBtn.ForeColor = System.Drawing.Color.White;
            this.bookingBtn.Location = new System.Drawing.Point(12, 25);
            this.bookingBtn.Name = "bookingBtn";
            this.bookingBtn.Size = new System.Drawing.Size(137, 33);
            this.bookingBtn.TabIndex = 0;
            this.bookingBtn.Text = "Đặt Vé";
            this.bookingBtn.UseVisualStyleBackColor = false;
            this.bookingBtn.Click += new System.EventHandler(this.bookingBtn_Click);
            // 
            // textBox13
            // 
            this.textBox13.BackColor = System.Drawing.Color.White;
            this.textBox13.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            this.textBox13.Location = new System.Drawing.Point(419, 389);
            this.textBox13.Name = "textBox13";
            this.textBox13.ReadOnly = true;
            this.textBox13.Size = new System.Drawing.Size(100, 27);
            this.textBox13.TabIndex = 16;
            this.textBox13.TabStop = false;
            this.textBox13.Text = "Chức năng";
            this.textBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DatVeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(962, 605);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.customInfoPnl);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.flightInfoPnl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.filterPnl);
            this.Controls.Add(this.flightListLstBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DatVeForm";
            this.Text = "Đặt vé";
            this.Load += new System.EventHandler(this.DatVeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.airportBindingSource)).EndInit();
            this.filterPnl.ResumeLayout(false);
            this.filterPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flightDtgv)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flightInfoPnl.ResumeLayout(false);
            this.flightInfoPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketDtgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intermediaryDtgv)).EndInit();
            this.customInfoPnl.ResumeLayout(false);
            this.customInfoPnl.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox flightListLstBox;
        private ComboBox fromComboBox;
        private ComboBox toComboBox;
        private DateTimePicker ngayBayDtp;
        private BindingSource airportBindingSource;
        private Panel filterPnl;
        private Panel panel2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private DataGridView flightDtgv;
        private TextBox textBox5;
        private Panel flightInfoPnl;
        private DataGridView intermediaryDtgv;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox maChuyenBay_txtBox;
        private TextBox textBox9;
        private TextBox textBox10;
        private DataGridView ticketDtgv;
        private TextBox textBox11;
        private Panel customInfoPnl;
        private TextBox name_txtBox;
        private TextBox textBox16;
        private TextBox textBox17;
        private TextBox textBox12;
        private TextBox phone_txtBox;
        private TextBox textBox15;
        internal DateTimePicker ngSinhBox;
        private TextBox ID_txtBox;
        private Panel panel1;
        private Button bookingBtn;
        private Button resetBtn;
        private Button ExitBtn;
        private TextBox textBox13;
        private TextBox timeGoneTxtBox;
        private TextBox timeGoTxtBox;
    }
}