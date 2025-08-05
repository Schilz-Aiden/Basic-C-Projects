using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStringIntegersAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Make a list of numbers
            List<int> myNumbers = new List<int>() { 10, 20, 30, 40, 50 };

            // Ask the user to type a number to divide by
            Console.WriteLine("Hey! Enter a number to divide each number in the list by:");

            try
            {
                // Read what the user types and turn it into an integer
                int userNumber = Convert.ToInt32(Console.ReadLine());

                // Go through each number in the list
                foreach (int number in myNumbers)
                {
                    // Divide the number by what the user entered and show the result
                    int answer = number / userNumber;
                    Console.WriteLine(number + " divided by " + userNumber + " is " + answer);
                }
            }
            catch (FormatException)
            {
                // This runs if the user didn't type a number
                Console.WriteLine("Oops! That wasn't a number. Please try again.");
            }
            catch (DivideByZeroException)
            {
                // This runs if the user typed 0
                Console.WriteLine("Uh oh! You can't divide by zero!");
            }
            catch (Exception e)
            {
                // This catches any other unexpected errors
                Console.WriteLine("Something went wrong: " + e.Message);
            }

            // Let the user know the program kept running even after an error
            Console.WriteLine("The program kept going after the try/catch block. :)");

            // Wait for the user to press a key before closing the window
            Console.WriteLine("Press any key to close the program.");
            Console.ReadKey();
        }
    }
}
