using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SvaSuceljaAplikacije.DAL
{
    public interface IUnitOfWork : IDisposable
    {
        void CreateTransaction();
        void Commit();
        void Rollback();
        void Save();
    }
}
