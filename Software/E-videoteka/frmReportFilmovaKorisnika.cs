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
    public partial class frmReportFilmovaKorisnika : Form
    {
        public int idProslijedenogKorisnika;
        public frmReportFilmovaKorisnika(int korisnik)
        {
           
            InitializeComponent();
            idProslijedenogKorisnika = korisnik;
        }

        private void frmReportFilmovaKorisnika_Load(object sender, EventArgs e)
        {
            using(var context = new PI2247_DBEntities1())
            {
                var query = from c in context.Korisniks
                            where c.ID_Korisnik == idProslijedenogKorisnika
                            select c;
                Korisnik odabrani = query.Single();
                KorisnikBindingSource.DataSource = odabrani;

                var upit = from f in context.Films
                           where f.ID_Korsinik == idProslijedenogKorisnika
                           select f;
                List<Film> listaFilmova = upit.ToList();
                FilmBindingSource.DataSource = listaFilmova;
            }

            this.reportViewer.RefreshReport();
        }

        private void reportViewer_Load(object sender, EventArgs e)
        {

        }
    }
}
