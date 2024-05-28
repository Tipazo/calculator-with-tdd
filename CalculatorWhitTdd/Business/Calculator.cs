using CalculatorWhitTdd.Models.Calculator;
using System.Xml.Schema;

namespace CalculatorWhitTdd.Business
{
    public class Calculator
    {
        protected decimal total = 0;
        public Calculator(decimal total) { 
            this.total = total;
        }

        public decimal culculate (decimal value, OperationInterface operation)
        {
            this.total = operation.execute(this.total, value);

            return this.total; 
        }

    }
}
