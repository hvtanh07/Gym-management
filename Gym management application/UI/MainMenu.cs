using System;
using Gym_management_appication.Class;
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
using Gym_management_appication.UI.ThongKeHoiVien;
using Gym_management_appication.Database;

namespace Gym_management_appication.UI
{
    public partial class MainMenu : Form
    {
        private int permissionlevel;
        Log log = new Log();
        public MainMenu()
        {
            InitializeComponent();
            hideSubMenu();
            valiballecommon valiballecommon = valiballecommon.GetStorage();
            permissionlevel = valiballecommon.Permission;
            disableButton();
        }
        private void disableButton()
        {
           switch (permissionlevel)
            {
                case 1:
                    break;
                case 2:
                    btn_QuanLyNhanvien.Enabled = false;
                    btn_Danhsach.Enabled = false;
                    btn_attendance.Enabled = false;
                    break;
                case 3:
                    btn_QuanLyNhanvien.Enabled = false;
                    btn_QuanLyHoiVien.Enabled = false;
                    btn_attendance.Enabled = false;
                    btn_QuanLyThietbi.Enabled = false;
                    btn_QuanLyDoanhThu.Enabled = false;
                    break;
                case 4:
                    btn_QuanLyNhanvien.Enabled = false;
                    btn_QuanLyHoiVien.Enabled = false;
                    btn_attendance.Enabled = false;
                    btn_QuanLyThietbi.Enabled = false;
                    btn_QuanLyDoanhThu.Enabled = false;
                    break;
                default:
                    MessageBox.Show("Thông tin đăng nhập lỗi", "Error");
                    this.Close();
                    break;
            }    
        }
        private void hideSubMenu()
        {
            GroupQuanLyHoiVien.Visible = false;
            GroupQuanLyNhanVien.Visible = false;
            GroupQuanLyDoanhThu.Visible = false;
            //Add more Group of Form 
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }      

        #region QuanLyHoiVien
        private void btn_QuanLyHoiVien_Click(object sender, EventArgs e)
        {
            showSubMenu(GroupQuanLyHoiVien);
        }
        private void btn_Danhsach_Click(object sender, EventArgs e)
        {
            openChildForm(new MemberListForm());

            hideSubMenu();
        }

        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            openChildForm(new thongKeHoiVien());

            hideSubMenu();
        }

        private void btn_Dangky_Click(object sender, EventArgs e)
        {
            openChildForm(new UI.QuanLyHoiVien.DangKyHoiVien());

            hideSubMenu();
        }

        #endregion

        #region QuanLyDoanhThu
        private void btn_QuanLyDoanhThu_Click(object sender, EventArgs e)
        {
            showSubMenu(GroupQuanLyDoanhThu);
        }

        private void btn_baoCao_Click(object sender, EventArgs e)
        {
            openChildForm(new QuanLyDoanhThu.ThongKeDoangThu());

            hideSubMenu();
        }
        private void btn_thanhToan_Click(object sender, EventArgs e)
        {
            openChildForm(new ThanhToan());

            hideSubMenu();
        }
        #endregion

        #region QuanLyNhanVien
        private void btn_QuanLyNhanvien_Click(object sender, EventArgs e)
        {
            showSubMenu(GroupQuanLyNhanVien);
            
        }

        private void btn_DsNhanVien_Click(object sender, EventArgs e)
        {
            openChildForm(new DanhSachNhanVien());

            hideSubMenu();
        }

        private void btn_LichTrucPT_Click(object sender, EventArgs e)
        {
            openChildForm(new LichTrucPT.LichTrucPT());

            hideSubMenu();
        }

        #endregion

        private void btn_QuanLyThietbi_Click(object sender, EventArgs e)
        {
            openChildForm(new QuanLyThietBi());

            hideSubMenu();
        }
        private void btn_Scan_Click(object sender, EventArgs e)
        {
            openChildForm(new Scanning());

            hideSubMenu();
        }
        private void btn_attendance_Click(object sender, EventArgs e)
        {
            openChildForm(new Attendance());

            hideSubMenu();
        }
        private void btn_Phanhoi_Click(object sender, EventArgs e)
        {
            openChildForm(new QuanLyPhanHoi.QuanLyPhanHoi());

            hideSubMenu();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            container.Controls.Add(childForm);
            container.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            BW.RunWorkerAsync();
        }

        private void BW_DoWork(object sender, DoWorkEventArgs e)
        {
            using (MainDataClassesDataContext db = new MainDataClassesDataContext())
            {
                DateTime FiveYearsEarlierFromNow = DateTime.Today.Subtract(new TimeSpan(1825, 0, 0, 0));
                var foundMembers = db.Members.Where(item => item.ngayKetThuc.Value != null && FiveYearsEarlierFromNow > item.ngayKetThuc.Value);

                if (foundMembers.Count() > 0)
                {
                    db.Members.DeleteAllOnSubmit(foundMembers);
                    db.SubmitChanges();
                }
            }
        }

        private void btn_logout_Click(object sender, EventArgs e)
        { 
            this.Hide();
            var form1 = new Login();
            log.Insert("Logout");
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        private void logoPanel_Click(object sender, EventArgs e)
        {
            if (permissionlevel == 1)
            {
                openChildForm(new Loghistory());

                hideSubMenu();
            }
        }
    }
}
