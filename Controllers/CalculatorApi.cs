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
        public double Addition(double a, double b)
        {
            return CalculationLibrary.Calculations.Addition(a, b);

        }
        [HttpGet]
        //method for subtracttionn
        public double Subtraction(double a, double b)
        {
            return CalculationLibrary.Calculations.Subtraction(a, b);
        }
        [HttpGet]
        //method multiplication of the numbers
        public double Multiplication(double a, double b)
        {
            return CalculationLibrary.Calculations.Multiplication(a, b);
        }
        //method fot dividing the numbers
        [HttpGet]
        public double dividation(double a, double b)
        {
            double result = 0;
            try
            {
                result = CalculationLibrary.Calculations.Dividation(a, b);
            }
            catch(DivideByZeroException)
            {
                Response.StatusCode = 400;
            }
            return result;
        }
    }
}

