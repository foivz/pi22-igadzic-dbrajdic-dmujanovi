
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
            this.dgvPopisSvihKorisnika = new System.Windows.Forms.DataGridView();
            this.dgvPopisSvihFilmova = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisSvihKorisnika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisSvihFilmova)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(344, 430);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(100, 32);
            this.btnOdustani.TabIndex = 1;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // dgvPopisSvihKorisnika
            // 
            this.dgvPopisSvihKorisnika.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopisSvihKorisnika.Location = new System.Drawing.Point(12, 49);
            this.dgvPopisSvihKorisnika.Name = "dgvPopisSvihKorisnika";
            this.dgvPopisSvihKorisnika.Size = new System.Drawing.Size(359, 159);
            this.dgvPopisSvihKorisnika.TabIndex = 2;
            this.dgvPopisSvihKorisnika.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPopisSvihKorisnika_RowHeaderMouseClick);
            // 
            // dgvPopisSvihFilmova
            // 
            this.dgvPopisSvihFilmova.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopisSvihFilmova.Location = new System.Drawing.Point(12, 245);
            this.dgvPopisSvihFilmova.Name = "dgvPopisSvihFilmova";
            this.dgvPopisSvihFilmova.Size = new System.Drawing.Size(432, 145);
            this.dgvPopisSvihFilmova.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Popis svih korisnika:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Popis filmova korisnika:";
            // 
            // frmStatistika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 503);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPopisSvihFilmova);
            this.Controls.Add(this.dgvPopisSvihKorisnika);
            this.Controls.Add(this.btnOdustani);
            this.Name = "frmStatistika";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistika";
            this.Load += new System.EventHandler(this.frmStatistika_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmStatistika_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisSvihKorisnika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisSvihFilmova)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.DataGridView dgvPopisSvihKorisnika;
        private System.Windows.Forms.DataGridView dgvPopisSvihFilmova;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}