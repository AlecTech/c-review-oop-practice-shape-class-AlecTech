using System;
using System.Collections.Generic;
using System.Text;

namespace oct23ShapesClassesPracticeCS.Shapes
{
    public class Triangle : Shape
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public Triangle(float area, float perimeter, string color)
       : base(area, perimeter, color)
        {

            Color = color;
        }
        public override void CalculateArea()
        {
            Area = (Base * Height)/2;
        }
        public override void CalculatePerimeter()
        {
            Perimeter = Base+Math.Sqrt((Base*Base) + 4*(Height*Height));
        }
    }
}
