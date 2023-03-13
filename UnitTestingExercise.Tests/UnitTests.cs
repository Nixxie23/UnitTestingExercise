using System;
using Xunit;
using Xunit.Sdk;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]
        [InlineData(0, 5, 7, 12)]
        [InlineData(-5, 4, 3, 2)]
        [InlineData(-5, -3, 1, -7)]
        [InlineData(0, 0, 0, 0)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            Calculator challenger = new Calculator();
            int actual = challenger.Add(num1, num2, num3);
            Assert.Equal(expected, actual);
           
        }

        [Theory]
        [InlineData(5, 2, 3)]
        [InlineData(0, 2, -2)]
        [InlineData(0, 0, 0)]
        [InlineData(500, 250, 250)]
        [InlineData(-50, -25, -25)]
        [InlineData(-50, -30, -20)]
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            
            Calculator challenger = new Calculator();
            int actual = challenger.Subtract(minuend, subtrhend);
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(5, 6, 30)]
        [InlineData(0, 55, 0)]
        [InlineData(-3, 1, -3)]
        [InlineData(-3, -3, 9)]

      
        public void MultiplyTest(int num1, int num2, int expected)
        {
            Calculator challenger = new Calculator();
            int actual = challenger.Multiply(num1, num2);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0, 5, 0)]
        [InlineData(5, -1, -5)]
        [InlineData(10, 2 , 5)]
        [InlineData(10, 0, 0)]
        [InlineData( 0, 0, 0)]

        public void DivideTest(int num1, int num2, int expected)
        {
            Calculator challenger = new Calculator();
            int actual = challenger.Divide(num1, num2);
            Assert.Equal(expected, actual);
        }

    }
}
