using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Calculator
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
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

        [TestMethod]
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

        [TestMethod]
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

        [TestMethod]
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
