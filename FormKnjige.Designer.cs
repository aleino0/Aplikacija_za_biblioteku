namespace Aplikacija_za_biblioteku
{
    partial class FormKnjige
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
            this.listKnjige = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnTrazi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listKnjige
            // 
            this.listKnjige.FormattingEnabled = true;
            this.listKnjige.Location = new System.Drawing.Point(28, 55);
            this.listKnjige.Name = "listKnjige";
            this.listKnjige.Size = new System.Drawing.Size(402, 186);
            this.listKnjige.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(28, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "search";
            // 
            // btnTrazi
            // 
            this.btnTrazi.Location = new System.Drawing.Point(192, 248);
            this.btnTrazi.Name = "btnTrazi";
            this.btnTrazi.Size = new System.Drawing.Size(75, 23);
            this.btnTrazi.TabIndex = 3;
            this.btnTrazi.Text = "button1";
            this.btnTrazi.UseVisualStyleBackColor = true;
            this.btnTrazi.Click += new System.EventHandler(this.btnTrazi_Click);
            // 
            // FormKnjige
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 280);
            this.Controls.Add(this.btnTrazi);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listKnjige);
            this.Name = "FormKnjige";
            this.Text = "Knjige";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listKnjige;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnTrazi;
    }
}