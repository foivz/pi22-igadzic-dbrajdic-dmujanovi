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
    public partial class frmOdobravanjeFilmova : Form
    {
        public static List<Film> popisFilmovaNaCekanju = new List<Film>();
        public frmOdobravanjeFilmova()
        {
            InitializeComponent();
        }

        private void frmOdobravanjeFilmova_Load(object sender, EventArgs e)
        {
            OsvjeziPopisFilmova();
            
        }

        private void OsvjeziPopisFilmova()
        {
            dgvPopisFilmovaNaListiČekanja.DataSource = null;
            dgvPopisFilmovaNaListiČekanja.DataSource = popisFilmovaNaCekanju;
            dgvPopisFilmovaNaListiČekanja.Columns["Korisnik"].Visible = false;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOdobri_Click(object sender, EventArgs e)
        {
            DodajFilmUBazu();
           
        }

        private void DodajFilmUBazu()
        {
            Film odabraniFilm = dgvPopisFilmovaNaListiČekanja.CurrentRow.DataBoundItem as Film;
          
            

            int idkorisnika = odabraniFilm.ID_Korsinik;
            Korisnik cijiJeFilm = new Korisnik();
            List<Korisnik> listaKorisnika = new List<Korisnik>();
            var context = new PI2247_DBEntities1();
                 
                var query = from k in context.Korisniks
                            select k;
                listaKorisnika = query.ToList();
                foreach (Korisnik item in listaKorisnika)
                {
                    if(item.ID_Korisnik == idkorisnika)
                    {
                        cijiJeFilm = item;
                        break;
                    }
                }
                     context.Korisniks.Attach(cijiJeFilm);
                     cijiJeFilm.Films.Add(odabraniFilm);
                     context.SaveChanges();
            dgvPopisFilmovaNaListiČekanja.DataSource = null;
            popisFilmovaNaCekanju.Remove(odabraniFilm);
            dgvPopisFilmovaNaListiČekanja.DataSource = popisFilmovaNaCekanju;
        }

        private void btnUkloni_Click(object sender, EventArgs e)
        {
            Film odabraniFilm = dgvPopisFilmovaNaListiČekanja.CurrentRow.DataBoundItem as Film;
            popisFilmovaNaCekanju.Remove(odabraniFilm);
            OsvjeziPopisFilmova();

        }
    }
}
