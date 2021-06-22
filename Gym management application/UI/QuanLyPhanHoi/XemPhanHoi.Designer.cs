namespace Gym_management_appication.UI.QuanLyPhanHoi
{
    partial class XemPhanHoi
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
            this.dtgv_Phanhoi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Phanhoi)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv_Phanhoi
            // 
            this.dtgv_Phanhoi.AllowUserToAddRows = false;
            this.dtgv_Phanhoi.AllowUserToDeleteRows = false;
            this.dtgv_Phanhoi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_Phanhoi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgv_Phanhoi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(129)))), ((int)(((byte)(118)))));
            this.dtgv_Phanhoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Phanhoi.Location = new System.Drawing.Point(16, 36);
            this.dtgv_Phanhoi.Margin = new System.Windows.Forms.Padding(4);
            this.dtgv_Phanhoi.Name = "dtgv_Phanhoi";
            this.dtgv_Phanhoi.RowHeadersVisible = false;
            this.dtgv_Phanhoi.RowHeadersWidth = 51;
            this.dtgv_Phanhoi.Size = new System.Drawing.Size(1035, 503);
            this.dtgv_Phanhoi.TabIndex = 0;
            // 
            // XemPhanHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dtgv_Phanhoi);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "XemPhanHoi";
            this.Text = "XemPhanHoi";
            this.Load += new System.EventHandler(this.XemPhanHoi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Phanhoi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_Phanhoi;
    }
}