using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._9._12___Chapter_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 27;
            Console.Write("Enter Course Name: ");
            string name = Console.ReadLine();
            Gradebook gb1 = new Gradebook(name);
            gb1.DisplayMessage();
            BankAccount myAccount = new BankAccount("Alex M.", 72567.0M);
            Console.WriteLine("{0}'s Balance: {1:C}", myAccount.AccountHolder, myAccount.Balance);//Interesting so 0 is the first argument, and 1 is the first ...
        }
    }
}
