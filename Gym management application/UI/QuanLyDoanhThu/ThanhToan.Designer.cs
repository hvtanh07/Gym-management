
namespace Gym_management_appication.UI.ThongKeHoiVien
{
    partial class ThanhToan
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Thanhtoan = new System.Windows.Forms.Button();
            this.btn_ChangePlan = new System.Windows.Forms.Button();
            this.txt_maHV = new System.Windows.Forms.TextBox();
            this.txt_tenHV = new System.Windows.Forms.TextBox();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.cmb_goiTap = new System.Windows.Forms.ComboBox();
            this.dtP_payDate = new System.Windows.Forms.DateTimePicker();
            this.dtgv_PaymentHistory = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xóaLịchSửGiaoDịchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_PaymentHistory)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hội viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên hội viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gói tập hiện tại";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(562, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày giao dịch";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(562, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số tiền";
            // 
            // btn_Thanhtoan
            // 
            this.btn_Thanhtoan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Thanhtoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(39)))), ((int)(((byte)(18)))));
            this.btn_Thanhtoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Thanhtoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thanhtoan.Location = new System.Drawing.Point(534, 191);
            this.btn_Thanhtoan.Name = "btn_Thanhtoan";
            this.btn_Thanhtoan.Size = new System.Drawing.Size(148, 43);
            this.btn_Thanhtoan.TabIndex = 5;
            this.btn_Thanhtoan.Text = "Đóng tiền";
            this.btn_Thanhtoan.UseVisualStyleBackColor = false;
            this.btn_Thanhtoan.Click += new System.EventHandler(this.btn_Thanhtoan_Click);
            // 
            // btn_ChangePlan
            // 
            this.btn_ChangePlan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ChangePlan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(39)))), ((int)(((byte)(18)))));
            this.btn_ChangePlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ChangePlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChangePlan.Location = new System.Drawing.Point(712, 191);
            this.btn_ChangePlan.Name = "btn_ChangePlan";
            this.btn_ChangePlan.Size = new System.Drawing.Size(188, 43);
            this.btn_ChangePlan.TabIndex = 6;
            this.btn_ChangePlan.Text = "Thay đổi gói tập";
            this.btn_ChangePlan.UseVisualStyleBackColor = false;
            this.btn_ChangePlan.Click += new System.EventHandler(this.btn_ChangePlan_Click);
            // 
            // txt_maHV
            // 
            this.txt_maHV.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_maHV.Location = new System.Drawing.Point(207, 26);
            this.txt_maHV.Name = "txt_maHV";
            this.txt_maHV.Size = new System.Drawing.Size(308, 22);
            this.txt_maHV.TabIndex = 7;
            this.txt_maHV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_maHV_KeyDown);
            this.txt_maHV.Leave += new System.EventHandler(this.txt_maHV_Leave);
            // 
            // txt_tenHV
            // 
            this.txt_tenHV.Location = new System.Drawing.Point(207, 85);
            this.txt_tenHV.Name = "txt_tenHV";
            this.txt_tenHV.Size = new System.Drawing.Size(308, 22);
            this.txt_tenHV.TabIndex = 8;
            // 
            // txt_amount
            // 
            this.txt_amount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_amount.Location = new System.Drawing.Point(728, 26);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(159, 22);
            this.txt_amount.TabIndex = 9;
            // 
            // cmb_goiTap
            // 
            this.cmb_goiTap.Enabled = false;
            this.cmb_goiTap.FormattingEnabled = true;
            this.cmb_goiTap.Location = new System.Drawing.Point(207, 144);
            this.cmb_goiTap.Name = "cmb_goiTap";
            this.cmb_goiTap.Size = new System.Drawing.Size(308, 24);
            this.cmb_goiTap.TabIndex = 10;
            // 
            // dtP_payDate
            // 
            this.dtP_payDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtP_payDate.CustomFormat = "dd/MM/yyyy";
            this.dtP_payDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtP_payDate.Location = new System.Drawing.Point(728, 83);
            this.dtP_payDate.Name = "dtP_payDate";
            this.dtP_payDate.Size = new System.Drawing.Size(133, 22);
            this.dtP_payDate.TabIndex = 11;
            // 
            // dtgv_PaymentHistory
            // 
            this.dtgv_PaymentHistory.AllowUserToResizeRows = false;
            this.dtgv_PaymentHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgv_PaymentHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_PaymentHistory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(129)))), ((int)(((byte)(118)))));
            this.dtgv_PaymentHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_PaymentHistory.ContextMenuStrip = this.contextMenuStrip1;
            this.dtgv_PaymentHistory.Location = new System.Drawing.Point(12, 252);
            this.dtgv_PaymentHistory.Name = "dtgv_PaymentHistory";
            this.dtgv_PaymentHistory.RowHeadersVisible = false;
            this.dtgv_PaymentHistory.RowHeadersWidth = 51;
            this.dtgv_PaymentHistory.RowTemplate.Height = 24;
            this.dtgv_PaymentHistory.Size = new System.Drawing.Size(911, 206);
            this.dtgv_PaymentHistory.TabIndex = 12;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xóaLịchSửGiaoDịchToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(217, 28);
            // 
            // xóaLịchSửGiaoDịchToolStripMenuItem
            // 
            this.xóaLịchSửGiaoDịchToolStripMenuItem.Name = "xóaLịchSửGiaoDịchToolStripMenuItem";
            this.xóaLịchSửGiaoDịchToolStripMenuItem.Size = new System.Drawing.Size(216, 24);
            this.xóaLịchSửGiaoDịchToolStripMenuItem.Text = "Xóa lịch sử giao dịch";
            this.xóaLịchSửGiaoDịchToolStripMenuItem.Click += new System.EventHandler(this.xóaLịchSửGiaoDịchToolStripMenuItem_Click);
            // 
            // ThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(935, 470);
            this.Controls.Add(this.dtgv_PaymentHistory);
            this.Controls.Add(this.dtP_payDate);
            this.Controls.Add(this.cmb_goiTap);
            this.Controls.Add(this.txt_amount);
            this.Controls.Add(this.txt_tenHV);
            this.Controls.Add(this.txt_maHV);
            this.Controls.Add(this.btn_ChangePlan);
            this.Controls.Add(this.btn_Thanhtoan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ThanhToan";
            this.Text = "ThanhToan";
            this.Load += new System.EventHandler(this.ThanhToan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_PaymentHistory)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Thanhtoan;
        private System.Windows.Forms.Button btn_ChangePlan;
        private System.Windows.Forms.TextBox txt_maHV;
        private System.Windows.Forms.TextBox txt_tenHV;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.ComboBox cmb_goiTap;
        private System.Windows.Forms.DateTimePicker dtP_payDate;
        private System.Windows.Forms.DataGridView dtgv_PaymentHistory;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xóaLịchSửGiaoDịchToolStripMenuItem;
    }
}