using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Enter the first number or type 'exit' to quit: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
                break;

            if (!double.TryParse(input, out double num1))
            {
                Console.WriteLine("Invalid input.");
                continue;
            }

            Console.WriteLine("Enter second number: ");
            
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter operation (+, -, *, /): ");

            string operation = Console.ReadLine();

            double result = 0;

            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    Console.WriteLine("Result: " + result);
                    break;

                case "-":
                    result = num1 - num2;
                    Console.WriteLine("Result: " + result);
                    break;

                case "*":
                    result = num1 * num2;
                    Console.WriteLine("Result: " + result);
                    break;

                case "/":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine("Result: " + result);
                    }

                    else
                    {
                        Console.WriteLine("Error: You Cannot divide by zero.");
                    }

                    break;

                default:
                    Console.WriteLine("Invalid operation.");
                    break;

            }

            
         
            Console.WriteLine();


        }

        Console.WriteLine("Calculator Closed.");
    }
}