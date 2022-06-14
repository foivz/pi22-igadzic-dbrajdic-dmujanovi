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

        private void DodajFilmUBazu()
        {
            string ime = txtNazivFilma.Text.ToString();
            string trajanje = txtTrajanje.Text.ToString();
            string zanr = (string)cmbKategorija.SelectedItem;
            string lokacija = txtbLokacija.Text;
            string godina = txtGodina.Text.ToString();


            using (var context = new PI2247_DBEntities3())
            {
                context.Korisniks.Attach(frmPrijava.ulogirani);
              //  frmPrijava.ulogirani.
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ofd.ShowDialog();
            string lokacija = System.IO.Path.GetDirectoryName(ofd.FileName);
            txtbLokacija.Text = lokacija;
        }
    }
}
