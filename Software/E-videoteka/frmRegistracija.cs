using System;
using System.Windows.Forms;

namespace E_videoteka
{
    public partial class frmRegistracija : Form
    {
        public Autentifikator autentifikator = new Autentifikator();
        public PokretacServisa pokretacServisa = new PokretacServisa();
        public frmRegistracija()
        {
            InitializeComponent();
        }

        private void btnRegistriajSe_Click(object sender, EventArgs e)
        {
            string ime = txtbIme.Text;
            string prezime = txtbPrezime.Text;
            string email = txtbEmail.Text;
            string username = txtbUsername.Text;
            string password = txtbLozinka.Text;
            string passwordrep = txtbPonovnaLozinka.Text;

            autentifikator.Registracija(ime, prezime, email, username, password, passwordrep);
            pokretacServisa.PokreniServer();
            Close();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmRegistracija_Load(object sender, EventArgs e)
        {

        }
    }
}
