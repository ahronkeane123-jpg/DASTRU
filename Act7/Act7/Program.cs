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
             Console.WriteLine("---Enter the name of the favourite friends you have in your entire life---");
             // Loop to get each friend's name
            for (int i = 0; i < numofFriends; i++)
            {
            Console.Write("Favourite friends #{0}: ", i + 1);
        string friendName = Console.ReadLine();
        // Add this friend's name to the LinkedList
        myFriends.AddLast(friendName);
    }
    // Convert the LinkedList to an array so we can sort it alphabetically
    string[] friendArray = myFriends.ToArray();
    Array.Sort(friendArray);
    myFriends = new LinkedList<string>(friendArray);

    Console.Clear();
    Console.WriteLine("\n----This is your favourite friends in your life---- ");
    foreach(string friend in myFriends)
    {
        Console.WriteLine(friend);
    }
    Console.ReadKey();

        }
    }
}
