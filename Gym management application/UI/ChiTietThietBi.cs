using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gym_management_appication.Class;



namespace Gym_management_appication.UI
{
    public partial class ChiTietThietBi : Form
    {
        public ChiTietThietBi(trangThietBi trangThietBi)
        {          
            InitializeComponent();
            txt_Ten.Text = trangThietBi.ten;
            txt_Ma.Text = trangThietBi.ma;
            txt_soLuong.Text = trangThietBi.soLuong.ToString();
            txt_tinhTrang.Text = trangThietBi.tinhTrang;
            txt_Ma.ReadOnly = true;
            btn_Sua.Text = "Sửa";
        }
        public ChiTietThietBi()
        {
            InitializeComponent();
            txt_Ma.ReadOnly = false;
            btn_Sua.Text = "Thêm";
        }
        

        private void ChiTietThietBi_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            trangThietBi trangThietBi = new trangThietBi();
            trangThietBi.ten = txt_Ten.Text;
            trangThietBi.ma = txt_Ma.Text;
            trangThietBi.soLuong = int.Parse(txt_soLuong.Text);
            trangThietBi.tinhTrang = txt_tinhTrang.Text;
            Database.trangThietBi data = new Database.trangThietBi();
            if ("Sửa" == btn_Sua.Text)
            {
                data.insertData(trangThietBi);
            }
            else if ("Thêm" == btn_Sua.Text)
            {
                data.updateData(trangThietBi);
            }    
        }
    }
}
