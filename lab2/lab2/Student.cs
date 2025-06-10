using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Student
    {
        public int Enrollment { get; set; }
        public String Name { get; set; }
        public int Sem { get; set; }
        public double CPI { get; set; }
        public double SPI { get; set; }

        public void GetStudDetails()
        {
            Console.WriteLine("Enter Student Enrollment : ");
            Enrollment = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Student Name : ");
            Name = Console.ReadLine();

            Console.WriteLine("Enter Student Semester : ");
            Sem = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Student CPI : ");
            CPI = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Student SPI : ");
            SPI = Convert.ToDouble(Console.ReadLine());
        }

        public void ShowDetails()
        {

            Console.WriteLine("Student Details : \n");
            Console.WriteLine("Enrollment Number : " + Enrollment);
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Semester : " + Sem);
            Console.WriteLine("CPI : " + CPI);
            Console.WriteLine("SPI : " + SPI);
        }

        public Student(){
            Console.WriteLine("Enter Student Details :");
        }
    }
}
