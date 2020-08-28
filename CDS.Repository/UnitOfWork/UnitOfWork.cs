using CDS.Data.Models;
using CDS.Repository.Repositories;
using CDS.Repository.Repositories.Inerfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CDS.Repository.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly CDSContext _context;

        public UnitOfWork(CDSContext context)
        {
            _context = context;
            Person = new PersonRepository(_context);

        }

        public IPersonRepository Person { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
