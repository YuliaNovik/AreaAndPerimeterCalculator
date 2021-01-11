using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle : Shape
    {
        private double length;
        private double width;

        public Rectangle()
        {

        }
        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public double Length
        {
            get
            {
                return length;
            }
            set
            {
                length = value;
            }
        }

        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
            }
        }

        public override double Area()
        {
           double area =  width * length;
            double area1 = Math.Round((Double)area, 2);
            return area1;
        }
        public override double Perimeter()
        {
            double per = 2 * (length + width);
            double per1 = Math.Round((Double)per, 2);
            return per1;
        }
    }
}
