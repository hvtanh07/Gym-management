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
using Gym_management_appication.UI.QuanLyHoiVien;
using Gym_management_appication.UI.QuanLyHoiVien.QRCodeFeature;
using Gym_management_appication.UI.ThongKeHoiVien;

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
            if (textBoxID.Text.Trim() == "" || textBoxTen.Text.Trim() == "" || textBoxTuoi.Text.Trim() == "" || (radioButtonNam.Checked == false && radioButtonNu.Checked == false) || textBoxSDT.Text.Trim() == "") {
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

        private void DataGridViewHoiVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            textBoxID.Text = dataGridViewHoiVien.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxTen.Text = dataGridViewHoiVien.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxTuoi.Text = dataGridViewHoiVien.Rows[e.RowIndex].Cells[3].Value.ToString();
            if (dataGridViewHoiVien.Rows[e.RowIndex].Cells[4].Value.ToString().Trim() == "Nam" || dataGridViewHoiVien.Rows[e.RowIndex].Cells[4].Value.ToString().Trim() == "")
                radioButtonNam.Checked = true;
            else
                radioButtonNu.Checked = true;
            textBoxSDT.Text = dataGridViewHoiVien.Rows[e.RowIndex].Cells[5].Value.ToString();
            dateTimePickerNgayThamGia.Value = Convert.ToDateTime(dataGridViewHoiVien.Rows[e.RowIndex].Cells[6].Value.ToString());
            try
            {
                dateTimePickerNgayKetThuc.Value = Convert.ToDateTime(dataGridViewHoiVien.Rows[e.RowIndex].Cells[7].Value.ToString());
            }
            catch(Exception ex)
            {
                dateTimePickerNgayKetThuc.Value = DateTime.Today.AddYears(1);
            }            
            hoiVien.ma = textBoxID.Text;
            hoiVien.ten = textBoxTen.Text;
            hoiVien.tuoi = Convert.ToInt32(textBoxTuoi.Text.ToString());
            hoiVien.gioiTinh = (radioButtonNam.Checked ? "Nam" : "Nữ");
            hoiVien.sdt = textBoxSDT.Text;
            hoiVien.ngayThamGia = dateTimePickerNgayThamGia.Value;
            hoiVien.ngayTKetThuc = dateTimePickerNgayKetThuc.Value;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text == "" || textBoxTen.Text == "" || textBoxTuoi.Text == "" || (radioButtonNam.Checked == false && radioButtonNu.Checked == false) || textBoxSDT.Text == "")
            {
                MessageBox.Show("Chưa đủ thông tin");
                return;
            }
            DataTable dataTable = (new Database.QuanLyHoiVien.DSHVModel().GetData("Select ma from DanhSachHoiVien where ma='" + textBoxID.Text.ToString().Trim() + "'"));
            if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("ID chưa tồn tại");
            }
            else if (dataTable.Rows.Count == 1)
            {
                hoiVien.ma = textBoxID.Text;
                hoiVien.ten = textBoxTen.Text;
                hoiVien.tuoi = Convert.ToInt32(textBoxTuoi.Text.ToString());
                hoiVien.gioiTinh = (radioButtonNam.Checked ? "Nam" : "Nữ");
                hoiVien.sdt = textBoxSDT.Text;
                hoiVien.ngayThamGia = dateTimePickerNgayThamGia.Value;
                hoiVien.ngayTKetThuc = dateTimePickerNgayKetThuc.Value;
                Database.QuanLyHoiVien.DSHVModel danhSachHoiVienModel = new Database.QuanLyHoiVien.DSHVModel();
                try
                {
                    danhSachHoiVienModel.Update(hoiVien);
                    MessageBox.Show("Cập nhật thành công.");
                    LoadDanhSachHoiVien();
                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi! Cập nhật thất bại!");
                }
            }
            else
            {

            }
        }



        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Bạn muốn xóa hội viên này ?", "Xóa hội viên", MessageBoxButtons.YesNo);
            if (dlg == DialogResult.Yes)
            {
                Database.QuanLyHoiVien.DSHVModel ds = new Database.QuanLyHoiVien.DSHVModel();
                ds.Delete(hoiVien.ma.ToString().Trim());
                MessageBox.Show("Xóa thành công.");
                LoadDanhSachHoiVien();
            }
        }
        private void TextBoxSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TextBoxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TextBoxTuoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnQRCode_Click(object sender, EventArgs e) {

            if (dataGridViewHoiVien.SelectedCells.Count > 0) { 
                QRCodeForm form = new QRCodeForm(dataGridViewHoiVien.Rows[dataGridViewHoiVien.SelectedCells[0].RowIndex].Cells[1].Value.ToString()); //Member ID
                form.ShowDialog();
            }
        }

        private void btnScanQR_Click(object sender, EventArgs e) {
            QRScanForm scanForm = new QRScanForm((DataTable)dataGridViewHoiVien.DataSource);
            string Result = scanForm.ShowDialogWithReturnedID();

            for (int i=0; i<dataGridViewHoiVien.Rows.Count; i++) {
                if (dataGridViewHoiVien.Rows[i].Cells[1].Value.ToString().Trim()==Result) {
                    textBoxID.Text = dataGridViewHoiVien.Rows[i].Cells[1].Value.ToString();
                    textBoxTen.Text = dataGridViewHoiVien.Rows[i].Cells[2].Value.ToString();
                    textBoxTuoi.Text = dataGridViewHoiVien.Rows[i].Cells[3].Value.ToString();
                    if (dataGridViewHoiVien.Rows[i].Cells[4].Value.ToString().Trim() == "Nam" || dataGridViewHoiVien.Rows[i].Cells[4].Value.ToString().Trim() == "")
                        radioButtonNam.Checked = true;
                    else
                        radioButtonNu.Checked = true;
                    textBoxSDT.Text = dataGridViewHoiVien.Rows[i].Cells[5].Value.ToString();
                    dateTimePickerNgayThamGia.Value = Convert.ToDateTime(dataGridViewHoiVien.Rows[i].Cells[6].Value.ToString());
                    dateTimePickerNgayKetThuc.Value = Convert.ToDateTime(dataGridViewHoiVien.Rows[i].Cells[7].Value.ToString());
                    hoiVien.ma = textBoxID.Text;
                    hoiVien.ten = textBoxTen.Text;
                    hoiVien.tuoi = Convert.ToInt32(textBoxTuoi.Text.ToString());
                    hoiVien.gioiTinh = (radioButtonNam.Checked ? "Nam" : "Nữ");
                    hoiVien.sdt = textBoxSDT.Text;
                    hoiVien.ngayThamGia = dateTimePickerNgayThamGia.Value;
                    hoiVien.ngayTKetThuc = dateTimePickerNgayKetThuc.Value;
                }
            }
        }
    }
}
