using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Distance
    {
        public double D1 { get; set; }
        public double D2 { get; set; }
        public double D3 { get; set; }
        public double total { get; set; }

        public Distance()
        {
            D1 = 10;
            D2 = 20;
        }

        public void EnterD3()
        {
            Console.WriteLine("Enter Third Distance : ");
            D3 = Convert.ToDouble(Console.ReadLine());
        }
        public void Addition()
        {
           total = D1 + D2 + D3;
        }
        public void ShowTotalDistance()
        {
            Console.WriteLine("Total Distance = " + total);
        }
    }
}
