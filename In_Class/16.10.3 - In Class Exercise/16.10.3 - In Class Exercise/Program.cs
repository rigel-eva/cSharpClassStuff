using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._10._3___In_Class_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            exercise2();
        }
        static void exercise1()
        {
            for(int i=1; i<21; i++)
            {
                Console.WriteLine("1/{0}=={1}", i, 1.0 / i);
            }
        }
        static void exercise2()
        {
            int smallest = int.MaxValue;
            int secSmallest = int.MaxValue;
            for(int i=0; i<5; i++)
            {
                int input = getInput("Please enter the " + (i + 1) + " value");
                if (input < smallest)
                {
                    smallest = input;
                }
                else if (input < secSmallest)
                {
                    secSmallest = input;
                }
            }

            Console.WriteLine("Smallest Value: {0}\nSecond Smallest Value: {1}", smallest, secSmallest);
        }
        static int getInput(string prompt)// much code reuse. many lazy. wow.
        {
            int returner;
            string input;
            Console.Write(prompt + ": ");
            input = Console.ReadLine();
            if (int.TryParse(input, out returner))
            {
                return returner;
            }
            else
            {
                Console.WriteLine("Please enter an integer.");
                return getInput(prompt);
            }
        }
    }
}
