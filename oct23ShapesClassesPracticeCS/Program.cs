using System;
using System.Collections.Generic;
using oct23ShapesClassesPracticeCS.Shapes;

namespace oct23ShapesClassesPracticeCS
{
    class Program
    {
        static void Main(string[] args)
        {

            Drawing myDrawing = new Drawing();
            myDrawing.Draw(new Circle(10, "white"));

            Console.WriteLine($"Total Area covered by drawing {myDrawing.SpaceCovered}, Total perimeter covered by drawing {myDrawing.LinesDrawn} ");

            Console.WriteLine(myDrawing.ToString());

            myDrawing.Draw(new Circle(20, "green"));

            Console.WriteLine($"Total Area covered by drawing {myDrawing.SpaceCovered}, Total perimeter covered by drawing {myDrawing.LinesDrawn} ");

            Console.WriteLine(myDrawing.ToString());

            Console.ReadLine();

            /*
            Console.WriteLine("Hello World!");

            List<Shape> circles = new List<Shape>();
            circles.Add(new Circle(circles.Area, circles.Perimeter, Shape.Color()));

            List<Shape> rectangles = new List<Shape>();
            circles.Add(new Rectangle(rectangles.Area, rectangles.Perimeter, Shape.Color()));

            List<Shape> triangles = new List<Shape>();
            circles.Add(new Triangle(triangles.Area, triangles.Perimeter, Shape.Color()));

            Shape aShape = new Circle(10, 23, "black");
            aShape = circles[0];
        */
        }
    }
}
