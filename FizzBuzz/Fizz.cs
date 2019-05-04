namespace FizzBuzz
{
    public static class Fizz
    {
        public static string FormatNumber(int number)
        {
            return IsDividedByThree(number) ? "Fizz" : string.Empty;
        }

        private static bool IsDividedByThree(int number)
        {
            return number % 3 == 0;
        }                
    }
}