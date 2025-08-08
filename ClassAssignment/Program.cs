using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    // Static class for math stuff
    static class MathStuff
    {
        // This method takes a number, divides it by 2, and prints it
        public static void DivideByTwo(int num)
        {
            int result = num / 2; // cut it in half
            Console.WriteLine("Half of " + num + " is " + result);
        }

        // This one uses out parameters to give back sum and product
        public static void DoMath(int a, int b, out int sum, out int product)
        {
            sum = a + b; // adding
            product = a * b; // multiplying
        }

        // Overload example with ints
        public static double Divide(int top, int bottom)
        {
            return (double)top / bottom; // cast so we don't lose decimals
        }

        // Overload example with doubles
        public static double Divide(double top, double bottom)
        {
            return top / bottom;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // ask user for a number
            Console.Write("Enter a whole number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            // call the method that divides by two
            MathStuff.DivideByTwo(num);

            // now doing sum and product with out params
            Console.WriteLine("\nLet's try sum and product.");
            Console.Write("Enter first number: ");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int second = Convert.ToInt32(Console.ReadLine());

            MathStuff.DoMath(first, second, out int sum, out int product);

            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Product: " + product);

            // show method overloading
            Console.WriteLine("\nMethod overloading examples:");
            Console.WriteLine("Divide ints 7 / 3 = " + MathStuff.Divide(7, 3));
            Console.WriteLine("Divide doubles 7.5 / 3.2 = " + MathStuff.Divide(7.5, 3.2));

            // pause so program doesn't close right away
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
