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
            //So I could write a switch here, but ... essentially the only thing that's different from c++ is that you can't do weird things ... like not having breaks.
            switch (10 / 10)
            {
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Are you sure this is correct?");
                    goto case 12;//THIS CAN CAUSE AN INFINITE LOOP >_<
                case 12:
                case 13:
                    Console.WriteLine("You Got an A!");
                    break;
                case 8:
                    Console.WriteLine("You Got a B!");
                    break;
                case 7:
                    Console.WriteLine("You got a C.");
                    break;
                case 6:
                    Console.WriteLine("You got a D ...");
                    break;
                default:
                    Console.WriteLine("You got an F ... ");
                    break;
            }
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
