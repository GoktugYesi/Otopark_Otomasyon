using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System;

namespace G_Otopark
{

    public partial class Form1 : Form
    {
        public Form1(frmOtopark frm)
        {
            InitializeComponent();
            _frmOtopark = frm;
        }



        OtoParkDbEntities db = new OtoParkDbEntities();
        private frmOtopark _frmOtopark;

        private void Form1_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            AcceptButton = button1;



        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {

                txtPassword.UseSystemPasswordChar = false;
                checkBox1.Text = "Şifreyi Gizle";
            }
            else if (checkBox1.CheckState == CheckState.Unchecked)
            {
                txtPassword.UseSystemPasswordChar = true;
                checkBox1.Text = "Şifreyi Göster";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var sorgu = (from x in db.KullanıcıTBL where x.NickName == txtID.Text && x.KullanıcıSifre == txtPassword.Text select x).FirstOrDefault();



            if (sorgu != null)
            {
                _frmOtopark.yetkiID = sorgu.YetkiID;
                _frmOtopark.yetkiliAd = sorgu.KullanıcıAdSoyad;


                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı ID/Şifre", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
