using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class BankAccount
    {
        public int ID { get; set; }
        public int AccountNo { get; set; }
        public String Name { get; set; }
        public String Type { get; set; }
        public double Balance { get; set; }

        public void GetAccountDetails()
        {
            Console.WriteLine("Enter Account ID : ");
            ID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Account Holder Name : ");
            Name = Console.ReadLine();

            Console.WriteLine("Enter Account Type : ");
            Type = Console.ReadLine();

            Console.WriteLine("Enter Account Balance : ");
            Balance = Convert.ToDouble(Console.ReadLine());

        }

        public void ShowAccountDetails()
        {
            Console.WriteLine("Account Details : \n");
            Console.WriteLine("ID : " + ID);
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Type : " + Type);
            Console.WriteLine("Balance : " + Balance);

        }
    }
}
