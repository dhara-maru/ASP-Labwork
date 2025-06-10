using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Interest
    {
        public void CalcInterest(double P, double R, double N)
        {
            double SI = (P * R * N) / 100;
            Console.WriteLine("Simple Interest : " + SI);
        }
    }
}
