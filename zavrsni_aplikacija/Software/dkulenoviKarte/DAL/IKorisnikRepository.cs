using SvaSuceljaAplikacije.EntityKlase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SvaSuceljaAplikacije.DAL
{
    public interface IKorisnikRepository
    {
        IEnumerable<Korisnik> DohvatiSve();
        Korisnik DohvatiPremaId(int KorisnikID);
        void Dodaj(Korisnik korisnik);
        void Azuriraj(Korisnik korisnik);
        void Obrisi(Korisnik korisnik);
        void Save();
    }
}
