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
    public partial class frmStatistika : Form
    {
        public frmStatistika()
        {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmStatistika_Load(object sender, EventArgs e)
        {
            DohvatiStatistiku();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(frmStatistika_KeyDown);
        }

        private void DohvatiStatistiku()
        {
            int sveukupnoKorisnici = 0;
            int recenzenti = 0;
            int sveukupnoFilmovi = 0;
            int gosti = 0;
            int registriraniKorisnici = 0;

            List<Korisnik> listaKorisnika = new List<Korisnik>();
            List<Film> listaFIlmova = new List<Film>();
            using(var context = new PI2247_DBEntities1())
            {
                var query = from k in context.Korisniks
                            select k;
                var upit = from f in context.Films
                           select f;
                listaKorisnika = query.ToList();
                listaFIlmova = upit.ToList();
            }
            foreach (Film item in listaFIlmova)
            {
                sveukupnoFilmovi++;
            }
            foreach (Korisnik item in listaKorisnika)
            {
                sveukupnoKorisnici++;
                if (item.Uloga.ToString() == "Korisnik")
                {
                    registriraniKorisnici++;
                }
                if (item.Uloga.ToString() == "Recenzent")
                {
                    recenzenti++;
                }
                if (item.Uloga.ToString() == "Gost")
                {
                    gosti++;
                }
                
            }
            txtFilmovi.Text = sveukupnoFilmovi.ToString();
            txtGosti.Text = gosti.ToString();
            txtRecenzenti.Text = recenzenti.ToString();
            txtRegistrirani.Text = registriraniKorisnici.ToString();
            txtSveukupno.Text = sveukupnoKorisnici.ToString();
        }

        private void frmStatistika_KeyDown(object sender, KeyEventArgs e)
        {
                if (e.KeyCode == Keys.F1)
            {
                var path = System.IO.Path.GetDirectoryName(
                 System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
                path = path.Substring(6);
                string cijeli = "File://" + path + "\\UserManual\\UserManual.chm";
                Help.ShowHelp(this, cijeli, HelpNavigator.Topic, "StatistikaForma.htm");
            }
        }
    }
}
