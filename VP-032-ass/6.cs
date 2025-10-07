// Program 6: Factorial Calculator

using System;

namespace FactorialCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, factorial = 1, i = 1;

            Console.Write("Enter a number: ");
            n = int.Parse(Console.ReadLine());

            while (i <= n)
            {
                factorial *= i;
                i++;
            }

            Console.WriteLine("Factorial = " + factorial);
        }
    }
}
