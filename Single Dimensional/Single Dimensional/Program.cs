using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Dimensional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Constant size of the array
            const int SIZE = 5;
            string[] superheroes = new string[SIZE];

            Console.WriteLine("Enter the names of your favorite Superheroes:\n");

            // Collecting superhero names with input validation
            for (int i = 0; i < superheroes.Length; i++)
            {
                while (true)
                {
                    Console.Write($"Superhero {i + 1}: ");
                    string input = Console.ReadLine();

                    if (!string.IsNullOrWhiteSpace(input))
                    {
                        superheroes[i] = input;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input.Please try again.");
                    }
                }
            }


            Console.WriteLine("\nChoose sorting order:");
            Console.WriteLine("A - Ascending");
            Console.WriteLine("D - Descending");
            Console.Write("Your choice: ");
            string choice = Console.ReadLine().ToUpper();


            Console.Clear();

            // Sorting the array
            Array.Sort(superheroes);

            if (choice == "D")
            {
                Array.Reverse(superheroes);
            }


            Console.WriteLine("\nHere are the Superheroes you like: ");
            foreach (string here in superheroes)
            {
                Console.WriteLine(here);
            }
            Console.ReadKey();

        }
    }
}
