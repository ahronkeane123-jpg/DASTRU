using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Heroes[,] heroes = new Heroes[2, 2];

            for (int c = 0; c < 2; c++)
            {
                // Display a header for the Marvel heroes input section
                Console.WriteLine($"========Hero========");
                Console.WriteLine($"Enter details for Marvel heroes \n");
                string name = UserInput.GetString("Name:");
                string power = UserInput.GetString("Power:");
                string realName = UserInput.GetString("Real Name: ");


                heroes[0, c] = new Marvel(name, power, realName);
                Console.WriteLine();

            }
            // Loop for Marvel heroes input (for 2 heroes)
            for (int c = 0; c < 2; c++)
            {
                Console.WriteLine($"========Hero========");
                Console.WriteLine($"Enter details for DC heroes \n");
                string name = UserInput.GetString("Name:");
                string power = UserInput.GetString("Power:");
                int age = UserInput.GetInt("Age: ");

                // Store the new DC hero in the heroes array at [1, c] position
                heroes[1, c] = new DC(name, power, age);
                Console.WriteLine();

            }
            // Display information for all the heroes stored in the heroes array

            for (int r = 0; r < heroes.GetLength(0); r++)
            {
                for(int c = 0; c <  heroes.GetLength(1); c++)
                {
                    // Call DisplayInfo method to print hero details
                    heroes[r, c].DisplayInfo();
                }
            }
            Console.ReadKey();
        }
    }
}
