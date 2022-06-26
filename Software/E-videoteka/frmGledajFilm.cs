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
    public partial class frmGledajFilm : Form
    {
        public Film odabrani;
        public frmGledajFilm(Film odabraniFilm)
        {
            odabrani = odabraniFilm;
            InitializeComponent();
        }

        private void frmGledajFilm_Load(object sender, EventArgs e)
        {
            textBox1.Text = odabrani.LokacijaFilma.ToString();
            textBox1.Visible = false;
            axWindowsMediaPlayer1.URL = textBox1.Text;
            axWindowsMediaPlayer1.settings.autoStart = true;
        }

    }
}
