using API_Interactive_Lab_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_Interactive_Lab_1.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class CoffeeController : ControllerBase
    {
        [HttpGet("lover")]
        public string GetCoffeeLover() {
            return "I like coffee!";
        }

        [HttpGet("{name}")]
        public Coffee Get(string? name) {
            return new Coffee {Id = (name !=null ?7:-1), 
                Name = name ?? "latte" };
        }
    }
}
