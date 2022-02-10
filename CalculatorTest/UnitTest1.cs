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
        public void Calculator_AddTwoNegative()
        {
            //Arrange

            //Act
            double Result = uut.Add(-2.22, -5.22);
            //Assert
            Assert.That(Result, Is.EqualTo(-2.22+-5.22));
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

        [Test]
        public void Calculator_PowerOf3()
        {
            //Arrange

            //Act
            double Result = uut.Power(5, 3);
            //Assert
            Assert.That(Result, Is.EqualTo(125));
        }

        [Test]
        public void Calculator_PowerOf7()
        {
            //Arrange

            //Act
            double Result = uut.Power(5, 7);
            //Assert
            Assert.That(Result, Is.EqualTo(78125));
        }

        [Test]
        public void Calculator_PowerOf_minus3()
        {
            //Arrange

            //Act
            double Result = uut.Power(5, -3);
            //Assert
            Assert.That(Result, Is.EqualTo(0.008));
        }
        [Test]
        public void Calculator_DivideBy2()
        {
            //Arrange

            //Act
            double Result = uut.Divide(10, 2);

            //Assert
            Assert.That(Result, Is.EqualTo(5));
        }
        [Test]
        public void Calculator_DivideByNeg5()
        {
            //Arrange

            //Act
            double Result = uut.Divide(10, -5);
            //Assert
            Assert.That(Result, Is.EqualTo(-2));
        }
        [Test]
        public void Calculator_DivideBy0()
        {
            //Arrange

            //Act
            double Result = uut.Divide(10, 0);
            //Assert
            Assert.That(Result, Is.EqualTo(0));
        }
    }
}