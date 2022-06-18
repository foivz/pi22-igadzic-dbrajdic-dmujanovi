﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_videoteka
{
    public partial class frmDodajFilm : Form
    {
        public OpenFileDialog ofd;
        public RepozitorijKorisnika repozitorij = new RepozitorijKorisnika();
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
            using (var context = new PI2247_DBEntities())
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
            Korisnik test = frmPrijava.ulogirani;
            if (test.Username == null)
            {
                //PRVI PUT
                string ime = "Gost";
                string prezime = "Gost";
                string password = "Gost";
                string email = "Gost@foi.hr";
                string uloga = "Gost";
                string username = "Gost";
                string adresa = DohvatiAdresu();
                
                repozitorij.DodajKorisnika(ime,prezime,email,username,password,adresa, uloga);
                Korisnik gost = repozitorij.DohvatiKorisnikaPoAdresi(adresa);
                novifilm.ID_Korisnik = gost.ID_Korisnik;

            }
            if (test.Username != null)
            {
                novifilm.ID_Korisnik = frmPrijava.ulogirani.ID_Korisnik;
                using(var context = new PI2247_DBEntities())
                {

                }
            }
           
          //  frmOdobravanjeFilmova.popisFilmovaNaCekanju.Add(novifilm);
        }

        private string DohvatiAdresu()
        {
           
                var host = Dns.GetHostEntry(Dns.GetHostName());
                foreach (var ip in host.AddressList)
                {
                    if (ip.AddressFamily == AddressFamily.InterNetwork)
                    {
                        return ip.ToString();
                    }
                }
                throw new Exception("No network adapters with an IPv4 address in the system!");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ofd.ShowDialog();
            string lokacija = System.IO.Path.GetDirectoryName(ofd.FileName);
            txtbLokacija.Text = lokacija;
        }

        private void frmDodajFilm_Load(object sender, EventArgs e)
        {

        }
    }
}
