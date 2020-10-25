using System;
using System.Collections.Generic;
using System.Text;

namespace oct23ShapesClassesPracticeCS.Shapes
{
   public class Circle : Shape
    {
        public float Radius { get; set; }
        public double Diameter
        {
            get
            {
                return Radius * 2;
            }
        }

        public Circle (float area, float perimeter, string color)
            : base (area, perimeter, color)
        {

            Color = color;
        }

        public override void CalculateArea()
        {
            Area = 3.14 * (Radius * Radius);
            

        }
        public override void CalculatePerimeter()
        {
            Perimeter = 2 * 3.14 * Radius;
        }
    }
}
