using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._9._12___Dates_and_Imaginary_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            ComplexUnitTests.runAll();
        }
        

    }
    class ComplexUnitTests
    {
        static  ComplexNumber c1 = new ComplexNumber();
        static  ComplexNumber c2 = new ComplexNumber(0, 3);
        static  ComplexNumber c3 = new ComplexNumber(0, -3);
        static  ComplexNumber c4 = new ComplexNumber(2, 0);
        static  ComplexNumber c5 = new ComplexNumber(2, 3);
        static  ComplexNumber c6 = new ComplexNumber(2, -3);
        static  ComplexNumber c7 = new ComplexNumber(-2, 0);
        static  ComplexNumber c8 = new ComplexNumber(-2, 3);
        static  ComplexNumber c9 = new ComplexNumber(-2, -3);
        public static void runAll()
        {
            Console.Write("Complex String Unit Test: ");
            if (ComplexUnitTests.StringTest())
            {
                Console.WriteLine("Pass!");
            }
            else
            {
                Console.WriteLine("Fail!");
            }
            Console.Write("Complex Addition Unit Test: ");
            if (ComplexUnitTests.AdditionTest())
            {
                Console.WriteLine("Pass!");
            }
            else
            {
                Console.WriteLine("Fail!");
            }
            Console.Write("Complex Subtraction Unit Test: ");
            if (ComplexUnitTests.SubtractionTest())
            {
                Console.WriteLine("Pass!");
            }
            else
            {
                Console.WriteLine("Fail!");
            }
            Console.Write("Complex Multiplication Unit Test: ");
            if (ComplexUnitTests.MultiplicationTest())
            {
                Console.WriteLine("Pass!");
            }
            else
            {
                Console.WriteLine("Fail!");
            }
            Console.Write("Complex Division Unit Test: ");
            if (ComplexUnitTests.DivisionTest())
            {
                Console.WriteLine("Pass!");
            }
            else
            {
                Console.WriteLine("Fail!");
            }
        }
        public static bool StringTest()
        {
            bool returner = true;
            returner = returner && String.Equals(c1.ToString(), "0");//Should Return a flat 0
            returner = returner && String.Equals(c2.ToString(), "3i");//Should return 3i
            returner = returner && String.Equals(c3.ToString(), "-3i");//Should return -3i
            returner = returner && String.Equals(c4.ToString(), "2");//Should return a flat 2
            returner = returner && String.Equals(c5.ToString(), "2+3i");//Should return 2+3i
            returner = returner && String.Equals(c6.ToString(), "2-3i");//Should Return 2-3i
            returner = returner && String.Equals(c7.ToString(), "-2");//Should return -2
            returner = returner && String.Equals(c8.ToString(), "-2+3i");//Should return -2+3i
            returner = returner && String.Equals(c9.ToString(), "-2-3i");//Should return -2-3i
            return returner;
        }
        public static bool AdditionTest()
        {
            bool returner = true;
            return returner;
        }
        public static bool SubtractionTest()
        {
            bool returner = true;
            return returner;
        }
        public static bool MultiplicationTest()
        {
            bool returner = true;
            return returner;
        }
        public static bool DivisionTest()
        {
            bool returner = true;
            return returner;
        }
    }
}

