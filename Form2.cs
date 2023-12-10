using QRCoder;

namespace Modul_9
{
    public partial class Form2 : Form
    {
        Form1 f1;

        public Form2(Form1 frm1)
        {
            InitializeComponent();
            this.f1 = frm1;
        }

        public static string GenerateQR(string nama, string alamat, string no_hp)
        {
            string result = "#" + nama + alamat + no_hp;
            return result;

        }

        public static string GenerateQR(string nama, string alamat, string no_hp, out Bitmap bitMap)
        {
            string text = GenerateQR(nama, alamat, no_hp);
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(text, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            bitMap = qrCode.GetGraphic(7);
            return text;

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Bitmap qr;
            string nama = f1.tbNama.Text;
            string alamat = f1.tbAlamat.Text;
            string no_hp = f1.tbHp.Text;
            lb_qr.Text = GenerateQR(nama, alamat, no_hp, out qr);

            pb_qr.BackgroundImage = qr;
        }
    }
}
