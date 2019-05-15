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
        public void FibonacciWhenInputNThenOutputNumberTest(int number, decimal result)
        {
            var actual = Fibonacci.F(1, 1,number);
            Assert.Equal(result, actual);
        }
        
        [Fact]
        public void FibonacciWhenInput120ThenOutputNumberTest()
        {
            var actual = Fibonacci.F(1, 1,120);
            Assert.Equal(5358359254990966640871840m, actual);
        }
    }
}