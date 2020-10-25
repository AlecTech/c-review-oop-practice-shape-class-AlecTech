using System;
using System.Collections.Generic;
using System.Text;

namespace oct23ShapesClassesPracticeCS.Shapes
{
    //https://www.c-sharpcorner.com/article/oops-concepts-and-net-part-2-inheritance-abstraction-and/
    public abstract class Shape
    {
        //private double _area;
        //private double _perimeter;
        //private string _color;
        public abstract double Area { get; }
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
        public abstract double Perimeter { get; }
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
        //encapsulation
        public string Color { get; set; }
        public Shape()
        {
            Color = "White";
        }
        public Shape( string color)
        {
            Color = color;
        }
        //public abstract void CalculateArea();
        //public abstract void CalculatePerimeter();
    }
}
