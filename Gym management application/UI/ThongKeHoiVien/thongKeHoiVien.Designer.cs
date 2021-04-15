
namespace Gym_management_appication.UI.ThongKeHoiVien
{
    partial class thongKeHoiVien
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dt_fromDate = new System.Windows.Forms.DateTimePicker();
            this.dt_toDate = new System.Windows.Forms.DateTimePicker();
            this.btn_search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.c_ThongKe = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cb_DataType = new System.Windows.Forms.ComboBox();
            this.cb_ChartType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.c_ThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // dt_fromDate
            // 
            this.dt_fromDate.CustomFormat = "dd/MM/yyyy";
            this.dt_fromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_fromDate.Location = new System.Drawing.Point(94, 40);
            this.dt_fromDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dt_fromDate.Name = "dt_fromDate";
            this.dt_fromDate.Size = new System.Drawing.Size(95, 20);
            this.dt_fromDate.TabIndex = 0;
            // 
            // dt_toDate
            // 
            this.dt_toDate.CustomFormat = "dd/MM/yyyy";
            this.dt_toDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_toDate.Location = new System.Drawing.Point(273, 40);
            this.dt_toDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dt_toDate.Name = "dt_toDate";
            this.dt_toDate.Size = new System.Drawing.Size(95, 20);
            this.dt_toDate.TabIndex = 1;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Red;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Location = new System.Drawing.Point(407, 32);
            this.btn_search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(80, 35);
            this.btn_search.TabIndex = 3;
            this.btn_search.Text = "Confirm";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "From date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "to date:";
            // 
            // c_ThongKe
            // 
            this.c_ThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(129)))), ((int)(((byte)(118)))));
            chartArea1.Name = "ChartArea1";
            this.c_ThongKe.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.c_ThongKe.Legends.Add(legend1);
            this.c_ThongKe.Location = new System.Drawing.Point(40, 91);
            this.c_ThongKe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.c_ThongKe.Name = "c_ThongKe";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Số lượng";
            this.c_ThongKe.Series.Add(series1);
            this.c_ThongKe.Size = new System.Drawing.Size(739, 244);
            this.c_ThongKe.TabIndex = 6;
            this.c_ThongKe.Text = "chart1";
            // 
            // cb_DataType
            // 
            this.cb_DataType.FormattingEnabled = true;
            this.cb_DataType.Items.AddRange(new object[] {
            "Số lượng hội viên từng tháng",
            "Số lượng hội viên mới từng tháng",
            "Số lượng hội viên nghỉ từng tháng"});
            this.cb_DataType.Location = new System.Drawing.Point(40, 11);
            this.cb_DataType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_DataType.Name = "cb_DataType";
            this.cb_DataType.Size = new System.Drawing.Size(174, 21);
            this.cb_DataType.TabIndex = 7;
            this.cb_DataType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cb_ChartType
            // 
            this.cb_ChartType.FormattingEnabled = true;
            this.cb_ChartType.Items.AddRange(new object[] {
            "Line",
            "Column"});
            this.cb_ChartType.Location = new System.Drawing.Point(229, 11);
            this.cb_ChartType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_ChartType.Name = "cb_ChartType";
            this.cb_ChartType.Size = new System.Drawing.Size(139, 21);
            this.cb_ChartType.TabIndex = 8;
            this.cb_ChartType.SelectedIndexChanged += new System.EventHandler(this.cb_ChartType_SelectedIndexChanged);
            // 
            // thongKeHoiVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(818, 366);
            this.Controls.Add(this.cb_ChartType);
            this.Controls.Add(this.cb_DataType);
            this.Controls.Add(this.c_ThongKe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.dt_toDate);
            this.Controls.Add(this.dt_fromDate);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "thongKeHoiVien";
            this.Text = "thongKeHoiVien";
            this.Load += new System.EventHandler(this.thongKeHoiVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c_ThongKe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dt_fromDate;
        private System.Windows.Forms.DateTimePicker dt_toDate;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart c_ThongKe;
        private System.Windows.Forms.ComboBox cb_DataType;
        private System.Windows.Forms.ComboBox cb_ChartType;
    }
}