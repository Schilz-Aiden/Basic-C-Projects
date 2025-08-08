using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    abstract class Person
    {
        public string firstName { get; set; } // first name
        public string lastName { get; set; }  // last name

        public abstract void SayName();
    }

    // interface with one method
    interface IQuittable
    {
        void Quit(); // just a method signature
    }

    // Employee inherits Person and implements IQuittable
    class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }

        // method from IQuittable
        public void Quit()
        {
            Console.WriteLine(firstName + " " + lastName + " has quit the job.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // make a new Employee
            Employee emp = new Employee();
            emp.firstName = "Sample";
            emp.lastName = "Student";

            // show name
            emp.SayName();

            // polymorphism example: make an IQuittable variable
            IQuittable quitter = emp; // Employee "is-a" IQuittable so this works

            // call Quit using interface type
            quitter.Quit();

            // keep console open
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
