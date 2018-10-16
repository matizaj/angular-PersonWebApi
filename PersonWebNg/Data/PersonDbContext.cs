using Microsoft.EntityFrameworkCore;
using PersonWebNg.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonWebNg.Data
{
    public class PersonDbContext:DbContext
    {
        public PersonDbContext(DbContextOptions<PersonDbContext> options) : base(options)
        {

        }
        public DbSet<Person> People { get; set; }
    }
}
