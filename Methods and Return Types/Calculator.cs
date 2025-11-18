using System;

namespace Calculator
{
    public class Calculator
    {
        // Void method to print welcome message
        public void PrintWelcome()
        {
            Console.WriteLine("Welcome to the Calculator");
        }

        // Method to add two numbers
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        // Method to multiply two numbers with optional second parameter
        public int Multiply(int num1, int num2 = 1)
        {
            return num1 * num2;
        }
    }
}
