using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _8._21
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] commands = { "2", "5,12", "3", "5,12", "3", "5,12", "3", "5,12", "1", "6", "9" };
            turtle(commands);

        }
        struct Point
        {
            public int x, y;
            public Point(int _x,int  _y)
            {
                x = _x;
                y = _y;
            }
        }
        enum Direction {North,East,South,West}
        static void turtle(string[] commands)
        {
            bool[,] floor=new bool[20,20];//x,y
            Point turtleLoc = new Point(0, 0);//Where our turtle is at
            bool write = false; //wether we are writing to the array
            Direction direction = Direction.South;
            for(int i=0; i<20; i++)
            {
                for(int j=0; j<20; j++)
                {
                    floor[i, j] = false;
                }
            }
            for(int comm=0; comm<commands.Length; comm++)
            {
                switch (commands[comm][0])
                {
                    case '1'://pen up
                        write = false;
                        break;
                    case '2'://pen down 
                        write = true;
                        break;
                    case '3'://rotate counterclockwise
                        if (direction == Direction.North)
                        {
                            direction = Direction.West;
                        }
                        else
                        {
                            direction--;
                        }
                        break;
                    case '4'://rotate clockwise
                        if (direction == Direction.West)
                        {
                            direction = Direction.North;
                        }
                        else
                        {
                            direction++;
                        }
                        break;
                    case '5'://Move and possibly draw (Could have condensed this portion down, but I wanted to have the slightly less looped version)
                        int move = int.Parse(commands[comm].Substring(2))-1;
                        if (write)
                        {
                            Point last = turtleLoc;
                            switch (direction)
                            {
                                case Direction.North:
                                    for(; turtleLoc.y>last.y-move&&turtleLoc.y>0; turtleLoc.y--)
                                    {
                                        floor[turtleLoc.x, turtleLoc.y] = true;
                                    }
                                    break;
                                case Direction.South:
                                    for (; turtleLoc.y < last.y + move; turtleLoc.y++)
                                    {
                                        floor[turtleLoc.x, turtleLoc.y] = true;
                                    }
                                    break;
                                case Direction.East:
                                    for (; turtleLoc.x < last.x + move; turtleLoc.x++)
                                    {
                                        floor[turtleLoc.x, turtleLoc.y] = true;
                                    }
                                    break;
                                case Direction.West:
                                    for (; turtleLoc.x > last.x - move && turtleLoc.x > 0; turtleLoc.x--)
                                    {
                                        floor[turtleLoc.x, turtleLoc.y] = true;
                                    }
                                    break;
                            }
                        }else
                        {
                            switch (direction)
                            {
                                case Direction.North:
                                    turtleLoc.y -= move;
                                    break;
                                case Direction.South:
                                    turtleLoc.y += move;
                                    break;
                                case Direction.East:
                                    turtleLoc.x += move;
                                    break;
                                case Direction.West:
                                    turtleLoc.x -= move;
                                    break;
                            }
                        }
                        break;
                    case '6'://Print the display!
                        for(int i=0; i<20; i++)
                        {
                            for(int j=0; j<20; j++)
                            {
                                Console.SetCursorPosition(i, j);//Man am I happy that computercraft forced me into learning that this was a thing
                                if (floor[i, j])
                                {
                                    Console.Write("█");//Why yes, I will write this array one character at a time
                                }
                            }
                        }
                        break;
                    case '9'://End of Data
                        return;//Just return the damn thing ...
                }
            }
        }
    }
}
