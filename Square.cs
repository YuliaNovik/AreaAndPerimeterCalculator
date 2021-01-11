using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Square : Rectangle
    {
        private double side;

      
        public Square(double side)
        {
            
            this.side = side;
        }
        public double Side
        {
            get
            {
                return side;
            }
            set
            {
                side = value;
            }
        }

        public override double Area()
        {
            double area = Math.Pow(side, 2);
            double area1 = Math.Round((Double)area, 2);
            return area1;
        }
        public override double Perimeter()
        {
            double per = 4 * side;
            double per1 = Math.Round((Double)per, 2);
            return per1;
        }
    }
}
