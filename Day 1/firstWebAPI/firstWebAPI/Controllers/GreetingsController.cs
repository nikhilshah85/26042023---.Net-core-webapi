using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace firstWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GreetingsController : ControllerBase
    {


        [HttpGet]
        [Route("greet")]
        public IActionResult Greetings()
        {
            //we need to return HTTP Status Code
            return Ok("Hello and Welcome to WebAPI Development, this is your first REST API method");
        }

        [HttpGet]
        [Route("greet2/{guestName}")]
        public  IActionResult Greetings(string guestName)
        {
            return Ok("Good going " + guestName);
        }

        [HttpGet]
        [Route("addition/{num1}/{num2}")]
        public IActionResult AddNumbers(int num1, int num2)
        {
            if (num1 <0 || num2 < 0)
            {
                return Ok("Please provide only Positive numbers");
            }
            else if (num1 < num2)
            {
                return Ok("First number should be greater than 2nd number");
            }
            int addResult = num1 + num2;
            return Ok(addResult);
        }

    }
}





