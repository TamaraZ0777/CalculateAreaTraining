using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCalculation
{
    class Circle
    {
        private double _radius;
        private double _area;

        public Circle(double radius)
        {
            Radius = radius;
            Area = GetArea(Radius);
        }

        public double Radius 
        {
            get { return _radius; }
            private set { _radius = value; }
        }

        public double Area 
        {
            get { return _area; }
            private set { _area = value; }
        }

        private double GetArea(double radius)
        {
            return Math.PI * radius * radius;
        }
    }
}
