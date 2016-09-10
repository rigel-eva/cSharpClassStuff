using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Realized that even though arrays are fun and all, this would be an easier way of doing it.
            int positives = 0;
            int negatives = 0;
            int zeros = 0;
            for(int i=1; i<6; i++)
            {
               double temp= getValue(i);
                if (temp > 0)
                {
                    positives++;
                }else if (temp < 0)
                {
                    negatives++;
                }else
                {
                    zeros++;
                }
            }
            Console.WriteLine("Positives: " + positives + "\nNegatives: " + negatives + "\nZeros: " + zeros);
            Console.WriteLine("Press [enter] to continue");
            Console.ReadLine();
        }
        static double getValue(int currentValue)
        {
            Console.Write("Enter the " + intToText(currentValue) + " Number:");
            string read = Console.ReadLine();
            try{
                return Convert.ToDouble(read);
            }catch(System.FormatException e) {//Just to try to prevent a crash.


                Console.WriteLine("Please enter in a number.");
                return getValue(currentValue);//Oh How I love recursion
            }
        }
        static string intToText(int integer)//I wanted it to look pretty ... 
        {
            switch (integer){
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
