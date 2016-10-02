using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._20
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine("Number of itterations to get " + i + " Digits of accuracy: " + piAccuracy(i));
            }
        }
        static int piAccuracy(int accuracy=1)
        {
            double output;
            int terms = 0;
            do
            {
                output = piCalc(++terms);
            }
            while (Math.Floor(output * Math.Pow(10, accuracy)- Math.PI * Math.Pow(10, accuracy))!=0);
            return terms;
        }
        static double piCalc(int terms)
        {
            if (terms <=0)
            {
                return 4;
            }
            else if ((terms+1) % 2 == 0)
            {
                return piCalc(terms - 1) - 4.0 / (1 + terms * 2);
            }
            else
            {
                return piCalc(terms - 1) + 4.0 / (1 + terms * 2);
            }
        }
    }
}
