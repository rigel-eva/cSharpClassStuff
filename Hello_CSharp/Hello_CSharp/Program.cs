using System;//Oh no ...
using System.Collections.Generic;//So this is how we used libraries in java ... I think (It's been 10 years
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_CSharp
{
    class Program//Oh god, the Java-like begins
    {
        static void Main(string[] args)//I guess we are declaring Functions in very much the same way as Java
        {
            helloWorld();//Well, Ruby/Swift has thourally screwed me up ... we need semicolins, Crap ... also how we run a function
            ifTesting(true);
            ifTesting(false);//Awesome, default options work the same, so this shouldn't be too bad
            ifTesting(false, true);
            fibbonachi(20);
            boopLoop(15);
            Console.Beep();
            Console.ReadKey();//This is annoying, ah well, might as well keep it for now ... though
        }
        static void helloWorld()
        {
            Console.WriteLine("Hello World!");//Well this is pretty interesting ... how to write to console
        }
        static void ifTesting(bool testVar1, bool testVar2=false)//Alright this is how you feed in a single variable
        {
            if (testVar1)//And this is how we do conditional testing
            {
                Console.WriteLine("If you do not bend...you break.");
            }
            else if(testVar2){//And an additional Layer
                Console.WriteLine("I am on Fire, but an extinguisher is not required");
            }else
            {
                Console.WriteLine("Adversity is an opportunity for change.");
            }
        }
        static int fibbonachi(int numToCompute, int count=0, int lastA=1, int lastB=0)
        {
            if (numToCompute == count)
            {
                return lastA;
            }
            int temp = lastA;
            lastA += lastB;
            lastB = temp;
            Console.WriteLine("Count "+count+" : "+lastA);
            return fibbonachi(numToCompute, count + 1, lastA, lastB);
        }
        static void boopLoop(int numOfBoops)
        {
            for(int i=0; i < numOfBoops; i++)
            {
                Console.WriteLine("Boop");
            }
        }
    }
}