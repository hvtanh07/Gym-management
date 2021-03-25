using Gym_management_appication.Class;
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
        NhanVienControl nhanVienControl;
        NhanVien nhanVien = new NhanVien();
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
            nhanVienControl = new NhanVienControl();
            this.panelNhanVien.Controls.Add(nhanVienControl);
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            LoadDanhSachNhanVien();
        }

        private void DataGridViewNhanVien_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            nhanVien.ID = Convert.ToInt32(dataGridViewNhanVien.Rows[e.RowIndex].Cells[0].Value.ToString());
            nhanVien.HoTen = dataGridViewNhanVien.Rows[e.RowIndex].Cells[1].Value.ToString();
            nhanVien.GioiTinh = dataGridViewNhanVien.Rows[e.RowIndex].Cells[2].Value.ToString();
            nhanVien.Email = dataGridViewNhanVien.Rows[e.RowIndex].Cells[3].Value.ToString();
            nhanVien.SoDT = Convert.ToInt64( dataGridViewNhanVien.Rows[e.RowIndex].Cells[4].Value.ToString());
            nhanVien.DiaChi = dataGridViewNhanVien.Rows[e.RowIndex].Cells[5].Value.ToString();
            nhanVien.ChucVu = dataGridViewNhanVien.Rows[e.RowIndex].Cells[6].Value.ToString();
            nhanVien.Luong = Convert.ToInt64( dataGridViewNhanVien.Rows[e.RowIndex].Cells[7].Value);
            this.nhanVienControl.SetControlsData(nhanVien.ID.ToString(), nhanVien.HoTen, nhanVien.GioiTinh, nhanVien.Email, nhanVien.SoDT.ToString(), nhanVien.DiaChi, nhanVien.ChucVu, nhanVien.Luong);
        }
    }
}
