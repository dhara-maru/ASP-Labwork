using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Area
    {
        public double findArea(double h)
        {
            double area = h * h;
            return area;
        }
        public double findArea(double l, double w)
        {
            double area = l * w;
            return area;
        }

        public float findArea(float r)
        {
            float area = 3.14f * r * r;
            return area;
        }
    }
}
