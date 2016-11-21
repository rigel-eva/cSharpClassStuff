using System;
using System.Threading;
using System.Security.Cryptography;
using System.Text;
using System.Collections.Generic;

namespace Project1
{
    class MainClass
    {
        static conwayCell[,] cells;
        static List<int> checksums;
        public enum endState { maxTicks,checksumFailed,noPopulation}
        public static void Main(string[] args)
        {
            checksums = new List<int>();
            cells = conwayCell.initCells(80, 24);
            //Example on how to load in a custom board from a text file
            //cells = conwayCell.initCells(testCaseLoader.load("I:\\User Data\\Sir Rigel\\Documents\\Programing\\C#\\cSharpClassStuff\\Homework\\Project 1 - Game of Life\\Project1\\glider.txt"));
            switch (runSim(cells, 6000))
            {
                case endState.maxTicks:
                    Console.WriteLine("Done! Max Ticks Reached");
                    break;
                case endState.noPopulation:
                    Console.WriteLine("Done! No population left.");
                    break;
                case endState.checksumFailed:
                    Console.WriteLine("Done! Two states were the same.");
                    break;
            }
        }
        public static int checksum(string toCheck)//Why checksums? ... because it's faster than checking the entire string.
        {
            int returner = 0;
            var md5 = MD5.Create();
            var data = Encoding.Unicode.GetBytes(toCheck);
            var md5Hash = md5.ComputeHash(data);
            returner = BitConverter.ToInt32(md5Hash, 0);
            return returner;
        }
        public static endState runSim(conwayCell[,] cells, int ticksToRun, int millsecBetweenTicks=100, bool color=false, bool descriptive=true)
        {
            int currentChecksum = checksum(conwayCell.writeArray(ref cells));
            int i = 0;
            int infoPos = cells.GetLength(0);
            for (; i < ticksToRun && !checksums.Contains(currentChecksum) && conwayCell.currentPopulation(ref cells) > 0; i++)
            {
                Console.Clear();
                checksums.Add(currentChecksum);
                if (color)
                {
                    conwayCell.drawArray(ref cells, descriptive);
                }
                else
                {
                    Console.WriteLine(conwayCell.writeArray(ref cells, descriptive));
                }
                Console.SetCursorPosition(0, infoPos);
                Console.Write("Generation {0}/{1}, Current Population: {2}/{3}\n", i + 1, ticksToRun, conwayCell.currentPopulation(ref cells), cells.Length);
                Thread.Sleep(millsecBetweenTicks);
                conwayCell.step(ref cells);
                currentChecksum = checksum(conwayCell.writeArray(ref cells));
            }
            if (i == ticksToRun)
            {
                return endState.maxTicks;
            }
            else if (conwayCell.currentPopulation(ref cells) > 0)
            {
                return endState.checksumFailed;
            }
            else
            {
                return endState.noPopulation;
            }
        }
    }
}
