using SvaSuceljaAplikacije.EntityKlase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SvaSuceljaAplikacije.DAL
{
    public interface IKartaRepository
    {
        IEnumerable<Karta> DohvatiSve();
        Karta DohvatiPremaId(int KartaID);
        void Dodaj(Karta karta);
        void Azuriraj(Karta karta);
        void Obrisi(Karta karta);
        void Save();
    }
}
