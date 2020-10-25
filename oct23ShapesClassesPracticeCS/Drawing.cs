using System;
using System.Collections.Generic;
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

        public Drawing()
        {
            //initialize the list here
        }

    }
}
