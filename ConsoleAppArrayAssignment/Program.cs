using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArrayAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a one-dimensional array of strings
            string[] stringArray = { "Apple", "Banana", "Cherry", "Date", "Elderberry" };

            Console.WriteLine("String Array: Select an index (0 to 4):");
            // Ask user for an index and validate the input
            if (int.TryParse(Console.ReadLine(), out int stringIndex))
            {
                // Check if the index is within bounds
                if (stringIndex >= 0 && stringIndex < stringArray.Length)
                {
                    // Display the string at the selected index
                    Console.WriteLine("You selected: " + stringArray[stringIndex]);
                }
                else
                {
                    // Display an error message if index is out of bounds
                    Console.WriteLine("That index does not exist in the string array.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a numeric index.");
            }

            Console.WriteLine(); // Blank line for spacing

            // Create a one-dimensional array of integers
            int[] intArray = { 10, 20, 30, 40, 50 };

            Console.WriteLine("Integer Array: Select an index (0 to 4):");
            // Ask user for an index and validate the input
            if (int.TryParse(Console.ReadLine(), out int intIndex))
            {
                // Check if the index is within bounds
                if (intIndex >= 0 && intIndex < intArray.Length)
                {
                    // Display the integer at the selected index
                    Console.WriteLine("You selected: " + intArray[intIndex]);
                }
                else
                {
                    // Display an error message if index is out of bounds
                    Console.WriteLine("That index does not exist in the integer array.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a numeric index.");
            }

            Console.WriteLine(); // Blank line for spacing

            // Create a list of strings
            List<string> stringList = new List<string> { "Red", "Green", "Blue", "Yellow", "Purple" };

            Console.WriteLine("String List: Select an index (0 to 4):");
            // Ask user for an index and validate the input
            if (int.TryParse(Console.ReadLine(), out int listIndex))
            {
                // Check if the index is within bounds
                if (listIndex >= 0 && listIndex < stringList.Count)
                {
                    // Display the string at the selected index
                    Console.WriteLine("You selected: " + stringList[listIndex]);
                }
                else
                {
                    // Display an error message if index is out of bounds
                    Console.WriteLine("That index does not exist in the string list.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a numeric index.");
            }

            // Pause the program so the console window stays open
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
    
}
