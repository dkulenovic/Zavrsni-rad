using SvaSuceljaAplikacije.EntityKlase;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SvaSuceljaAplikacije.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private KartaRepository _kartaRepo;
        private KorisnikRepository _korisnikRepo;
        private VrstaKarteRepository _vrstaKarteRepo;
        private MjestoRepository _mjestoRepo;

        private Entities _entities;
        private DbContextTransaction _objTran;
        private string _errorMessage = string.Empty;
        private bool disposedValue;

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

        public void Commit()
        {
            _objTran.Commit();
        }

        public void CreateTransaction()
        {
            _objTran = _entities.Database.BeginTransaction();
        }

        public void Rollback()
        {
            _objTran.Rollback();
            _objTran.Dispose();
        }

        public void Save()
        {
            try
            {
                _entities.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                    foreach (var validationError in validationErrors.ValidationErrors)
                        _errorMessage += string.Format("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage) + Environment.NewLine;
                throw new Exception(_errorMessage, dbEx);
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _entities.Dispose();
                }
                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
