using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inserting_Nodes_to_the_Linked_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a LinkedList to store friends' names
            LinkedList<string> myfriend = new LinkedList<string>();

        // Label used for re-entering input if validation fails
        InputValue:
            Console.Clear();

            // Ask the user for the number of favorite friends
            Console.Write("Please enter the number of your favorite friends in your whole life: ");
            int numOfFriends = int.Parse(Console.ReadLine());

            // Validate that the number is between 5 and 10
            if (numOfFriends < 5 || numOfFriends > 10)
            {
                Console.WriteLine("Please enter a number between 5 and 10.");
                goto InputValue;// Go back and ask again
            }
            Console.WriteLine("===Type the names of your favorite friends from your life===");
            // Loop to collect each friend's name
            for (int i = 0; i < numOfFriends; ++i)
            {
                Console.Write("Favourite friends #{0}:", i + 1);
                string friendName = Console.ReadLine();
                // Add the name to the linked list
                myfriend.AddLast(friendName);
            }
            // Sort the friends alphabetically and store them in a new list

            var sortedFriends = myfriend.OrderBy(name => name).ToList();
            Console.Clear();
            Console.WriteLine("\n Here are your favorite friends from your life.");
            // Traverse and print each friend in the linked list
            foreach (string friend in myfriend)
            {
                Console.Write(friend + "+-->");

            }
            Console.ReadKey();
        }
    }
}
