
namespace Gym_management_appication.UI.QuanLyDoanhThu
{
    partial class ThongKeDoangThu
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.c_ThongKeDoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cb_ChartType = new System.Windows.Forms.ComboBox();
            this.cb_DataType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.dt_toDate = new System.Windows.Forms.DateTimePicker();
            this.dt_fromDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.c_ThongKeDoanhThu)).BeginInit();
            this.SuspendLayout();
            // 
            // c_ThongKeDoanhThu
            // 
            this.c_ThongKeDoanhThu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(129)))), ((int)(((byte)(118)))));
            chartArea2.Name = "ChartArea1";
            this.c_ThongKeDoanhThu.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.c_ThongKeDoanhThu.Legends.Add(legend2);
            this.c_ThongKeDoanhThu.Location = new System.Drawing.Point(12, 112);
            this.c_ThongKeDoanhThu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.c_ThongKeDoanhThu.Name = "c_ThongKeDoanhThu";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Doanh thu";
            this.c_ThongKeDoanhThu.Series.Add(series2);
            this.c_ThongKeDoanhThu.Size = new System.Drawing.Size(1063, 355);
            this.c_ThongKeDoanhThu.TabIndex = 7;
            this.c_ThongKeDoanhThu.Text = "chart1";
            // 
            // cb_ChartType
            // 
            this.cb_ChartType.FormattingEnabled = true;
            this.cb_ChartType.Items.AddRange(new object[] {
            "Line",
            "Column"});
            this.cb_ChartType.Location = new System.Drawing.Point(310, 29);
            this.cb_ChartType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_ChartType.Name = "cb_ChartType";
            this.cb_ChartType.Size = new System.Drawing.Size(184, 24);
            this.cb_ChartType.TabIndex = 15;
            this.cb_ChartType.SelectedIndexChanged += new System.EventHandler(this.cb_ChartType_SelectedIndexChanged);
            // 
            // cb_DataType
            // 
            this.cb_DataType.FormattingEnabled = true;
            this.cb_DataType.Items.AddRange(new object[] {
            "Thống kê theo tháng",
            "Thống kê theo năm"});
            this.cb_DataType.Location = new System.Drawing.Point(58, 29);
            this.cb_DataType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_DataType.Name = "cb_DataType";
            this.cb_DataType.Size = new System.Drawing.Size(231, 24);
            this.cb_DataType.TabIndex = 14;
            this.cb_DataType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "to date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "From date:";
            // 
            // btn_search
            // 
            this.btn_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search.BackColor = System.Drawing.Color.Red;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Location = new System.Drawing.Point(904, 29);
            this.btn_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(137, 57);
            this.btn_search.TabIndex = 11;
            this.btn_search.Text = "Confirm";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // dt_toDate
            // 
            this.dt_toDate.CustomFormat = "dd/MM/yyyy";
            this.dt_toDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_toDate.Location = new System.Drawing.Point(369, 64);
            this.dt_toDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dt_toDate.Name = "dt_toDate";
            this.dt_toDate.Size = new System.Drawing.Size(125, 22);
            this.dt_toDate.TabIndex = 10;
            // 
            // dt_fromDate
            // 
            this.dt_fromDate.CustomFormat = "dd/MM/yyyy";
            this.dt_fromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_fromDate.Location = new System.Drawing.Point(138, 64);
            this.dt_fromDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dt_fromDate.Name = "dt_fromDate";
            this.dt_fromDate.Size = new System.Drawing.Size(125, 22);
            this.dt_fromDate.TabIndex = 9;
            // 
            // ThongKeDoangThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 481);
            this.Controls.Add(this.cb_ChartType);
            this.Controls.Add(this.cb_DataType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.dt_toDate);
            this.Controls.Add(this.dt_fromDate);
            this.Controls.Add(this.c_ThongKeDoanhThu);
            this.Name = "ThongKeDoangThu";
            this.Text = "ThongKeDoangThu";
            ((System.ComponentModel.ISupportInitialize)(this.c_ThongKeDoanhThu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart c_ThongKeDoanhThu;
        private System.Windows.Forms.ComboBox cb_ChartType;
        private System.Windows.Forms.ComboBox cb_DataType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DateTimePicker dt_toDate;
        private System.Windows.Forms.DateTimePicker dt_fromDate;
    }
}