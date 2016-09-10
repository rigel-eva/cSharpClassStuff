using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._15
{
    class Program
    {
        static void Main(string[] args)
        {
            int var1 = getValue(1);
            int var2 = getValue(2);
            if (var1 > var2)
            {
                Console.WriteLine(var1 + " is larger");
            }else if (var2 > var1)
            {
                Console.WriteLine(var2 + " is larger");
            }else
            {
                Console.WriteLine("These numbers are equal");
            }
            Console.WriteLine("Press [enter] to continue");
            Console.ReadLine();
        }
        //Why Yes, I did copy the following code from 3.30.
        static int getValue(int currentValue)
        {
            Console.Write("Enter the " + intToText(currentValue) + " Number:");
            string read = Console.ReadLine();
            try
            {
                return Convert.ToInt32(read);
            }
            catch (System.FormatException e)
            {//Just to try to prevent a crash.


                Console.WriteLine("Please enter in a number.");
                return getValue(currentValue);//Oh How I love recursion
            }
        }
        static string intToText(int integer)//I wanted it to look pretty ... 
        {
            switch (integer)
            {
                case 1:
                    return "First";
                case 2:
                    return "Second";
                case 3:
                    return "Third";
                case 4:
                    return "Forth";
                case 5:
                    return "Fifth";
                default:
                    throw new System.ArgumentException("Parameter out of range!!!");//If we somehow reach here, something has gone terribly wrong, and I'd like to know about it as quickly as possible.
            }
        }
    }
}
