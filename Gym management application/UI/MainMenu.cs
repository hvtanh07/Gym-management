using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gym_management_appication.Database.QuanLyHoiVien;
using Gym_management_appication.UI;

namespace Gym_management_appication.UI
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DanhSachNhanVien frm = new DanhSachNhanVien();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            QuanLyThietBi frm = new QuanLyThietBi();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DanhSachHoiVien frm = new DanhSachHoiVien();
            frm.Show();
        }
    }
}
