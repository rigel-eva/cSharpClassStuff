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
            exercise3();
        }
        static void getInput(string prompt, out int output)// much code reuse. many lazy. wow.
        {
            string input;
            Console.Write(prompt + ": ");
            input = Console.ReadLine();
            if (!int.TryParse(input, out output))
            {
                Console.WriteLine("Please enter an integer.");
                getInput(prompt, out output);
            }
        }
        static void getInput(string prompt, out uint output)// much code reuse. many lazy. wow.
        {
            string input;
            Console.Write(prompt + ": ");
            input = Console.ReadLine();
            if (!uint.TryParse(input, out output))
            {
                Console.WriteLine("Please enter a positive integer.");
                getInput(prompt, out output);
            }
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
                int input;
                getInput("Please enter the " + (i + 1) + " value", out input);
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
        static void exercise3()//Fibbonachi sequence ... fun ...
        {
            uint numTerms;
            uint a=0;
            uint b=0;

            getInput("Enter the number of terms to get", out numTerms);
            for(int i=0; i<numTerms; i++)
            {
                if (i == 0)
                {
                    continue;
                }
                else if(i==1)
                {
                    b = 1;
                    continue;
                }
                uint temp = a;
                a = b;
                b = temp + a;
            }
            Console.WriteLine("The {0}th term of the Fibbonachi sequence is {1}", numTerms, b);
        }
    }
}
