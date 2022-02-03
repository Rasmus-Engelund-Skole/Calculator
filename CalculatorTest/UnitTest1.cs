using CalculatorApp;
using NUnit.Framework;

namespace Calculator.Test.Unit
{
    public class Tests
    {
        private  CalculatorApp.Calculator uut;
        [SetUp]
        public void Setup()
        {
            uut = new CalculatorApp.Calculator();
        }

        [Test]
        public void Calculator_AddTwo_Test()
        {
            //Arrange

            //Act
            double Result = uut.Add(2.22, 5.22);
            //Assert
           
            Assert.That(Result, Is.EqualTo(2.22+5.22));
        }

        [Test]
        public void Calculator_AddOneNegative()
        {
            //Arrange

            //Act
            double Result = uut.Add(2.22, -5.22);
            //Assert
            Assert.That(Result, Is.EqualTo(2.22-5.22));
        }

        [Test]
        public void Calculator_Multiply2Positive()
        {
            //Arrange

            //Act
            double Result = uut.Multiply(3, 5);
            //Assert
            Assert.That(Result, Is.EqualTo(15));
        }

        [Test]
        public void Calculator_MultiplyPositiveAndNegative()
        {
            //Arrange

            //Act
            double Result = uut.Multiply(-3, 5);
            //Assert
            Assert.That(Result, Is.EqualTo(-15));
        }



    }
}