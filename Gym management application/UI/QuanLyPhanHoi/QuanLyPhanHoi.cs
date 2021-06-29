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
using Gym_management_appication.Database;

namespace Gym_management_appication.UI.QuanLyPhanHoi
{
    public partial class QuanLyPhanHoi : Form
    {
        Log Log = new Log();
        public QuanLyPhanHoi()
        {
            InitializeComponent();
        }



        private void btn_sendReview_Click(object sender, EventArgs e)
        {
            feedBack feedBack = new feedBack();
            feedBack.maHV = txt_memberName.Text;
            feedBack.date = dtP_reviewDate.Value;
            feedBack.feedback = txt_review.Text;
            feedBackDB database = new feedBackDB();
            if (database.Insert(feedBack))
            {
                MessageBox.Show("Gửi phản hồi thành công.");
                Log.Insert("Gửi phản hồi từ khách hàng " + txt_memberName);
                txt_memberName.Text = "";
                txt_review.Text = "";
            }else
            {
                MessageBox.Show("Gửi phản hồi thất bại, vui lòng thử lại.");
            }
           
        }

        private void btn_watchReview_Click(object sender, EventArgs e)
        {
            XemPhanHoi frmXemPhanHoi = new XemPhanHoi();
            Log.Insert("Xem phản hồi từ khách hàng");
            frmXemPhanHoi.Show();
        }
    }
}
