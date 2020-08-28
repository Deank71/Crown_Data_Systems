using CDS.Repository.Repositories.Inerfaces;
using CDS.Repository.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace CDS.MainApplicationTests.TestHelpers
{
    public class MockUnitOfWork<T> : IUnitOfWork where T : class, new()
    {
        private T Context;
        private Dictionary<Type, object> _repositories;

        public MockUnitOfWork()
        {
            Context = new T();
            _repositories = new Dictionary<Type, object>();
        }

        public IPersonRepository Person => throw new NotImplementedException();

        public int Complete()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
