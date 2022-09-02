using SvaSuceljaAplikacije.EntityKlase;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SvaSuceljaAplikacije.DAL
{
    public class KorisnikRepository : IKorisnikRepository
    {
        private readonly Entities _context;

        public KorisnikRepository(Entities entities)
        {
            _context = entities;
        }

        public Korisnik DohvatiPremaId(int KorisnikID)
        {
            return _context.Korisnik.Find(KorisnikID);
        }

        public IEnumerable<Korisnik> DohvatiSve()
        {
            return _context.Korisnik.ToList();
        }

        public void Azuriraj(Korisnik korisnik)
        {
            _context.Entry(korisnik).State = EntityState.Modified;
        }

        public void Dodaj(Korisnik korisnik)
        {
            _context.Korisnik.Add(korisnik);
        }

        public void Obrisi(Korisnik korisnik)
        {
            _context.Korisnik.Remove(korisnik);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
