using System;
using Xunit;
using FizzBuzz;

namespace FizzBuzz.Test
{
    public class FizzBuzzTest
    {
        [Theory]
        [InlineData(-12, "Fizz")]
        [InlineData(1, "1")]
        [InlineData(3, "Fizz")]
        [InlineData(5, "Buzz")]
        [InlineData(6, "Fizz")]
        [InlineData(30, "FizzBuzz")]
        [InlineData(50, "Buzz")]
        [InlineData(90, "FizzBuzz")]
        [InlineData(99, "Fizz")]
        [InlineData(98, "98")]
        [InlineData(100, "Buzz")]
        public void StringForNumberTest(int number, string expectResult)
        {
            var result = FizzBuzz.FizzBuzzForNumber(number);
            
            Assert.Equal(result, expectResult);
        }

        [Theory]
        [InlineData(-12, "Fizz")]
        [InlineData(1, "")]
        [InlineData(3, "Fizz")]
        [InlineData(5, "")]
        [InlineData(6, "Fizz")]
        [InlineData(30, "Fizz")]
        [InlineData(50, "")]
        [InlineData(90, "Fizz")]
        [InlineData(99, "Fizz")]
        [InlineData(98, "")]
        [InlineData(100, "")]
        public void FizzStringForNumberTest(int number, string expectResult)
        {
            var result = Fizz.FormatNumber(number);
            
            Assert.Equal(result, expectResult);
        }
        
        [Theory]
        [InlineData(-12, "")]
        [InlineData(1, "")]
        [InlineData(3, "")]
        [InlineData(5, "Buzz")]
        [InlineData(6, "")]
        [InlineData(30, "Buzz")]
        [InlineData(50, "Buzz")]
        [InlineData(90, "Buzz")]
        [InlineData(99, "")]
        [InlineData(98, "")]
        [InlineData(100, "Buzz")]
        public void BuzzStringForNumberTest(int number, string expectResult)
        {
            var result = Buzz.FormatNumber(number);
            
            Assert.Equal(result, expectResult);
        }
    }
}