using System;
using System.Collections.Generic;
using System.Text;

namespace oct23ShapesClassesPracticeCS.Shapes
{
    public class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }
    
        //inheritance
        public Rectangle(string color)
            : base(color)
        {

            //overridden constructor
        }
        //pipeline data to base class
        public Rectangle(double length, double width, string color)
           : base(color)
        {
            Length = length;
            Width = width;
        }
        public Rectangle() : base()
        {
            //default constructor
        }
        public override double Area
        {
            get
            {
                return Length * Width;
            }
        }

        public override double Perimeter
        {
            get
            {
                return 2 * (Length + Width);
            }
        }
    }
    
}
