using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using oct23ShapesClassesPracticeCS.Shapes;

namespace oct23ShapesClassesPracticeCS
{
    public class Drawing
    {
        private double _totalAreas;
        private string _color;
        private double _totalPerimeters;
        private List<Shape> Shapes { get; set; }

        public Drawing()
        {
            //initialize the list here
        }

        public double SpaceCovered
        {
            get
            {
                return _totalAreas;
            }
            set
            {
                _totalAreas = value;
            }
        }

        public double LinesDrawn
        {
            get
            {
                return _totalPerimeters;
            }
            set
            {
                _totalPerimeters = value;
            }
        }

        public void Draw(Shape)
        {
           

            Shape = new List<Circle>();
            for(int i=1; i <= allCircles; i++)
            {
                placeholder.Add(new Circle(area, perimeter, color));
            }
            //Room = room;
           
        }

    }
}
