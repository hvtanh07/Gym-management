namespace Gym_management_appication.Database.QuanLyHoiVien
{
    partial class DanhSachHoiVien
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
            this.dataGridViewHoiVien = new System.Windows.Forms.DataGridView();
            this.Chọn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnInsert = new System.Windows.Forms.Button();
            this.panelNhanVien = new System.Windows.Forms.Panel();
            this.btnQRCode = new System.Windows.Forms.Button();
            this.dateTimePickerNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePickerNgayThamGia = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxSDT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTuoi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButtonNam = new System.Windows.Forms.RadioButton();
            this.radioButtonNu = new System.Windows.Forms.RadioButton();
            this.textBoxTen = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoiVien)).BeginInit();
            this.panelNhanVien.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewHoiVien
            // 
            this.dataGridViewHoiVien.AllowUserToAddRows = false;
            this.dataGridViewHoiVien.AllowUserToDeleteRows = false;
            this.dataGridViewHoiVien.AllowUserToResizeRows = false;
            this.dataGridViewHoiVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewHoiVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewHoiVien.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(129)))), ((int)(((byte)(118)))));
            this.dataGridViewHoiVien.ColumnHeadersHeight = 29;
            this.dataGridViewHoiVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Chọn});
            this.dataGridViewHoiVien.Location = new System.Drawing.Point(9, 209);
            this.dataGridViewHoiVien.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewHoiVien.Name = "dataGridViewHoiVien";
            this.dataGridViewHoiVien.RowHeadersVisible = false;
            this.dataGridViewHoiVien.RowHeadersWidth = 51;
            this.dataGridViewHoiVien.RowTemplate.Height = 24;
            this.dataGridViewHoiVien.Size = new System.Drawing.Size(846, 275);
            this.dataGridViewHoiVien.TabIndex = 3;
            this.dataGridViewHoiVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewHoiVien_CellContentClick);
            // 
            // Chọn
            // 
            this.Chọn.HeaderText = "";
            this.Chọn.MinimumWidth = 6;
            this.Chọn.Name = "Chọn";
            this.Chọn.Text = "Chọn";
            this.Chọn.UseColumnTextForButtonValue = true;
            this.Chọn.Width = 6;
            // 
            // btnInsert
            // 
            this.btnInsert.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(39)))), ((int)(((byte)(18)))));
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(146, 163);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(88, 25);
            this.btnInsert.TabIndex = 1;
            this.btnInsert.Text = "INSERT";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // panelNhanVien
            // 
            this.panelNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(219)))));
            this.panelNhanVien.Controls.Add(this.btnQRCode);
            this.panelNhanVien.Controls.Add(this.dateTimePickerNgayKetThuc);
            this.panelNhanVien.Controls.Add(this.label7);
            this.panelNhanVien.Controls.Add(this.dateTimePickerNgayThamGia);
            this.panelNhanVien.Controls.Add(this.label6);
            this.panelNhanVien.Controls.Add(this.textBoxSDT);
            this.panelNhanVien.Controls.Add(this.label4);
            this.panelNhanVien.Controls.Add(this.textBoxTuoi);
            this.panelNhanVien.Controls.Add(this.label5);
            this.panelNhanVien.Controls.Add(this.radioButtonNam);
            this.panelNhanVien.Controls.Add(this.radioButtonNu);
            this.panelNhanVien.Controls.Add(this.textBoxTen);
            this.panelNhanVien.Controls.Add(this.textBoxID);
            this.panelNhanVien.Controls.Add(this.label3);
            this.panelNhanVien.Controls.Add(this.label2);
            this.panelNhanVien.Controls.Add(this.label1);
            this.panelNhanVien.Controls.Add(this.btnReset);
            this.panelNhanVien.Controls.Add(this.btnDelete);
            this.panelNhanVien.Controls.Add(this.btnUpdate);
            this.panelNhanVien.Controls.Add(this.btnInsert);
            this.panelNhanVien.Location = new System.Drawing.Point(2, 6);
            this.panelNhanVien.Margin = new System.Windows.Forms.Padding(2);
            this.panelNhanVien.Name = "panelNhanVien";
            this.panelNhanVien.Size = new System.Drawing.Size(862, 198);
            this.panelNhanVien.TabIndex = 4;
            // 
            // btnQRCode
            // 
            this.btnQRCode.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnQRCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(39)))), ((int)(((byte)(18)))));
            this.btnQRCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQRCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQRCode.Location = new System.Drawing.Point(514, 163);
            this.btnQRCode.Margin = new System.Windows.Forms.Padding(2);
            this.btnQRCode.Name = "btnQRCode";
            this.btnQRCode.Size = new System.Drawing.Size(88, 25);
            this.btnQRCode.TabIndex = 37;
            this.btnQRCode.Text = "QR Code";
            this.btnQRCode.UseVisualStyleBackColor = false;
            this.btnQRCode.Click += new System.EventHandler(this.btnQRCode_Click);
            // 
            // dateTimePickerNgayKetThuc
            // 
            this.dateTimePickerNgayKetThuc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerNgayKetThuc.Location = new System.Drawing.Point(599, 80);
            this.dateTimePickerNgayKetThuc.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerNgayKetThuc.Name = "dateTimePickerNgayKetThuc";
            this.dateTimePickerNgayKetThuc.Size = new System.Drawing.Size(248, 20);
            this.dateTimePickerNgayKetThuc.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(511, 81);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Ngày kết thúc";
            // 
            // dateTimePickerNgayThamGia
            // 
            this.dateTimePickerNgayThamGia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerNgayThamGia.Location = new System.Drawing.Point(599, 50);
            this.dateTimePickerNgayThamGia.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerNgayThamGia.Name = "dateTimePickerNgayThamGia";
            this.dateTimePickerNgayThamGia.Size = new System.Drawing.Size(248, 20);
            this.dateTimePickerNgayThamGia.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(511, 50);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Ngày tham gia";
            // 
            // textBoxSDT
            // 
            this.textBoxSDT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSDT.Location = new System.Drawing.Point(599, 17);
            this.textBoxSDT.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSDT.Name = "textBoxSDT";
            this.textBoxSDT.Size = new System.Drawing.Size(248, 20);
            this.textBoxSDT.TabIndex = 32;
            this.textBoxSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxSDT_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(511, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Số điện thoại";
            // 
            // textBoxTuoi
            // 
            this.textBoxTuoi.Location = new System.Drawing.Point(94, 79);
            this.textBoxTuoi.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTuoi.Name = "textBoxTuoi";
            this.textBoxTuoi.Size = new System.Drawing.Size(248, 20);
            this.textBoxTuoi.TabIndex = 30;
            this.textBoxTuoi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxTuoi_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 81);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Tuổi";
            // 
            // radioButtonNam
            // 
            this.radioButtonNam.AutoSize = true;
            this.radioButtonNam.Location = new System.Drawing.Point(94, 115);
            this.radioButtonNam.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonNam.Name = "radioButtonNam";
            this.radioButtonNam.Size = new System.Drawing.Size(47, 17);
            this.radioButtonNam.TabIndex = 28;
            this.radioButtonNam.TabStop = true;
            this.radioButtonNam.Text = "Nam";
            this.radioButtonNam.UseVisualStyleBackColor = true;
            this.radioButtonNam.CheckedChanged += new System.EventHandler(this.RadioButtonNam_CheckedChanged);
            // 
            // radioButtonNu
            // 
            this.radioButtonNu.AutoSize = true;
            this.radioButtonNu.Location = new System.Drawing.Point(170, 115);
            this.radioButtonNu.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonNu.Name = "radioButtonNu";
            this.radioButtonNu.Size = new System.Drawing.Size(39, 17);
            this.radioButtonNu.TabIndex = 27;
            this.radioButtonNu.TabStop = true;
            this.radioButtonNu.Text = "Nữ";
            this.radioButtonNu.UseVisualStyleBackColor = true;
            this.radioButtonNu.CheckedChanged += new System.EventHandler(this.RadioButtonNu_CheckedChanged);
            // 
            // textBoxTen
            // 
            this.textBoxTen.Location = new System.Drawing.Point(94, 44);
            this.textBoxTen.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTen.Name = "textBoxTen";
            this.textBoxTen.Size = new System.Drawing.Size(248, 20);
            this.textBoxTen.TabIndex = 25;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(94, 15);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(248, 20);
            this.textBoxID.TabIndex = 24;
            this.textBoxID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxID_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Giới tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Họ tên";
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(39)))), ((int)(((byte)(18)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(422, 163);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(88, 25);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(39)))), ((int)(((byte)(18)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(330, 163);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 25);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(39)))), ((int)(((byte)(18)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(238, 163);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(88, 25);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // DanhSachHoiVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(864, 490);
            this.Controls.Add(this.dataGridViewHoiVien);
            this.Controls.Add(this.panelNhanVien);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DanhSachHoiVien";
            this.Text = "DanhSachHoiVien";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoiVien)).EndInit();
            this.panelNhanVien.ResumeLayout(false);
            this.panelNhanVien.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewHoiVien;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Panel panelNhanVien;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.RadioButton radioButtonNam;
        private System.Windows.Forms.RadioButton radioButtonNu;
        private System.Windows.Forms.TextBox textBoxTen;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTuoi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxSDT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayThamGia;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayKetThuc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewButtonColumn Chọn;
        private System.Windows.Forms.Button btnQRCode;
    }
}