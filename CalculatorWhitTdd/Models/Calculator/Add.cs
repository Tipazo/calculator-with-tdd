namespace CalculatorWhitTdd.Models.Calculator
{
    public class Add : OperationInterface
    {
        public decimal execute(decimal total, decimal value)
        {
            return total + value;
        }
    }
}
