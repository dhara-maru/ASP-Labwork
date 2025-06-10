using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Staff
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public String Department { get; set; }
        public String Designation { get; set; }
        public int Experience;
        public double Salary { get; set; }

        public void GetStaffDetails()
        {
            Console.WriteLine("Enter Staff ID : ");
            ID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Staff Name : ");
            Name = Console.ReadLine();

            Console.WriteLine("Enter Staff Designation : ");
            Designation = Console.ReadLine();

            Console.WriteLine("Enter Staff Department : ");
            Department = Console.ReadLine();

            Console.WriteLine("Enter Experience : ");
            Experience = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter Salary : ");
            Salary = Convert.ToDouble(Console.ReadLine());
        }

        public void ShowStaffDetails()
        {
            Console.WriteLine("Staff Details : \n");
            Console.WriteLine("ID : " + ID);
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Designation : " + Designation);
            Console.WriteLine("Department : " + Department);
            Console.WriteLine("Experience : " + Experience);
            Console.WriteLine("Salary : " + Salary);

        }

        public void displaynameAndSalary()
        {
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Salary : " + Salary);
        }
    }
}
