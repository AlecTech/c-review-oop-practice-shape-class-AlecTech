using System;
using System.Collections.Generic;
using System.Text;

namespace oct23ShapesClassesPracticeCS.Shapes
{
    public abstract class Shape
    {
        private float _area;
        private string _color;
        private float _perimeter;
        public float Area
        {
            get
            {
                return _area;
            }
           // set
          //  {
          //      _area = value;
           // }
        }
        public float Perimeter
        {
            get
            {
                return _perimeter;
            }
            //set
           // {
           //     _perimeter = value;
           // }
        }
        public string Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        }
        public abstract void CalculateArea();
        public abstract void CalculatePerimeter();
    }
}
