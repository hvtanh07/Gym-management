using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_management_appication.UI.QuanLyPhanHoi
{
    public partial class QuanLyPhanHoi : Form
    {
        public QuanLyPhanHoi()
        {
            InitializeComponent();
        }



        private void btn_sendReview_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gửi phản hồi thành công");
            txt_memberName.Text = "";
            rTB_review.Text = "";
            dtP_reviewDate.Format = DateTimePickerFormat.Custom;
            dtP_reviewDate.CustomFormat = "dd/MM/yyyy";
        }

        private void btn_watchReview_Click(object sender, EventArgs e)
        {
            XemPhanHoi frmXemPhanHoi = new XemPhanHoi();
            frmXemPhanHoi.Show();
        }
    }
}
