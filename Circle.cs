using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

      

        public override double Area()
        {
          double area =  Math.Pow(radius, 2) * Math.PI;
            double area1 = Math.Round((Double)area, 2);
            return area1;

        }

        public override double Perimeter()
        {
            double per = Math.PI * (2 * radius);
            double per1 = Math.Round((Double)per, 2);
            return per1;
        }


    }
}
