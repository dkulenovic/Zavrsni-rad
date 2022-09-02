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
    public partial class IzvjestajZaradePrikaz : Form
    {
        Entities entities = new Entities();
        private DateTime datumOd;
        private DateTime datumDo;

        public IzvjestajZaradePrikaz()
        {
            InitializeComponent();
        }

        public IzvjestajZaradePrikaz(DateTime datumod, DateTime datumdo)
        {
            InitializeComponent();
            this.datumOd = datumod;
            this.datumDo = datumdo;
            var query = from k in entities.Karta.Include("korisnik").Include("mjesto").Include("vrsta_karte") where (k.datum_kupnje.Value >= datumOd && k.datum_kupnje.Value <= datumDo) select k;

            KartaBindingSource.DataSource = query.ToList();
        }

        private void IzvjestajZaradePrikaz_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("datumOd", datumOd.ToShortDateString()));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("datumDo", datumDo.ToShortDateString()));
            this.reportViewer1.RefreshReport();
        }
    }
}
