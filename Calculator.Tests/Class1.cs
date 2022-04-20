using NUnit.Framework;
using Practices;


namespace SimpleCalculator.Tests
{
    [TestFixture]
    public class CalculatorTests
    {

        Calculator calc = new Calculator();
        [Test]
        public void AdditionalMustReturnTrueValue()
        {

            Assert.True(calc.Additional(5, 5) == 10);
        }


        [Test]
        public void SubtractionMustReturnTrueValue()
        {

            Assert.True(calc.Subtraction(5, 5) == 0);
        }

        [Test]
        public void MultiplicationMustReturnTrueValue()
        {

            Assert.True(calc.Miltiplication(5, 5) == 25);
        }

        [Test]
        public void DivisionMustReturnTrueValue()
        {

            Assert.True(calc.Division(10, 5) == 2);
        }













    }
}