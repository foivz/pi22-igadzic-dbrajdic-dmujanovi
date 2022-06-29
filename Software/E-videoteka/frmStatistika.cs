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
    public partial class frmStatistika : Form
    {
        public frmStatistika()
        {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmStatistika_Load(object sender, EventArgs e)
        {
            PopuniDgv();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(frmStatistika_KeyDown);
        }

        private void PopuniDgv()
        {
            List<Korisnik> listaSvihKorisnika = new List<Korisnik>();
            using (var context = new PI2247_DBEntities1())
            {
                var query = from k in context.Korisniks
                            select k;
                listaSvihKorisnika = query.ToList();
                dgvPopisSvihKorisnika.DataSource = listaSvihKorisnika;
                dgvPopisSvihKorisnika.Columns["Films"].Visible = false;
                dgvPopisSvihKorisnika.Columns["Adresa"].Visible = false;
                dgvPopisSvihKorisnika.Columns["Uloga"].Visible = false;
                dgvPopisSvihKorisnika.Columns["Email"].Visible = false;
                dgvPopisSvihKorisnika.Columns["Password"].Visible = false;
                dgvPopisSvihKorisnika.Columns["ID_Korisnik"].Visible = false;
            }
        }

        private void frmStatistika_KeyDown(object sender, KeyEventArgs e)
        {
                if (e.KeyCode == Keys.F1)
            {
                var path = System.IO.Path.GetDirectoryName(
                 System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
                path = path.Substring(6);
                string cijeli = "File://" + path + "\\UserManual\\UserManual.chm";
                Help.ShowHelp(this, cijeli, HelpNavigator.Topic, "StatistikaForma.htm");
            }
        }

        private void dgvPopisSvihKorisnika_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Korisnik odabraniKorisnik = dgvPopisSvihKorisnika.CurrentRow.DataBoundItem as Korisnik;
            List<Film> listaFilmovaOdabranogKorisnika = new List<Film>();
            using(var context = new PI2247_DBEntities1())
            {
                context.Korisniks.Attach(odabraniKorisnik);
                var query = from f in odabraniKorisnik.Films
                            select f;
                listaFilmovaOdabranogKorisnika = query.ToList();
                dgvPopisSvihFilmova.DataSource = listaFilmovaOdabranogKorisnika;
                dgvPopisSvihFilmova.Columns["ID_Korsinik"].Visible = false;
                dgvPopisSvihFilmova.Columns["ID_Film"].Visible = false;
                dgvPopisSvihFilmova.Columns["LokacijaFilma"].Visible = false;
                dgvPopisSvihFilmova.Columns["Odobren"].Visible = false;
                dgvPopisSvihFilmova.Columns["Korisnik"].Visible = false;
            }
        }
    }
}
