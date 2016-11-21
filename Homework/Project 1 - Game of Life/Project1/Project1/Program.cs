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
		public static void Main(string[] args)
		{
            checksums = new List<int>();
            cells = conwayCell.initCells(80,24);
            int currentChecksum = checksum(conwayCell.writeArray(ref cells));
            for (int i=0; i<1000&&!checksums.Contains(currentChecksum)&&conwayCell.currentPopulation(ref cells)>0; i++)
            {
                checksums.Add(currentChecksum);
                Console.WriteLine(conwayCell.writeArray(ref cells));
                Console.Write("Generation {0}, Current Population: {1}/{2}",i+1, conwayCell.currentPopulation(ref cells),cells.Length);
                Thread.Sleep(35);
                conwayCell.step(ref cells);
                Console.Clear();
                currentChecksum = checksum(conwayCell.writeArray(ref cells));
            }
		}
        public static int checksum(string toCheck)//Why checksums? ... because it's faster than checking the entire string.
        {
            int returner=0;
            var md5 = MD5.Create();
            var data = Encoding.Unicode.GetBytes(toCheck);
            var md5Hash = md5.ComputeHash(data);
            returner = BitConverter.ToInt32(md5Hash,0);
            return returner;
        }
	}
}
