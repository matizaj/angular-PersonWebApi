using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonWebNg.Models;
using PersonWebNg.Services.IRepositoryPerson;

namespace PersonWebNg.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private IPersonRepository _context;
        public PersonController(IPersonRepository context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("GetAll")]
        public IEnumerable<Person> GetAll()
        {
            return _context.People;
        }

        [HttpGet("{id}", Name = "GetPerson")]
        public ActionResult<Person> GetById(int id)
        {
            var person = _context.People.FirstOrDefault(x => x.Id == id);
            if (person == null)
            {
                return NotFound();
            }
            return person;
        }

        [HttpPost]
        [Route("Create")]
        public ActionResult<List<Person>> Create([FromBody]Person p)
        {
            _context.AddPerson(p);
            //return CreatedAtRoute("GetPerson", p);
            return Ok(p);
        }
    }
}