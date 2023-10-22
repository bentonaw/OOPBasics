using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasics
{
    public class Triangle
    {
        public double A { get; set; }
        public double B { get; set; }

        public Triangle(double a, double b)
        {
            A = a;
            B = b;
        }

        public double GetArea2sides()
        {
            return (A * B) / 2.0;
        }
    }
}
