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
            UD_soLuong.Text = trangThietBi.soLuong.ToString();
            cb_tinhTrang.Text = trangThietBi.tinhTrang;
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
            if (!checknull())
            {
                return;
            }
            trangThietBi trangThietBi = new trangThietBi();
            trangThietBi.ten = txt_Ten.Text;
            trangThietBi.ma = txt_Ma.Text;
            trangThietBi.soLuong = int.Parse(UD_soLuong.Text);
            trangThietBi.tinhTrang = cb_tinhTrang.Text;
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
        private bool checknull()
        {
            if(txt_Ten.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập tên thiết bị!", "Warning!");
                txt_Ten.Select();
                return false;
            }
            if (txt_Ma.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập mã thiết bị!", "Warning!");
                txt_Ma.Select();
                return false;
            }
            if( cb_tinhTrang.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn tình trạng của thiết bị!", "Warning!");
                cb_tinhTrang.Select();
                return false;
            }
            return true;
        }
    }
}
