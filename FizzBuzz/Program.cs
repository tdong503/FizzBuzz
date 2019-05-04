using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = InitData();            

            foreach (var number in numbers)
            {
                Console.WriteLine(FizzBuzz.FizzBuzzForNumber(number));
            }
        }

        private static IEnumerable<int> InitData()
        {
            var numbers = new List<int>();
            for (var i = 1; i <= 100; i++)
            {
                numbers.Add(i);
            }

            return numbers;
        }
    }
}