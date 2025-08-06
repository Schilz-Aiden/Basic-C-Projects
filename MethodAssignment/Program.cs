using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    // This class holds our math method
    class MathHelper
    {
        // This method adds two numbers.
        // The second number is optional. If you don't give it, it will just use 5.
        public int AddNumbers(int firstNum, int secondNum = 5)
        {
            return firstNum + secondNum;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Make an object so we can use the method inside MathHelper
            MathHelper helper = new MathHelper();

            // Ask the user for the first number
            Console.WriteLine("Hey there! ");
            Console.WriteLine("Enter your first number:");
            string firstInput = Console.ReadLine(); // read what they typed
            int number1 = Convert.ToInt32(firstInput); // turn it into an int

            // Ask for the second number (but let them skip it)
            Console.WriteLine("Now enter a second number (or just press ENTER to skip it):");
            string secondInput = Console.ReadLine(); // might be blank

            int result; // this will store the final answer

            // Check if they entered something or skipped it
            if (string.IsNullOrWhiteSpace(secondInput))
            {
                // They skipped it! Just use the first number
                result = helper.AddNumbers(number1);
            }
            else
            {
                // They typed a second number, so convert it too
                int number2 = Convert.ToInt32(secondInput);
                result = helper.AddNumbers(number1, number2);
            }

            // Show the answer
            Console.WriteLine("Your result is: " + result);

            // Keep the window open until they press a key
            Console.WriteLine("\nAll done! Press any key to exit.");
            Console.ReadKey();
        }
    }
}
