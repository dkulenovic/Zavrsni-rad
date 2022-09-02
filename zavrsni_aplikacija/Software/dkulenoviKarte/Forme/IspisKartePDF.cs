using Microsoft.Reporting.WinForms;
using SvaSuceljaAplikacije.EntityKlase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SvaSuceljaAplikacije.Forme
{
    public partial class IspisKartePDF : Form
    {
        private Karta karta;

        public IspisKartePDF()
        {
            InitializeComponent();
        }
        
        public IspisKartePDF(Karta karta) // konstruktor koji prima kartu kako bi je mogao prikazati
        {
            InitializeComponent();
            this.karta = karta;
            kartaBindingSource.DataSource = karta;
        }

        private void IspisKartePDF_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("NazivMjesta", karta.Mjesto.naziv.ToString()));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("VrstaKarte", karta.Vrsta_karte.naziv));
            this.reportViewer1.RefreshReport();
        }
    }
}
