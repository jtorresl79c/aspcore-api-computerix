using Microsoft.AspNetCore.Mvc;

namespace WebApplicationAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet]
        public string Prueba()
        {
            return "Soy un metodo de prueba";
        }


        [HttpGet]
        [Route("getAge")]
        public int GetAge()
        {
            return 10;
        }

        [HttpGet]
        [Route("getName")]
        public string GetName()
        {
            return "Jhon Doe";
        }

        [HttpPost]
        [Route("sendData")]
        public void SendData([FromBody] Person p)
        {
            Console.WriteLine(p.firstName + " " + p.lastName);
        }

    }
}