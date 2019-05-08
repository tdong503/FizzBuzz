using System;

namespace FizzBuzz
{
    public static class Buzz
    {
        public static string FormatNumber(int number)
        {
            return IsDividedByFive(number) ? "Buzz" : string.Empty;
        }

        private static bool IsDividedByFive(int number)
        {
            return number % 5 == 0;
        }
    }
}