using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SvaSuceljaAplikacije.DAL;
using SvaSuceljaAplikacije.EntityKlase;
using SvaSuceljaAplikacije.Forme;

namespace SvaSuceljaAplikacije
{
    public partial class KupnjaKarte : Form
    {
        UnitOfWork _unitOfWork = new UnitOfWork(new Entities());

        public KupnjaKarte()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void KupnjaKarata_Load(object sender, EventArgs e)
        {

            //ucitavanje svih vrsta karata u padajuci izbornik
            _unitOfWork.VrstaKarteRepo.DohvatiSve().Select(v => v.naziv).ToList().ForEach(m => uxVrstaKarte.Items.Add(m));
            //ucitavanje svih mjesta u padajuci izbornik
            _unitOfWork.MjestoRepo.DohvatiSve().Select(v => v.naziv).ToList().ForEach(m => uxMjesto.Items.Add(m));

            uxDatum.Text = DateTime.Now.Date.ToShortDateString();
            uxVrijeme.Text = DateTime.Now.ToString("HH:mm");
        }



        private void uxVrstaKarte_SelectedIndexChanged(object sender, EventArgs e)
        {
            uxCijena.Text = _unitOfWork.VrstaKarteRepo.DohvatiSve().Where(v => v.naziv == uxVrstaKarte.Text).ToList().Select(m => m.cijena).First().ToString();
        }

        private void uxKupiKartu_Click(object sender, EventArgs e)
        {
            if (uxMjesto.Text == "")
            {
                MessageBox.Show("Odaberite mjesto!");
                return;
            }
            if (uxVrstaKarte.Text == "")
            {
                MessageBox.Show("Odaberite vrstu karte!");
                return;
            }
            Vrsta_karte _vrsta = _unitOfWork.VrstaKarteRepo.DohvatiSve().Where(v => v.naziv == uxVrstaKarte.Text).First();
            int _mjestoID = _unitOfWork.MjestoRepo.DohvatiSve().Where(m => m.naziv == uxMjesto.Text).Select(m => m.id_mjesto).FirstOrDefault();
            _unitOfWork.CreateTransaction();
            var _karta = _unitOfWork.KartaRepo.DohvatiPrazniObjekt();
            
            _karta.valjanost = 1;
            _karta.id_vrsta_karte = _vrsta.id_vrsta_karte;
            _karta.id_mjesto = _mjestoID;
            _karta.id_korisnik = 1; // hardkodiran korisnik ID-a 1 jer nemamo funkciju login-a, za lakše testiranje
            _karta.datum_kupnje = DateTime.Now;

            _unitOfWork.KartaRepo.Dodaj(_karta);
            _unitOfWork.KartaRepo.Save();
            _unitOfWork.Commit();

            //ispis karte u PDF format
            IspisKartePDF ispis = new IspisKartePDF(_unitOfWork.KartaRepo.DohvatiPremaId(_karta.id_karta));
            ispis.ShowDialog();
        }

        private void KupnjaKarte_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                Help.ShowHelp(this, "../../Help/Pomoc.chm");
            }
        }
    }
}
