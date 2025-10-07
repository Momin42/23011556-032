// Program 8: Array - Find Maximum and Minimum

using System;

namespace ArrayMaxMin
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            int max, min;

            Console.WriteLine("Enter 10 integers:");

            for (int i = 0; i < 10; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            max = numbers[0];
            min = numbers[0];

            for (int i = 1; i < 10; i++)
            {
                if (numbers[i] > max)
                    max = numbers[i];
                if (numbers[i] < min)
                    min = numbers[i];
            }

            Console.WriteLine("Maximum = " + max);
            Console.WriteLine("Minimum = " + min);
        }
    }
}
