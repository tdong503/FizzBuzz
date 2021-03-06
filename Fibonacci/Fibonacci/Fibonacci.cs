namespace Fibonacci
{
    public static class Fibonacci
    {
        public static decimal F(decimal firstNumber, decimal secondNumber, int figure)
        {
            if (figure <= 2)
            {
                return 1;
            }

            if (figure == 3)
            {
                return firstNumber + secondNumber;
            }
            
            return F(secondNumber, firstNumber + secondNumber, figure - 1);
        }
    }
}