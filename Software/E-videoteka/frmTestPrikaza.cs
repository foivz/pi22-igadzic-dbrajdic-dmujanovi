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
    public partial class frmTestPrikaza : Form
    {
        public frmTestPrikaza()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using(var context = new PI2247_DBEntities1())
            {
                var query = from p in context.Korisniks
                            select p;

                dataGridView1.DataSource = query.ToList();
            }
        }
    }
}
