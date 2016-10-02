using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._37
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Factorial of that number is: " + factorial(getInput("Please enter a positive integer")));
        }
        static uint getInput(string prompt)//converted this function to uint, because, unsigned integers are fun, right? (also, instead of checking whether it's positive or not, I can just check if it's a valid unsigned integer.)
        {
            uint returner;
            string input;
            Console.Write(prompt + ": ");
            input = Console.ReadLine();
            if (uint.TryParse(input, out returner))
            {
                return returner;
            }
            else
            {
                Console.WriteLine("Please enter a positive integer.");
                return getInput(prompt);
            }
        }
        static uint factorial(uint integer)
        {
            if (integer == 1)
            {
                return 1;
            }
            return integer * factorial(integer - 1);//Why yes I will turn this into a recursion problem. because why not?
        }
    }
}
