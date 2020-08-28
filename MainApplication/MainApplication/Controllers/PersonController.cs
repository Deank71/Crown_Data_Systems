using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CDS.Data.Models;
using CDS.Repository.UnitOfWork;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace MainApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {

        private readonly IUnitOfWork _unitOfWork;
       //  this.mockIndexRepo = MockRepository<Index>.CreateMock().Object;
        public PersonController(IUnitOfWork unitOfWork)
        {
        
            _unitOfWork = unitOfWork;
        }

        // GET: api/<controller>
        [Route("/api/GetAllPeople")]
        public List<Person> Get()
        {
            var result = new List<Person>();
            try
            {
               result = _unitOfWork.Person.GetAll();
            }
            catch(Exception ex)
            {
                
            }
                return result;            
        }

        // GET: api/<controller>
        [Route("/api/SortPeople")]
        public List<Person> SortPeople(int dir, string field)
        {
            var result = new List<Person>();
            try
            {
                result = _unitOfWork.Person.Sort(dir,field).ToList();
            }
            catch (Exception ex)
            {

            }
            return result;
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
         [Route("/api/GetPerson")]
        public Person Get(int id)
        {
            return _unitOfWork.Person.Get(id);
        }

        [HttpPost]
        [Route("/api/AddPerson")]
        public virtual IActionResult AddPerson([FromBody] Person person)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Person.Add(person);
                _unitOfWork.Complete();
            }
            else
            {
                return BadRequest("Person data is Invalid.");
            }
          
            return Ok("Complete");
        }
    }
}
