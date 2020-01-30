using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCalculation
{
    class Square
    {
        private double side;
        private double area;

        public Square(double side)
        {
            //Side = side;
            Area = GetArea(side);
        }

        public double Side
        {
            get { return side; }
            //set { side = value; }
        }

        public double Area
        {
            get { return area; }
            private set { area = value; }
        }

        private double GetArea(double side)
        {
            return side * side;
        }
    }
}
