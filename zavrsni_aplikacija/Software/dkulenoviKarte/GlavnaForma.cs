using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SvaSuceljaAplikacije
{
    public partial class GlavnaForma : Form
    {
        public GlavnaForma()
        {
            InitializeComponent();
        }

        private void uxKupnjaKarte_Click(object sender, EventArgs e)
        {
            KupnjaKarte form = new KupnjaKarte();
            form.Show();
        }

        private void uxPregledProdanihKarata_Click(object sender, EventArgs e)
        {
            PregledProdanihKarata form = new PregledProdanihKarata();
            form.Show();
        }

        private void uxValidacijaKarata_Click(object sender, EventArgs e)
        {
            ValidacijaKarata form = new ValidacijaKarata();
            form.Show();
        }
    }
}
