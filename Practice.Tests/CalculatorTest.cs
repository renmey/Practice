using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Practice;

namespace Practice.Tests
{
    [TestFixture]
    public class CalculatorTest
    {

        [Test]
        public void AdditionalMustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();
            int result = calculator.Additional(10, 10);
            Assert.That(result == 20);
        }

        [Test]
        public void SubtractionlMustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();
            int result = calculator.Subtraction(20, 10);
            Assert.That(result == 10);
        }

        [Test]
        public void MultiplicationMustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();
            int result = calculator.Multiplication(10, 10);
            Assert.That(result == 100);
        }

        [Test]
        public void DivisionMustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();
            int result = calculator.Division(10, 10);
            Assert.That(result == 1);
        }

        [Test]
        public void DivisionMustThrowExceptionOnZeroDivision()
        {
            Calculator calculator = new Calculator();
            Assert.Throws<ArgumentException>(() => calculator.Division(10, 0));
        }

    }
}
