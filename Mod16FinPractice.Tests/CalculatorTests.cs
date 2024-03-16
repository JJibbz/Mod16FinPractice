using NUnit.Framework;

namespace Mod16FinPractice.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void AdditionalMustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();
            Assert.That(calculator.Additional(2, 2) == 4);
        }

        [Test]
        public void SubtractionMustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();
            Assert.That(calculator.Subtraction(4, 2) == 2);
        }

        [Test]
        public void MultiplicationMustReturnCorrectValue() 
        {  
            Calculator calculator = new Calculator();
            Assert.That(calculator.Multiplication(4, 2) == 8);
        }

        [Test]
        public void DivisionMustReturnCorrectValue() 
        {  
            Calculator calculator = new Calculator();
            Assert.That(calculator.Division(4, 2) == 2);
        }
    }
}
