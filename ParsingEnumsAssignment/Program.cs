using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnumsAssignment
{
    // enum for days of the week
    enum DaysOfWeek
    {
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }

    class Program
    {
        static void Main(string[] args)
        {
            // ask user for the current day
            Console.Write("Enter the current day of the week: ");
            string userInput = Console.ReadLine(); // read what they typed

            try
            {
                // try to convert the string to the enum type
                DaysOfWeek currentDay = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), userInput, true);

                // show the day back to them
                Console.WriteLine("You picked: " + currentDay);
            }
            catch
            {
                // if parsing failed, tell them they typed it wrong
                Console.WriteLine("Please enter an actual day of the week.");
            }

            // keep console open
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
