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
			IntegerSet a = new IntegerSet();
			IntegerSet b = new IntegerSet();
			a.insertElement(2);
			a.insertElement(3);
			a.insertElement(5);
			b.insertElement(1);
			b.insertElement(3);
			b.insertElement(7);
			Console.WriteLine("A: {0}", a);
			Console.WriteLine("B: {0}", b);
			Console.WriteLine("A ∪ B: {0}", a.Union(b));
			Console.WriteLine("A ∩ B: {0}", a.Intersection(b));
			Console.WriteLine("A \\ B: {0}", a.SetDifference(b));
			Console.WriteLine("B \\ A: {0}", b.SetDifference(a));
			Console.WriteLine("A △ B: {0}", a.SymmetricDifference(b));
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
