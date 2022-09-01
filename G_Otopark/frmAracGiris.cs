using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.Remoting.Contexts;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Sql;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;

namespace G_Otopark
{
    public partial class frmAracGiris : Form
    {

        public frmAracGiris()
        {
            InitializeComponent();
        }

        OtoParkDbEntities db = new OtoParkDbEntities();

        private void frmAracGiris_Load(object sender, EventArgs e)
        {
            txtPlaka.CharacterCasing = CharacterCasing.Upper;

            var turler = db.SiniflarTBL.ToList();
            cboxTur.DataSource = turler;
            cboxTur.DisplayMember = "SinifAdi";
            cboxTur.ValueMember = "ID";

            var otoparklar = db.OtoparkTBL.ToList();

            cboxOtopark.DataSource = otoparklar;
            cboxOtopark.DisplayMember = "OtoparkAd";
            cboxOtopark.ValueMember = "ID";



            cboxOtopark.Text = string.Empty;
            cboxTur.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cboxKat.SelectedIndex == -1)
                return;

            string plaka = txtPlaka.Text;
            DateTime GTarih = DateTime.Now;
            var kat = cboxKat.SelectedItem as KatTBL;

            if (!string.IsNullOrEmpty(txtPlaka.Text) && (kat.Kapasite > kat.G_CTBL.Where(x => x.Icerdemi).Count()))
            {
                G_CTBL g = new G_CTBL();
                g.SinifID = (int)cboxTur.SelectedValue;
                g.KatTBL = kat;
                g.Plaka = plaka;
                g.GirisZaman = GTarih;
                g.Icerdemi = true;
                db.G_CTBL.Add(g);
                db.SaveChanges();
                MessageBox.Show("Araç Başarıyla Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPlaka.Text = string.Empty;



            }

            else
            {
                MessageBox.Show("Tüm Alanları Doldur", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void txtPlaka_TextChanged(object sender, EventArgs e)
        {
            var icerde = (from x in db.G_CTBL
                          where x.Icerdemi == false && x.Plaka.Replace(" ", "") == txtPlaka.Text.Replace(" ", "")
                          select x).FirstOrDefault();
            if (icerde != null)
            {
                cboxOtopark.SelectedValue = icerde.KatTBL.OtoparkTBL;
                cboxTur.SelectedValue = icerde.SiniflarTBL;
            }

        }

        private void cboxOtopark_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id=(cboxOtopark.SelectedItem as OtoparkTBL).ID;

            var katlar = db.KatTBL.Where(x => x.OtoparkID == id && x.Kapasite > x.G_CTBL.Where(y => y.Icerdemi).Count());
                cboxKat.DataSource = katlar.ToList();

                cboxKat.DisplayMember = "KatNo";
                cboxKat.ValueMember = "ID";


        }





    }
}


