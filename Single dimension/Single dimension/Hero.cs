using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_dimension
{
    class SuperHero
    {
        public string Name { get; set; }
        public string Movie { get; set; }
        public string Power { get; set; }


        public SuperHero(string name, string movie, string power)
        {
            Name = name;
            Movie = movie;
            Power = power;

        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name of the super heroes: {Name}");
            Console.WriteLine($"Title of the movie: {Movie}");
            Console.WriteLine($"The Ability: {Power}");
            Console.WriteLine();
        }
     
    }
    class Avengers : SuperHero
    {
        public string Role { get; set; }

        public Avengers(string name, string movie, string power, string role) :base(name, movie, power)
        {
            Role = role;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine("              Details of Superheroes          ");
            Console.WriteLine($"The role of superheroes: {Role}");
            base.DisplayInfo();
        }
    }
    
}
