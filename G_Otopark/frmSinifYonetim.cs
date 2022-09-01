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
    public partial class frmSinifYonetim : Form
    {

        public frmSinifYonetim()
        {
            InitializeComponent();
        }

        OtoParkDbEntities db = new OtoParkDbEntities();

        private void ComboBoxYenile()
        {
            var turler = db.SiniflarTBL.ToList();
            cboxTur.DataSource = turler;
            cboxTur.DisplayMember = "SinifAdi";
            cboxTur.ValueMember = "ID";

            var turler2 = db.SiniflarTBL.ToList();
            cboxTur2.DataSource = turler;
            cboxTur2.DisplayMember = "SinifAdi";
            cboxTur2.ValueMember = "ID";
        }

        private void frmFiyatList_Load(object sender, EventArgs e)
        {
            ComboBoxYenile();

        }

        private void btnFiyatGuncelle_Click(object sender, EventArgs e)
        {
            int sınıf = (int)cboxTur.SelectedValue;
            int num = Convert.ToInt32(numericUpDown1.Value);

            var guncelle = db.SiniflarTBL.Where(x => x.ID == sınıf).FirstOrDefault();
            guncelle.SınıfUcreti = num;
            db.SaveChanges();

            MessageBox.Show("Fiyat başarıyla güncellenmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ComboBoxYenile();
        }

        private void btnSınıfSil_Click(object sender, EventArgs e)
        {
            try
            {
                int sınıf = (int)cboxTur2.SelectedValue;

                var sil = db.SiniflarTBL.Where(x => x.ID == sınıf).FirstOrDefault();
                db.SiniflarTBL.Remove(sil);
                db.SaveChanges();

                MessageBox.Show("Araç sınıfı başarıyla silinmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ComboBoxYenile();
            }
            catch 
            {

                MessageBox.Show("Silmeye çalıştığımız sınıf garaj içerisinde bulunduğu için silemezsiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }

        private void btnSınıfEkle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtYeniAracAd.Text))
            {
                SiniflarTBL g = new SiniflarTBL();
                g.SinifAdi = txtYeniAracAd.Text;
                g.SınıfUcreti = 0;
                db.SiniflarTBL.Add(g);
                db.SaveChanges();
                txtYeniAracAd.Text = string.Empty;

                MessageBox.Show("Arac başarıyla eklenmiştir Fiyat = 0 TL, Fiyatını güncellemeyi unutmayın.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            ComboBoxYenile();




        }
    }
}
