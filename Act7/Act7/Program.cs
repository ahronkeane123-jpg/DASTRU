using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act7
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //Hiligan, Keane Ahron E. | IT402A | ACTIVITY 7: Inserting Nodes with Exception Handling
            LinkedList<string> myFriends = new LinkedList<string>();

        inputValue:


            int numofFriends = 0;
            Console.Clear();


            Console.Write("Give me the number of your favorite friends you have in your whole life (Within 5-10): ");

            try
            {
                numofFriends = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine("Invalid input! Please enter a valid number: " + ex.Message);
                Console.ReadKey();


                goto inputValue;


            }
            Console.WriteLine();

            if (numofFriends < 5 || numofFriends > 10)
            {
                Console.WriteLine("Please enter a number between 5 and 10 ");
                Console.ReadKey();
                goto inputValue;
            }
        }
    }
}
