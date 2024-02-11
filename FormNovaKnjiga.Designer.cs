namespace Aplikacija_za_biblioteku
{
    partial class UnosKnijga
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
            this.fAutor = new System.Windows.Forms.TextBox();
            this.fNaslov = new System.Windows.Forms.TextBox();
            this.fIzdavac = new System.Windows.Forms.TextBox();
            this.fDodajKnjigu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fAutor
            // 
            this.fAutor.Location = new System.Drawing.Point(69, 44);
            this.fAutor.Name = "fAutor";
            this.fAutor.Size = new System.Drawing.Size(100, 20);
            this.fAutor.TabIndex = 2;
            // 
            // fNaslov
            // 
            this.fNaslov.Location = new System.Drawing.Point(69, 88);
            this.fNaslov.Name = "fNaslov";
            this.fNaslov.Size = new System.Drawing.Size(100, 20);
            this.fNaslov.TabIndex = 3;
            // 
            // fIzdavac
            // 
            this.fIzdavac.Location = new System.Drawing.Point(69, 134);
            this.fIzdavac.Name = "fIzdavac";
            this.fIzdavac.Size = new System.Drawing.Size(100, 20);
            this.fIzdavac.TabIndex = 4;
            // 
            // fDodajKnjigu
            // 
            this.fDodajKnjigu.Location = new System.Drawing.Point(83, 200);
            this.fDodajKnjigu.Name = "fDodajKnjigu";
            this.fDodajKnjigu.Size = new System.Drawing.Size(75, 23);
            this.fDodajKnjigu.TabIndex = 7;
            this.fDodajKnjigu.Text = "dodaj";
            this.fDodajKnjigu.UseVisualStyleBackColor = true;
            this.fDodajKnjigu.Click += new System.EventHandler(this.bntUnesi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Autor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Naslov";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Izdavac";
            // 
            // FormNovaKnjiga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 290);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fDodajKnjigu);
            this.Controls.Add(this.fIzdavac);
            this.Controls.Add(this.fNaslov);
            this.Controls.Add(this.fAutor);
            this.Name = "FormNovaKnjiga";
            this.Text = "FormNovaKnjiga";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox fAutor;
        private System.Windows.Forms.TextBox fNaslov;
        private System.Windows.Forms.TextBox fIzdavac;
        private System.Windows.Forms.Button fDodajKnjigu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}