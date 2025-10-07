// Program 5: Multiplication Table

using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;

            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(number + " x " + i + " = " + (number * i));
            }
        }
    }
}
