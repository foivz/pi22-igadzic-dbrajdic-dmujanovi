
namespace E_videoteka
{
    partial class frmGledajFilm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGledajFilm));
            this.axwmpFilm = new AxWMPLib.AxWindowsMediaPlayer();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnIskljuci = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axwmpFilm)).BeginInit();
            this.SuspendLayout();
            // 
            // axwmpFilm
            // 
            this.axwmpFilm.Enabled = true;
            this.axwmpFilm.Location = new System.Drawing.Point(0, 0);
            this.axwmpFilm.Name = "axwmpFilm";
            this.axwmpFilm.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axwmpFilm.OcxState")));
            this.axwmpFilm.Size = new System.Drawing.Size(860, 486);
            this.axwmpFilm.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(595, 464);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(265, 22);
            this.textBox1.TabIndex = 4;
            // 
            // btnIskljuci
            // 
            this.btnIskljuci.BackColor = System.Drawing.SystemColors.MenuText;
            this.btnIskljuci.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIskljuci.Location = new System.Drawing.Point(0, 0);
            this.btnIskljuci.Name = "btnIskljuci";
            this.btnIskljuci.Size = new System.Drawing.Size(89, 42);
            this.btnIskljuci.TabIndex = 5;
            this.btnIskljuci.Text = "Iskljuci";
            this.btnIskljuci.UseVisualStyleBackColor = false;
            this.btnIskljuci.Click += new System.EventHandler(this.btnIskljuci_Click);
            // 
            // frmGledajFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 486);
            this.Controls.Add(this.btnIskljuci);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.axwmpFilm);
            this.Name = "frmGledajFilm";
            this.Text = "frmGledajFilm";
            this.Load += new System.EventHandler(this.frmGledajFilm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axwmpFilm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axwmpFilm;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnIskljuci;
    }
}