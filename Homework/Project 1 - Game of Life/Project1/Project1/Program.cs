using System;
using System.Threading;
using System.Security.Cryptography;
namespace Project1
{
	class MainClass
	{
		static conwayCell[,] cells;
		public static void Main(string[] args)
		{
            cells = conwayCell.initCells(80,24);
            for(int i=0; i<1000; i++)
            {
                Console.WriteLine(conwayCell.writeArray(ref cells));
                Console.Write("Generation {0}, Current Population: {1}/{2}",i+1, conwayCell.currentPopulation(ref cells),cells.Length);
                Thread.Sleep(35);
                conwayCell.step(ref cells);
                Console.Clear();
            }
		}
        public static int checksum(string toCheck)
        {
            int returner=0;

            return returner;
        }
	}
}
