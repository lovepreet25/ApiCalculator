using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiCalculator.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CalculatorApi : ControllerBase
    {
        [HttpGet]
        public int Addition(int a, int b)
        {
            return a + b;
        }
        [HttpGet]
        public int Subtraction(int a, int b)
        {
            return a - b;
        }
        [HttpGet]
        public int Multiplication(int a, int b)
        {
            return a * b;
        }
        [HttpGet]
        public int dividation(int a, int b)
        {
            return a / b;
        }
    }
}

namespace CalcaulationsLibrary
{
    public class calculation
    {
        public int Addition(int a, int b)
        {
            return a + b;
        }
        public int Subtraction(int a, int b)
        {
            return a - b;
        }
        public int Multiplication(int a, int b)
        {
            return a * b;
        }
        public int division(int a, int b)
        {
            return a / b;
        }
    }
}