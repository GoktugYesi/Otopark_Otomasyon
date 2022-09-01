using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G_Otopark
{
    public partial class frmOtopark : Form
    {


        OtoParkDbEntities db = new OtoParkDbEntities();

        public frmOtopark()
        {
            InitializeComponent();

            this.IsMdiContainer = true;
        }

    private void formac(Form frm)
        {
            pnlAna.Controls.Clear();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            pnlAna.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void btnAracGiris_Click(object sender, EventArgs e)
        {
            formac(new frmAracGiris());
        }

        private void btnAracCıkıs_Click(object sender, EventArgs e)
        {
            formac(new frmAracCıkıs());
        }

        private void btnGecmis_Click(object sender, EventArgs e)
        {
            formac(new frmAracGecmis());
        }

        private void btnGarajlar_Click(object sender, EventArgs e)
        {
            formac(new frmGarajYonetim());
        }

        private void btnFiyat_Click(object sender, EventArgs e)
        {
            formac(new frmSinifYonetim());
        }

        private void btnGarajEkle_Click(object sender, EventArgs e)
        {
            formac(new frmGarajlar());
        }

        public int yetkiID { get; set; }
        public string yetkiliAd { get; set; }

        private void frmOtopark_Load(object sender, EventArgs e)
        {
            Form1 frm = new Form1(this);
            Ligin(frm);


             void Ligin(Form1 form)
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    timer1.Start();
                    label4.Text = yetkiliAd + " Hoşgeldiniz";
                }
                else
                {
                   Close();
                }
            }

            if (yetkiID == 2)
            {
                
                btnFiyat.Enabled = false;
                btnGecmis.Enabled = false;
                btnAnaliz.Enabled = false;
                btnGarajYonetim.Enabled = false;



                btnGarajYonetim.Location = new Point(3, 3);
                btnGecmis.Location = new Point(3, 86);
                btnAracGiris.Location = new Point(3, 170);
                btnAracCıkıs.Location = new Point(3, 254);
                btnGarajlar.Location = new Point(3, 338);
                btnFiyat.Location = new Point(3, 422);
                btnAnaliz.Location = new Point(3, 506);
            }
            else if(yetkiID == 1)
            {

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnAnaliz_Click(object sender, EventArgs e)
        {
            formac(new frmAnaliz());
        }
    }
}
