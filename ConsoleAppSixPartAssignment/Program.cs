using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSixPartAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initialize an array of phrases
            string[] phrases = { "Hello", "Welcome", "Goodbye", "See you", "Thank you" };

            // List of words that are all unique
            List<string> uniqueWords = new List<string> { "apple", "banana", "cherry", "date", "fig" };

            // List that intentionally contains duplicate values
            List<string> duplicatedWords = new List<string> { "grape", "melon", "grape", "kiwi", "melon" };

            // Separate list to test duplicate detection
            List<string> itemsToCheck = new List<string> { "A", "B", "C", "D", "C" };

            // We'll use this HashSet to keep track of values we've already seen
            HashSet<string> seen = new HashSet<string>();

            Console.WriteLine("Checking for duplicates in the list:");

            // Loop through each item and print whether it's unique or a duplicate
            foreach (string item in itemsToCheck)
            {
                if (seen.Contains(item))
                {
                    Console.WriteLine($"{item} - this item is a duplicate");
                }
                else
                {
                    Console.WriteLine($"{item} - this item is unique");
                    seen.Add(item); // Remember that we've seen this item now
                }
            }

            // Main loop for user interaction
            while (true)
            {
                // Ask the user to enter some text to append to all phrases
                Console.WriteLine("\nEnter text to append to each phrase (or type 'exit' to quit):");
                string input = Console.ReadLine();

                // If user types "exit", break out of the loop and end the program
                if (input.ToLower() == "exit")
                {
                    Console.WriteLine("Exiting the program...");
                    break;
                }

                // Loop through the array and append the input text to each phrase
                for (int i = 0; i < phrases.Length; i++)
                {
                    phrases[i] += " " + input;
                }

                // Display the updated phrases using a <= comparison
                Console.WriteLine("\nUpdated phrases:");
                for (int i = 0; i <= phrases.Length - 1; i++)
                {
                    Console.WriteLine(phrases[i]);
                }

                // Ask the user to search for a word in the unique list
                Console.WriteLine("\nSearch for a word in the unique word list:");
                string uniqueSearch = Console.ReadLine();

                bool uniqueFound = false;

                // Loop through the unique list and look for the user's input
                for (int i = 0; i < uniqueWords.Count; i++)
                {
                    if (uniqueWords[i].Equals(uniqueSearch, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine($"Found in unique list at index {i}: {uniqueWords[i]}");
                        uniqueFound = true;
                        break; // Stop searching once we've found a match
                    }
                }

                // If not found, let the user know
                if (!uniqueFound)
                {
                    Console.WriteLine("Your input is not on the unique list.");
                }

                // Ask the user to search the duplicated list
                Console.WriteLine("\nSearch for a word in the duplicated word list:");
                string dupSearch = Console.ReadLine();

                bool dupFound = false;

                // Loop through the duplicated list and print all matching indices
                for (int i = 0; i < duplicatedWords.Count; i++)
                {
                    if (duplicatedWords[i].Equals(dupSearch, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine($"Found in duplicated list at index {i}: {duplicatedWords[i]}");
                        dupFound = true;
                        // No break here — we want to find every match
                    }
                }

                // If the input wasn't found in the list, display a message
                if (!dupFound)
                {
                    Console.WriteLine("Your input is not on the duplicated list.");
                }
            }

            // Pause the program so the user can see the final output
            Console.WriteLine("\nPress any key to close the program...");
            Console.ReadKey();

        }
    }
}
