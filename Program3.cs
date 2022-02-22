// See https://aka.ms/new-console-template for more information
using System;
namespace Prog6B3
{
    class BankCustomer
    {
        public int accno;
        public string acname;
        public double bankbalance;
        public BankCustomer(int acno, string acname, double bb)
        {
            this.accno = acno;
            this.acname = acname;
            this.bankbalance = bb;
        }
    }
    public delegate void BalanceChecker(double n);
    class Program
    {
        //method for delegate
        public static void checkBalance(double balance)
        {
            if (balance < 0)
                Console.Write("You are overdrawn");
            else if (balance < 10)
                Console.Write("Your account balance is very low !");
            else if (balance < 100)
                Console.Write("Watch your spending carefully.");
            else
                Console.Write("You have over $100 in your account.");
        }
        static void Main()
        {
            //instanciate delegate
            BalanceChecker checker = checkBalance;
            BankCustomer b1 = new BankCustomer(1221, "A", -6);
            Console.Write($"\nHello ,{b1.acname} : ");
            checker(b1.bankbalance);
            Console.WriteLine($" (Account balance = ${b1.bankbalance})");
            BankCustomer b2 = new BankCustomer(1214, "B", 1.5);
            Console.Write($"\nHello ,{b2.acname} : ");
            checker(b2.bankbalance);
            Console.WriteLine($" (Account balance = ${b2.bankbalance})");
            BankCustomer b3 = new BankCustomer(1225, "C", 56.9);
            Console.Write($"\nHello ,{b3.acname} : ");
            checker(b3.bankbalance);
            Console.WriteLine($" (Account balance = ${b3.bankbalance})");
            BankCustomer b4 = new BankCustomer(1236, "D", 500);
            Console.Write($"\nHello ,{b4.acname} : ");
            checker(b4.bankbalance);
            Console.WriteLine($" (Account balance = ${b4.bankbalance})");

        }
    }
}


