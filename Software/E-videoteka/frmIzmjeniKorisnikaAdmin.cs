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
    public partial class frmIzmjeniKorisnikaAdmin : Form
    {
        public Korisnik selektirani;
        public frmIzmjeniKorisnikaAdmin(Korisnik selektiraniKorisnik)
        {
            InitializeComponent();
            selektirani = selektiraniKorisnik;
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            
            using (var context = new PI2247_DBEntities5())
            {
                string ime = txtbIme.Text;
                string prezime = txtbPrezime.Text;
                string email = txtbEmail.Text;
                string username = txtbUsername.Text;
                string lozinka = txtbLozinka.Text;
                string uloga = cmbUloga.SelectedItem as string;

                context.Korisniks.Attach(selektirani);
                selektirani.Ime = ime;
                selektirani.Prezime = prezime;
                selektirani.Email = email;
                selektirani.Username = username;
                selektirani.Password = lozinka;
                selektirani.Uloga = uloga;
                context.SaveChanges();
            }
            Close();
        }

        private void frmIzmjeniKorisnikaAdmin_Load(object sender, EventArgs e)
        {
            txtbIme.Text = selektirani.Ime;
            txtbPrezime.Text = selektirani.Prezime;
            txtbEmail.Text = selektirani.Email;
            txtbUsername.Text = selektirani.Username;
            txtbLozinka.Text = selektirani.Password;
            cmbUloga.SelectedText = selektirani.Uloga;

        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
