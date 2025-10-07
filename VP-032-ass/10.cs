// Program 10: Array - Search Element

using System;

namespace ArraySearchElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            int search, found = 0;

            Console.WriteLine("Enter 10 integers:");

            for (int i = 0; i < 10; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter a number to search: ");
            search = int.Parse(Console.ReadLine());

            for (int i = 0; i < 10; i++)
            {
                if (numbers[i] == search)
                {
                    found = 1;
                    break;
                }
            }

            if (found == 1)
                Console.WriteLine("Number found in the array.");
            else
                Console.WriteLine("Number not found in the array.");
        }
    }
}
