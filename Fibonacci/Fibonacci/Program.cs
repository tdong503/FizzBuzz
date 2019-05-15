using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 1; i <= 120; i++)
            {
                Console.WriteLine(Fibonacci.F(1, 1, i));
            }
            Console.WriteLine("Hello World!");
        }
    }
}