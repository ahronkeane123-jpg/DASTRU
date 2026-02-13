using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List_in_OOP
{
    internal class HeroManager
    {
        private List<Hero> heroes = new List<Hero>();

        public void InsertHero(Hero hero)
        {
            heroes.Add(hero);
            Console.WriteLine("Hero added successfully!");
        }

        public void RemoveHero(int id)
        {
            Hero hero = heroes.Find(h => h.Id == id);

            if (hero != null)
            {
                heroes.Remove(hero);
                Console.WriteLine("Hero removed successfully!");
            }
            else
            {
                Console.WriteLine("Hero not found.");
            }
        }

        public void DisplayHeroes()
        {
            if (heroes.Count == 0)
            {
                Console.WriteLine("No heroes available.");
                return;
            }

            foreach (Hero hero in heroes)
            {
                Console.WriteLine($"ID: {hero.Id}, Name: {hero.Name}, Power: {hero.Power}");
            }
        }
    }
}
