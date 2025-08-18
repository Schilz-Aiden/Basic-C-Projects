using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{
    // This class has a method that does math with two integers
    class MathAction
    {
        // This is a void method (it doesn't return anything)
        // It takes two integers: one to do math on, one to just display
        public void DoSomething(int firstNumber, int secondNumber)
        {
            // Do a simple math operation on the first number (like double it)
            int result = firstNumber * 2;

            // Show the result of the math (optional, but helpful!)
            Console.WriteLine("First number multiplied by 2 is: " + result);

            // Show the second number directly
            Console.WriteLine("Second number (just showing it): " + secondNumber);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Make an object so we can use the method
            MathAction action = new MathAction();

            // Call the method by passing two numbers directly (positional arguments)
            action.DoSomething(5, 10);  // firstNumber = 5, secondNumber = 10

            Console.WriteLine(); // Add space between calls

            // Call the method again, this time using named arguments
            action.DoSomething(firstNumber: 8, secondNumber: 3);

            // Wait for a key press before closing the window
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
