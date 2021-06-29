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

namespace Gym_management_appication.UI.ThongKeHoiVien
{
    public partial class thongKeHoiVien : Form
    {
        Log Log = new Log();
        public thongKeHoiVien()
        {
            InitializeComponent();
        }

        private void thongKeHoiVien_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(dt_fromDate.Value.AddMonths(1) >= dt_toDate.Value)
            {
                MessageBox.Show("Ngày bắt đầu phải bé hơn ngày kết thúc 2 tháng!","Error!");
                return;
            }

            if (cb_DataType.Text.Trim() == "")
            {
                MessageBox.Show("Chọn loại thống kê!", "Error!");
                return;
            }
            if (cb_ChartType.Text.Trim() == "")
            {
                MessageBox.Show("Chọn loại bảng!", "Error!");
                return;
            }
            switch (cb_DataType.Text)
            {
                case "Số lượng hội viên từng tháng":
                    numOfMemeachMonth();
                    break;
                case "Số lượng hội viên mới từng tháng":
                    numOfNewMemeachMonth();
                    break;
                case "Số lượng hội viên nghỉ từng tháng":
                    numOfResignMemeachMonth();
                    break;
            }
        }

        private void numOfMemeachMonth()
        {
            c_ThongKe.DataSource = null;
            hoiVien hoivien = new hoiVien();
            DataTable hoivienList = hoivien.getMemberofMonth(dt_fromDate.Value, dt_toDate.Value);
            c_ThongKe.DataSource = hoivienList;
            c_ThongKe.ChartAreas["ChartArea1"].AxisX.Title = "Nhóm";
            c_ThongKe.ChartAreas["ChartArea1"].AxisX.Title = "Tổng số lượng";

            c_ThongKe.Series["Số lượng"].XValueMember = "thang";
            c_ThongKe.Series["Số lượng"].YValueMembers = "total";
            c_ThongKe.Series["Số lượng"].Color = Color.Blue;
            Log.Insert("Xem thông tin hội viên từng tháng");
        }
        private void numOfNewMemeachMonth()
        {
            c_ThongKe.DataSource = null;
            //c_ThongKe.typ
            hoiVien hoivien = new hoiVien();
            DataTable hoivienList = hoivien.getNewMemberofMonth(dt_fromDate.Value, dt_toDate.Value);
            c_ThongKe.DataSource = hoivienList;
            c_ThongKe.ChartAreas["ChartArea1"].AxisX.Title = "Nhóm";
            c_ThongKe.ChartAreas["ChartArea1"].AxisX.Title = "Tổng số lượng";

            c_ThongKe.Series["Số lượng"].XValueMember = "thang";
            c_ThongKe.Series["Số lượng"].YValueMembers = "total";
            c_ThongKe.Series["Số lượng"].Color = Color.Green;
            Log.Insert("Xem thông tin hội viên mới từng tháng");
        }
        private void numOfResignMemeachMonth()
        {
            c_ThongKe.DataSource = null;
            //c_ThongKe.typ
            hoiVien hoivien = new hoiVien();
            DataTable hoivienList = hoivien.getResignMemberofMonth(dt_fromDate.Value, dt_toDate.Value);
            c_ThongKe.DataSource = hoivienList;
            c_ThongKe.ChartAreas["ChartArea1"].AxisX.Title = "Nhóm";
            c_ThongKe.ChartAreas["ChartArea1"].AxisX.Title = "Tổng số lượng";

            c_ThongKe.Series["Số lượng"].XValueMember = "thang";
            c_ThongKe.Series["Số lượng"].YValueMembers = "total";
            c_ThongKe.Series["Số lượng"].Color = Color.Red;
            Log.Insert("Xem thông tin hội viên nghỉ từng tháng");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            c_ThongKe.DataSource = null;
        }   

        private void cb_ChartType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_ChartType.Text == "Line")
                c_ThongKe.Series["Số lượng"].ChartType = SeriesChartType.Line;
            else if (cb_ChartType.Text == "Column")
                c_ThongKe.Series["Số lượng"].ChartType = SeriesChartType.Column;
        }
    }
}
