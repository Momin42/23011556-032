// Program 9: Array - Count Even and Odd Numbers

using System;

namespace ArrayEvenOddCount
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            int evenCount = 0, oddCount = 0;

            Console.WriteLine("Enter 10 integers:");

            for (int i = 0; i < 10; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 10; i++)
            {
                if (numbers[i] % 2 == 0)
                    evenCount++;
                else
                    oddCount++;
            }

            Console.WriteLine("Even numbers: " + evenCount);
            Console.WriteLine("Odd numbers: " + oddCount);
        }
    }
}
