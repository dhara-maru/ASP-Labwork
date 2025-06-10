using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class InterestAccount
    {
        public int Acno { get; set; }
        public String Name { get; set; }
        public double P = 20.0;
        public double R = 4.5;

        public double N = 3.0;

      
        public void GetIAccDetails()
        {
            Console.WriteLine("Enter Account number : ");
            Acno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Name : ");
            Name = Console.ReadLine();

            Console.WriteLine("Enter P : ");
            P = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter R : ");
            R = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter N : ");
            N = Convert.ToDouble(Console.ReadLine());
        }
    }
}
