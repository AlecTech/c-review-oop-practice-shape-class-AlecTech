using System;
using System.Collections.Generic;
using System.Text;

namespace oct23ShapesClassesPracticeCS.Shapes
{
    //https://www.c-sharpcorner.com/article/oops-concepts-and-net-part-2-inheritance-abstraction-and/
    public abstract class Shape
    {
        private float _area;
        private string _color;
        private float _perimeter;
        public float Area { get; }
      //  {
           // get
          //  {
          //      return _area;
           // }
           // set
          //  {
          //      _area = value;
           // }
       // }
        public float Perimeter { get; }
       // {
           // get
          //  {
           //     return _perimeter;
          //  }
            //set
           // {
           //     _perimeter = value;
           // }
        //}
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

        public Shape()
        {
            Area = 0;
            Perimeter = 0;
            Color = "White";
        }
        public Shape(float area, float perimeter, string color)
        {
            Area = area;
            Perimeter = perimeter;
            Color = color;
        }

        public abstract void CalculateArea();
        public abstract void CalculatePerimeter();
    }
}
