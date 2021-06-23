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

namespace Gym_management_appication.UI.ThongKeHoiVien
{
    public partial class ThanhToan : Form
    {
        public ThanhToan()
        {
            InitializeComponent();
        }
        private AutoCompleteStringCollection GetAutoSourceCollectionFromTable(DataTable table)
        {
            AutoCompleteStringCollection autoSourceCollection = new AutoCompleteStringCollection();

            foreach (DataRow row in table.Rows)
            {
                autoSourceCollection.Add(row[0].ToString()); //assuming required data is in first column
            }

            return autoSourceCollection;
        }
        private void LoadData()
        {
            GoiTap data1 = new GoiTap();
            hoiVien data2 = new hoiVien();
            DataTable goiTapList = data1.getPlanList();
            DataTable hoiVienList = data2.getMemberList();

            cmb_goiTap.DataSource = goiTapList;
            cmb_goiTap.DisplayMember = "List";
            cmb_goiTap.ValueMember = "List";

            AutoCompleteStringCollection allowedTypes = new AutoCompleteStringCollection();
            allowedTypes = GetAutoSourceCollectionFromTable(hoiVienList);
            txt_maHV.AutoCompleteCustomSource = allowedTypes;
            txt_maHV.AutoCompleteMode = AutoCompleteMode.Suggest;
            txt_maHV.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //SetHeader();
        }
        private void SetHeader()
        {
            dtgv_PaymentHistory.Columns["HoiVien"].HeaderText = "Tên người trả";
            dtgv_PaymentHistory.Columns["dateOfPay"].HeaderText = "Ngày thanh toán";
            dtgv_PaymentHistory.Columns["Goi"].HeaderText = "Gói tập";
            dtgv_PaymentHistory.Columns["price"].HeaderText = "Số tiền";
        }
        private void retrieveInfo()
        {
            hoiVien data = new hoiVien();
            DataTable hoiVienList = data.getMemberpaymentinfo(txt_maHV.Text.Split('-')[0]);
            try
            {
                txt_tenHV.Text = txt_maHV.Text.Split('-')[1].Trim();
                cmb_goiTap.Text = (from DataRow dr in hoiVienList.Rows
                                   where true
                                   select (string)dr["Goi"]).LastOrDefault();
                txt_amount.Text = (from DataRow dr in hoiVienList.Rows
                                   where true
                                   select (int)dr["price"]).LastOrDefault().ToString();
                dtgv_PaymentHistory.DataSource = hoiVienList;
                SetHeader();
            }
            catch (Exception ex)
            {

            }
           
        }


        private void btn_ChangePlan_Click(object sender, EventArgs e)
        {
            cmb_goiTap.Enabled = true;
        }

        private void ThanhToan_Load(object sender, EventArgs e)
        {
            LoadData(); 
        }

        private void txt_maHV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                retrieveInfo();
            }
        }

        private void btn_Thanhtoan_Click(object sender, EventArgs e)
        {
            hoiVien data = new hoiVien();
            GoiTap data2 = new GoiTap();
            int Duration = data2.getDuration(cmb_goiTap.Text.Split('-')[0]);
            data.AddPayment(txt_maHV.Text.Split('-')[0], cmb_goiTap.Text.Split('-')[0], dtP_payDate.Value, Duration, int.Parse(txt_amount.Text));
            retrieveInfo();
        }

        private void xóaLịchSửGiaoDịchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Bạn muốn xóa lịch sử giao dịch này?", "Xóa hội viên", MessageBoxButtons.YesNo);
            if (dlg == DialogResult.Yes)
            {
                int currentRowIndex = dtgv_PaymentHistory.CurrentCellAddress.Y;// 'current row selected
                if (-1 < currentRowIndex && currentRowIndex < dtgv_PaymentHistory.RowCount)
                {
                    hoiVien data = new hoiVien();
                    string mahv = data.GetIDfromName(dtgv_PaymentHistory.Rows[currentRowIndex].Cells["HoiVien"].Value.ToString());
                    DateTime payDate = Convert.ToDateTime(dtgv_PaymentHistory.Rows[currentRowIndex].Cells["dateOfPay"].Value.ToString());
                    data.DeletePayment(mahv, payDate);
                    retrieveInfo();
                }
            }
        }

        private void txt_maHV_Leave(object sender, EventArgs e)
        {
            retrieveInfo();
        }
    }
}
