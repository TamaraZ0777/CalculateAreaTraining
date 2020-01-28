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
            this.radius = radius;
        }

        public double getRadius()
        {
            return radius;
        }

        public double getArea()
        {
            return Math.PI * radius * radius;
        }
    }
}
