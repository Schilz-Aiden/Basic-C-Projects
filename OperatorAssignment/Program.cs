using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorAssignment
{
    class Employee
    {
        public int Id { get; set; } // employee id
        public string FirstName { get; set; } // first name
        public string LastName { get; set; } // last name

        // overload == operator to check if Id is the same
        public static bool operator ==(Employee e1, Employee e2)
        {
            // check if both are null
            if (ReferenceEquals(e1, null) && ReferenceEquals(e2, null))
                return true;

            // check if one is null
            if (ReferenceEquals(e1, null) || ReferenceEquals(e2, null))
                return false;

            return e1.Id == e2.Id; // compare ids
        }

        // overload != operator 
        public static bool operator !=(Employee e1, Employee e2)
        {
            return !(e1 == e2); // just reverse of ==
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // make first employee
            Employee emp1 = new Employee();
            emp1.Id = 1;
            emp1.FirstName = "John";
            emp1.LastName = "Doe";

            // make second employee
            Employee emp2 = new Employee();
            emp2.Id = 1; // same id as emp1
            emp2.FirstName = "Jane";
            emp2.LastName = "Smith";

            // check if they are equal using overloaded operator
            Console.WriteLine("Are they equal? " + (emp1 == emp2));

            // check if they are not equal
            Console.WriteLine("Are they not equal? " + (emp1 != emp2));

            // paus so we can see results
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
