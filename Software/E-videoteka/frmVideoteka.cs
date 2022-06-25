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
        }

        private void frmVideoteka_Load(object sender, EventArgs e)
        {
            DohvatiDostupneFilmove();
            rbtnUkljuci.Checked = true;
        }

        private void DohvatiDostupneFilmove()
        {
            if (rbtnUkljuci.Enabled)
            {
                using (var context = new PI2247_DBEntities1())
                {
                    var query = from p in context.Films
                                where p.Odobren.ToString() == "Da"
                                select p;
                    dgvDostupniFilmovi.DataSource = query.ToList();
                }
            }
        }

        private void btnSviFilmovi_Click(object sender, EventArgs e)
        {
            DohvatiDostupneFilmove();
        }

        private void btnMojiFilmovi_Click(object sender, EventArgs e)
        {
            using (var context = new PI2247_DBEntities1())
            {
                context.Korisniks.Attach(frmPrijava.ulogirani);
                var query = from f in frmPrijava.ulogirani.Films
                            select f;
                dgvDostupniFilmovi.DataSource = query.ToList();
            }
        }

        private void btnPohrani_Click(object sender, EventArgs e)
        {
            if(rbtnUkljuci.Checked)
            {
                PokretacServisa.pokreniServis();
            }
            if(rbtnIskljuci.Checked)
            {
                PokretacServisa.zaustaviServis();
            }
        }
    }
}
