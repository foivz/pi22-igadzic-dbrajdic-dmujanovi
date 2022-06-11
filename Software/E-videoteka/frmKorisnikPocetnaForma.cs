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
    public partial class frmKorisnikPocetnaForma : Form
    {
        public Korisnik proslijedeniKorisnik;
        public frmKorisnikPocetnaForma(Korisnik proslijedeni)
        {
            proslijedeniKorisnik = proslijedeni;
            InitializeComponent();
        }

        private void frmKorisnikPocetnaForma_Load(object sender, EventArgs e)
        {

        }

        private void btnMojProfil_Click(object sender, EventArgs e)
        {
            frmMojProfil forma = new frmMojProfil(proslijedeniKorisnik);
            forma.ShowDialog();
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnVideoteka_Click(object sender, EventArgs e)
        {

        }
    }
}
