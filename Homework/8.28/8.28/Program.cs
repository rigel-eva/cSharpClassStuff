using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _8._28
{
    class Program
    {

        static Random rng = new Random();
        static void Main(string[] args)
        {
            race();
        }
        enum Move{Sleep=0,BigHop=9,BigSlip=12,SmallHop=1,SmallSlip=-2,FastPlod=3,Slip=-6,SlowPlod=1}//Yeah it's a bit lazy, but it will work in readablity
        static Move tortoiseMove()
        {
            int move = rng.Next(0,9);
            switch (move)
            {
                case 0:
                case 1:
                    return Move.Slip;
                case 2:
                case 3:
                case 4:
                    return Move.SlowPlod;
                default:
                    return Move.FastPlod;
            }
        }
        static Move hareMove()
        {
            int move = rng.Next(0, 9);
            switch (move)
            {
                case 0:
                    return Move.BigSlip;
                case 1:
                case 2:
                    return Move.Sleep;
                case 3:
                case 4:
                    return Move.SmallSlip;
                case 5:
                case 6:
                    return Move.BigHop;
                default:
                    return Move.SmallHop;
            }
        }
        static void race()
        {
            string[] message = { "ON YOUR MARK, GET SET", "BANG!!!!!", "AND THEY'RE OFF!!!" };
            int hareLoc = 0;
            int tortLoc = 0;
            for(int i=0; i<3; i++)
            {
                Console.WriteLine(message[i]);
                Console.ReadKey();
            }
            do
            {
                Console.Clear();
                Console.SetCursorPosition(hareLoc, 0);
                Console.Write("🐰");//Trying to be a bit cheeky with the emojis ...
                Console.SetCursorPosition(tortLoc, 1);
                Console.Write("🐢");
                Console.SetCursorPosition(69, 0);
                Console.Write("│");
                Console.SetCursorPosition(69, 1);
                Console.Write("|");
                tortLoc += (int)tortoiseMove();
                hareLoc += (int)hareMove();
                if (tortLoc < 0)
                {
                    tortLoc = 0;
                }
                if (hareLoc < 0)
                {
                    hareLoc = 0;
                }
                Thread.Sleep(1000);//Sleep for 1 sec.
            } while (hareLoc < 69 || tortLoc < 69);
        }
    }
}
