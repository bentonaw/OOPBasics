using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasics
{
    public class Circle
    {
        public double Radius { get; set; } // property
        public double Area { get; set; }
        public double Circumference { get; set; }
        public double Volume { get; set; }


        public Circle (double radius) // constructor
        {
            Radius = radius;
        }

        public double GetArea() // metod
        {
            return Math.Round(((Radius * Radius) * Math.PI), 2);
        }

        public double GetCircumference()
        {
            return Math.Round((2.0 * Math.PI * Radius), 2);
        }

        public double GetVolume()
        {
            return Math.Round(((4.0 / 3.0) * Math.PI * (Radius * Radius * Radius)), 2);
        }


    }
}
