using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_management_appication.UI
{
    public partial class NhanVien : UserControl
    {
        public NhanVien()
        {
            InitializeComponent();
        }

        private void CheckBoxNam_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxNam.Checked == true)
                this.checkBoxNu.Checked = false;
        }

        private void CheckBoxNu_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxNu.Checked == true)
                this.checkBoxNam.Checked = false;

        }
    }
}
