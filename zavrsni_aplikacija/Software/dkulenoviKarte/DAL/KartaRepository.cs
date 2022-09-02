using SvaSuceljaAplikacije.EntityKlase;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SvaSuceljaAplikacije.DAL
{
    public class KartaRepository : IKartaRepository
    {
        private readonly Entities _context;


        public KartaRepository(Entities entities)
        {
            _context = entities;
        }

        public Karta DohvatiPrazniObjekt()
        {
            return _context.Set<Karta>().Create(); //vraća novi objekt s kreiranim proxy navigacijskim svojstvima
        }

        public Karta DohvatiPremaId(int KartaID)
        {
            return _context.Karta.Find(KartaID);
        }

        public IEnumerable<Karta> DohvatiSve()
        {
            return _context.Karta;
        }

        public void Azuriraj(Karta karta)
        {
            _context.Entry(karta).State = EntityState.Modified;
        }

        public void Dodaj(Karta karta)
        {
            _context.Karta.Add(karta);
        }

        public void Obrisi(Karta karta)
        {
            _context.Karta.Remove(karta);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
