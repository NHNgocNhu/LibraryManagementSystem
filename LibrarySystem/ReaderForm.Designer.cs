﻿
namespace LibrarySystem
{
    partial class ReaderForm
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
            this.pnQuanLyDG = new System.Windows.Forms.Panel();
            this.dgvReaders = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbTimKiemDG = new System.Windows.Forms.TextBox();
            this.rdTenDG = new System.Windows.Forms.RadioButton();
            this.rdMaDG = new System.Windows.Forms.RadioButton();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtGmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbSoPhieu = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btLuuDG = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.btCapNhatDG = new System.Windows.Forms.Button();
            this.btXoaDG = new System.Windows.Forms.Button();
            this.btInsertReader = new System.Windows.Forms.Button();
            this.readerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.created_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnQuanLyDG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReaders)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnQuanLyDG
            // 
            this.pnQuanLyDG.Controls.Add(this.dgvReaders);
            this.pnQuanLyDG.Controls.Add(this.groupBox3);
            this.pnQuanLyDG.Controls.Add(this.groupBox8);
            this.pnQuanLyDG.Controls.Add(this.btLuuDG);
            this.pnQuanLyDG.Controls.Add(this.button1);
            this.pnQuanLyDG.Controls.Add(this.btCapNhatDG);
            this.pnQuanLyDG.Controls.Add(this.btXoaDG);
            this.pnQuanLyDG.Controls.Add(this.btInsertReader);
            this.pnQuanLyDG.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnQuanLyDG.Location = new System.Drawing.Point(2, -4);
            this.pnQuanLyDG.Name = "pnQuanLyDG";
            this.pnQuanLyDG.Size = new System.Drawing.Size(1356, 627);
            this.pnQuanLyDG.TabIndex = 11;
            // 
            // dgvReaders
            // 
            this.dgvReaders.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvReaders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReaders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.readerID,
            this.firstName,
            this.lastName,
            this.gender,
            this.dateOfBirth,
            this.gmail,
            this.address,
            this.phone,
            this.created_date});
            this.dgvReaders.Location = new System.Drawing.Point(3, 391);
            this.dgvReaders.Name = "dgvReaders";
            this.dgvReaders.ReadOnly = true;
            this.dgvReaders.RowHeadersWidth = 62;
            this.dgvReaders.RowTemplate.Height = 28;
            this.dgvReaders.Size = new System.Drawing.Size(1353, 233);
            this.dgvReaders.TabIndex = 8;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbTimKiemDG);
            this.groupBox3.Controls.Add(this.rdTenDG);
            this.groupBox3.Controls.Add(this.rdMaDG);
            this.groupBox3.Controls.Add(this.btTimKiem);
            this.groupBox3.Font = new System.Drawing.Font("Candara", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(733, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(613, 166);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm ";
            // 
            // tbTimKiemDG
            // 
            this.tbTimKiemDG.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbTimKiemDG.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.tbTimKiemDG.Location = new System.Drawing.Point(93, 113);
            this.tbTimKiemDG.Name = "tbTimKiemDG";
            this.tbTimKiemDG.Size = new System.Drawing.Size(267, 33);
            this.tbTimKiemDG.TabIndex = 7;
            // 
            // rdTenDG
            // 
            this.rdTenDG.AutoSize = true;
            this.rdTenDG.Font = new System.Drawing.Font("Candara", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdTenDG.ForeColor = System.Drawing.Color.DodgerBlue;
            this.rdTenDG.Location = new System.Drawing.Point(381, 62);
            this.rdTenDG.Name = "rdTenDG";
            this.rdTenDG.Size = new System.Drawing.Size(132, 28);
            this.rdTenDG.TabIndex = 0;
            this.rdTenDG.Text = "Tên Độc Giả";
            this.rdTenDG.UseVisualStyleBackColor = true;
            // 
            // rdMaDG
            // 
            this.rdMaDG.AutoSize = true;
            this.rdMaDG.Checked = true;
            this.rdMaDG.Font = new System.Drawing.Font("Candara", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMaDG.ForeColor = System.Drawing.Color.DodgerBlue;
            this.rdMaDG.Location = new System.Drawing.Point(23, 62);
            this.rdMaDG.Name = "rdMaDG";
            this.rdMaDG.Size = new System.Drawing.Size(127, 28);
            this.rdMaDG.TabIndex = 0;
            this.rdMaDG.TabStop = true;
            this.rdMaDG.Text = "Mã Độc Giả";
            this.rdMaDG.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.txtAddress);
            this.groupBox8.Controls.Add(this.txtGmail);
            this.groupBox8.Controls.Add(this.label6);
            this.groupBox8.Controls.Add(this.label4);
            this.groupBox8.Controls.Add(this.lbSoPhieu);
            this.groupBox8.Controls.Add(this.label5);
            this.groupBox8.Controls.Add(this.cbGender);
            this.groupBox8.Controls.Add(this.dtpDate);
            this.groupBox8.Controls.Add(this.txtPhone);
            this.groupBox8.Controls.Add(this.txtLastName);
            this.groupBox8.Controls.Add(this.label3);
            this.groupBox8.Controls.Add(this.label9);
            this.groupBox8.Controls.Add(this.label8);
            this.groupBox8.Controls.Add(this.label2);
            this.groupBox8.Controls.Add(this.txtFirstName);
            this.groupBox8.Controls.Add(this.label1);
            this.groupBox8.Font = new System.Drawing.Font("Candara", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupBox8.Location = new System.Drawing.Point(3, 0);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(724, 385);
            this.groupBox8.TabIndex = 14;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Cập nhật thông tin";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.txtAddress.Location = new System.Drawing.Point(157, 247);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(185, 36);
            this.txtAddress.TabIndex = 25;
            // 
            // txtGmail
            // 
            this.txtGmail.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.txtGmail.Location = new System.Drawing.Point(157, 185);
            this.txtGmail.Multiline = true;
            this.txtGmail.Name = "txtGmail";
            this.txtGmail.Size = new System.Drawing.Size(185, 36);
            this.txtGmail.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 24);
            this.label6.TabIndex = 23;
            this.label6.Text = "Gmail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 24);
            this.label4.TabIndex = 22;
            this.label4.Text = "Last Name";
            // 
            // lbSoPhieu
            // 
            this.lbSoPhieu.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.lbSoPhieu.Location = new System.Drawing.Point(153, 362);
            this.lbSoPhieu.Name = "lbSoPhieu";
            this.lbSoPhieu.Size = new System.Drawing.Size(63, 20);
            this.lbSoPhieu.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(724, 49);
            this.label5.TabIndex = 17;
            this.label5.Text = "Cập nhật thông tin";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbGender
            // 
            this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGender.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Khác",
            "Nam",
            "Nữ"});
            this.cbGender.Location = new System.Drawing.Point(537, 80);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(168, 31);
            this.cbGender.TabIndex = 5;
            // 
            // dtpDate
            // 
            this.dtpDate.CalendarForeColor = System.Drawing.SystemColors.Highlight;
            this.dtpDate.CalendarMonthBackground = System.Drawing.Color.IndianRed;
            this.dtpDate.CalendarTitleBackColor = System.Drawing.Color.Maroon;
            this.dtpDate.CalendarTitleForeColor = System.Drawing.SystemColors.Highlight;
            this.dtpDate.CalendarTrailingForeColor = System.Drawing.SystemColors.Highlight;
            this.dtpDate.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(537, 130);
            this.dtpDate.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dtpDate.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(168, 30);
            this.dtpDate.TabIndex = 6;
            this.dtpDate.Value = new System.DateTime(2024, 4, 19, 0, 0, 0, 0);
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.txtPhone.Location = new System.Drawing.Point(157, 302);
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(185, 36);
            this.txtPhone.TabIndex = 4;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.txtLastName.Location = new System.Drawing.Point(157, 130);
            this.txtLastName.Multiline = true;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(185, 36);
            this.txtLastName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Phone";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Candara", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 249);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 24);
            this.label9.TabIndex = 0;
            this.label9.Text = "Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Candara", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(428, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(428, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Gender";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.txtFirstName.Location = new System.Drawing.Point(157, 75);
            this.txtFirstName.Multiline = true;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(185, 36);
            this.txtFirstName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // btLuuDG
            // 
            this.btLuuDG.BackColor = System.Drawing.Color.DodgerBlue;
            this.btLuuDG.Font = new System.Drawing.Font("Candara", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLuuDG.ForeColor = System.Drawing.SystemColors.Window;
            this.btLuuDG.Location = new System.Drawing.Point(1135, 199);
            this.btLuuDG.Name = "btLuuDG";
            this.btLuuDG.Size = new System.Drawing.Size(111, 36);
            this.btLuuDG.TabIndex = 11;
            this.btLuuDG.Text = "Lưu";
            this.btLuuDG.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Font = new System.Drawing.Font("Candara", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(962, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 36);
            this.button1.TabIndex = 7;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btTimKiem
            // 
            this.btTimKiem.BackColor = System.Drawing.Color.DodgerBlue;
            this.btTimKiem.Font = new System.Drawing.Font("Candara", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTimKiem.ForeColor = System.Drawing.SystemColors.Window;
            this.btTimKiem.Location = new System.Drawing.Point(381, 112);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(111, 36);
            this.btTimKiem.TabIndex = 7;
            this.btTimKiem.Text = "Tìm Kiếm";
            this.btTimKiem.UseVisualStyleBackColor = false;
            // 
            // btCapNhatDG
            // 
            this.btCapNhatDG.BackColor = System.Drawing.Color.DodgerBlue;
            this.btCapNhatDG.Enabled = false;
            this.btCapNhatDG.Font = new System.Drawing.Font("Candara", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCapNhatDG.ForeColor = System.Drawing.SystemColors.Window;
            this.btCapNhatDG.Location = new System.Drawing.Point(962, 199);
            this.btCapNhatDG.Name = "btCapNhatDG";
            this.btCapNhatDG.Size = new System.Drawing.Size(111, 36);
            this.btCapNhatDG.TabIndex = 9;
            this.btCapNhatDG.Text = "Cập nhật";
            this.btCapNhatDG.UseVisualStyleBackColor = false;
            // 
            // btXoaDG
            // 
            this.btXoaDG.BackColor = System.Drawing.Color.DodgerBlue;
            this.btXoaDG.Enabled = false;
            this.btXoaDG.Font = new System.Drawing.Font("Candara", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoaDG.ForeColor = System.Drawing.SystemColors.Window;
            this.btXoaDG.Location = new System.Drawing.Point(772, 293);
            this.btXoaDG.Name = "btXoaDG";
            this.btXoaDG.Size = new System.Drawing.Size(111, 35);
            this.btXoaDG.TabIndex = 10;
            this.btXoaDG.Text = "Xóa";
            this.btXoaDG.UseVisualStyleBackColor = false;
            // 
            // btInsertReader
            // 
            this.btInsertReader.BackColor = System.Drawing.Color.DodgerBlue;
            this.btInsertReader.Font = new System.Drawing.Font("Candara", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInsertReader.ForeColor = System.Drawing.SystemColors.Window;
            this.btInsertReader.Location = new System.Drawing.Point(772, 198);
            this.btInsertReader.Name = "btInsertReader";
            this.btInsertReader.Size = new System.Drawing.Size(111, 37);
            this.btInsertReader.TabIndex = 8;
            this.btInsertReader.Text = "Insert";
            this.btInsertReader.UseVisualStyleBackColor = false;
            this.btInsertReader.Click += new System.EventHandler(this.btInsertReader_Click);
            // 
            // readerID
            // 
            this.readerID.Frozen = true;
            this.readerID.HeaderText = "ID";
            this.readerID.MinimumWidth = 8;
            this.readerID.Name = "readerID";
            this.readerID.ReadOnly = true;
            this.readerID.Width = 150;
            // 
            // firstName
            // 
            this.firstName.Frozen = true;
            this.firstName.HeaderText = "First Name";
            this.firstName.MinimumWidth = 8;
            this.firstName.Name = "firstName";
            this.firstName.ReadOnly = true;
            this.firstName.Width = 150;
            // 
            // lastName
            // 
            this.lastName.Frozen = true;
            this.lastName.HeaderText = "Last Name";
            this.lastName.MinimumWidth = 8;
            this.lastName.Name = "lastName";
            this.lastName.ReadOnly = true;
            this.lastName.Width = 150;
            // 
            // gender
            // 
            this.gender.Frozen = true;
            this.gender.HeaderText = "Gender";
            this.gender.MinimumWidth = 8;
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            this.gender.Width = 150;
            // 
            // dateOfBirth
            // 
            this.dateOfBirth.Frozen = true;
            this.dateOfBirth.HeaderText = "Date";
            this.dateOfBirth.MinimumWidth = 8;
            this.dateOfBirth.Name = "dateOfBirth";
            this.dateOfBirth.ReadOnly = true;
            this.dateOfBirth.Width = 150;
            // 
            // gmail
            // 
            this.gmail.Frozen = true;
            this.gmail.HeaderText = "Gmail";
            this.gmail.MinimumWidth = 8;
            this.gmail.Name = "gmail";
            this.gmail.ReadOnly = true;
            this.gmail.Width = 150;
            // 
            // address
            // 
            this.address.Frozen = true;
            this.address.HeaderText = "Address";
            this.address.MinimumWidth = 8;
            this.address.Name = "address";
            this.address.ReadOnly = true;
            this.address.Width = 150;
            // 
            // phone
            // 
            this.phone.Frozen = true;
            this.phone.HeaderText = "Phone";
            this.phone.MinimumWidth = 8;
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            this.phone.Width = 150;
            // 
            // created_date
            // 
            this.created_date.Frozen = true;
            this.created_date.HeaderText = "Created Date";
            this.created_date.MinimumWidth = 8;
            this.created_date.Name = "created_date";
            this.created_date.ReadOnly = true;
            this.created_date.Width = 150;
            // 
            // ReaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 623);
            this.Controls.Add(this.pnQuanLyDG);
            this.Name = "ReaderForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ReaderForm_Load);
            this.pnQuanLyDG.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReaders)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnQuanLyDG;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbTimKiemDG;
        private System.Windows.Forms.RadioButton rdTenDG;
        private System.Windows.Forms.RadioButton rdMaDG;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtGmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbSoPhieu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btLuuDG;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.Button btCapNhatDG;
        private System.Windows.Forms.Button btXoaDG;
        private System.Windows.Forms.Button btInsertReader;
        private System.Windows.Forms.DataGridView dgvReaders;
        private System.Windows.Forms.DataGridViewTextBoxColumn readerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn gmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn created_date;
    }
}

