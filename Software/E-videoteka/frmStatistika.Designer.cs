
namespace E_videoteka
{
    partial class frmStatistika
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOdustani = new System.Windows.Forms.Button();
            this.dgvPopisSvihFilmova = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReportKorisnika = new System.Windows.Forms.Button();
            this.btnIzvjestajFilmova = new System.Windows.Forms.Button();
            this.cmbKorisnici = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFiltriraj = new System.Windows.Forms.Button();
            this.btnPrikaziSveFilmove = new System.Windows.Forms.Button();
            this.cmbZanr = new System.Windows.Forms.Label();
            this.cmbZanrovi = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbPretraziPoNazivu = new System.Windows.Forms.TextBox();
            this.checkbox = new System.Windows.Forms.CheckBox();
            this.btnIzvještajSvih = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisSvihFilmova)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(496, 502);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(111, 40);
            this.btnOdustani.TabIndex = 1;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // dgvPopisSvihFilmova
            // 
            this.dgvPopisSvihFilmova.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopisSvihFilmova.Location = new System.Drawing.Point(12, 176);
            this.dgvPopisSvihFilmova.Name = "dgvPopisSvihFilmova";
            this.dgvPopisSvihFilmova.Size = new System.Drawing.Size(458, 315);
            this.dgvPopisSvihFilmova.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Popis filmova:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnReportKorisnika
            // 
            this.btnReportKorisnika.Location = new System.Drawing.Point(12, 503);
            this.btnReportKorisnika.Name = "btnReportKorisnika";
            this.btnReportKorisnika.Size = new System.Drawing.Size(137, 39);
            this.btnReportKorisnika.TabIndex = 6;
            this.btnReportKorisnika.Text = "Izvještaj svih korisnika";
            this.btnReportKorisnika.UseVisualStyleBackColor = true;
            this.btnReportKorisnika.Click += new System.EventHandler(this.btnReportKorisnika_Click);
            // 
            // btnIzvjestajFilmova
            // 
            this.btnIzvjestajFilmova.Location = new System.Drawing.Point(168, 503);
            this.btnIzvjestajFilmova.Name = "btnIzvjestajFilmova";
            this.btnIzvjestajFilmova.Size = new System.Drawing.Size(137, 39);
            this.btnIzvjestajFilmova.TabIndex = 7;
            this.btnIzvjestajFilmova.Text = "Izvještaj filmova za odabranog korisnika";
            this.btnIzvjestajFilmova.UseVisualStyleBackColor = true;
            this.btnIzvjestajFilmova.Click += new System.EventHandler(this.btnIzvjestajFilmova_Click);
            // 
            // cmbKorisnici
            // 
            this.cmbKorisnici.FormattingEnabled = true;
            this.cmbKorisnici.Location = new System.Drawing.Point(12, 34);
            this.cmbKorisnici.Name = "cmbKorisnici";
            this.cmbKorisnici.Size = new System.Drawing.Size(121, 21);
            this.cmbKorisnici.TabIndex = 8;
            this.cmbKorisnici.SelectedIndexChanged += new System.EventHandler(this.cmbKorisnici_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Korisnici:";
            // 
            // btnFiltriraj
            // 
            this.btnFiltriraj.Location = new System.Drawing.Point(153, 68);
            this.btnFiltriraj.Name = "btnFiltriraj";
            this.btnFiltriraj.Size = new System.Drawing.Size(68, 34);
            this.btnFiltriraj.TabIndex = 10;
            this.btnFiltriraj.Text = "Filtriraj";
            this.btnFiltriraj.UseVisualStyleBackColor = true;
            this.btnFiltriraj.Click += new System.EventHandler(this.btnFiltriraj_Click);
            // 
            // btnPrikaziSveFilmove
            // 
            this.btnPrikaziSveFilmove.Location = new System.Drawing.Point(230, 68);
            this.btnPrikaziSveFilmove.Name = "btnPrikaziSveFilmove";
            this.btnPrikaziSveFilmove.Size = new System.Drawing.Size(75, 34);
            this.btnPrikaziSveFilmove.TabIndex = 11;
            this.btnPrikaziSveFilmove.Text = "Prikaži sve";
            this.btnPrikaziSveFilmove.UseVisualStyleBackColor = true;
            this.btnPrikaziSveFilmove.Click += new System.EventHandler(this.btnPrikaziSveFilmove_Click);
            // 
            // cmbZanr
            // 
            this.cmbZanr.AutoSize = true;
            this.cmbZanr.Location = new System.Drawing.Point(13, 58);
            this.cmbZanr.Name = "cmbZanr";
            this.cmbZanr.Size = new System.Drawing.Size(32, 13);
            this.cmbZanr.TabIndex = 12;
            this.cmbZanr.Text = "Žanr:";
            // 
            // cmbZanrovi
            // 
            this.cmbZanrovi.FormattingEnabled = true;
            this.cmbZanrovi.Location = new System.Drawing.Point(12, 76);
            this.cmbZanrovi.Name = "cmbZanrovi";
            this.cmbZanrovi.Size = new System.Drawing.Size(121, 21);
            this.cmbZanrovi.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Traži po naslovu:";
            // 
            // txtbPretraziPoNazivu
            // 
            this.txtbPretraziPoNazivu.Location = new System.Drawing.Point(110, 130);
            this.txtbPretraziPoNazivu.Name = "txtbPretraziPoNazivu";
            this.txtbPretraziPoNazivu.Size = new System.Drawing.Size(129, 20);
            this.txtbPretraziPoNazivu.TabIndex = 15;
            this.txtbPretraziPoNazivu.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // checkbox
            // 
            this.checkbox.AutoSize = true;
            this.checkbox.Location = new System.Drawing.Point(153, 37);
            this.checkbox.Name = "checkbox";
            this.checkbox.Size = new System.Drawing.Size(116, 17);
            this.checkbox.TabIndex = 16;
            this.checkbox.Text = "Stariji od 10 godina";
            this.checkbox.UseVisualStyleBackColor = true;
            // 
            // btnIzvještajSvih
            // 
            this.btnIzvještajSvih.Location = new System.Drawing.Point(333, 502);
            this.btnIzvještajSvih.Name = "btnIzvještajSvih";
            this.btnIzvještajSvih.Size = new System.Drawing.Size(137, 40);
            this.btnIzvještajSvih.TabIndex = 17;
            this.btnIzvještajSvih.Text = "Izvještaj svih filmova";
            this.btnIzvještajSvih.UseVisualStyleBackColor = true;
            this.btnIzvještajSvih.Click += new System.EventHandler(this.btnIzvještajSvih_Click);
            // 
            // frmStatistika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 546);
            this.Controls.Add(this.btnIzvještajSvih);
            this.Controls.Add(this.checkbox);
            this.Controls.Add(this.txtbPretraziPoNazivu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbZanrovi);
            this.Controls.Add(this.cmbZanr);
            this.Controls.Add(this.btnPrikaziSveFilmove);
            this.Controls.Add(this.btnFiltriraj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbKorisnici);
            this.Controls.Add(this.btnIzvjestajFilmova);
            this.Controls.Add(this.btnReportKorisnika);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvPopisSvihFilmova);
            this.Controls.Add(this.btnOdustani);
            this.Name = "frmStatistika";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistika";
            this.Load += new System.EventHandler(this.frmStatistika_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmStatistika_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisSvihFilmova)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.DataGridView dgvPopisSvihFilmova;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReportKorisnika;
        private System.Windows.Forms.Button btnIzvjestajFilmova;
        private System.Windows.Forms.ComboBox cmbKorisnici;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFiltriraj;
        private System.Windows.Forms.Button btnPrikaziSveFilmove;
        private System.Windows.Forms.Label cmbZanr;
        private System.Windows.Forms.ComboBox cmbZanrovi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbPretraziPoNazivu;
        private System.Windows.Forms.CheckBox checkbox;
        private System.Windows.Forms.Button btnIzvještajSvih;
    }
}