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
            this.side = side;
        }

        public double getSide()
        {
            return side;
        }

        public double getArea()
        {
            return side * side;
        }
    }
}
