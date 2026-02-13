using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List_in_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                // Create something to manage all the heroes
                HeroManager manager = new HeroManager();

                // This will store the option the user picks from the menu
                int choice;

                // Keep running the program until the user decides to exit
                do
                {
                    // Display menu and get user choice
                    choice = UserInput.ShowMenu();

                    // Check what the user selected
                    switch (choice)
                    {
                        case 1:
                            // Get hero details and insert hero
                            Hero hero = UserInput.GetHeroDetails();
                            manager.InsertHero(hero);
                            break;

                        case 2:
                            // Ask for hero ID to remove
                            Console.Write("Enter Hero ID to remove: ");
                            int id = int.Parse(Console.ReadLine());
                            manager.RemoveHero(id);
                            break;

                        case 3:
                            // Display all heroes
                            manager.DisplayHeroes();
                            break;

                        case 4:
                            // Exit the program
                            Console.WriteLine("Program exited.");
                            break;

                        default:
                            Console.WriteLine("Invalid choice. Try again.");
                            break;
                    }

                } while (choice != 4);
            }
        }
    }
}
