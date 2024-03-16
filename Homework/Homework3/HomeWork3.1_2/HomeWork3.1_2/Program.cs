using System;
using System.Collections.Generic;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Available operations:");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Modulo");
                Console.WriteLine("0. Exit");

                Console.Write("Enter operation number: ");
                string operation = Console.ReadLine().Trim();

                if (operation == "0")
                    break;

                if (calculator.Operations.ContainsKey(operation))
                {
                    Console.Write("Enter first operand: ");
                    double operand1;
                    while (!double.TryParse(Console.ReadLine(), out operand1))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                        Console.Write("Enter first operand: ");
                    }

                    Console.Write("Enter second operand: ");
                    double operand2;
                    while (!double.TryParse(Console.ReadLine(), out operand2))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                        Console.Write("Enter second operand: ");
                    }

                    double result = calculator.Operations[operation](operand1, operand2);
                    Console.WriteLine($"Result: {result}");
                }
                else
                {
                    Console.WriteLine("Invalid operation number.");
                }

                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey(); 
            }
        }
    }

    public class Calculator
    {
        public Dictionary<string, Func<double, double, double>> Operations { get; private set; }

        public Calculator()
        {
            Operations = new Dictionary<string, Func<double, double, double>>
            {
                {"1", (a, b) => a + b}, 
                {"2", (a, b) => a - b}, 
                {"3", (a, b) => a * b},
                {"4", (a, b) => b != 0 ? a / b : throw new DivideByZeroException("Cannot divide by zero.")}, 
                {"5", (a, b) => b != 0 ? a % b : throw new DivideByZeroException("Cannot divide by zero.")}, 
            };
        }
    }
}
