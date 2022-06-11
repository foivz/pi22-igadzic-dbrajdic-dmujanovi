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
    public partial class frmAdminUpravljanjeKorisnicima : Form
    {
        public frmAdminUpravljanjeKorisnicima()
        {
            InitializeComponent();
        }

        private void frmAdminUpravljanjeKorisnicima_Load(object sender, EventArgs e)
        {
            DohvatiKorisnike();
        }

        private void DohvatiKorisnike()
        {
            using (var context = new PI2247_DBEntities3())
            {
                var query = from p in context.Korisniks
                            select p;
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            
            using (var context = new PI2247_DBEntities3())
            {
                Korisnik selektirani = dgvUpravljanjeKorsincima.CurrentRow.DataBoundItem as Korisnik;
                context.Korisniks.Remove(selektirani);
                context.SaveChanges();
            }
            DohvatiKorisnike();
        }

        private void btnUrediKorisnika_Click(object sender, EventArgs e)
        {
            Korisnik selektirani = dgvUpravljanjeKorsincima.CurrentRow.DataBoundItem as Korisnik;
            frmIzmjeniKorisnikaAdmin frmIzmjeni = new frmIzmjeniKorisnikaAdmin(selektirani);
            frmIzmjeni.ShowDialog();

            DohvatiKorisnike();
        }
    }
}
