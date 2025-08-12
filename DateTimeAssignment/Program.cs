using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Step 1: Show the current date and time
            Console.WriteLine("Right now it is: " + DateTime.Now);

            // Step 2: Ask the user for a number of hours to add
            Console.Write("Enter how many hours you want to add: ");

            // Read the user's input (as text) and save it
            string input = Console.ReadLine();

            // Convert the text to an integer so we can do math with it
            int hoursToAdd = int.Parse(input);

            // Step 3: Add the given hours to the current time
            DateTime futureTime = DateTime.Now.AddHours(hoursToAdd);

            // Step 4: Show the future time to the user
            Console.WriteLine("In " + hoursToAdd + " hours, it will be: " + futureTime);

            Console.WriteLine("\nPress any key to close...");
            Console.ReadKey();
        }
    }
}
