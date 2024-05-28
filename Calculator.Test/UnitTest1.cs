using CalculatorWhitTdd.Models.Calculator;
using Microsoft.AspNetCore.Cors.Infrastructure;

namespace Calculator.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodAddItAddsPositiveNumber()
        {
            //arrange
            Add add = new Add();

            decimal total = 0;
            decimal value = 5;
            decimal expected = 5;

            //act
            decimal result = add.execute(total, value);

            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethodAddItAddsNegativeNumber()
        {
            Add add = new Add();

            decimal total = 100;
            decimal value = -5;
            decimal expected = 95;
            
            decimal result = add.execute(total, value);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethodDivisionItDivisionDiferenteByZeroNumber()
        {
            Division add = new Division();

            decimal total = 100;
            decimal value = 5;
            decimal expected = 20;
            
            decimal result = add.execute(total, value);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethodDivisionItThrows_an_exception_for_division_by_zero()
        {
            Division division = new Division();

            decimal total = 100;
            decimal value = 0;
            
            Exception exception = Assert.ThrowsException<Exception>(() => division.execute(total, value));

            Assert.AreEqual("Invalid division by zero", exception.Message);
        }

        [TestMethod]
        public void TestMethodDivisionItThrows_an_exception_for_division_by_zero_and_zero()
        {
            Division division = new Division();

            decimal total = 0;
            decimal value = 0;

            Assert.ThrowsException<Exception>(() => division.execute(total, value));
        }

        [TestMethod]
        public void TestMethodDivisionItThrows_an_exception_for_division_by_negative_number()
        {
            Division division = new Division();

            decimal total = 100;
            decimal value = -5;
            decimal expected = -20;

            decimal result = division.execute(total, value);

            Assert.AreEqual(expected, result);
        }
    }
}