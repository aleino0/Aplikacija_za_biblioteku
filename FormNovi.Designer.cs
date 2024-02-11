namespace Aplikacija_za_biblioteku
{
    partial class FormNovi
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
            this.btnNoviKorisnik = new System.Windows.Forms.Button();
            this.btnNovaKnjiga = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNoviKorisnik
            // 
            this.btnNoviKorisnik.Location = new System.Drawing.Point(52, 94);
            this.btnNoviKorisnik.Name = "btnNoviKorisnik";
            this.btnNoviKorisnik.Size = new System.Drawing.Size(81, 23);
            this.btnNoviKorisnik.TabIndex = 0;
            this.btnNoviKorisnik.Text = "Novi korisnik";
            this.btnNoviKorisnik.UseVisualStyleBackColor = true;
            this.btnNoviKorisnik.Click += new System.EventHandler(this.btnNoviKorisnik_Click);
            // 
            // btnNovaKnjiga
            // 
            this.btnNovaKnjiga.Location = new System.Drawing.Point(201, 94);
            this.btnNovaKnjiga.Name = "btnNovaKnjiga";
            this.btnNovaKnjiga.Size = new System.Drawing.Size(75, 23);
            this.btnNovaKnjiga.TabIndex = 1;
            this.btnNovaKnjiga.Text = "Nova knjiga";
            this.btnNovaKnjiga.UseVisualStyleBackColor = true;
            this.btnNovaKnjiga.Click += new System.EventHandler(this.btnNovaKnjiga_Click);
            // 
            // FormNovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 220);
            this.Controls.Add(this.btnNovaKnjiga);
            this.Controls.Add(this.btnNoviKorisnik);
            this.Name = "FormNovi";
            this.Text = "Novi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNoviKorisnik;
        private System.Windows.Forms.Button btnNovaKnjiga;
    }
}