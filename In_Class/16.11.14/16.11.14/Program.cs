using System;
namespace Application
{
	class MainClass
	{
		private int a;
		private int b;
		void function(int a, int b)
		{
			this.a = a;
			this.b = b;
		}
		public static void Main(string[] args)
		{
			time a = new time();
			Console.WriteLine(a);
			fizzbuzz();
		}
		//bored ... so ... fizzbuzz?
		public static void fizzbuzz()
		{
			for (int i = 1; i < 100; i++)
			{
				if (!(i % 3 == 0 || i % 5 == 0))
				{
					Console.Write(i);
				}
				else 
				{
					if (i % 3 == 0)
					{
						Console.Write("Fizz");
					}
					if (i % 5 == 0)
					{
						Console.Write("Buzz");
					}
				}

			Console.Write(Environment.NewLine);
			}
		}
	}
}
