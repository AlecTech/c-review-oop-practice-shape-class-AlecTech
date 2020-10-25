using System;
using System.Collections.Generic;
using oct23ShapesClassesPracticeCS.Shapes;

namespace oct23ShapesClassesPracticeCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<Shape> circles = new List<Shape>();
            circles.Add(new Circle(circles.Area, circles.Perimeter, Shape.Color()));

            List<Shape> rectangles = new List<Shape>();
            circles.Add(new Rectangle(rectangles.Area, rectangles.Perimeter, Shape.Color()));

            List<Shape> triangles = new List<Shape>();
            circles.Add(new Circle(triangles.Area, triangles.Perimeter, Shape.Color()));
        }
    }
}
