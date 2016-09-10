using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._26
{
    class Program
    {
        static void Main(string[] args)
        {
            int radius=getValue();
            Console.WriteLine("Diameter: " + (2 * radius) + "\nCircumfrence: " + (2 * Math.PI * radius) + "\nArea: " + (Math.PI * Math.Pow(radius, 2)));//I really should ease up on the one line statements ...
            Console.WriteLine("Press [enter] to continue");
            Console.ReadLine();
        }
        //And then I coppied this from 3.16
        static int getValue()
        {
            Console.Write("Enter the Radius:");
            string read = Console.ReadLine();
            try
            {
                return Convert.ToInt32(read);
            }
            catch (System.FormatException e)
            {//Just to try to prevent a crash.


                Console.WriteLine("Please enter in a number.");
                return getValue();//Oh How I love recursion
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
