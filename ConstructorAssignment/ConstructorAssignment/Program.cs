using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Make a constant variable (this value never changes)
            const double Pi = 3.14159;

            var message = "Hello, world!";

            // Print both variables to the console
            Console.WriteLine("Pi = " + Pi);
            Console.WriteLine(message);

            // Create a new student object using the single-parameter constructor
            Student s = new Student("Alex");

            // Create another student using the two-parameter constructor
            Student s2 = new Student("Jim", 20);
        }
    }

    class Student
    {
        public string Name;
        public int Age;

        // First constructor: takes only a name
        public Student(string name)
        {
            Name = name;
            Age = 0; // default age
            Console.WriteLine("Student created: " + Name + ", Age: " + Age);
        }

        // Second constructor: takes a name AND an age
        public Student(string name, int age) : this(name)
        {
            Age = age; // now we set the actual age
            Console.WriteLine("Student updated: " + Name + ", Age: " + Age);
        }
    }
}
