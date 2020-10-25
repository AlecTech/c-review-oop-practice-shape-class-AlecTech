using System;
using System.Collections.Generic;
using System.Text;

namespace oct23ShapesClassesPracticeCS.Shapes
{
    public class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(float area, float perimeter, string color)
       : base(area, perimeter, color)
        {

            Color = color;
        }

        public override void CalculateArea()
        {
            Area = Length * Width;
        }
        public override void CalculatePerimeter()
        {
            Perimeter = 2*(Length + Width);
        }
    }
}
