using CalculatorWhitTdd.Business;
using CalculatorWhitTdd.Models.Calculator;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorWhitTdd.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : Controller
    {

        [HttpGet(Name = "calcular")]
        public string  Get()
        {
            try
            {
                Calculator calc = new Calculator(0);

                calc.culculate(100, new Add());
                calc.culculate(4, new Division());
                decimal total = calc.culculate(5, new Add());

                return $"total: {total}";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
    }
}
