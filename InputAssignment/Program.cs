using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InputAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user to enter a number
            Console.Write("Please enter a number: ");

            // Read the user's input from the console and store it as a string
            string userInput = Console.ReadLine();

            // Specify the path for the text file where the number will be stored
            // Here, the file will be created in the same folder as the program
            string filePath = "number_log.txt";

            // Write the user's number into the file
            // Using 'WriteAllText' will overwrite the file if it already exists
            File.WriteAllText(filePath, userInput);

            // Read the contents of the file back into a string
            string fileContents = File.ReadAllText(filePath);

            // Display the file contents back to the user
            Console.WriteLine("\nThe contents of the text file are:");
            Console.WriteLine(fileContents);

            // Prevent the console window from closing immediately
            // This lets the user see the output before pressing a key to exit
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
