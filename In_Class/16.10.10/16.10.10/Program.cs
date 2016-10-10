using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._10._10
{
    class Program
    {
        enum NAMES
        {
            SNAKE_EYES=2,

        }
        static IComparable Maximum(IComparable  a, IComparable b)//Ok, interfaces are a thing in C# ... now how the hell do I use them ...
        {
            return (a.CompareTo(b)<0) ? a : b;//And here comes the single line ifs ... oh no ...
        }
        static void Main(string[] args)
        {
            Console.Write(3.CompareTo(5));
            Maximum(3,5);
        }
    }
}
