using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace CallingMethodsAssignment
    {
        // This class holds our math methods
        class MathOperations
        {
            // This method adds 10 to the number and gives it back
            public int AddTen(int number)
            {
                return number + 10;
            }

            // This method multiplies the number by 5 and gives it back
            public int MultiplyByFive(int number)
            {
                return number * 5;
            }

            // This method subtracts 3 from the number and gives it back
            public int SubtractThree(int number)
            {
                return number - 3;
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                // Create an object so we can use the math methods
                MathOperations math = new MathOperations();

                // Ask the user for a number
                Console.WriteLine("Hi there!");
                Console.WriteLine("Enter a number, and I'll do some math with it:");

                // Get the number from the user
                string input = Console.ReadLine(); // read what they typed
                int userNumber = Convert.ToInt32(input); // change it into an int

                // Use AddTen method
                int plusTen = math.AddTen(userNumber);
                Console.WriteLine("Your number plus 10 is: " + plusTen);

                // Use MultiplyByFive method
                int timesFive = math.MultiplyByFive(userNumber);
                Console.WriteLine("Your number times 5 is: " + timesFive);

                // Use SubtractThree method
                int minusThree = math.SubtractThree(userNumber);
                Console.WriteLine("Your number minus 3 is: " + minusThree);

                // Let the user know it's all done
                Console.WriteLine("That's it! Thanks for using my little math app.");
                Console.WriteLine("Press any key to close the window.");
                Console.ReadKey(); // Wait for a key so the window doesn't close right away
            }
        }
    }


