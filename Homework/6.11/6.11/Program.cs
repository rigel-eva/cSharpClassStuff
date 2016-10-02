using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._11
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfInputs;
            int smallest=int.MaxValue;
            do
            {
                numberOfInputs = getInput("Please enter the number of values");
                if (numberOfInputs < 1)
                {
                    Console.WriteLine("Please enter a Positive Integer");
                }
            } while (numberOfInputs < 1);
            for(int i= numberOfInputs-1; i>0; i--)
            {
                smallest = Math.Min(smallest, getInput("Please enter an Integer"));
            }
            Console.WriteLine("The smallest value inputed was: " + smallest);
        }
        static int getInput(string prompt)
        {
            int returner;
            string input;
            Console.Write(prompt + ": ");
            input = Console.ReadLine();
            if (int.TryParse(input, out returner))
            {
                return returner;
            }
            else
            {
                Console.WriteLine("Please enter an integer.");
                return getInput(prompt);
            }
        }
    }
}
