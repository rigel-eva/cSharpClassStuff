using System;

namespace Application
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int test;
			Console.Write("Enter a number to divide 32 by ...\n>");
			if (int.TryParse(Console.ReadLine(), out test))
			{
				try
				{
					test = 32 / test;
				}
				catch (DivideByZeroException e)
				{
					Console.WriteLine("Um ... are you sure you want to do that?");
					Console.WriteLine(e.InnerException.Message);
				}
				finally
				{
					//Stuff in here will get executed wether or not the try succeeds, like closing files.
					Console.WriteLine("And this is going to be printed no matter what!");
				}
				/*using (String boop= new String())
				{
					//Equivilant of try / finally
				}*/
			}
		}
	}
}
