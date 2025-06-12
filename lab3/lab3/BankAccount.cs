using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class BankAccount
    {
        public double Balance { get; set; }
        public String Name { get; set; }

        public int Acno { get; set; }
        public BankAccount()
        {
            Balance = 1000.00;
            Console.WriteLine("Enter Account Number : ");
            Acno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Account Name : ");
            Name = Console.ReadLine();

        }

        public void Deposit(int checknumber, double amount)
        {
            Console.WriteLine("Amount " + amount + " deposited on the Check " + checknumber + " on your account " + Acno);
        }

        public void Deposit(double amount)
        {
            Console.WriteLine("Amount " + amount + " deposited on your account " + Acno);
        }

        public void Withdraw(int checknumber, double amount)
        {
            Console.WriteLine("Amount " + amount + " Withdrawn through the Check " + checknumber + " from your account " + Acno);
        }

        public void Withdraw(double amount)
        {
            Console.WriteLine("Amount " + amount + " Withdrawn from your account " + Acno);
        }
    }
}
