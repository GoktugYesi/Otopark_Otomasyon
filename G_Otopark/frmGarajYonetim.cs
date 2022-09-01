using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G_Otopark
{
    public partial class frmGarajYonetim : Form
    {
        

        public frmGarajYonetim()
        {
            InitializeComponent();
        }

        OtoParkDbEntities db = new OtoParkDbEntities();

        private void ComboBoxYenile()
        {
            var otoparklar = db.OtoparkTBL.ToList();
            cboxOtopark.DataSource = otoparklar;
            cboxOtopark.DisplayMember = "OtoparkAd";
            cboxOtopark.ValueMember = "ID";

            var otoparklarSil = db.OtoparkTBL.ToList();
            cboxOtoparkSil.DataSource = otoparklar;
            cboxOtoparkSil.DisplayMember = "OtoparkAd";
            cboxOtoparkSil.ValueMember = "ID";

        }

        private void frmGarajlar_Load(object sender, EventArgs e)
        {
            ComboBoxYenile();

        }

        private void numericUpDown1_MouseDown(object sender, MouseEventArgs e)
        {
            if (nm1.Minimum == nm1.Value)
            {
                MessageBox.Show("Şuanda otoparkta bulunan araç sayısına geldiniz bu sayıyı daha fazla düşürmek için otoparkta " +
                    "bulunan araçları çıkartınız",
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cboxOtopark_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxOtopark.SelectedIndex > -1)
            {

                var katlar = (cboxOtopark.SelectedItem as OtoparkTBL).KatTBL;
                cboxKat.DataSource = katlar.ToList();

                cboxKat.DisplayMember = "KatNo";
                cboxKat.ValueMember = "ID";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(nm1.Value);
            int garaj = (int)cboxOtopark.SelectedValue;

            var guncelle = db.KatTBL.Where(x=> x.OtoparkTBL.ID == garaj).FirstOrDefault();
            guncelle.Kapasite = num;
            db.SaveChanges();

            ComboBoxYenile();

        }

        private void cboxKat_SelectedIndexChanged(object sender, EventArgs e)
        {
            var kat = (cboxKat.SelectedItem as KatTBL);
            nm1.Minimum = kat.G_CTBL.Where(x=>x.Icerdemi).Count();

            nm1.Value=  kat.Kapasite;

        }

        private void btnSınıfEkle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cboxKat.Text))
            {
                int kapasite = Convert.ToInt32(nm1.Value);

                KatTBL g = new KatTBL();
                g.OtoparkID = (int)cboxOtopark.SelectedValue;
                g.KatNo = cboxKat.Text;
                g.Kapasite = kapasite;
                db.KatTBL.Add(g);
                db.SaveChanges();


                ComboBoxYenile();

                MessageBox.Show("Kat başarıyla eklenmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

                int otopark = (int)cboxOtopark.SelectedValue;
                int kat = (int)cboxKat.SelectedValue;

                var sil = db.KatTBL.Where(x => x.ID == kat).FirstOrDefault();
                db.KatTBL.Remove(sil);
                db.SaveChanges();

                MessageBox.Show("Kat başarıyla silinmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ComboBoxYenile();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtOtoparkAd.Text))
            {
                OtoparkTBL g = new OtoparkTBL();
                g.OtoparkAd = txtOtoparkAd.Text;
                db.OtoparkTBL.Add(g);
                db.SaveChanges();


                ComboBoxYenile();

                MessageBox.Show("Otopark Başarıyla Eklenmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtOtoparkAd.Text = string.Empty;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                int otopark = (int)cboxOtoparkSil.SelectedValue;
                

                var sil = db.OtoparkTBL.Where(x => x.ID == otopark).FirstOrDefault();
                db.OtoparkTBL.Remove(sil);
                db.SaveChanges();

                MessageBox.Show("Otopark başarıyla silinmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ComboBoxYenile();
            }
            catch
            {
                MessageBox.Show("Otoparkın içerisinde Araç olabilir yada Mevcut otoparkta kat bulunuyo olabilir!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }


        }
    }
}


// Kullanıcı Garaj Ekleyebilecek ve garajı silebilecek