using Microsoft.AspNetCore.Mvc;
using WebApplicationAPI.Repository;
using WebApplicationAPI.Repository.Models;

namespace WebApplicationAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        [HttpDelete]
        [Route("deletePerson")]
        public void deletePerson(int id)
        {
            var db = new PersonDbContext();

            Person? p = new Person();

            p = db.Person.FirstOrDefault(p => p.Id == id);

            if (p == null)
            {
                throw new Exception("Not found");
            }

            db.Person.Remove(p);
            db.SaveChanges();

        }


        [HttpGet]
        [Route("getPersons")]
        public List<Person> GetAllPersons()
        {
            var db = new PersonDbContext();
            return db.Person.ToList();
        }


        [HttpPost]
        [Route("postPerson")]
        public void postPerson([FromBody] Person p)
        {
            var db = new PersonDbContext();

            db.Add(p);
            db.SaveChanges();
        }

        

        [HttpGet]
        [Route("getPerson")]
        public Person GetPerson(int id)
        {
            var db = new PersonDbContext();

            Person? p = new Person();

            p = db.Person.FirstOrDefault(p => p.Id == id);

            if (p == null)
            {
                throw new Exception("Not found");
            }

            return p;
        }

        


    }
}