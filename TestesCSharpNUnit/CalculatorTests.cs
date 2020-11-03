using Calculator;
using NUnit.Framework;
using System;

namespace Calculator
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void Sum_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var calculator = new Calculator();
            int x = 2;
            int y = 2;

            // Act
            var result = calculator.Sum(
                x,
                y);

            // Assert
            Assert.AreEqual(4, result);
        }

        [Test]
        public void Subtraction_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var calculator = new Calculator();
            int x = 10;
            int y = 5;

            // Act
            var result = calculator.Subtraction(
                x,
                y);

            // Assert
            Assert.AreEqual(5, result);
        }

        [Test]
        public void Multiplication_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var calculator = new Calculator();
            int x = 3;
            int y = 3;

            // Act
            var result = calculator.Multiplication(
                x,
                y);

            // Assert
            Assert.AreEqual(9, result);
        }

        [Test]
        public void Division_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var calculator = new Calculator();
            int x = 10;
            int y = 2;

            // Act
            var result = calculator.Division(
                x,
                y);

            // Assert
            Assert.AreEqual(5, result);
        }
    }
}
