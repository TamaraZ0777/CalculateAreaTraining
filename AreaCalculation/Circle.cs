using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCalculation
{
    class Circle
    {
        private double _radius;
        private double area;

        public Circle(double radius)
        {
            _radius = radius;
            Area = GetArea(radius);
        }

        public double Radius 
        {
            get { return _radius; }
            //set { _radius = value; }
        }

        public double Area 
        {
            get { return area; }
            private set { area = value; }
        }

        public double GetArea(double radius)
        {
            return Math.PI * radius * radius;
        }
    }
}
