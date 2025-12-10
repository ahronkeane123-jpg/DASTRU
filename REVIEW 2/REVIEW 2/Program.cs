using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REVIEW_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Shape Geometry area calculator:");
            Console.WriteLine("1. Circle");
            Console.WriteLine("2. Rectangle");
            Console.Write("Select shape (1 or 2): ");
            int choice = Convert.ToInt32(Console.ReadLine());


            if (choice == 1)
            {
                Circle circle = new Circle();
                circle.InputShape();
                circle.InputCircle();

                Console.WriteLine("\n            'OUTPUT'              ");
                circle.DisplayCircle();
            }
            else if (choice == 2)
            {
                Rectangle rectangle = new Rectangle();
                rectangle.InputShape();
                rectangle.InputRectangle();

                Console.WriteLine("\n            'OUTPUT'              ");
                rectangle.DisplayRectangle();
            }
            else
            {
                Console.WriteLine("Invalid choice.");
                Console.ReadKey();
            }
        }
    }
}
