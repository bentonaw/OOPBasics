using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasics
{
    internal class Circle
    {
        private int _radius { get; set; }

        internal Circle (int radius)
        {
            _radius = radius;
        }

        public double GetArea()
        {
            return ((_radius * _radius) * Math.PI);
        }
    }
}
