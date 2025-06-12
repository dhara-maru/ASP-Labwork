using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class RBI
    {
        public virtual void CalcSI(double p, double r, double n)
        {
            double SI = (p * r * n) / 100;
            Console.WriteLine(SI);
        }
    }
    internal class HDFC : RBI
    {
        public override void CalcSI(double p, double r, double n)
        {
            Console.WriteLine("Simple Interest of HDFC Bank");
            double SI = (p * r * n) / 100;
            Console.WriteLine(SI);
        }
    }
    internal class SBI : RBI
    {
        public override void CalcSI(double p, double r, double n)
        {
            Console.WriteLine("Simple Interest of SBI Bank");
            double SI = (p * r * n) / 100;
            Console.WriteLine(SI);
        }
    }
    internal class ICICI : RBI
    {
        public override void CalcSI(double p, double r, double n)
        {
            Console.WriteLine("Simple Interest of ICICI Bank");
            double SI = (p * r * n) / 100;
            Console.WriteLine(SI);
        }
    }
}
