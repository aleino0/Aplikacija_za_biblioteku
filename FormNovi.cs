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
    public partial class FormNovi : Form
    {
        public FormNovi()
        {
            InitializeComponent();
        }

        private void btnNoviKorisnik_Click(object sender, EventArgs e)
        {
            FormNoviKorisnik frm = new FormNoviKorisnik();
            DialogResult rez = frm.ShowDialog();
        }

        private void btnNovaKnjiga_Click(object sender, EventArgs e)
        {
            UnosKnijga frm = new UnosKnijga();
            DialogResult rez = frm.ShowDialog();
        }

    }
}
