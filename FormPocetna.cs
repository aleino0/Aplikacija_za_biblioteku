using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikacija_za_biblioteku
{
    public partial class FormPocetna : Form
    {
        public FormPocetna()
        {
            InitializeComponent();
        }

        private void btnNovi_Click(object sender, EventArgs e)
        {
            FormNovi frm = new FormNovi();
            DialogResult rez = frm.ShowDialog();

        }

        private void btnKnjige_Click(object sender, EventArgs e)
        {
            FormKnjige frm = new FormKnjige();
            DialogResult rez = frm.ShowDialog();
        }

        private void btnKorisnik_Click(object sender, EventArgs e)
        {
            FormKorisnik frm = new FormKorisnik();
            DialogResult rez = frm.ShowDialog();
        }

        private void btnPodaci_Click(object sender, EventArgs e)
        {
            FormPodaci frm = new FormPodaci();
            DialogResult rez = frm.ShowDialog();
        }
    }
}
