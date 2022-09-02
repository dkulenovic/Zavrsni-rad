using SvaSuceljaAplikacije.EntityKlase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SvaSuceljaAplikacije.DAL
{
    public class UnitOfWork
    {
        private KartaRepository _kartaRepo;
        private KorisnikRepository _korisnikRepo;
        private VrstaKarteRepository _vrstaKarteRepo;
        private MjestoRepository _mjestoRepo;

        private Entities _entities;

        public UnitOfWork(Entities entities)
        {
            _entities = entities;
        }

        public KartaRepository KartaRepo
        {
            get
            {
                if(_kartaRepo == null)
                {
                    _kartaRepo = new KartaRepository(_entities);
                }
                return _kartaRepo;
            }
        }

        public KorisnikRepository KorisnikRepo
        {
            get
            {
                if (_korisnikRepo == null)
                {
                    _korisnikRepo = new KorisnikRepository(_entities);
                }
                return _korisnikRepo;
            }
        }

        public VrstaKarteRepository VrstaKarteRepo
        {
            get
            {
                if (_vrstaKarteRepo == null)
                {
                    _vrstaKarteRepo = new VrstaKarteRepository(_entities);
                }
                return _vrstaKarteRepo;
            }
        }

        public MjestoRepository MjestoRepo
        {
            get
            {
                if (_mjestoRepo == null)
                {
                    _mjestoRepo = new MjestoRepository(_entities);
                }
                return _mjestoRepo;
            }
        }

        public void Save()
        {
            _entities.SaveChanges();
        }
    }
}
