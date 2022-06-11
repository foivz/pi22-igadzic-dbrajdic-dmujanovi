using System;
using System.Windows.Forms;

namespace E_videoteka
{
    public partial class frmGlavna : Form
    {
        public frmGlavna()
        {
            InitializeComponent();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            frmPrijava form = new frmPrijava();
            form.ShowDialog();
        }

        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            frmRegistracija form = new frmRegistracija();
            form.ShowDialog();
        }

        private void btnGost_Click(object sender, EventArgs e)
        {
            frmGost form = new frmGost();
            form.ShowDialog();
        }

        private void frmGlavna_Load(object sender, EventArgs e)
        {

        }
    }
}
