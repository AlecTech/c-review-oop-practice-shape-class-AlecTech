using System;
using System.Collections.Generic;
using System.Text;

namespace oct23ShapesClassesPracticeCS.Shapes
{
    public class Circle : Shape
    {
        const double pi = 3.14;
        public double Radius { get; set; }
        public double Diameter
        {
            get
            {
                return Radius * 2;
            }
        }
        public Circle(string color)
            : base(color)
        {

            //overridden constructor
        }
        //pipeline data to base class
        public Circle(double radius, string color)
           : base(color)
        {
            Radius = radius;
        }
        public Circle() : base()
        {
            //default constructor
        }
        public override double Area 
            {
                get
                {
                    return pi*Radius* Radius;
                }
           

            }

        //public override void CalculateArea()
       // {
        //    Area = 3.14 * (Radius * Radius);
            
       // }
       // public override void CalculatePerimeter()
       // {
        //    Perimeter = 2 * 3.14 * Radius;
       // }
    }
}
