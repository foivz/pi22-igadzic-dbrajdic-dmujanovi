using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_videoteka
{
    public partial class frmReportSvihKorisnika : Form
    {
        public frmReportSvihKorisnika()
        {
            InitializeComponent();
        }

        private void frmReportSvihKorisnika_Load(object sender, EventArgs e)
        {
            DohvatiPodatke();
            this.reportViewer.RefreshReport();
        }

        private void DohvatiPodatke()
        {
            List<Korisnik> listaKorisnika = new List<Korisnik>();
            using(var context = new PI2247_DBEntities1())
            {
                var query = from c in context.Korisniks
                            select c;
                listaKorisnika = query.ToList();
                KorisnikBindingSource.DataSource = listaKorisnika;
            }
        }
    }
}
