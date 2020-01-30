using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCalculation
{
    class Circle
    {
        private double radius;
        private double area;

        public Circle(double radius)
        {
            //Radius = radius;
            Area = GetArea(radius);
        }

        public double Radius 
        {
            get { return radius; }
            //set { radius = value; }
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
