using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimension
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Superhero Information\n         ");


            // Creating superheroes
            Avengers avenger1 = new Avengers(
                "Captain America",
                "Avengers: Endgame",
                "Super strength and leadership",
                "Team Leader"
            );

            Avengers avenger2 = new Avengers(
                "Black Widow",
                "Avengers",
                "Expert spy and martial artist",
                "Strategist"
            );

            // Displaying details
            avenger1.DisplayInfo();
            avenger2.DisplayInfo();

            Console.WriteLine("Thanks for viewing the superhero information.");
            Console.ReadLine();
        }
    }
}
