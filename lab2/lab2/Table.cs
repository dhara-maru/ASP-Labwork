using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Table : Furniture
    {
        public double Height { get; set; }
        public double SurfaceArea { get; set; }

        public void GetTableDetails()
        {
            Console.WriteLine("Enter Material : ");
            Material = Console.ReadLine();

            Console.WriteLine("Enter Price : ");
            Price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Height : ");
            Height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Surface Area : ");
            SurfaceArea = Convert.ToDouble(Console.ReadLine());
        }

        public void ShowTable()
        {
            Console.WriteLine("Table Materials Used : " + Material);
            Console.WriteLine("Table Surface Area : " + SurfaceArea);
            Console.WriteLine("Table Price : " + Price);
            Console.WriteLine("Table Height : " + Height);
        }
    }
}
