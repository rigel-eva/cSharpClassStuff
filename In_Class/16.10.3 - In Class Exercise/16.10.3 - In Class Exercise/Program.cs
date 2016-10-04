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
            exercise5();
        }
        //Helper functions
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
        static bool isPrime(long number)//Slightly modified from: http://stackoverflow.com/questions/15743192/check-if-number-is-prime-number (Not going to write this if I don't have to)
        {
            if (number == 1) return false;
            if (number == 2) return true;

            var boundary = (long)Math.Floor(Math.Sqrt(number));

            for (int i = 2; i <= boundary; ++i)
            {
                if (number % i == 0) return false;
            }

            return true;
        }
        //The Actual functions we are writing.
        static bool isPalendrome(string testee)
        {
            string sideA;
            string sideB;
            if (testee.Length % 2 == 1)//if the string is odd
            {
                sideA = testee.Substring(0, (testee.Length-1) / 2);//get the left side, minus the center character
                sideB = testee.Substring((((testee.Length -1)/ 2) + 1));//get the right side minus the center character
            }
            else
            {
                sideA = testee.Substring(0, testee.Length / 2);
                sideB = testee.Substring(testee.Length / 2);
            }
            char[] sideBArray = sideB.ToCharArray();
            Array.Reverse(sideBArray);
            return sideA.Equals(new string(sideBArray));
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
        static void exercise4(long toFind = 600851475143)//... Oh joy ... prime numbers ... blerg ...
        {
            long i=toFind-1;
            //If i isn't less than zero, and i isn't prime and what we are looking for modulo i isn't zero, we continue.
            for (; i>0&&!isPrime(i)&&toFind%i!=0; i--) ;
            Console.WriteLine("The Largest prime factor of {0} is {1}", toFind, i);
        }
        static void exercise5()//Ah crap ... we are getting into palandromes ... oh joy ...
        {
            //Note we are only interested in the largest ... and we are not afraid to brute force.\
            int max = int.MinValue;
            for(int i=0; i<1000; i++)
            {
                for(int j=0; j<1000; j++)
                {
                    if (isPalendrome((i * j).ToString())) max = Math.Max(max, i * j);
                }
            }
            Console.WriteLine("Largest Palendrome of two three digit integers: {0}", max);
        }
    }
}
