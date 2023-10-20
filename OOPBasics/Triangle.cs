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
        public double C { get; set; }
        public double Angle1 { get; set; }

        //public double Angle2 { get; set; }
 
        public double s { get; set; }

        public double GetArea2sides()
        {
            return (A * B) / 2.0;
        }
        public double GetArea3sides()
        {
            s = (A + B + C) / 2.0;
            return Math.Sqrt(s * (s - A) * (s - B) * (s - C));
        }
        public double GetArea2sides1Angle()
        {
            return (A * B * Math.Sin(Angle1)) / 2.0;
        }
    }
}
