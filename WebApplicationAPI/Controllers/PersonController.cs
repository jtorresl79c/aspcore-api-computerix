using Business_Logic_Layer.Models;
using Data_Access_Layer.Repository.Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        private Business_Logic_Layer.PersonBLL _BLL;
        public PersonController()
        {
            _BLL = new Business_Logic_Layer.PersonBLL();
        }

        [HttpGet]
        [Route("getPersons")]
        public List<PersonModel> GetAllPersons()
        {
            return _BLL.GetAllPersons();
        }

        [HttpGet]
        [Route("getPersonById")]
        //public Person GetPersonById(int id)
        public ActionResult<PersonModel> GetPersonById(int id) // el <Person> indica que a Ok solo podremos pasarle datos de tipo Person
        {
            var person = _BLL.GetPersonById(id);
            if (person == null)
            {
                return NotFound("Invalid ID");
            }

            return Ok(person);
        }

        [HttpPost]
        [Route("postPerson")]
        public void postPerson([FromBody] PersonModel personModel)
        {
            _BLL.postPerson(personModel);
        }



        //[HttpDelete]
        //[Route("deletePerson")]
        //public void deletePerson(int id)
        //{
        //    var db = new PersonDbContext();

        //    Person? p = new Person();

        //    p = db.Person.FirstOrDefault(p => p.Id == id);

        //    if (p == null)
        //    {
        //        throw new Exception("Not found");
        //    }

        //    db.Person.Remove(p);
        //    db.SaveChanges();

        //}





        //[HttpGet]
        //[Route("getPerson")]
        //public Person GetPerson(int id)
        //{
        //    var db = new PersonDbContext();

        //    Person? p = new Person();

        //    p = db.Person.FirstOrDefault(p => p.Id == id);

        //    if (p == null)
        //    {
        //        throw new Exception("Not found");
        //    }

        //    return p;
        //}




    }
}