namespace Aplikacija_za_biblioteku
{
    partial class FormPocetna
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
            this.btnNovi = new System.Windows.Forms.Button();
            this.btnKnjige = new System.Windows.Forms.Button();
            this.btnKorisnik = new System.Windows.Forms.Button();
            this.btnPodaci = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNovi
            // 
            this.btnNovi.Location = new System.Drawing.Point(93, 71);
            this.btnNovi.Name = "btnNovi";
            this.btnNovi.Size = new System.Drawing.Size(117, 23);
            this.btnNovi.TabIndex = 0;
            this.btnNovi.Text = "Novi korisnik/ knjiga";
            this.btnNovi.UseVisualStyleBackColor = true;
            this.btnNovi.Click += new System.EventHandler(this.btnNovi_Click);
            // 
            // btnKnjige
            // 
            this.btnKnjige.Location = new System.Drawing.Point(111, 112);
            this.btnKnjige.Name = "btnKnjige";
            this.btnKnjige.Size = new System.Drawing.Size(75, 23);
            this.btnKnjige.TabIndex = 1;
            this.btnKnjige.Text = "Knjige";
            this.btnKnjige.UseVisualStyleBackColor = true;
            this.btnKnjige.Click += new System.EventHandler(this.btnKnjige_Click);
            // 
            // btnKorisnik
            // 
            this.btnKorisnik.Location = new System.Drawing.Point(111, 163);
            this.btnKorisnik.Name = "btnKorisnik";
            this.btnKorisnik.Size = new System.Drawing.Size(75, 23);
            this.btnKorisnik.TabIndex = 2;
            this.btnKorisnik.Text = "Korisnik";
            this.btnKorisnik.UseVisualStyleBackColor = true;
            this.btnKorisnik.Click += new System.EventHandler(this.btnKorisnik_Click);
            // 
            // btnPodaci
            // 
            this.btnPodaci.Location = new System.Drawing.Point(111, 206);
            this.btnPodaci.Name = "btnPodaci";
            this.btnPodaci.Size = new System.Drawing.Size(75, 23);
            this.btnPodaci.TabIndex = 3;
            this.btnPodaci.Text = "Posudivanje";
            this.btnPodaci.UseVisualStyleBackColor = true;
            this.btnPodaci.Click += new System.EventHandler(this.btnPodaci_Click);
            // 
            // FormPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 310);
            this.Controls.Add(this.btnPodaci);
            this.Controls.Add(this.btnKorisnik);
            this.Controls.Add(this.btnKnjige);
            this.Controls.Add(this.btnNovi);
            this.Name = "FormPocetna";
            this.Text = "Knjižnica";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNovi;
        private System.Windows.Forms.Button btnKnjige;
        private System.Windows.Forms.Button btnKorisnik;
        private System.Windows.Forms.Button btnPodaci;
    }
}

