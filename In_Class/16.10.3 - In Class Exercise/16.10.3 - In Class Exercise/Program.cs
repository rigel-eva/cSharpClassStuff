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
            exercise1();
        }
        static void exercise1()
        {
            for(int i=0; i<21; i++)
            {
                Console.WriteLine("1/{0}=={1}", i, 1.0 / i);
            }
        }
    }
}
