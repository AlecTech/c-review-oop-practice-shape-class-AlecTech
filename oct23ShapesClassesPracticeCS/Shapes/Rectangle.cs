using System;
using System.Collections.Generic;
using System.Text;

namespace oct23ShapesClassesPracticeCS.Shapes
{
    class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }

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
