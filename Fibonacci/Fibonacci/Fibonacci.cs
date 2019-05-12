namespace Fibonacci
{
    public class Fibonacci
    {
        public static long F(int firstNumber, int secondNumber, int figure)
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