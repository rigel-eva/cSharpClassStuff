using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(box(getInput("Width"), getInput("Height")));

        }
        static int getInput(string prompt)
        {
            int returner;
            string input;
            Console.Write(prompt + ": ");
            input = Console.ReadLine();
            if(int.TryParse(input,out returner))
            {
                return returner;
            }
            else
            {
                Console.WriteLine("Please enter an integer.");
                return getInput(prompt);
            }
        }
        static string box(int width, int height,char character='*')//Well, might as well make a function for this ...
        {
            string returner = "";

            returner += line(width, true,character);
            for(int i=0; i<height-2; i++)
            {
                returner += line(width, false,character);
            }
            returner += line(width, true,character);
            return returner;
        }
        static string line(int width, bool solid = false, char character='*')//And I want my code as dry as possible, so helper functions to the rescue!.
        {
            string returner = "*";
            for(int i=0;i<width-2; i++)
            {
                if (solid)
                {
                    returner += "*";
                }
                else
                {
                    returner += " ";
                }
            }
            returner += "*\n";
            return returner;
        }
    }
}
