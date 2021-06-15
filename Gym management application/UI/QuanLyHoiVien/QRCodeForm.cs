using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_management_appication.UI.QuanLyHoiVien {
    public partial class QRCodeForm : Form {
        private string id;
        public QRCodeForm() {
            InitializeComponent();
        }

        public QRCodeForm(string id) {
            InitializeComponent();
            this.id = id;

            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(this.id, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);

            pictureBox1.Image = qrCodeImage;

        }
    }
}
