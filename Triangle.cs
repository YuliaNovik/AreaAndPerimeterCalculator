using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Triangle : Shape
    {
        private double a;
        private double b;
        private double c;

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override double Area()
        {
            double p =  (a + b +c)/2 ;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            double area1 = Math.Round((Double)area, 2);
            return area1;
        }
        public override double Perimeter()
        {
            double per = a + b + c;
            double per1 = Math.Round((Double)per, 2);
            return per1;
        }
    }
}
