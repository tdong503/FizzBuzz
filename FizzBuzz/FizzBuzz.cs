using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    public static class FizzBuzz
    {
        public static string FizzBuzzForNumber(int number)
        {
            var result = Fizz.FormatNumber(number) + Buzz.FormatNumber(number);
            return result == string.Empty ? number.ToString() : result;
        }
    }
}