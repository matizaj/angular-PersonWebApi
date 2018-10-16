using PersonWebNg.Data;
using PersonWebNg.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonWebNg.Services.IRepositoryPerson
{
    public class PersonRepository : IPersonRepository
    {
        private PersonDbContext _context;
        public PersonRepository(PersonDbContext context)
        {
            _context = context;
            if (_context.People.Count() == 0)
            {
                _context.People.Add(new Person() { Name = "Mat" });
                _context.SaveChanges();
            }
        }

        public IEnumerable<Person> People => _context.People.ToList();

        public Person AddPerson(Person p)
        {
            var maxId = _context.People.Max(x => x.Id);
            var personToCreate = new Person()
            {
                Id = ++maxId,
                Name = p.Name
            };
            _context.People.Add(personToCreate);
            _context.SaveChanges();
            return personToCreate;
        }
    }
}
