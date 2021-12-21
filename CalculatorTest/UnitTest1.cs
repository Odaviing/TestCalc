using System;
using Xunit;
using ConsoleApp5;
namespace CalculatorTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestDivideNegative()
        {
            double a = 5;
            double b = 0;
            string act_mess = "You cannot divide on zero";
            
            var expected = Assert.Throws<DivideByZeroException>(() => Calculator.Divide(a, b));
            Assert.Equal(act_mess, expected.Message);
        }

        [Theory]
        [InlineData(-14, -2, 7)]
        [InlineData(28, 4, 7)]
        [InlineData(0.25, 5, 0.05)]
        public void TestDividePositive(double a, double b, double expected)
        {
            double actual = Calculator.Divide(a, b);
            
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 8, 13)]
        [InlineData(-10, -2, -12)]
        [InlineData(0.575, 0.425, 1)]
        public void TestSumPositive(double a, double b, double expected)
        {
            double actual = Calculator.Sum(a, b);
            
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(24, 5, 19)]
        [InlineData(-15, -5, -10)]
        [InlineData(0.325, 0.024, 0.301)]
        public void TestSubtractPositive(double a, double b, double expected)
        {
            double actual = Calculator.Subtract(a, b);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 5, 25)]
        [InlineData(-2, -2, 4)]
        [InlineData(0.4, 0.4, 0.16000000000000003)]
        public void TestMultPositive(double a, double b, double expected)
        {
            double actual = Calculator.Mult(a, b);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(25, 5)]
        [InlineData(1024, 32)]
        public void TestSqrtPositive(int a, double expected)
        {
            double actual = Calculator.Square(a);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestSqrtNegative()
        {
            int a = -1;
            string act_mess = "You cannot get a square root from negative number";

            var expected = Assert.Throws<ArgumentException>(() => Calculator.Square(a));
            Assert.Equal(act_mess, expected.Message);
        }
    }
}
