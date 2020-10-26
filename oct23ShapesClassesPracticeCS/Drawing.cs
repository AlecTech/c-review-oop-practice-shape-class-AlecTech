using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using oct23ShapesClassesPracticeCS.Shapes;

namespace oct23ShapesClassesPracticeCS
{
    public class Drawing
    {
      
        private List<Shape> Shapes { get; set; } = new List<Shape>();

        public Drawing()
        {
            //initialize the list here
        }
        //encupsulation
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
        }

        public override string ToString()
        {
            return $"A drawing consisting of {Shapes.Count} shapes."; 
        }
        //polymorphism is used here to combine different shapes into one List
        public void Draw(Shape shape)
        {
            Shapes.Add(shape);
        }
    }
}
