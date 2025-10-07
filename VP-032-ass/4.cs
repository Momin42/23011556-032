// Program 4: Sum of Natural Numbers (Loop)

using System;

namespace SumOfNaturalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, sum = 0;

            Console.Write("Enter a number: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }

            Console.WriteLine("Sum = " + sum);
        }
    }
}
