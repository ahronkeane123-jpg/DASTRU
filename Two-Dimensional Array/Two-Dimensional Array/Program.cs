using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two_Dimensional_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[3, 3]

            {
            {1, 2,  3 }, //First row of array
            {4, 5,  6 },//Second row of array
            {7, 8,  9 }//Third row of arrray
            };

            //Print the headers for table 
            Console.WriteLine("____________________");
            Console.WriteLine("   Col1  Col2  Col3"); //print the Colum number
            Console.WriteLine("____________________");//print the liner separator

            // Loop through rows of the array
            for (int i = 0; i < array.GetLength(0); i++)
            {

                Console.Write($"Row" + i + "|"); //header for the current row 

                for (int j = 0; j < array.GetLength(1); j++) // loop through  each Colum of the current row
                {
                    // Print each element with fixed spacing
                    Console.Write(array[i, j] + "    "); // Add for alignment 

                }
                // Move to the next line after each row
                Console.WriteLine();
            }
            Console.ReadKey();
       
        }
    }
}
