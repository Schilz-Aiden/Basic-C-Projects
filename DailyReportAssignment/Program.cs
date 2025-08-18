using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReportAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //This asks for your name then prints it out
            Console.WriteLine("What is our name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("Your name is: " + yourName);
            Console.ReadLine();

            //This asks for your input on what course you are on then prints it back out.
            Console.WriteLine("What course are you on?");
            string yourCourse = Console.ReadLine();
            Console.WriteLine("The course you are on is: " + yourCourse);
            Console.ReadLine();

            //This asks for your input on what page you are on then prints it back out.
            Console.WriteLine("What page number are you on?");
            string pageNumber = Console.ReadLine();
            Console.WriteLine("The page number is: " + pageNumber);
            Console.ReadLine();

            //This asks if you need any help with your studies then prints your answer back out.
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false.\"");
            string needHelp = Console.ReadLine();
            Console.WriteLine("Do you need help? " + needHelp);
            Console.ReadLine();

            //This asks if you had any positive experiences then prints back what you said.
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string positiveExperiences = Console.ReadLine();
            Console.WriteLine("Your positive experiences: " + positiveExperiences);
            Console.ReadLine();

            //This asks if you had any feedback worth mentioning and prints back what you wrote.
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine("Your feedback was: " + feedback);
            Console.ReadLine();

            //This asks how many hours you studied and then show you what you wrote.
            Console.WriteLine("How many hours did you study today?");
            string hoursStudied = Console.ReadLine();
            Console.WriteLine("You studied: " + hoursStudied + " hours");

            //This writes the completion message letting you know that the program is done.
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
