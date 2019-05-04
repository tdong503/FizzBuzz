using System;

namespace FizzBuzz
{
    public static class Buzz
    {
        public static string FormatNumber(int number)
        {
            return number % 5 == 0 ? "Buzz" : string.Empty;
        }
    }
}