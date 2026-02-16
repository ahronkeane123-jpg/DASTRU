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
                        try
                        {
                            Hero hero = UserInput.GetHeroDetails();
                            manager.InsertHero(hero);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error adding hero: " + ex.Message);
                        }
                        break;

                    case 2:
                        // Ask for hero ID to remove
                        try
                        {
                            Console.Write("Enter Hero ID to remove: ");
                            int id = int.Parse(Console.ReadLine());
                            manager.RemoveHero(id);
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Invalid input. Please enter a numeric ID.");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error removing hero: " + ex.Message);
                        }
                        break;

                    case 3:
                        // Display all heroes
                        try
                        {
                            manager.DisplayHeroes();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error displaying heroes: " + ex.Message);
                        }
                        break;

                    case 4:
                        // Exit the program
                        try
                        {
                            Console.WriteLine("Program exited.");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Unexpected error: " + ex.Message);
                        }
                        break;


                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }

            } while (choice != 4);
        }
    }
}

            
        
    

