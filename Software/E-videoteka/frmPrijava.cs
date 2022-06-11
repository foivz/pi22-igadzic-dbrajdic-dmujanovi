using System;
using System.Windows.Forms;

namespace E_videoteka
{
    public partial class frmPrijava : Form
    {
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
            autentifikator.ProvjeriPrijavu(username, password);
            autentifikator.ProvjeraUloge();
        }
    }
}
