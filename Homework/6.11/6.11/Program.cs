using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._11
{
    //So Blackboard gave me this problem twice ... I'm pretty sure that wasn't intentional ... but I'll write this one twice just to be safe.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The smallest value inputed was: " + v1());//just switch the function v1 for v2 for the alternate version, with less Math.
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
        static int v1()//The first version I wrote
        {
            int numberOfInputs;
            int smallest = int.MaxValue;
            do
            {
                numberOfInputs = getInput("Please enter the number of values");
                if (numberOfInputs < 1)
                {
                    Console.WriteLine("Please enter a Positive Integer");
                }
            } while (numberOfInputs < 1);
            for (int i = numberOfInputs - 1; i > 0; i--)
            {
                smallest = Math.Min(smallest, getInput("Please enter an Integer"));
            }
            return smallest;
        }
        static int v2()
        {
            int numberOfInputs;
            int input;
            int smallest=int.MaxValue;
            do
            {
                numberOfInputs = getInput("Please enter the number of values");
                if (numberOfInputs < 1)
                {
                    Console.WriteLine("Please enter a Positive Integer");
                }
            } while (numberOfInputs < 1);
            for(int i=0; i<numberOfInputs; i++)
            {
                input = getInput("Please enter value " + (i+1));
                if (input < smallest)
                {
                    smallest = input;
                }   
            }
            return smallest;
        }
    }
}
