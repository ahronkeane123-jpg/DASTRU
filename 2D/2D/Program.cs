using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Two-dimensional array of Heroes objects with 2 rows and 2 columns
            Heroes[,] heroes = new Heroes[2, 2]
            {
    {
        new Heroes("Iron Man", "Genius-level intellect", "Marvel", "Hero", "Avengers"),
        new Heroes("Batman", "Peak human abilities", "DC", "Hero", "Justice League")
    },
    {
        new Heroes("Thor", "God of Thunder", "Marvel", "Hero", "Avengers"),
        new Heroes("Wonder Woman", "Super strength", "DC", "Hero", "Justice League")
    }
            };

            // Loop structure to access the 2D array
            for (int r = 0; r < heroes.GetLength(0); r++)
            {
                for (int col = 0; col < heroes.GetLength(1); col++)
                {
                    // Get the current Heroes object from the array
                    Heroes h = heroes[r, col];

                    // Display hero details in the console
                    Console.WriteLine("Hero Details:");
                    Console.WriteLine("Name      - " + h.Name);
                    Console.WriteLine("Power     - " + h.Power);
                    Console.WriteLine("Universe  - " + h.Universe);
                    Console.WriteLine("Alignment - " + h.Alignment);
                    Console.WriteLine("Team      - " + h.Team);
                    Console.WriteLine();
                }
            }
        }
    }
}
