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
            return 4 * termCalc(terms);//Trying this out to see if this prevents the stack overflow error.   
        }
        static double termCalc(int terms)
        {
            if (terms <= 0)
            {
                return 1;
            }
            else
            {
                return termCalc(terms - 1) + (Math.Pow(-1, terms) / (1 + terms * 2));
            }

        }
    }
}
