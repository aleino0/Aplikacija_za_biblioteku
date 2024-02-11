namespace Aplikacija_za_biblioteku
{
    partial class FormNoviKorisnik
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fImeKor = new System.Windows.Forms.TextBox();
            this.fPrezimeKor = new System.Windows.Forms.TextBox();
            this.fMailKor = new System.Windows.Forms.TextBox();
            this.fAdresaKor = new System.Windows.Forms.TextBox();
            this.btnDodajKor = new System.Windows.Forms.Button();
            this.fTelBroj = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(26, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 254);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // fImeKor
            // 
            this.fImeKor.Location = new System.Drawing.Point(322, 20);
            this.fImeKor.Name = "fImeKor";
            this.fImeKor.Size = new System.Drawing.Size(264, 20);
            this.fImeKor.TabIndex = 1;
            // 
            // fPrezimeKor
            // 
            this.fPrezimeKor.Location = new System.Drawing.Point(322, 56);
            this.fPrezimeKor.Name = "fPrezimeKor";
            this.fPrezimeKor.Size = new System.Drawing.Size(264, 20);
            this.fPrezimeKor.TabIndex = 2;
            // 
            // fMailKor
            // 
            this.fMailKor.Location = new System.Drawing.Point(322, 92);
            this.fMailKor.Name = "fMailKor";
            this.fMailKor.Size = new System.Drawing.Size(264, 20);
            this.fMailKor.TabIndex = 3;
            // 
            // fAdresaKor
            // 
            this.fAdresaKor.Location = new System.Drawing.Point(322, 128);
            this.fAdresaKor.Name = "fAdresaKor";
            this.fAdresaKor.Size = new System.Drawing.Size(264, 20);
            this.fAdresaKor.TabIndex = 4;
            // 
            // btnDodajKor
            // 
            this.btnDodajKor.Location = new System.Drawing.Point(387, 204);
            this.btnDodajKor.Name = "btnDodajKor";
            this.btnDodajKor.Size = new System.Drawing.Size(75, 23);
            this.btnDodajKor.TabIndex = 6;
            this.btnDodajKor.Text = "dodaj";
            this.btnDodajKor.UseVisualStyleBackColor = true;
            this.btnDodajKor.Click += new System.EventHandler(this.bntUnesi_Click);
            // 
            // fTelBroj
            // 
            this.fTelBroj.Location = new System.Drawing.Point(322, 164);
            this.fTelBroj.Name = "fTelBroj";
            this.fTelBroj.Size = new System.Drawing.Size(264, 20);
            this.fTelBroj.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "ime:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(274, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "prezime:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(283, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "e-mail:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(278, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "adresa:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(279, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "tel broj:";
            // 
            // FormNoviKorisnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 356);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fTelBroj);
            this.Controls.Add(this.btnDodajKor);
            this.Controls.Add(this.fAdresaKor);
            this.Controls.Add(this.fMailKor);
            this.Controls.Add(this.fPrezimeKor);
            this.Controls.Add(this.fImeKor);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormNoviKorisnik";
            this.Text = "FormNoviKorisnik";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox fImeKor;
        private System.Windows.Forms.TextBox fPrezimeKor;
        private System.Windows.Forms.TextBox fMailKor;
        private System.Windows.Forms.TextBox fAdresaKor;
        private System.Windows.Forms.Button btnDodajKor;
        private System.Windows.Forms.TextBox fTelBroj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}