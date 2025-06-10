using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Rectangle
    {
        public double Height { get; set; }
        public double Width { get; set; }

        public void GetRectDetails()
        {
            Console.WriteLine("Enter Rectangle Height : ");
            Height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Rectngle Width : ");
            Width = Convert.ToDouble(Console.ReadLine());
        }
        public Rectangle(){
            GetRectDetails();
        }

        public void FindArea()
        {
            double area = Height * Width;
            Console.WriteLine("Area is : " + area);
        }
    }
}
