using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsAssignment
{
    internal class Person
    {
        public string FirstName { get; set; } // person's first name
        public string LastName { get; set; } // person's last name

        // method to say the name
        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }

    // Employee inherits from Person
    class Employee : Person
    {
        public int Id { get; set; } // employee id number
    }

    class Program
    {
        static void Main(string[] args)
        {
            // make a new employee and set their name + id
            Employee emp = new Employee();
            emp.FirstName = "Sample"; // setting first name
            emp.LastName = "Student"; // setting last name
            emp.Id = 1; // setting id

            // call SayName method from Person class
            emp.SayName();

            // stop console from closing right away
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
