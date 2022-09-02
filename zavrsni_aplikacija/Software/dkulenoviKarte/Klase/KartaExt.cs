using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SvaSuceljaAplikacije.EntityKlase
{
    public partial class Karta
    {
        private string valjanostPrikaz;
       
        public string ValjanostPrikaz
        {
            get {
                if(valjanost == 0)
                {
                    return "Ne vrijedi";
                }
                else
                {
                    return "Vrijedi";
                }
            }
            set { valjanostPrikaz = value; }
        }

        private string nazivMjesta;

        public string NazivMjesta
        {
            get { return Mjesto.naziv; }
            set { nazivMjesta = value; }
        }

        private string nazivVrsteKarte;

        public string Vrsta_karteNaziv
        {
            get { return Vrsta_karte.naziv; }
            set { nazivVrsteKarte = value; }
        }

        private string nazivKorisnika;
        public string KorisnikNaziv
        {
            get { return (Korisnik.ime + " " +Korisnik.prezime); }
            set { nazivKorisnika = value; }
        }

        private int cijenaKarte;
        public int CijenaKarte
        {
            get { return Vrsta_karte.cijena.Value; }
            set { cijenaKarte = value; }
        }


    }
}
