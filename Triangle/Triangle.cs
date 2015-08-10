using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleNS
{
    public class Triangle
    {
        public double a { get; protected set; }
        public double b { get; protected set; }
        public double c { get; protected set; }

        public Triangle(double a, double b, double c)
        {
            if ((a <= 0) || (b <= 0) || (c <= 0))
            {
                throw new ArgumentOutOfRangeException("Wrong side length");
            }
            if (!((a + b >= c) && (a + c >= b) && (b + c >= a)))
            {
                throw new ArgumentOutOfRangeException("Triangle inequality");
            }
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double Area()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }

    public class RightTriangle : Triangle
    {
        public RightTriangle(double a, double b, double c) : base(a, b, c)
        {
            double[] sides = new double[3] {a, b, c};
            Array.Sort(sides);
            if (Math.Abs(sides[0] * sides[0] + sides[1] * sides[1] - sides[2] * sides[2]) > 1E-5)
            {
                throw new ArgumentOutOfRangeException("Not right triangle");
            }
        }
    }
}
