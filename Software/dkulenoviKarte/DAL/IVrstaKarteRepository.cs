using SvaSuceljaAplikacije.EntityKlase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SvaSuceljaAplikacije.DAL
{
    public interface IVrstaKarteRepository
    {
        IEnumerable<Vrsta_karte> DohvatiSve();
        Vrsta_karte DohvatiPremaId(int VrstaKarteID);
        void Dodaj(Vrsta_karte vrsta_Karte);
        void Azuriraj(Vrsta_karte vrsta_Karte);
        void Obrisi(Vrsta_karte vrsta_Karte);
        void Save();
    }
}
