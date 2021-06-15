using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Gym_management_appication.Database;

namespace Gym_management_appication.UI.QuanLyDoanhThu
{
    public partial class ThongKeDoangThu : Form
    {
        public ThongKeDoangThu()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            
            if (cb_DataType.Text.Trim() == "")
            {
                MessageBox.Show("Chọn loại thống kê!", "Error!");
                return;
            }else
            {
                //Thống kê theo tháng
                //Thống kê theo năm
                switch (cb_DataType.Text)
                {
                    case "Thống kê theo tháng":
                        if (dt_fromDate.Value.AddMonths(1) >= dt_toDate.Value)
                        {
                            MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc 2 tháng!", "Error!");
                            return;
                        }
                        break;
                        
                    case "Thống kê theo năm":
                        if (dt_fromDate.Value.AddYears(1) >= dt_toDate.Value)
                        {
                            MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc 2 năm!", "Error!");
                            return;
                        }
                        break;
                }
                if (dt_fromDate.Value.AddMonths(1) >= dt_toDate.Value)
                {
                    MessageBox.Show("Ngày bắt đầu phải bé hơn ngày kết thúc 2 tháng!", "Error!");
                    return;
                }
            }
            if (cb_ChartType.Text.Trim() == "")
            {
                MessageBox.Show("Chọn loại bảng!", "Error!");
                return;
            }
            switch (cb_DataType.Text)
            {              
                case "Thống kê theo tháng":
                    incomEeachMonth();
                    break;
                case "Thống kê theo năm":
                    incomEeacYear();
                    break;               
            }
        }
        private void incomEeachMonth()
        {
            c_ThongKeDoanhThu.DataSource = null;
            DoanhThu doanhthu = new DoanhThu();
            DataTable doanhthuList = doanhthu.getIncomeofMonth(dt_fromDate.Value, dt_toDate.Value);
            c_ThongKeDoanhThu.DataSource = doanhthuList;
            c_ThongKeDoanhThu.ChartAreas["ChartArea1"].AxisX.Title = "Nhóm";
            c_ThongKeDoanhThu.ChartAreas["ChartArea1"].AxisX.Title = "Tổng lượng doanh thu";

            c_ThongKeDoanhThu.Series["Doanh thu"].XValueMember = "SalesMonth";
            c_ThongKeDoanhThu.Series["Doanh thu"].YValueMembers = "TotalSales";
            c_ThongKeDoanhThu.Series["Doanh thu"].Color = Color.Blue;
        }
        private void incomEeacYear()
        {
            c_ThongKeDoanhThu.DataSource = null;
            DoanhThu doanhthu = new DoanhThu();
            DataTable doanhthuList = doanhthu.getIncomeofYear(dt_fromDate.Value, dt_toDate.Value);
            c_ThongKeDoanhThu.DataSource = doanhthuList;
            c_ThongKeDoanhThu.ChartAreas["ChartArea1"].AxisX.Title = "Nhóm";
            c_ThongKeDoanhThu.ChartAreas["ChartArea1"].AxisX.Title = "Tổng lượng doanh thu";

            c_ThongKeDoanhThu.Series["Doanh thu"].XValueMember = "SalesYear";
            c_ThongKeDoanhThu.Series["Doanh thu"].YValueMembers = "TotalSales";
            c_ThongKeDoanhThu.Series["Doanh thu"].Color = Color.Blue;
        }
       
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            c_ThongKeDoanhThu.DataSource = null;
        }

        private void cb_ChartType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_ChartType.Text == "Line")
                c_ThongKeDoanhThu.Series["Doanh thu"].ChartType = SeriesChartType.Line;
            else if (cb_ChartType.Text == "Column")
                c_ThongKeDoanhThu.Series["Doanh thu"].ChartType = SeriesChartType.Column;
        }
    }
}
