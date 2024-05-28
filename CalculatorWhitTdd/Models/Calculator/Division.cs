namespace CalculatorWhitTdd.Models.Calculator
{
    public class Division : OperationInterface
    {
        public decimal execute(decimal total, decimal value)
        {
            if (value == 0)
            {
                throw new Exception("Invalid division by zero");
            }

            return total / value;
        }
    }
}
