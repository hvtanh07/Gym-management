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

namespace Gym_management_appication.Database.QuanLyHoiVien
{
    public partial class DanhSachHoiVien : Form
    {
        Class.hoiVien hoiVien = new Class.hoiVien();
        public DanhSachHoiVien()
        {
            InitializeComponent();
            LoadDanhSachHoiVien();
        }

        private void LoadDanhSachHoiVien()
        {
            DataTable dataTable = new DataTable();
            dataTable = new Database.QuanLyHoiVien.DSHVModel().GetData("Select * from DanhSachHoiVien");
            this.dataGridViewHoiVien.DataSource = dataTable;
            dataGridViewHoiVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            SetHeader();
        }
        private void SetHeader()
        {
            dataGridViewHoiVien.Columns["ten"].HeaderText = "Tên";
            dataGridViewHoiVien.Columns["ma"].HeaderText = "Mã";
            dataGridViewHoiVien.Columns["tuoi"].HeaderText = "Tuổi";
            dataGridViewHoiVien.Columns["gioiTinh"].HeaderText = "Giới tính";
            dataGridViewHoiVien.Columns["soDT"].HeaderText = "SĐT";
            dataGridViewHoiVien.Columns["ngayThamGia"].HeaderText = "Ngày bắt đầu";
            dataGridViewHoiVien.Columns["ngayKetThuc"].HeaderText = "Ngày kết thúc";

        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            LoadDanhSachHoiVien();
            label8.Text = dateTimePickerNgayThamGia.Value.ToString("MM/dd/yyyy");
        }

      

        private void RadioButtonNam_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonNam.Checked == true)
                this.radioButtonNu.Checked = false;
        }

        private void RadioButtonNu_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonNu.Checked == true)
                this.radioButtonNam.Checked = false;
        }
        private void BtnInsert_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text == "" || textBoxTen.Text == "" || textBoxTuoi.Text == "" || (radioButtonNam.Checked == false && radioButtonNu.Checked == false) || textBoxSDT.Text == "") {
                MessageBox.Show("Chưa đủ thông tin");
                return;
            }
            else
            {
                DataTable dataTable = (new Database.QuanLyHoiVien.DSHVModel().GetData("Select ma from DanhSachHoiVien where ma='" + textBoxID.Text.ToString().Trim() + "'"));
                if (dataTable.Rows.Count == 1) {
                    MessageBox.Show("ID đã tồn tại");
                }
                else
                {

                    Database.QuanLyHoiVien.DSHVModel danhSachHoiVienModel = new Database.QuanLyHoiVien.DSHVModel();
                    hoiVien.ma = textBoxID.Text;
                    hoiVien.ten = textBoxTen.Text;
                    hoiVien.tuoi = Convert.ToInt32( textBoxTuoi.Text.ToString());
                    hoiVien.gioiTinh = (radioButtonNam.Checked ? "Nam" : "Nữ");
                    hoiVien.sdt = textBoxSDT.Text;
                    hoiVien.ngayThamGia = dateTimePickerNgayThamGia.Value;
                    hoiVien.ngayTKetThuc = dateTimePickerNgayKetThuc.Value;                  
                    try
                    {
                        danhSachHoiVienModel.Insert(hoiVien);
                        MessageBox.Show("Thêm mới thành công.");
                        LoadDanhSachHoiVien();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Có lỗi xảy ra. Vui Lòng thử lại.");
                    }
                }



            }
        }
    }
}
