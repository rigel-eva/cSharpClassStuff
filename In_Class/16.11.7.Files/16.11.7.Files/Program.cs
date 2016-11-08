using System;
using System.IO;
namespace Files
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			try
			{
				using (StreamWriter stream = new StreamWriter("numbers.txt"))
				{
					for (int i = 1; i < 101; i++)
					{
						stream.Write(i+"\n");
					}
				}
				using (StreamReader stream = new StreamReader("numbers.txt"))
				{
					string name = stream.ReadLine();
					Console.WriteLine(name);
				}
			}
			catch (Exception e)
			{
				Console.WriteLine("Something is amiss...: \n "+e.ToString());
			}
		}
	}
}
