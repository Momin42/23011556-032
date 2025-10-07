// Calculator

using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, result;
            char operation;

            Console.Write("Enter first number: ");
            num1 = double.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter operation (+, -, *, /): ");
            operation = char.Parse(Console.ReadLine());

            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    Console.WriteLine("Result = " + result);
                    break;

                case '-':
                    result = num1 - num2;
                    Console.WriteLine("Result = " + result);
                    break;

                case '*':
                    result = num1 * num2;
                    Console.WriteLine("Result = " + result);
                    break;

                case '/':
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine("Result = " + result);
                    }
                    else
                    {
                        Console.WriteLine("Division by zero is not allowed.");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid operation.");
                    break;
            }
        }
    }
}

