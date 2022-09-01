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
    public partial class frmAnaliz : Form
    {
        public frmAnaliz()
        {
            InitializeComponent();
        }
        OtoParkDbEntities db = new OtoParkDbEntities();

        private void button1_Click(object sender, EventArgs e)
        {
            
            DateTime Baslangic = dateTimeBaslangic.Value.Date +
                    TimeBaslangic.Value.TimeOfDay;

            DateTime Bitis = dateTimeBitis.Value.Date +
                    TimeBitis.Value.TimeOfDay;
            

            var icerde = (from x in db.G_CTBL
                          where x.CıkısZaman != null &&
                         /* x.Icerdemi == false &&
                          x.CıkısZaman.Value.Year >= Baslangic.Year &&
                          x.CıkısZaman.Value.Month >= Baslangic.Month &&
                          x.CıkısZaman.Value.Day >= Baslangic.Day && 
                          

                          x.CıkısZaman.Value.Year <= Bitis.Year &&
                          x.CıkısZaman.Value.Month <= Bitis.Month &&
                          x.CıkısZaman.Value.Day <= Bitis.Day*/
                          
                          x.CıkısZaman.Value >= Baslangic &&
                          x.CıkısZaman.Value <= Bitis

                          select x);

            lblTotalPara.Text = icerde.Sum(x => x.Ucret).ToString();
            lblTotalAracGC.Text = icerde.Count().ToString();

        }

        private void frmAnaliz_Load(object sender, EventArgs e)
        {
            dateTimeBaslangic.CustomFormat = "dd   MMMM    yyyy ";
            dateTimeBitis.CustomFormat = "dd   MMMM    yyyy ";
            TimeBaslangic.ShowUpDown = true;
            TimeBitis.ShowUpDown = true;
        }
    }
}
