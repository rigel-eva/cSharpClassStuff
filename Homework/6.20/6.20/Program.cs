using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._20
{
    class Program
    {
        /*Results:
         * one digit of accuracy:        11
         * Two digits of accuracy:      101
         * Three Digits of accuracy:   1001
         * Four Digits of accuracy:   10001
         * Five Digits of accuracy:  100001
         * 
         * Note: Really wanted to use recursion on this one ... 
         * but it turns out I eneded up with a stack overflow 
         * error instead, so I had to go with the for loop. 
         * Also, the weird buisness with the *4 was my attempt 
         * to try to mittigate that error ... didn't really work
         * out that way.
         */
        static void Main(string[] args)
        {
            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine("Number of itterations to get " + i + " Digits of accuracy: " + piAccuracy2(i));
            }
        }
        static int piAccuracy(int accuracy=1)
        {
            double output;
            int terms = 0;
            do
            {
                output = piCalc(++terms);
            }
            while (Math.Floor(output * Math.Pow(10, accuracy)- Math.PI * Math.Pow(10, accuracy))!=0);
            return terms;
        }
        static double piCalc(int terms)
        {
            return 4 * termCalc(terms);//Trying this out to see if this prevents the stack overflow error.   
        }
        static double termCalc(int terms)
        {
            double returner = 0;
            for(int i=0; i<terms; i++)
            {
                returner += (Math.Pow(-1, i) / (1 + i * 2));
            }
            return returner;
        }
        //Wanted to try to write an alternate method
        static int piAccuracy2(int accuracy = 1)
        {
            int returner = 1;
            double accVar = Math.Pow(.1, accuracy);//Freaking floating point errors...
            //We don't care about the first bit; if the Next Value is Less Than our Accuracy Variable, we are done!; otherwise keep stepping
            //for (; (Math.Pow(-1, returner) / (1 + 2 * returner))<accVar; returner++) ;
            double output;
            do
            {
                output = (Math.Pow(-1, returner) / (1 + 2 * returner));
                returner++;
            } while (output < accVar);
            return returner; 
        }
    }
}
