﻿using System;
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
    public partial class frmVideoteka : Form
    {
        public frmVideoteka()
        {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDodajFilm_Click(object sender, EventArgs e)
        {
            //this.Hide();
            frmDodajFilm forma = new frmDodajFilm();
            forma.ShowDialog();
            this.Show();
            
        }

        

        private void frmVideoteka_Load(object sender, EventArgs e)
        {
           
        }


        
        

        private void btnSviFilmovi_Click(object sender, EventArgs e)
        {
          
        }
    }
}
