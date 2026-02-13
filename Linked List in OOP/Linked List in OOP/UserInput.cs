using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List_in_OOP
{
    internal class UserInput
    {
        public static int ShowMenu()
        {
            Console.WriteLine("\n--- Hero Management System ---");
            Console.WriteLine("1. Add Hero");
            Console.WriteLine("2. Remove Hero");
            Console.WriteLine("3. Display Heroes");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            return int.Parse(Console.ReadLine());
        }

        public static Hero GetHeroDetails()
        {
            Console.Write("Enter Hero ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter Hero Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Hero Power: ");
            string power = Console.ReadLine();

            return new Hero(id, name, power);
        }
    }
}
