using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace CDS.Data.Models
{
    public class CDSContext:DbContext
    {
        public CDSContext(DbContextOptions<CDSContext> options) : base(options)
        {
           
        }
        public DbSet<Person> Person { get; set; }
    }
}
