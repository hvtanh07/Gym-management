using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gym_management_appication.Database;

namespace Gym_management_appication.UI.QuanLyPhanHoi
{
    public partial class XemPhanHoi : Form
    {
        public XemPhanHoi()
        {
            InitializeComponent();
        }

        private void XemPhanHoi_Load(object sender, EventArgs e)
        {
            feedBackDB data = new feedBackDB();
            DataTable feedbackList = data.getData();
            dtgv_Phanhoi.DataSource = feedbackList;
            SetHeader();
        }
        private void SetHeader()
        {
            dtgv_Phanhoi.Columns["maKH"].HeaderText = "Mã khách hàng";
            dtgv_Phanhoi.Columns["thoigian"].HeaderText = "Ngày";
            dtgv_Phanhoi.Columns["feedback"].HeaderText = "Nội dung";
        }
    }
}
