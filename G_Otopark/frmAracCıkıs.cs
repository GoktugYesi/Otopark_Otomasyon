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
    public partial class frmAracCıkıs : Form
    {
        private G_CTBL kayit;

        public frmAracCıkıs()
        {
            InitializeComponent();
        }

        OtoParkDbEntities db = new OtoParkDbEntities();

        private void IcerdeAracDATA()
        {
            var ıcerde = from x in db.G_CTBL
                         where (x.Icerdemi == true)
                         select new
                         {
                             Otopark = x.KatTBL.OtoparkTBL.OtoparkAd,
                             Kat = x.KatTBL.KatNo,
                             Plaka = x.Plaka,
                             Sınıf = x.SiniflarTBL.SinifAdi,
                             Giriş_Tarih = x.GirisZaman
                         };
            dataGridView1.DataSource = ıcerde.ToList();
        }

        private void frmAracCıkıs_Load(object sender, EventArgs e)
        {
            IcerdeAracDATA();
            

            //*******************************************************************************************\\
            txtPlaka.CharacterCasing = CharacterCasing.Upper;

            var turler = db.SiniflarTBL.ToList();
            cboxTur.DataSource = turler;
            cboxTur.DisplayMember = "SinifAdi";
            cboxTur.ValueMember = "ID";

            var otoparklar = db.OtoparkTBL.ToList();
            cboxOtopark.DataSource = otoparklar;
            cboxOtopark.DisplayMember = "OtoparkAd";
            cboxOtopark.ValueMember = "ID";

            txtPlaka.Text = string.Empty;
            
        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cboxOtopark.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtPlaka.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            cboxTur.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void tnCıkıs_Click(object sender, EventArgs e)
        {
            
           kayit = db.G_CTBL.FirstOrDefault(x => x.Icerdemi && x.Plaka == txtPlaka.Text);

            if (kayit != null)
            {
                tnCıkıs.Enabled = true;
                kayit.CıkısZaman = DateTime.Now;
                kayit.Ucret = (int)(kayit.CıkısZaman.Value - kayit.GirisZaman).TotalHours * kayit.SiniflarTBL.SınıfUcreti;

                decimal ucretTL = Math.Round(kayit.Ucret.Value, 2); 

                lblUcret.Text = ucretTL.ToString() + " TL";

                kayit.Icerdemi = false;
                kayit.CıkısZaman = DateTime.Now;
                kayit.Ucret = ucretTL;
                db.SaveChanges();

                MessageBox.Show("Araç Başarıyla Çıkartıldı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

            }
            IcerdeAracDATA();

            /*     G_CTBL g = db.G_CTBL.FirstOrDefault(x=>x.Plaka==txtPlaka.Text);
                 g.CıkısZaman = cıkısZ;
                 g.Icerdemi = false;
                 db.SaveChanges();
               */
            /*  

              var result = db.G_CTBL.SingleOrDefault(b => b.Icerdemi == true);
              if (result != null)
              {
                  result.Icerdemi = false;
                  result.CıkısZaman = cıkısZ;
                  db.SaveChanges();
              }
            */
            
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cboxOtopark.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            cboxKat.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtPlaka.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            cboxTur.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

        }

        private void btnFiltre_Click(object sender, EventArgs e)
        {
            int oto = Convert.ToInt32(cboxOtopark.SelectedValue);
            int tur = Convert.ToInt32(cboxTur.SelectedValue);

            var varmi = cboxOtopark.SelectedIndex > -1;
            if (!string.IsNullOrEmpty(cboxTur.SelectedText) || !string.IsNullOrEmpty(cboxOtopark.SelectedText) || !string.IsNullOrEmpty(txtPlaka.Text))
            {
                if (!string.IsNullOrEmpty(txtPlaka.Text))
                {
                    var ıcerde = from x in db.G_CTBL
                                 where x.Icerdemi == true && x.Plaka.Replace(" ", "") == txtPlaka.Text.Replace(" ", "")
                                 select new
                                 {
                                     Otopark = x.KatTBL.OtoparkTBL.OtoparkAd,
                                     Plaka = x.Plaka,
                                     Sınıf = x.SiniflarTBL.SinifAdi,
                                     Giriş_Tarih = x.GirisZaman
                                 };

                    dataGridView1.DataSource = ıcerde.ToList();
                }
                else if (!string.IsNullOrEmpty(cboxTur.SelectedText) && !string.IsNullOrEmpty(cboxOtopark.SelectedText))
                {
                    var ıcerde = from x in db.G_CTBL
                                 where x.Icerdemi == true && x.KatTBL.OtoparkID == oto && x.SinifID == tur
                                 select new
                                 {
                                     Otopark = x.KatTBL.OtoparkTBL.OtoparkAd,
                                     Plaka = x.Plaka,
                                     Sınıf = x.SiniflarTBL.SinifAdi,
                                     Giriş_Tarih = x.GirisZaman
                                 };

                    dataGridView1.DataSource = ıcerde.ToList();

                }
                else if ((!string.IsNullOrEmpty(cboxOtopark.SelectedText)))
                {
                    var ıcerde = from x in db.G_CTBL
                                 where x.Icerdemi == true && x.KatTBL.OtoparkID == oto
                                 select new
                                 {
                                     Otopark = x.KatTBL.OtoparkTBL.OtoparkAd,
                                     Plaka = x.Plaka,
                                     Sınıf = x.SiniflarTBL.SinifAdi,
                                     Giriş_Tarih = x.GirisZaman
                                 };

                    dataGridView1.DataSource = ıcerde.ToList();

                }
                else if ((!string.IsNullOrEmpty(cboxTur.SelectedText)))
                {
                    var ıcerde = from x in db.G_CTBL
                                 where x.Icerdemi == true && x.SinifID == tur
                                 select new
                                 {
                                     Otopark = x.KatTBL.OtoparkTBL.OtoparkAd,
                                     Plaka = x.Plaka,
                                     Sınıf = x.SiniflarTBL.SinifAdi,
                                     Giriş_Tarih = x.GirisZaman
                                 };

                    dataGridView1.DataSource = ıcerde.ToList();

                }
            }

            else
            {
                IcerdeAracDATA();
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
    }
}
