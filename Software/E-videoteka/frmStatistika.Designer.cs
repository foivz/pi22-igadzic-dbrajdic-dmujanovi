
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFilmovi = new System.Windows.Forms.TextBox();
            this.txtGosti = new System.Windows.Forms.TextBox();
            this.txtRecenzenti = new System.Windows.Forms.TextBox();
            this.txtRegistrirani = new System.Windows.Forms.TextBox();
            this.txtSveukupno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFilmovi);
            this.groupBox1.Controls.Add(this.txtGosti);
            this.groupBox1.Controls.Add(this.txtRecenzenti);
            this.groupBox1.Controls.Add(this.txtRegistrirani);
            this.groupBox1.Controls.Add(this.txtSveukupno);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(566, 238);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Statistika e-Videoteke:";
            // 
            // txtFilmovi
            // 
            this.txtFilmovi.Location = new System.Drawing.Point(421, 49);
            this.txtFilmovi.Name = "txtFilmovi";
            this.txtFilmovi.ReadOnly = true;
            this.txtFilmovi.Size = new System.Drawing.Size(100, 20);
            this.txtFilmovi.TabIndex = 9;
            // 
            // txtGosti
            // 
            this.txtGosti.Location = new System.Drawing.Point(148, 147);
            this.txtGosti.Name = "txtGosti";
            this.txtGosti.ReadOnly = true;
            this.txtGosti.Size = new System.Drawing.Size(100, 20);
            this.txtGosti.TabIndex = 8;
            // 
            // txtRecenzenti
            // 
            this.txtRecenzenti.Location = new System.Drawing.Point(148, 115);
            this.txtRecenzenti.Name = "txtRecenzenti";
            this.txtRecenzenti.ReadOnly = true;
            this.txtRecenzenti.Size = new System.Drawing.Size(100, 20);
            this.txtRecenzenti.TabIndex = 7;
            // 
            // txtRegistrirani
            // 
            this.txtRegistrirani.Location = new System.Drawing.Point(148, 84);
            this.txtRegistrirani.Name = "txtRegistrirani";
            this.txtRegistrirani.ReadOnly = true;
            this.txtRegistrirani.Size = new System.Drawing.Size(100, 20);
            this.txtRegistrirani.TabIndex = 6;
            // 
            // txtSveukupno
            // 
            this.txtSveukupno.Location = new System.Drawing.Point(148, 49);
            this.txtSveukupno.Name = "txtSveukupno";
            this.txtSveukupno.ReadOnly = true;
            this.txtSveukupno.Size = new System.Drawing.Size(100, 20);
            this.txtSveukupno.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(314, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sveukupno filmova:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gosti:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Recenzenti:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Registrirani korisnici:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sveukupno korisnici:";
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(474, 266);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(100, 32);
            this.btnOdustani.TabIndex = 1;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // frmStatistika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 318);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmStatistika";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistika";
            this.Load += new System.EventHandler(this.frmStatistika_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.TextBox txtFilmovi;
        private System.Windows.Forms.TextBox txtGosti;
        private System.Windows.Forms.TextBox txtRecenzenti;
        private System.Windows.Forms.TextBox txtRegistrirani;
        private System.Windows.Forms.TextBox txtSveukupno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}