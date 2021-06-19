using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;

namespace Gym_management_appication.UI.QuanLyHoiVien.QRCodeFeature {
    public partial class QRCodeForm : Form {
        public QRCodeForm() {
            InitializeComponent();
        }

        public QRCodeForm(string id) {
            InitializeComponent();

            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(id, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);

            pictureBox1.Image = qrCodeImage;

        }
    }
}
