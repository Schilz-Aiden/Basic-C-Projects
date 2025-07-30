using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Print a welcome message to the user
            Console.WriteLine("Boolean Comparison Using While and Do-While Loops");

            
            // Boolean comparison using a WHILE loop
            
            int number = 0; // Initialize variable

            Console.WriteLine("\nStarting WHILE loop:");
            while (number < 5) // Boolean condition: loop runs while number is less than 5
            {
                Console.WriteLine("Number is: " + number); // Print the current value of number
                number++; // Increment number by 1
            }

            
            // Boolean comparison using a DO-WHILE loop

            int userInput; // Variable to store user input

            Console.WriteLine("\nStarting DO-WHILE loop:");
            do
            {
                Console.Write("Enter a number greater than 10 to exit: ");
                userInput = Convert.ToInt32(Console.ReadLine()); // Read user input and convert to integer
            }
            while (userInput <= 10); // Boolean condition: loop continues while input is less than or equal to 10

            // Let user know the loop ended
            Console.WriteLine("You entered a number greater than 10. Program ended.");
        }
    }
}
