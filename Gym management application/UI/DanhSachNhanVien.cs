using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_management_appication.UI
{
    public partial class DanhSachNhanVien : Form
    {
        public DanhSachNhanVien()
        {
            InitializeComponent();
            LoadDanhSachNhanVien();
            LoadNhanVienControl();
        }

        void LoadDanhSachNhanVien() {
            DataTable dataTable = new DataTable();
            dataTable = (new DanhSachNhanVienModel().GetDatabase("Select * from dbo.[NHANVIEN]"));
            this.dataGridViewNhanVien.DataSource = dataTable;

        }

        void LoadNhanVienControl() {
            NhanVien nhanVien = new NhanVien();
            this.panelNhanVien.Controls.Add(nhanVien);
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            LoadDanhSachNhanVien();
        }
    }
}
