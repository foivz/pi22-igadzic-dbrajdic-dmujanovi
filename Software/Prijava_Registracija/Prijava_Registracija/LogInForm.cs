using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prijava_Registracija
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            RegisterForm reg_form = new RegisterForm();
            reg_form.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pocetna pocetna_form = new Pocetna();
            pocetna_form.ShowDialog();
        }
    }
}
