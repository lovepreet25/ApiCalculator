using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiCalculator.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CalculatorApi : ControllerBase
    {
        [HttpGet]
        // method for addition
        public int Addition(int a, int b)
        {
            return a + b;
        }
        [HttpGet]
        //method for subtracttionn
        public int Subtraction(int a, int b)
        {
            return a - b;
        }
        [HttpGet]
        //method multiplication of the numbers
        public int Multiplication(int a, int b)
        {
            return a * b;
        }
        //method fot dividing the numbers
        [HttpGet]
        public int dividation(int a, int b)
        {
            return a / b;
        }
    }
}


    
