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
            ValidacijaUnosaFilma();
            DodajFilmNaPopisZaOdobrenje();
            Close();
        }

        private void ValidacijaUnosaFilma()
        {
            if(txtbLokacija.Text == "" ||txtGodina.Text == "" || txtNazivFilma.Text == "" || txtTrajanje.Text == "")
            {
                throw new EmptyInputException("Unos ne može biti prazno polje!");
            }
            if(cmbKategorija.SelectedItem == null)
            {
                throw new EmptyInputException("Odaberite kategoriju!");
            }
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
            foreach (Filmovi item in listaSvihFilmova)
            {
                if(item.Naziv.ToLower() == txtNazivFilma.Text.ToLower())
                {
                    throw new InvalidInputException("Film koji ste unijeli već postoji u bazi podataka!");
                }
            }
        }

        private void DodajFilmNaPopisZaOdobrenje()
        {
            Filmovi novifilm = new Filmovi();
            novifilm.GodinaIzdanja = txtGodina.Text.ToString();
            novifilm.LokacijaFilma = txtbLokacija.Text;
            novifilm.Kategorija = (string)cmbKategorija.SelectedItem;
            novifilm.Trajanje = txtTrajanje.Text.ToString();
            novifilm.Naziv = txtNazivFilma.Text.ToString();
            if(frmPrijava.ulogirani == null)
            {
                Korisnik gost = new Korisnik();
                gost.Ime = "Gost";
                gost.Prezime = "Gost";
                gost.Password = "Gost";
                gost.Email = "Gost@foi.hr";
                gost.Uloga = "Gost";
            }
            novifilm.ID_Korisnik = frmPrijava.ulogirani.ID_Korisnik;

            frmOdobravanjeFilmova.popisFilmovaNaCekanju.Add(novifilm);
        }

      
       

        private void button1_Click(object sender, EventArgs e)
        {
            ofd.ShowDialog();
            string lokacija = System.IO.Path.GetDirectoryName(ofd.FileName);
            txtbLokacija.Text = lokacija;
        }
    }
}
