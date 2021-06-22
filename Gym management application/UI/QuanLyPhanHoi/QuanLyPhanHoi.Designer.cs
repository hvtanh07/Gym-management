namespace Gym_management_appication.UI.QuanLyPhanHoi
{
    partial class QuanLyPhanHoi
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
            this.lbl_memberName = new System.Windows.Forms.Label();
            this.txt_memberName = new System.Windows.Forms.TextBox();
            this.lbl_reviewDate = new System.Windows.Forms.Label();
            this.dtP_reviewDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_review = new System.Windows.Forms.Label();
            this.txt_review = new System.Windows.Forms.RichTextBox();
            this.btn_sendReview = new System.Windows.Forms.Button();
            this.btn_watchReview = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_memberName
            // 
            this.lbl_memberName.AutoSize = true;
            this.lbl_memberName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbl_memberName.Location = new System.Drawing.Point(16, 30);
            this.lbl_memberName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_memberName.Name = "lbl_memberName";
            this.lbl_memberName.Size = new System.Drawing.Size(136, 20);
            this.lbl_memberName.TabIndex = 0;
            this.lbl_memberName.Text = "Họ tên hội viên";
            // 
            // txt_memberName
            // 
            this.txt_memberName.Location = new System.Drawing.Point(193, 26);
            this.txt_memberName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_memberName.Name = "txt_memberName";
            this.txt_memberName.Size = new System.Drawing.Size(397, 22);
            this.txt_memberName.TabIndex = 1;
            // 
            // lbl_reviewDate
            // 
            this.lbl_reviewDate.AutoSize = true;
            this.lbl_reviewDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbl_reviewDate.Location = new System.Drawing.Point(647, 30);
            this.lbl_reviewDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_reviewDate.Name = "lbl_reviewDate";
            this.lbl_reviewDate.Size = new System.Drawing.Size(86, 20);
            this.lbl_reviewDate.TabIndex = 0;
            this.lbl_reviewDate.Text = "Thời gian";
            // 
            // dtP_reviewDate
            // 
            this.dtP_reviewDate.CustomFormat = "dd/MM/yyyy";
            this.dtP_reviewDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtP_reviewDate.Location = new System.Drawing.Point(777, 26);
            this.dtP_reviewDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtP_reviewDate.Name = "dtP_reviewDate";
            this.dtP_reviewDate.Size = new System.Drawing.Size(133, 22);
            this.dtP_reviewDate.TabIndex = 12;
            // 
            // lbl_review
            // 
            this.lbl_review.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_review.AutoSize = true;
            this.lbl_review.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbl_review.Location = new System.Drawing.Point(496, 71);
            this.lbl_review.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_review.Name = "lbl_review";
            this.lbl_review.Size = new System.Drawing.Size(82, 20);
            this.lbl_review.TabIndex = 0;
            this.lbl_review.Text = "Phản hồi";
            // 
            // txt_review
            // 
            this.txt_review.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_review.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(129)))), ((int)(((byte)(118)))));
            this.txt_review.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_review.Location = new System.Drawing.Point(16, 96);
            this.txt_review.Margin = new System.Windows.Forms.Padding(4);
            this.txt_review.MaxLength = 2500;
            this.txt_review.Name = "txt_review";
            this.txt_review.Size = new System.Drawing.Size(1029, 273);
            this.txt_review.TabIndex = 13;
            this.txt_review.Text = "";
            // 
            // btn_sendReview
            // 
            this.btn_sendReview.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_sendReview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(39)))), ((int)(((byte)(18)))));
            this.btn_sendReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_sendReview.Location = new System.Drawing.Point(423, 417);
            this.btn_sendReview.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sendReview.Name = "btn_sendReview";
            this.btn_sendReview.Size = new System.Drawing.Size(221, 60);
            this.btn_sendReview.TabIndex = 14;
            this.btn_sendReview.Text = "Gửi";
            this.btn_sendReview.UseVisualStyleBackColor = false;
            this.btn_sendReview.Click += new System.EventHandler(this.btn_sendReview_Click);
            // 
            // btn_watchReview
            // 
            this.btn_watchReview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_watchReview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(39)))), ((int)(((byte)(18)))));
            this.btn_watchReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_watchReview.Location = new System.Drawing.Point(899, 491);
            this.btn_watchReview.Margin = new System.Windows.Forms.Padding(4);
            this.btn_watchReview.Name = "btn_watchReview";
            this.btn_watchReview.Size = new System.Drawing.Size(155, 50);
            this.btn_watchReview.TabIndex = 14;
            this.btn_watchReview.Text = "Xem phản hồi";
            this.btn_watchReview.UseVisualStyleBackColor = false;
            this.btn_watchReview.Click += new System.EventHandler(this.btn_watchReview_Click);
            // 
            // QuanLyPhanHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btn_watchReview);
            this.Controls.Add(this.btn_sendReview);
            this.Controls.Add(this.txt_review);
            this.Controls.Add(this.dtP_reviewDate);
            this.Controls.Add(this.txt_memberName);
            this.Controls.Add(this.lbl_reviewDate);
            this.Controls.Add(this.lbl_review);
            this.Controls.Add(this.lbl_memberName);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QuanLyPhanHoi";
            this.Text = "QuanLyPhanHoi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_memberName;
        private System.Windows.Forms.TextBox txt_memberName;
        private System.Windows.Forms.Label lbl_reviewDate;
        private System.Windows.Forms.DateTimePicker dtP_reviewDate;
        private System.Windows.Forms.Label lbl_review;
        private System.Windows.Forms.RichTextBox txt_review;
        private System.Windows.Forms.Button btn_sendReview;
        private System.Windows.Forms.Button btn_watchReview;
    }
}