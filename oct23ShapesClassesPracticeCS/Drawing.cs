using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using oct23ShapesClassesPracticeCS.Shapes;

namespace oct23ShapesClassesPracticeCS
{
    public class Drawing
    {
       
        private string _color;
        private double _totalPerimeters;
        private List<Shape> Shapes { get; set; } = new List<Shape>();

        public Drawing()
        {
            //initialize the list here
        }

        public double SpaceCovered
        {
            get
            {
                double totalAreas = 0;
                foreach (var shape in Shapes)
                {
                    totalAreas += shape.Area;
                   
                }
                return totalAreas;
            }
         
        }

        public double LinesDrawn
        {
            get
            {
                double totalPerimeters = 0;
                foreach (var shape in Shapes)
                {
                    totalPerimeters += shape.Perimeter;

                }
                
                return totalPerimeters;
            }
           // set
           // {
            //    _totalPerimeters = value;
           // }
        }

        public void Draw(Shape shape)
        {

            Shapes.Add(shape);
          
           
        }

    }
}
//List<Shapes> = new List<Circle>();
//for(int i=1; i <= allCircles; i++)
//{
//   placeholder.Add(new Circle(area, perimeter, color));
// }
//Room = room;