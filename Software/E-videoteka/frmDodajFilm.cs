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
    public partial class frmDodajFilm : Form
    {
        public OpenFileDialog ofd;
        public frmDodajFilm()
        {
            ofd = new OpenFileDialog();
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            DodajFilmUBazu();
        }

       // public static int brojac = 1;
        private void DodajFilmUBazu()
        {

            Filmovi novifilm = new Filmovi();
            novifilm.GodinaIzdanja = txtGodina.Text.ToString();
            novifilm.LokacijaFilma = txtbLokacija.Text;
            novifilm.Kategorija = (string)cmbKategorija.SelectedItem;
            novifilm.Trajanje = txtTrajanje.Text.ToString();
            novifilm.Naziv = txtNazivFilma.Text.ToString();
            novifilm.ID_Korisnik = frmPrijava.ulogirani.ID_Korisnik;
           // novifilm.ID_Film = brojac;
           // brojac++;

            using (var context = new PI2247_DBEntities4())
            {
                context.Korisniks.Attach(frmPrijava.ulogirani);
                frmPrijava.ulogirani.Filmovis.Add(novifilm);
                context.SaveChanges();
            }
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ofd.ShowDialog();
            string lokacija = System.IO.Path.GetDirectoryName(ofd.FileName);
            txtbLokacija.Text = lokacija;
        }
    }
}
