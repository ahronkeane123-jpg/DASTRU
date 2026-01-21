using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Input_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("You will enter detailes of your favorite hero");

            Heroes[,] heroes = new Heroes[2, 2];
            for (int r = 0; r < heroes.GetLength(0); r++)
            {
                for (int j = 0; j < heroes.GetLength(1); j++)
                {

                    Console.WriteLine($"======Hero  {r * 2 + j + 1}======");


                    Console.WriteLine($"Enter details for Hero at position:");
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Power: ");
                    string power = Console.ReadLine();
                    Console.Write("Universe: ");
                    string universe = Console.ReadLine();
                    Console.Write("Alignment: ");
                    string alignment = Console.ReadLine();
                    Console.Write("Team: ");
                    string team = Console.ReadLine();
                    heroes[r, j] = new Heroes(name, power, universe, alignment, team);

                    Console.WriteLine(" Hero saved \n");
                }
            }
            Console.Clear();
            Console.WriteLine("You have entered the following heroes:");
            Console.WriteLine("====================================\n");

            for (int  r = 0; r < heroes.GetLength(0); r++)
            {
                for (int j = 0; j < heroes.GetLength(1); j++)
                {
                    Heroes hero = heroes[r, j];
                    Console.WriteLine($"Hero {r * 2 + j + 1}:");
                    Console.WriteLine($"Name: {hero.Name}");
                    Console.WriteLine($"Power: {hero.Power}");
                    Console.WriteLine($"Universe: {hero.Universe}");
                    Console.WriteLine($"Alignment: {hero.Alignment}");
                    Console.WriteLine($"Team: {hero.Team}");
                    Console.WriteLine("------------------------------------\n");
                }
            }
            {
            }
            Console.ReadKey();
           
        }
    }
}

