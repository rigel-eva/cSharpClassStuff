using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._24
{
    class Program
    {
        static void Main(string[] args)
        {
            for (uint i = 1; i < 1001; i++)
            {
                Console.Write("{0} is ", i);
                if (!perfect(i))
                {
                    Console.Write("not ");
                }
                Console.WriteLine("a perfect number");
            }
        }
        static bool perfect(uint num)
        {
            //Lazy way to actually check: num==6||num==28||num==496
            if (num == 1)
            {
                return false;
            }
            uint factorAdd = 0;
            //int sqrt = (int)Math.Ceiling(Math.Sqrt(num));
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)//If we have no remainders
                {
                    factorAdd = i + factorAdd;
                }
            }
            return (num == factorAdd);
        }
        static bool lazyPerfect(ulong num)
        {
            //A rainbow table looks lovely today, no?
            ulong[] perfectNumbers = { 6, 28, 496, 8128, 33550336, 8589869056, 137438691328, 2305843008139952128 };
            return perfectNumbers.Contains(num);
        }
    }
}
