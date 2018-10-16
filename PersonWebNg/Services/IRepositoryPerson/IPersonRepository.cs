using PersonWebNg.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonWebNg.Services.IRepositoryPerson
{
    public interface IPersonRepository
    {
        Person AddPerson(Person p);
        IEnumerable<Person> People { get; }

    }
}
