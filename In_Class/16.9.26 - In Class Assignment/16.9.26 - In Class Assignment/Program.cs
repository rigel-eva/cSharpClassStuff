using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._9._26___In_Class_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Largest of 5: " + getLargest());
            Console.WriteLine("Smallest of 5: " + getSmalest());
        }
        static double getLargest(int numberToGet=5)
        {
            double largest=double.MinValue;
            int i = 0;
            while (i < numberToGet)
            {
                string sIn;
                double input;//Just set it to the lowest possible value of an integer.
                Console.Write("Please enter a double: ");
                sIn = Console.ReadLine();
                if(double.TryParse(sIn, out input))//this is to cover us if we get an invalid value.
                {
                    i++;
                    largest = Math.Max(largest, input);
                }
                else
                {
                    Console.WriteLine("Please enter in a VALID double.");
                }
            }
            return largest;
        }
        static double getSmalest(int numberToGet = 5)
        {
            double largest = double.MaxValue;
            int i = 0;
            while (i < numberToGet)
            {
                string sIn;
                double input;//Just set it to the lowest possible value of an integer.
                Console.Write("Please enter a double: ");
                sIn = Console.ReadLine();
                if (double.TryParse(sIn, out input))//this is to cover us if we get an invalid value.
                {
                    i++;
                    largest = Math.Min(largest, input);
                }
                else
                {
                    Console.WriteLine("Please enter in a VALID double.");
                }
            }
            return largest;
        }
        static void getSmallestTwice(int numberToGet = 5)
        {
            double smallest = double.MaxValue;
            double secondSmallest = double.MaxValue;
            int i = 0;
            while (i < numberToGet)
            {
                string sIn;
                double input;//Just set it to the lowest possible value of an integer.
                Console.Write("Please enter a double: ");
                sIn = Console.ReadLine();
                if (double.TryParse(sIn, out input))//this is to cover us if we get an invalid value.
                {
                    i++;
                    double temp = smallest;
                    smallest = Math.Min(smallest, input);
                    if (input != smallest)
                    {
                        secondSmallest = Math.Min(secondSmallest, input);
                    }
                    else
                    {
                        secondSmallest = Math.Min(secondSmallest, temp);
                    }
                }
                else
                {
                    Console.WriteLine("Please enter in a VALID double.");
                }
            }

        }
    }
}
