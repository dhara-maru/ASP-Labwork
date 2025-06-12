using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    interface Gross
    {
        public void Gross_sal();
    }
    internal class Salary : Gross
    {
        public double HRA { get; set; }
        public double TA { get; set; }
        public double DA { get; set; }

        public void Gross_sal()
        {
            Console.WriteLine("Gross Salary : " + (HRA + TA + DA));
        }
        public virtual void Disp_sal()
        {
            Gross_sal();
        }
    }
    internal class Employee : Gross
    {
        public String name;
        public double HRA = 2000;
        public double TA = 3000;
        public double DA = 5000;
        public double Basic;
        
        public virtual void Basic_sal()
        {
            Console.WriteLine("Enter Basic salary : ");
            Basic = Convert.ToDouble(Console.ReadLine());
        }
        public void Gross_sal()
        {
            Console.WriteLine("Gross Salary : " + (Basic + HRA + TA + DA));
        }
    }
}
