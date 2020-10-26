using System;
using System.Collections.Generic;
using System.Text;

namespace oct23ShapesClassesPracticeCS.Shapes
{
    public class Triangle : Shape
    {
        public double Base { get; set; }
        public double Height { get; set; }
        
        //inheritance implemented here
        public Triangle(string color)
            : base(color)
        {
            //overridden constructor
        }
        //pipeline data to base class
        public Triangle(double abase, double height, string color)
           : base(color)
        {
            Base = abase;
            Height = height;
        }
        public Triangle() : base()
        {
            //default constructor
        }
        public override double Area
        {
            get
            {
                return (Base * Height) / 2;
            }
        }

        public override double Perimeter
        {
            get
            {
                return Base + Math.Sqrt((Base * Base) + 4 * (Height * Height));
            }
        }

     
    }

}
