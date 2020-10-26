using System;
using System.Collections.Generic;
using System.Text;

namespace oct23ShapesClassesPracticeCS.Shapes
{
    //https://www.c-sharpcorner.com/article/oops-concepts-and-net-part-2-inheritance-abstraction-and/
    public abstract class Shape
    {
        public abstract double Area { get; }
    
        public abstract double Perimeter { get; }

        //encapsulation
        public string Color { get; set; }
        public Shape()
        {
            Color = "White";
        }
        public Shape( string color)
        {
            Color = color;
        }
        
    }
}
