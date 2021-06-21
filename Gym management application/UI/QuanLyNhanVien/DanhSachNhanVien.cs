using Gym_management_appication.Class;
using Gym_management_appication.UI.QuanLyNhanVien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gym_management_appication.UI.QuanLyNhanVien.QRCodeFeature;

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
            dataTable = new Database.QuanLyNhanVien.DSNVModel().GetData("Select * from NHANVIEN");
            this.dataGridViewNhanVien.DataSource = dataTable;
            dataGridViewNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        void LoadNhanVienControl() {
            nhanVienControl = new NhanVienControl();
            this.panelNhanVien.Controls.Add(nhanVienControl);
        }

        private void DataGridViewNhanVien_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridViewNhanVien.Rows[e.RowIndex].Cells[0].Value.ToString().Trim() == "")
                return;
            nhanVien.ID = dataGridViewNhanVien.Rows[e.RowIndex].Cells[0].Value.ToString();
            nhanVien.HoTen = dataGridViewNhanVien.Rows[e.RowIndex].Cells[1].Value.ToString();
            nhanVien.GioiTinh = dataGridViewNhanVien.Rows[e.RowIndex].Cells[2].Value.ToString();
            nhanVien.Email = dataGridViewNhanVien.Rows[e.RowIndex].Cells[3].Value.ToString();
            nhanVien.SoDT = Convert.ToInt64( dataGridViewNhanVien.Rows[e.RowIndex].Cells[4].Value.ToString());
            nhanVien.DiaChi = dataGridViewNhanVien.Rows[e.RowIndex].Cells[5].Value.ToString();
            nhanVien.ChucVu = dataGridViewNhanVien.Rows[e.RowIndex].Cells[6].Value.ToString();
            nhanVien.Luong = Convert.ToInt64( dataGridViewNhanVien.Rows[e.RowIndex].Cells[7].Value);
            this.nhanVienControl.SetControlsData(nhanVien.ID.ToString(), nhanVien.HoTen, nhanVien.GioiTinh, nhanVien.Email, nhanVien.SoDT.ToString(), nhanVien.DiaChi, nhanVien.ChucVu, nhanVien.Luong);
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            LoadDanhSachNhanVien();
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            if (!nhanVienControl.CheckData())
            {
                MessageBox.Show("Chưa đủ thông tin!");
                return;
            }
            DataTable dataTable = (new Database.QuanLyNhanVien.DSNVModel().GetData("Select ID from NHANVIEN where ID='" + nhanVienControl.GetID().ToString() + "'"));
            if (dataTable.Rows.Count == 1)
            {
                MessageBox.Show("ID đã tồn tại!");
            }
            else
            {
                Database.QuanLyNhanVien.DSNVModel danhSachNhanVienModel = new Database.QuanLyNhanVien.DSNVModel();
                try
                {
                    danhSachNhanVienModel.Insert(nhanVienControl.GetID().ToString(), nhanVienControl.GetTen(), nhanVienControl.GetGioiTinh(), nhanVienControl.GetEmail(), nhanVienControl.GetSDT(), nhanVienControl.GetDiaChi(), nhanVienControl.GetChucVu(), nhanVienControl.GetLuong());
                    MessageBox.Show("Thêm mới thành công.");
                    TaoTaiKhoanDangNhap taoTaiKhoanDangNhap = new TaoTaiKhoanDangNhap(nhanVienControl.GetID().ToString());
                    taoTaiKhoanDangNhap.ShowDialog();
                    LoadDanhSachNhanVien();
                }
                catch (Exception)
                {
                    MessageBox.Show("Có lỗi xảy ra. Vui lòng thử lại.");
                }              
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (!nhanVienControl.CheckData())
            {
                MessageBox.Show("Chưa đủ thông tin!");
                return;
            }
            DataTable dataTable = (new Database.QuanLyNhanVien.DSNVModel().GetData("Select ID from NHANVIEN where ID='" + nhanVienControl.GetID().ToString() + "'"));
            if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("ID chưa tồn tại!");
            }
            else if (dataTable.Rows.Count == 1) {
                if (dataTable.Rows[0][0].ToString().Trim() != nhanVien.ID.ToString().Trim())
                {
                    MessageBox.Show("Không hợp lệ!");
                    nhanVienControl.SetID(nhanVien.ID.ToString());
                }
                else {
                    Database.QuanLyNhanVien.DSNVModel danhSachNhanVienModel = new Database.QuanLyNhanVien.DSNVModel();
                    try
                    {
                        danhSachNhanVienModel.Update(nhanVienControl.GetID().ToString(), nhanVienControl.GetTen(), nhanVienControl.GetGioiTinh(), nhanVienControl.GetEmail(), nhanVienControl.GetSDT(), nhanVienControl.GetDiaChi(), nhanVienControl.GetChucVu(), nhanVienControl.GetLuong());
                        MessageBox.Show("Cập nhật thành công.");
                        LoadDanhSachNhanVien();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Lỗi! Cập nhật thất bại!");
                    }
                }
            }
            else
            {
               
            }

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Bạn muốn xóa nhân viên này ?", "Xóa nhân viên", MessageBoxButtons.YesNo);
            if (dlg == DialogResult.Yes)
            {
                Database.QuanLyNhanVien.DSNVModel ds = new Database.QuanLyNhanVien.DSNVModel();
                ds.Delete(nhanVien.ID.ToString());
                MessageBox.Show("Xóa thành công.");
                LoadDanhSachNhanVien();
            }
        }
        private void DataGridViewNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            nhanVien.ID = dataGridViewNhanVien.Rows[e.RowIndex].Cells[1].Value.ToString();
            nhanVien.HoTen = dataGridViewNhanVien.Rows[e.RowIndex].Cells[2].Value.ToString();
            nhanVien.GioiTinh = dataGridViewNhanVien.Rows[e.RowIndex].Cells[3].Value.ToString();
            nhanVien.Email = dataGridViewNhanVien.Rows[e.RowIndex].Cells[4].Value.ToString();
            nhanVien.SoDT = Convert.ToInt64(dataGridViewNhanVien.Rows[e.RowIndex].Cells[5].Value.ToString());
            nhanVien.DiaChi = dataGridViewNhanVien.Rows[e.RowIndex].Cells[6].Value.ToString();
            nhanVien.ChucVu = dataGridViewNhanVien.Rows[e.RowIndex].Cells[7].Value.ToString();
            nhanVien.Luong = Convert.ToInt64(dataGridViewNhanVien.Rows[e.RowIndex].Cells[8].Value);
            this.nhanVienControl.SetControlsData(nhanVien.ID.ToString(), nhanVien.HoTen, nhanVien.GioiTinh, nhanVien.Email, nhanVien.SoDT.ToString(), nhanVien.DiaChi, nhanVien.ChucVu, nhanVien.Luong);
        }

        private void btnQRCode_Click(object sender, EventArgs e) {
            if (dataGridViewNhanVien.SelectedCells.Count > 0) {
                QRCodeForm form = new QRCodeForm(dataGridViewNhanVien.Rows[dataGridViewNhanVien.SelectedCells[0].RowIndex].Cells[1].Value.ToString()); //Employee ID
                form.ShowDialog();
            }
        }

        private void btnScanQR_Click(object sender, EventArgs e) {
            QRScanForm scanForm = new QRScanForm();
            NHANVIEN foundEmployee = scanForm.ShowDialogWithReturnedEmployee();

            showEmployeeInfo(foundEmployee);
        }

        private void showEmployeeInfo(NHANVIEN employee) {
            if (employee!=null) {
                nhanVien.ID = employee.ID;
                nhanVien.HoTen = employee.HoTen;
                nhanVien.GioiTinh = employee.GioiTinh;
                nhanVien.Email = employee.Email;
                nhanVien.SoDT = employee.SoDT;
                nhanVien.DiaChi = employee.DiaChi;
                nhanVien.ChucVu = employee.ChucVu;
                nhanVien.Luong = (long)employee.Luong;
                this.nhanVienControl.SetControlsData(employee.ID, employee.HoTen, employee.GioiTinh, employee.Email, employee.SoDT.ToString(), employee.DiaChi, employee.ChucVu, (long)employee.Luong);
            }
        }
    }
}
