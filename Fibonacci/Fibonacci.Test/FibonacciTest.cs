using System;
using Xunit;

namespace Fibonacci.Test
{
    public class FibonacciTest
    {
        [Theory]
        [InlineData(1, 1)]
        [InlineData(3, 2)]
        [InlineData(6, 8)]
        [InlineData(7, 13)]
        [InlineData(8, 21)]
        [InlineData(9, 34)]
        [InlineData(120, 5.35835925499097E+24 - 2147483648)]
        public void FibonacciWhenInputNThenOutputNumber(int number, double result)
        {
            var actual = Fibonacci.F(1, 1,number);
            Assert.Equal(actual, result);
        }
    }
}