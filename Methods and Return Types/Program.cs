using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a Calculator object
            Calculator calc = new Calculator();

            // Call PrintWelcome()
            calc.PrintWelcome();

            // Call Add() and display result
            int sum = calc.Add(10, 20);
            Console.WriteLine($"Addition: {sum}");

            // Call Multiply() with both parameters
            int product1 = calc.Multiply(5, 4);
            Console.WriteLine($"Multiplication (5 * 4): {product1}");

            // Call Multiply() with only one parameter (optional second parameter)
            int product2 = calc.Multiply(7);
            Console.WriteLine($"Multiplication (7 * default 1): {product2}");
        }
    }
}
