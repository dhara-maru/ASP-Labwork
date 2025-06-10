using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Salary
    {
        public double Basic { get; set; }
        public double TA { get; set; }
        public double DA { get; set; }
        public double HRA { get; set; }

        public Salary()
        {
            DA = 2000.00;
            HRA = 3000.00;
        }

        public void EnterSalaryDetails()
        {
            Console.WriteLine("Enter Basic : ");
            Basic = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter TA : ");
            TA = Convert.ToDouble(Console.ReadLine());

           
        }

        public void ShowSalaryTotal()
        {
            double TotalSalary = Basic + TA + DA + HRA;
            Console.WriteLine("Total Salary = " + TotalSalary);
        }
    }
}
