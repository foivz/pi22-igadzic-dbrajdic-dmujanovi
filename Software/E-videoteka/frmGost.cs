using System;
using System.Windows.Forms;

namespace E_videoteka
{
    public partial class frmGost : Form
    {
        public frmGost()
        {
            InitializeComponent();
        }

        private void frmGost_Load(object sender, EventArgs e)
        {

        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnKerirajRacun_Click(object sender, EventArgs e)
        {
            frmRegistracija forma = new frmRegistracija();
            forma.ShowDialog();
        }

        private void btnVideoteka_Click(object sender, EventArgs e)
        {
            frmVideoteka videoteka = new frmVideoteka();
            videoteka.ShowDialog();
        }
    }
}
