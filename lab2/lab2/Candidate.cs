using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{

   
    internal class Candidate
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }

        public void GetCandidateDetails()
        {
            Console.WriteLine("Enter Candidate ID : ");
            ID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Candidate Name : ");
            Name = Console.ReadLine();

            Console.WriteLine("Enter Candidate Age : ");
            Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Candidate Height : ");
            Height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Candidate Weight : ");
            Weight = Convert.ToDouble(Console.ReadLine());
        }

        public void ShowCandidateDetails()
        {
            Console.WriteLine("Candidate Details : \n");
            Console.WriteLine("ID : " + ID);
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Age : " + Age);
            Console.WriteLine("Weight : " + Weight);
            Console.WriteLine("Height : " + Height);

        }
    }
}
