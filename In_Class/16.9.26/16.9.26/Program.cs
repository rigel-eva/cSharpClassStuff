using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._9._26
{
    class Program
    {
        static void Main(string[] args)
        {
            //for(;;);//Infinite loop ... that unfortunatly compiles, and doesn't run right ...
            for(int i =88; i>=7; i -= 7)
            {
                Console.WriteLine(i);
            }
        }
        static void menuFunction()
        {
            Console.WriteLine("1: Something\n" +
                              "2: Something\n" +
                              "3: Something\n" +
                              "4: Something");
            int entryValue = 0;
            while (entryValue < 1 || entryValue > 4)
            {
                Console.Write("?> ");
                string input = Console.ReadLine();
                int.TryParse(input, out entryValue);
            }
        }
        static void scoreCalc0()
        {
            int total = 0;
            const int NUMBER_OF_SCORES = 5;
            int studentNumber = 1;
            //input
            while (studentNumber <= NUMBER_OF_SCORES)
            {
                Console.Write("Enter Score " + studentNumber + ": ");
                int value;
                if (!int.TryParse(Console.ReadLine(), out value))
                {
                    Console.WriteLine("Please enter a valid Number.");
                    continue;//Loop back to start.
                }
                //Calculations
                total += value;
                studentNumber++;
            }
            //Output
            Console.WriteLine("Average Score: " + (double)total / NUMBER_OF_SCORES);
        }
        static double scoreCalc1()
        {
            int total = 0;
            int studentNumber = 0;
            int input = 0;
            string sInput = "";
            Console.WriteLine("Enter garbage to quit");
            do
            {
                studentNumber++;
                total += input;
                Console.Write("Enter Score for Student" + studentNumber + ": ");
                sInput = Console.ReadLine();
            } while (int.TryParse(sInput, out input));
            studentNumber--;
            if (studentNumber > 0)
            {
                Console.WriteLine("Average Score: " + (double)total / studentNumber);
                return (double)total / studentNumber;
            }
            else
            {
                Console.WriteLine("No Data Entered.");
                return -1;
            }
        }
    }
}
