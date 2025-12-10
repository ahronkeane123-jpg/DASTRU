using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REVIEW_2
{
    internal class Shape
    {
        protected string color;

        public void InputShape()
        {
            Console.Write("Enter Color: ");
            color = Console.ReadLine();
        }

        public virtual double GetArea()
        {
            return 0.0;
        }

        public void DisplayShape()
        {
            Console.WriteLine("Color: " + color);
            Console.WriteLine("Area: " + GetArea());
        }
    }


    class Circle : Shape
    {
        private double radius;

        public void InputCircle()
        {
            Console.Write("Enter Radius: ");
            radius = Convert.ToDouble(Console.ReadLine());
        }

        public override double GetArea()
        {
            return Math.PI * radius * radius;
        }

        public void DisplayCircle()
        {
            Console.WriteLine("\nCircle Information:");
            DisplayShape();
        }
    }

    class Rectangle : Shape
    {
        private double width;
        private double height;

        public void InputRectangle()
        {
            Console.Write("Enter Width: ");
            width = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Height: ");
            height = Convert.ToDouble(Console.ReadLine());
        }

        public override double GetArea()
        {
            return width * height;
        }

        public void DisplayRectangle()
        {
            Console.WriteLine("\nRectangle Information:");
            DisplayShape();
        }
    }
}
