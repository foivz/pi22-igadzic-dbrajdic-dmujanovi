using System;
using System.Windows.Forms;

namespace E_videoteka
{
    public partial class frmPrijava : Form
    {
        public static Korisnik ulogirani = new Korisnik();
        Autentifikator autentifikator = new Autentifikator();
        RepozitorijKorisnika repozitorij = new RepozitorijKorisnika();
        public frmPrijava()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            frmRegistracija form = new frmRegistracija();
            form.ShowDialog();
            this.Hide();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            string username = txtbUsername.Text;
            string password = txtbPassword.Text;
            if (txtbUsername.Text == "" || txtbPassword.Text == "")
            {
                throw new ValidacijaPrijaveException("Polja ne mogu biti prazna.");
            }

            txtbPassword.Clear();
            txtbUsername.Clear();
            repozitorij.ProvjeriPrijavu(username, password); 
            Korisnik dohvaceniKorisnik = repozitorij.DohvatiKorisnika(username,password);
            ulogirani = dohvaceniKorisnik;
            if (dohvaceniKorisnik.Uloga == "Korisnik")
            {
                this.Hide();
                frmKorisnikPocetnaForma forma = new frmKorisnikPocetnaForma(dohvaceniKorisnik);
                forma.ShowDialog();
            }
            if(dohvaceniKorisnik.Uloga == "Admin")
            {
                this.Hide();
                frmAdminGlavna forma = new frmAdminGlavna();
                forma.ShowDialog();
            }
             if (dohvaceniKorisnik.Uloga == "Recenzent")
            {
                this.Hide();
                frmGlavnaRecenzent forma = new frmGlavnaRecenzent();
                forma.ShowDialog();
            }
           
        }

        private void frmPrijava_Load(object sender, EventArgs e)
        {

        }
    }
}
