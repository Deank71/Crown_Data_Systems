using CDS.Data.Models;
using CDS.Repository.Repositories.Inerfaces;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
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

        public List<Person> Sort(int dir,string field)
        {
            var result = new List<Person>();
            if(dir == 0)
            {
                switch(field)
                {
                    case "Age":
                      result =  _context.Person.OrderBy(x => x.Age).ToList();
                        break;
                    case "Name":
                        result = _context.Person.OrderBy(x => x.Name).ToList();
                        break;
                }
            }
            else
            {
                switch (field)
                {
                    case "Age":
                        result = _context.Person.OrderByDescending(x => x.Age).ToList();
                        break;
                    case "Name":
                        result = _context.Person.OrderByDescending(x => x.Name).ToList();
                        break;
                }
            }
           
            return result;
        }
    }
}
