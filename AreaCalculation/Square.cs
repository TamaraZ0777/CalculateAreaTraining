using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCalculation
{
    class Square
    {
        private double _side;
        private double _area;

        public Square(double side)
        {
            Side = side;
            Area = GetArea(Side);
        }

        public double Side
        {
            get { return _side; }
            private set { _side = value; }
        }

        public double Area
        {
            get { return _area; }
            private set { _area = value; }
        }

        private double GetArea(double side)
        {
            return side * side;
        }
    }
}
