using Calculator;
using System;
using Xunit;

namespace Calculator
{
    public class CalculatorTests
    {
        [Fact]
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
            Assert.Equal(4, result);
        }

        [Fact]
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
            Assert.Equal(5, result);
        }

        [Fact]
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
            Assert.Equal(9, result);
        }

        [Fact]
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
            Assert.Equal(5, result);
        }
    }
}
