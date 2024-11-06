using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExerciseObjects
{
    public class Shape
    {
        int shapeID;

        public double Circumference()
        {
            return 0.0;
        }
        public double CalculateArea()
        {
            return 0.0;
        }
    }


    public class Triangle : Shape
    {
        private double sideLength;

        public Triangle(double sideLength)
        {
            shapeID = 1;
            this.sideLength = sideLength;
        }

        public double Circumference()
        {
            return 3 * sideLength;
        }

        public double CalculateArea()
        {
            return (Math.Sqrt(3) / 4) * Math.Pow(sideLength, 2);
        }
    }

    public class Square : Shape
    {
        private double sideLength;

        public Square(double sideLength)
        {
            this.sideLength = sideLength;
        }

        public override double Circumference()
        {
            return 4 * sideLength;
        }

        public override double CalculateArea()
        {
            return Math.Pow(sideLength, 2);
        }
    }


    class Program
    {
        static void Main()
        {
            Shape triangle = new Triangle(5);
            Console.WriteLine($"Triangle - Circumference: {triangle.Circumference()}, Area: {triangle.CalculateArea()}");

            Shape square = new Square(4);
            Console.WriteLine($"Square - Circumference: {square.Circumference()}, Area: {square.CalculateArea()}");

            Shape rectangle = new Rectangle(5, 3);
            Console.WriteLine($"Rectangle - Circumference: {rectangle.Circumference()}, Area: {rectangle.CalculateArea()}");

        }
    }
}
