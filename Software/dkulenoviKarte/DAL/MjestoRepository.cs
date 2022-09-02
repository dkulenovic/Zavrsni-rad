using SvaSuceljaAplikacije.EntityKlase;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SvaSuceljaAplikacije.DAL
{
    public class MjestoRepository : IMjestoRepository
    {
        private Entities _context;

        public MjestoRepository(Entities entities)
        {
            _context = entities;
        }

        public Mjesto DohvatiPremaId(int MjestoID)
        {
            return _context.Mjesto.Find(MjestoID);
        }

        public IEnumerable<Mjesto> DohvatiSve()
        {
            return _context.Mjesto.ToList();
        }

        public void Azuriraj(Mjesto mjesto)
        {
            _context.Entry(mjesto).State = EntityState.Modified;
        }

        public void Dodaj(Mjesto mjesto)
        {
            _context.Mjesto.Add(mjesto);
        }

        public void Obrisi(Mjesto mjesto)
        {
            _context.Mjesto.Remove(mjesto);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
