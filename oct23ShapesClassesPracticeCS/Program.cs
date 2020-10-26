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


            Drawing myDrawing2 = new Drawing();
            myDrawing2.Draw(new Rectangle(10, 20, "red"));

            Console.WriteLine($"Total Area covered by drawing {myDrawing2.SpaceCovered}, Total perimeter covered by drawing {myDrawing2.LinesDrawn} ");

            Console.WriteLine(myDrawing2.ToString());

            myDrawing2.Draw(new Rectangle(20,30, "yellow"));

            Console.WriteLine($"Total Area covered by drawing {myDrawing2.SpaceCovered}, Total perimeter covered by drawing {myDrawing2.LinesDrawn} ");

            Console.WriteLine(myDrawing2.ToString());

            Drawing myDrawing3 = new Drawing();
            myDrawing3.Draw(new Triangle(10, 30, "blue"));

            Console.WriteLine($"Total Area covered by drawing {myDrawing3.SpaceCovered}, Total perimeter covered by drawing {myDrawing3.LinesDrawn} ");

            Console.WriteLine(myDrawing3.ToString());

            myDrawing3.Draw(new Triangle(20, 40, "black"));

            Console.WriteLine($"Total Area covered by drawing {myDrawing3.SpaceCovered}, Total perimeter covered by drawing {myDrawing3.LinesDrawn} ");

            Console.WriteLine(myDrawing3.ToString());

            Console.ReadLine();

      
        }
    }
}
