using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._10._3
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal rate;
            decimal aT=1;
            int time = 0;
            int selection=int.MinValue;
            do
            {
                do
                {
                    Console.Clear();//Want to make sure the console is clear before we start executing code
                    Console.Write("1) Option 1\n" +
                                      "2) Option 2\n" +
                                      "3) Option 3\n" +
                                      ">");
                } while (!int.TryParse(Console.ReadLine(), out selection));
            } while ((selection < 1 || selection > 3));
            //do
            //{
            //    Console.Write("Eneter the interest rate as a decimal Value: ");
            //} while (!Decimal.TryParse(Console.ReadLine(),out rate));
            //while (aT < 2)
            //{
            //    time++;
            //    aT = aT * (1 + rate);
            //}
            //Console.WriteLine("It would take {0} units of time to double the value.", time);
        }
    }
}
