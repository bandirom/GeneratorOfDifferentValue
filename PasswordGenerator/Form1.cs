using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using QRCoder;
using static QRCoder.QRCodeGenerator;

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public string GetHash(string input)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));
            return Convert.ToBase64String(hash);
        }

        private void Butt_Generate_Click(object sender, EventArgs e)
        {
            string pass = PasswordField.Text;
            pass = GetHash(pass);
            GeneratedPassField.Text = pass;

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void PasssVisible_CheckedChanged(object sender, EventArgs e)
        {
            PasswordField.PasswordChar = PasssVisible.Checked ? '\0' : '*';
        }

        private void Butt_QrGenerate_Click(object sender, EventArgs e)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(PasswordField.Text, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            //Bitmap qrCodeImage = qrCode.GetGraphic(20);
            pictureBoxQRCode.Image = qrCode.GetGraphic(20);
        }
    }
}
