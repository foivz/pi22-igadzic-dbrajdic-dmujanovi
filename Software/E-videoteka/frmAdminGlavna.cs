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
    public partial class frmAdminGlavna : Form
    {
        public frmAdminGlavna()
        {
            InitializeComponent();
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnVideoteka_Click(object sender, EventArgs e)
        {
            frmVideoteka videoteka = new frmVideoteka();
            videoteka.ShowDialog();
        }

        private void btnUpravljanjeKorisnicima_Click(object sender, EventArgs e)
        {
            frmAdminUpravljanjeKorisnicima frmAdminUpravljanje=new frmAdminUpravljanjeKorisnicima();
            frmAdminUpravljanje.ShowDialog();
        }

        private void btnStatistika_Click(object sender, EventArgs e)
        {
            frmStatistika forma = new frmStatistika();
            forma.ShowDialog();
        }
    }
}
