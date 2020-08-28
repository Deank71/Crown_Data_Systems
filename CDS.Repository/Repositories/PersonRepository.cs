using CDS.Data.Models;
using CDS.Repository.Repositories.Inerfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CDS.Repository.Repositories
{
    public class PersonRepository : Repository<Person>, IPersonRepository
    {
        CDSContext _context;
        public PersonRepository(CDSContext context) : base(context)
        {
            _context = context;
        }

    }
}
