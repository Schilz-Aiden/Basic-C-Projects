using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperatorAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Print the title of the program
            Console.WriteLine("Anonymous Income Comparison Program");

            // --- Person 1 input section ---
            Console.WriteLine("Person 1");

            // Prompt for hourly rate and parse to decimal
            Console.Write("Hourly Rate: ");
            decimal hourlyRate1 = Convert.ToDecimal(Console.ReadLine());

            // Prompt for hours worked per week and parse to decimal
            Console.Write("Hours worked per week: ");
            decimal hoursPerWeek1 = Convert.ToDecimal(Console.ReadLine());

            // --- Person 2 input section ---
            Console.WriteLine("Person 2");

            // Prompt for hourly rate and parse to decimal
            Console.Write("Hourly Rate: ");
            decimal hourlyRate2 = Convert.ToDecimal(Console.ReadLine());

            // Prompt for hours worked per week and parse to decimal
            Console.Write("Hours worked per week: ");
            decimal hoursPerWeek2 = Convert.ToDecimal(Console.ReadLine());

            // --- Salary Calculations ---
            // Calculate annual salary = hourly rate * hours/week * 52
            decimal annualSalary1 = hourlyRate1 * hoursPerWeek1 * 52;
            decimal annualSalary2 = hourlyRate2 * hoursPerWeek2 * 52;

            // --- Output Results ---
            // Display Person 1's annual salary
            Console.WriteLine("Annual salary of Person 1:");
            Console.WriteLine(annualSalary1);

            // Display Person 2's annual salary
            Console.WriteLine("Annual salary of Person 2:");
            Console.WriteLine(annualSalary2);

            // Compare salaries and display result
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(annualSalary1 > annualSalary2);

            // Optional: Keep console open until user presses a key
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
