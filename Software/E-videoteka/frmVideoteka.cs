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
    public partial class frmVideoteka : Form
    {
        public frmVideoteka()
        {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDodajFilm_Click(object sender, EventArgs e)
        {
            //this.Hide();
            frmDodajFilm forma = new frmDodajFilm();
            forma.ShowDialog();
            this.Show();
            PopuniDataGrid();
        }

        private void btnMojiFilmovi_Click(object sender, EventArgs e)
        {
            using(var context = new PI2247_DBEntities4())
            {
                context.Korisniks.Attach(frmPrijava.ulogirani);
                var query = from f in frmPrijava.ulogirani.Filmovis
                            select f;
                dgvDostupniFilmovi.DataSource = query.ToList();
                dgvDostupniFilmovi.Columns["Korisnik"].Visible = false;
            }
        }

        private void frmVideoteka_Load(object sender, EventArgs e)
        {
            PopuniDataGrid();
        }


        
        private void PopuniDataGrid()
        {
            //treba dodati jos da provjerava dal je windows servis ukljucen ili ne

            List<Filmovi> listaSvihFilmova = new List<Filmovi>();
            using (var context = new PI2247_DBEntities4())
            {
                foreach (Korisnik korisnik in context.Korisniks)
                {
                    foreach (Filmovi f in korisnik.Filmovis)
                    {
                        listaSvihFilmova.Add(f);
                    }
                }
            }
            dgvDostupniFilmovi.DataSource = null;
            dgvDostupniFilmovi.DataSource = listaSvihFilmova;
            dgvDostupniFilmovi.Columns["Korisnik"].Visible = false;
        }

        private void btnSviFilmovi_Click(object sender, EventArgs e)
        {
            PopuniDataGrid();
        }
    }
}
