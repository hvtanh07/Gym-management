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
            this.rTB_review = new System.Windows.Forms.RichTextBox();
            this.btn_sendReview = new System.Windows.Forms.Button();
            this.btn_watchReview = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_memberName
            // 
            this.lbl_memberName.AutoSize = true;
            this.lbl_memberName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbl_memberName.Location = new System.Drawing.Point(12, 24);
            this.lbl_memberName.Name = "lbl_memberName";
            this.lbl_memberName.Size = new System.Drawing.Size(118, 17);
            this.lbl_memberName.TabIndex = 0;
            this.lbl_memberName.Text = "Họ tên hội viên";
            // 
            // txt_memberName
            // 
            this.txt_memberName.Location = new System.Drawing.Point(145, 21);
            this.txt_memberName.Name = "txt_memberName";
            this.txt_memberName.Size = new System.Drawing.Size(299, 20);
            this.txt_memberName.TabIndex = 1;
            // 
            // lbl_reviewDate
            // 
            this.lbl_reviewDate.AutoSize = true;
            this.lbl_reviewDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbl_reviewDate.Location = new System.Drawing.Point(485, 24);
            this.lbl_reviewDate.Name = "lbl_reviewDate";
            this.lbl_reviewDate.Size = new System.Drawing.Size(76, 17);
            this.lbl_reviewDate.TabIndex = 0;
            this.lbl_reviewDate.Text = "Thời gian";
            // 
            // dtP_reviewDate
            // 
            this.dtP_reviewDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtP_reviewDate.CustomFormat = "dd/MM/yyyy";
            this.dtP_reviewDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtP_reviewDate.Location = new System.Drawing.Point(583, 21);
            this.dtP_reviewDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtP_reviewDate.Name = "dtP_reviewDate";
            this.dtP_reviewDate.Size = new System.Drawing.Size(101, 20);
            this.dtP_reviewDate.TabIndex = 12;
            // 
            // lbl_review
            // 
            this.lbl_review.AutoSize = true;
            this.lbl_review.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbl_review.Location = new System.Drawing.Point(372, 58);
            this.lbl_review.Name = "lbl_review";
            this.lbl_review.Size = new System.Drawing.Size(72, 17);
            this.lbl_review.TabIndex = 0;
            this.lbl_review.Text = "Phản hồi";
            // 
            // rTB_review
            // 
            this.rTB_review.Location = new System.Drawing.Point(12, 78);
            this.rTB_review.Name = "rTB_review";
            this.rTB_review.Size = new System.Drawing.Size(773, 325);
            this.rTB_review.TabIndex = 13;
            this.rTB_review.Text = "";
            // 
            // btn_sendReview
            // 
            this.btn_sendReview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(39)))), ((int)(((byte)(18)))));
            this.btn_sendReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_sendReview.Location = new System.Drawing.Point(329, 409);
            this.btn_sendReview.Name = "btn_sendReview";
            this.btn_sendReview.Size = new System.Drawing.Size(166, 31);
            this.btn_sendReview.TabIndex = 14;
            this.btn_sendReview.Text = "Gửi";
            this.btn_sendReview.UseVisualStyleBackColor = false;
            this.btn_sendReview.Click += new System.EventHandler(this.btn_sendReview_Click);
            // 
            // btn_watchReview
            // 
            this.btn_watchReview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(39)))), ((int)(((byte)(18)))));
            this.btn_watchReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_watchReview.Location = new System.Drawing.Point(669, 409);
            this.btn_watchReview.Name = "btn_watchReview";
            this.btn_watchReview.Size = new System.Drawing.Size(116, 41);
            this.btn_watchReview.TabIndex = 14;
            this.btn_watchReview.Text = "Xem phản hồi";
            this.btn_watchReview.UseVisualStyleBackColor = false;
            this.btn_watchReview.Click += new System.EventHandler(this.btn_watchReview_Click);
            // 
            // QuanLyPhanHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_watchReview);
            this.Controls.Add(this.btn_sendReview);
            this.Controls.Add(this.rTB_review);
            this.Controls.Add(this.dtP_reviewDate);
            this.Controls.Add(this.txt_memberName);
            this.Controls.Add(this.lbl_reviewDate);
            this.Controls.Add(this.lbl_review);
            this.Controls.Add(this.lbl_memberName);
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
        private System.Windows.Forms.RichTextBox rTB_review;
        private System.Windows.Forms.Button btn_sendReview;
        private System.Windows.Forms.Button btn_watchReview;
    }
}