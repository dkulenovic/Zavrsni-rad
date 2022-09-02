using SvaSuceljaAplikacije.EntityKlase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SvaSuceljaAplikacije.DAL
{
    public interface IMjestoRepository
    {
        IEnumerable<Mjesto> DohvatiSve();
        Mjesto DohvatiPremaId(int MjestoID);
        void Dodaj(Mjesto mjesto);
        void Azuriraj(Mjesto mjesto);
        void Obrisi(Mjesto mjesto);
        void Save();
    }
}
