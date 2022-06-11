namespace E_videoteka
{
    partial class frmAdminGlavna
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
            this.btnUpravljanjeKorisnicima = new System.Windows.Forms.Button();
            this.btnVideoteka = new System.Windows.Forms.Button();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpravljanjeKorisnicima
            // 
            this.btnUpravljanjeKorisnicima.Location = new System.Drawing.Point(567, 42);
            this.btnUpravljanjeKorisnicima.Name = "btnUpravljanjeKorisnicima";
            this.btnUpravljanjeKorisnicima.Size = new System.Drawing.Size(170, 80);
            this.btnUpravljanjeKorisnicima.TabIndex = 0;
            this.btnUpravljanjeKorisnicima.Text = "Upravljanje korisnicima";
            this.btnUpravljanjeKorisnicima.UseVisualStyleBackColor = true;
            this.btnUpravljanjeKorisnicima.Click += new System.EventHandler(this.btnUpravljanjeKorisnicima_Click);
            // 
            // btnVideoteka
            // 
            this.btnVideoteka.Location = new System.Drawing.Point(567, 167);
            this.btnVideoteka.Name = "btnVideoteka";
            this.btnVideoteka.Size = new System.Drawing.Size(170, 80);
            this.btnVideoteka.TabIndex = 1;
            this.btnVideoteka.Text = "Videoteka";
            this.btnVideoteka.UseVisualStyleBackColor = true;
            this.btnVideoteka.Click += new System.EventHandler(this.btnVideoteka_Click);
            // 
            // btnOdjava
            // 
            this.btnOdjava.Location = new System.Drawing.Point(567, 296);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(170, 80);
            this.btnOdjava.TabIndex = 2;
            this.btnOdjava.Text = "Odjava";
            this.btnOdjava.UseVisualStyleBackColor = true;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(36, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(493, 334);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // frmAdminGlavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnOdjava);
            this.Controls.Add(this.btnVideoteka);
            this.Controls.Add(this.btnUpravljanjeKorisnicima);
            this.Name = "frmAdminGlavna";
            this.Text = "ADMIN";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpravljanjeKorisnicima;
        private System.Windows.Forms.Button btnVideoteka;
        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}