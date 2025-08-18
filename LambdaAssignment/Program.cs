using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssignment
{
    // This is the Employee class, it has 3 properties: Id, FirstName, LastName
    class Employee
    {
        public int Id { get; set; } // Id for the employee
        public string FirstName { get; set; } // first name
        public string LastName { get; set; } // last name
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Make a list of employees and add 10 people to it
            List<Employee> employees = new List<Employee>()
            {
                new Employee(){ Id = 1, FirstName = "Joe", LastName = "Smith"},
                new Employee(){ Id = 2, FirstName = "Anna", LastName = "Johnson"},
                new Employee(){ Id = 3, FirstName = "Bob", LastName = "Brown"},
                new Employee(){ Id = 4, FirstName = "Joe", LastName = "Davis"},
                new Employee(){ Id = 5, FirstName = "Emily", LastName = "Taylor"},
                new Employee(){ Id = 6, FirstName = "Chris", LastName = "Wilson"},
                new Employee(){ Id = 7, FirstName = "Megan", LastName = "Thomas"},
                new Employee(){ Id = 8, FirstName = "David", LastName = "Anderson"},
                new Employee(){ Id = 9, FirstName = "Sarah", LastName = "Martin"},
                new Employee(){ Id = 10, FirstName = "Paul", LastName = "Harris"}
            };

            // Here we will find all the people named "Joe" using a foreach loop
            List<Employee> joesListForeach = new List<Employee>(); // new empty list

            foreach (Employee emp in employees) // loop through all employees
            {
                if (emp.FirstName == "Joe") // check if their first name is "Joe"
                {
                    joesListForeach.Add(emp); // add them to the joe list
                }
            }

            // print the joes found with foreach
            Console.WriteLine("Joes found with foreach:");
            foreach (Employee joe in joesListForeach)
            {
                Console.WriteLine(joe.FirstName + " " + joe.LastName);
            }

            Console.WriteLine(); // blank line

            // This time we use .Where() with a lambda to do the same thing
            List<Employee> joesListLambda = employees.Where(x => x.FirstName == "Joe").ToList();

            Console.WriteLine("Joes found with lambda:");
            foreach (Employee joe in joesListLambda)
            {
                Console.WriteLine(joe.FirstName + " " + joe.LastName);
            }

            Console.WriteLine(); // blank line

            // Find all employees with an Id greater than 5
            List<Employee> idGreaterThanFive = employees.Where(x => x.Id > 5).ToList();

            Console.WriteLine("Employees with Id > 5:");
            foreach (Employee emp in idGreaterThanFive)
            {
                Console.WriteLine("Id: " + emp.Id + " Name: " + emp.FirstName + " " + emp.LastName);
            }

            Console.ReadLine(); // pause so console stays open
        }
    }
}
