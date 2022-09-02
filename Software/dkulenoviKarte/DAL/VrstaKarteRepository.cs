using SvaSuceljaAplikacije.EntityKlase;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SvaSuceljaAplikacije.DAL
{
    public class VrstaKarteRepository : IVrstaKarteRepository
    {
        private readonly Entities _context;

        public VrstaKarteRepository(Entities entities)
        {
            _context = entities;
        }

        public Vrsta_karte DohvatiPremaId(int VrstaKarteID)
        {
            return _context.Vrsta_karte.Find(VrstaKarteID);
        }

        public IEnumerable<Vrsta_karte> DohvatiSve()
        {
            return _context.Vrsta_karte.ToList();
        }

        public void Azuriraj(Vrsta_karte vrsta_Karte)
        {
            _context.Entry(vrsta_Karte).State = EntityState.Modified;
        }

        public void Dodaj(Vrsta_karte vrsta_Karte)
        {
            _context.Vrsta_karte.Add(vrsta_Karte);
        }

        public void Obrisi(Vrsta_karte vrsta_Karte)
        {
            _context.Vrsta_karte.Remove(vrsta_Karte);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
