using SvaSuceljaAplikacije.DAL;
using SvaSuceljaAplikacije.EntityKlase;
using SvaSuceljaAplikacije.Forme;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SvaSuceljaAplikacije
{
    public partial class PregledProdanihKarata : Form
    {
        UnitOfWork _unitOfWork = new UnitOfWork(new Entities());

        public PregledProdanihKarata()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void PregledProdanihKarata_Load(object sender, EventArgs e)
        {
            double ukupnaZarada = 0;

            _unitOfWork.KartaRepo.DohvatiSve().ToList().ForEach(k => ukupnaZarada += double.Parse(k.Vrsta_karte.cijena.ToString()));
            kartaBindingSource.DataSource = _unitOfWork.KartaRepo.DohvatiSve().ToList();
            
            uxUkupnaZarada.Text = ukupnaZarada.ToString() + " kn";
            uxPregledKarata.DataSource = kartaBindingSource;

            
        }

        private void uxFiltriraj_Click(object sender, EventArgs e)
        {
            DateTime datumOd = filtriranjeDatumOd.Value.Date;
            DateTime datumDo = filtriranjeDatumDo.Value.Date;

            double ukupnaZarada = 0;

            if (datumOd != datumDo) //dohvati karte u rasponu datuma od-do
            {
                var query = _unitOfWork.KartaRepo.DohvatiSve().ToList().Where(k => k.datum_kupnje.Value >= datumOd && k.datum_kupnje.Value <= datumDo).ToList();
                query.ForEach(k => ukupnaZarada += double.Parse(k.Vrsta_karte.cijena.ToString()));
                uxUkupnaZarada.Text = ukupnaZarada.ToString() + " kn";
                kartaBindingSource.DataSource = query;
            }
            else if(datumOd == datumDo) //provjera samo za jedan dan
            {   
                var query = from k in _unitOfWork.KartaRepo.DohvatiSve() where DbFunctions.TruncateTime(k.datum_kupnje.Value) == datumOd.Date select k;

                query.ToList().ForEach(k => ukupnaZarada += double.Parse(k.Vrsta_karte.cijena.ToString()));
                uxUkupnaZarada.Text = ukupnaZarada.ToString() + " kn";

                kartaBindingSource.DataSource = query.ToList();
            }
            
        }

        private void uxIspisiIzvjesce_Click(object sender, EventArgs e)
        {
            IzvjestajZaradePrikaz ispiskarte = new IzvjestajZaradePrikaz(izvjesceDatumOd.Value, izvjesceDatumDo.Value);
            ispiskarte.ShowDialog();
        }

        private void PregledProdanihKarata_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                Help.ShowHelp(this, "../../Help/Pomoc.chm");
            }
        }
    }
}
