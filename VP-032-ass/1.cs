// Even or Odd Number Checker

using System;

namespace EvenOddChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;

            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("The number is even.");
            }
            else
            {
                Console.WriteLine("The number is odd.");
            }
        }
    }
}
