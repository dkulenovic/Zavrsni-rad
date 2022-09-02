using SvaSuceljaAplikacije.DAL;
using SvaSuceljaAplikacije.EntityKlase;
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

namespace SvaSuceljaAplikacije
{
    public partial class ValidacijaKarata : Form
    {
        UnitOfWork _unitOfWork = new UnitOfWork(new Entities());
        public ValidacijaKarata()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void uxOtvoriSliku_Click(object sender, EventArgs e)
        {
            uxOtvoriSlikuDijalog.ShowDialog();
        }

        private void uxValidirajKartu_Click(object sender, EventArgs e)
        {
            Karta _karta = _unitOfWork.KartaRepo.DohvatiPremaId(int.Parse(uxSifraKarte.Text));
            if (uxSifraKarte.Text != "" && _karta != null)
            {
                if (_karta.trenutak_aktivacije == null)
                {
                    _karta.trenutak_aktivacije = DateTime.Now;
                    _unitOfWork.KartaRepo.Azuriraj(_karta);
                    _unitOfWork.KartaRepo.Save();

                    uxPoruka.Text = "Karta je valjana i aktivirana!";
                    uxPoruka.ForeColor = Color.Green;
                } 
                else if (_karta.trenutak_aktivacije != null)
                {
                    //provjerava se da li je karta istekla pomoću sadašnjeg vremena i vremena kada je karta aktivirana
                    int trajnost_karte = _karta.Vrsta_karte.trajanje_valjanosti.Value;
                    DateTime trenutno_vrijeme = DateTime.Now;
                    DateTime trenutak_aktivacije = DateTime.Parse(_karta.trenutak_aktivacije.ToString());
                    TimeSpan ts = trenutno_vrijeme - trenutak_aktivacije;

                    double proteklo_vrijeme = ts.TotalMinutes;

                    if (proteklo_vrijeme > trajnost_karte)
                    {
                        _karta.valjanost = 0;
                        _unitOfWork.KartaRepo.Azuriraj(_karta);
                        _unitOfWork.KartaRepo.Save();

                        uxPoruka.Text = "Karta više ne vrijedi!";
                        uxPoruka.ForeColor = Color.Red;
                    }
                    else
                    {
                        uxPoruka.Text = "Karta još uvijek vrijedi!";
                        uxPoruka.ForeColor = Color.Green;
                    }
                }
            }
            else
            {
                MessageBox.Show("Molimo unesite valjanu šifru karte.");
            }
        }

        private void ValidacijaKarata_Load(object sender, EventArgs e)
        {
        }

        private void ValidacijaKarata_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                Help.ShowHelp(this, "../../Help/Pomoc.chm");
            }
        }
    }
}
