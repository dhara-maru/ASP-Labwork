using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Hospital
    {
        public String Name { get; set; }
        public String Location { get; set; }

        public virtual void HospitalDetails()
        {
            Console.WriteLine("Enter Hospital Name : ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Hospital Location : ");
            Location = Console.ReadLine();

            Console.WriteLine("Hospital Details : ");
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Location : " + Name);
            Console.WriteLine("========================");
        }
    }

    internal class Apollo : Hospital
    {
        public int Beds=50;
        public override void HospitalDetails()
        {
            Console.WriteLine("Beds : "+Beds);
        }
    }

    internal class Wockhardt : Hospital
    {
        public String Branch = "Bandra, Mumbai";
        public override void HospitalDetails()
        {
            Console.WriteLine("Another Branch : " + Branch);
        }
    }
    internal class Gokul_Superspeciality : Hospital
    {
        public String Branch = "Rajkot, Gujarat";
        public override void HospitalDetails()
        {
            Console.WriteLine("Another Branch : " + Branch);
        }
    }
}
