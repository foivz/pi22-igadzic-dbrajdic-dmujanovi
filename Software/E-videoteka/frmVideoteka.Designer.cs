
namespace E_videoteka
{
    partial class frmVideoteka
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
            this.dgvDostupniFilmovi = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbtnUkljuci = new System.Windows.Forms.RadioButton();
            this.rbtnIskljuci = new System.Windows.Forms.RadioButton();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnDodajFilm = new System.Windows.Forms.Button();
            this.btnGledajFilm = new System.Windows.Forms.Button();
            this.btnPohrani = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDostupniFilmovi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDostupniFilmovi
            // 
            this.dgvDostupniFilmovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDostupniFilmovi.Location = new System.Drawing.Point(12, 45);
            this.dgvDostupniFilmovi.Name = "dgvDostupniFilmovi";
            this.dgvDostupniFilmovi.RowHeadersWidth = 51;
            this.dgvDostupniFilmovi.RowTemplate.Height = 24;
            this.dgvDostupniFilmovi.Size = new System.Drawing.Size(1027, 298);
            this.dgvDostupniFilmovi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Trenutno dostupni filmovi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Windows servisi :";
            // 
            // rbtnUkljuci
            // 
            this.rbtnUkljuci.AutoSize = true;
            this.rbtnUkljuci.Location = new System.Drawing.Point(63, 410);
            this.rbtnUkljuci.Name = "rbtnUkljuci";
            this.rbtnUkljuci.Size = new System.Drawing.Size(70, 21);
            this.rbtnUkljuci.TabIndex = 3;
            this.rbtnUkljuci.TabStop = true;
            this.rbtnUkljuci.Text = "Uključi";
            this.rbtnUkljuci.UseVisualStyleBackColor = true;
            // 
            // rbtnIskljuci
            // 
            this.rbtnIskljuci.AutoSize = true;
            this.rbtnIskljuci.Location = new System.Drawing.Point(150, 410);
            this.rbtnIskljuci.Name = "rbtnIskljuci";
            this.rbtnIskljuci.Size = new System.Drawing.Size(70, 21);
            this.rbtnIskljuci.TabIndex = 4;
            this.rbtnIskljuci.TabStop = true;
            this.rbtnIskljuci.Text = "Isključi";
            this.rbtnIskljuci.UseVisualStyleBackColor = true;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(549, 381);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(141, 61);
            this.btnOdustani.TabIndex = 5;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnDodajFilm
            // 
            this.btnDodajFilm.Location = new System.Drawing.Point(727, 381);
            this.btnDodajFilm.Name = "btnDodajFilm";
            this.btnDodajFilm.Size = new System.Drawing.Size(141, 61);
            this.btnDodajFilm.TabIndex = 6;
            this.btnDodajFilm.Text = "Dodaj film";
            this.btnDodajFilm.UseVisualStyleBackColor = true;
            this.btnDodajFilm.Click += new System.EventHandler(this.btnDodajFilm_Click);
            // 
            // btnGledajFilm
            // 
            this.btnGledajFilm.Location = new System.Drawing.Point(898, 381);
            this.btnGledajFilm.Name = "btnGledajFilm";
            this.btnGledajFilm.Size = new System.Drawing.Size(141, 61);
            this.btnGledajFilm.TabIndex = 7;
            this.btnGledajFilm.Text = "Gledaj film";
            this.btnGledajFilm.UseVisualStyleBackColor = true;
            // 
            // btnPohrani
            // 
            this.btnPohrani.Location = new System.Drawing.Point(241, 404);
            this.btnPohrani.Name = "btnPohrani";
            this.btnPohrani.Size = new System.Drawing.Size(91, 32);
            this.btnPohrani.TabIndex = 8;
            this.btnPohrani.Text = "Pohrani";
            this.btnPohrani.UseVisualStyleBackColor = true;
            // 
            // frmVideoteka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 475);
            this.Controls.Add(this.btnPohrani);
            this.Controls.Add(this.btnGledajFilm);
            this.Controls.Add(this.btnDodajFilm);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.rbtnIskljuci);
            this.Controls.Add(this.rbtnUkljuci);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDostupniFilmovi);
            this.Name = "frmVideoteka";
            this.Text = "frmVideoteka";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDostupniFilmovi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDostupniFilmovi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbtnUkljuci;
        private System.Windows.Forms.RadioButton rbtnIskljuci;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnDodajFilm;
        private System.Windows.Forms.Button btnGledajFilm;
        private System.Windows.Forms.Button btnPohrani;
    }
}