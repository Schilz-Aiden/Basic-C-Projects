using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    // abstract Person class with first/last name
    abstract class Person
    {
        public string firstName { get; set; } // stores first name
        public string lastName { get; set; }  // stores last name

        // abstract method - must be overridden by subclasses
        public abstract void SayName();
    }

    // Employee inherits from Person
    class Employee : Person
    {
        // overriding the abstract method
        public override void SayName()
        {
            // prints out the full name
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // make new employee object
            Employee emp = new Employee();

            // set first and last name
            emp.firstName = "Sample";
            emp.lastName = "Student";

            // call the SayName method
            emp.SayName();

            // keep console open so we can see output
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
