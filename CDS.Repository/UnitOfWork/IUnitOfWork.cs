using CDS.Repository.Repositories.Inerfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CDS.Repository.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        public IPersonRepository Person { get; }
        public int Complete();
    }
}
