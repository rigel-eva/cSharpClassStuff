using System;
namespace Application
{
	public class IntegerSet
	{
		const int maxValue= 255;
		private bool[] values = new bool[maxValue+1];
		public IntegerSet()
		{
			//Nothing here ... we don't need anything weird to set it to false.
		}
		public bool inSet(int value)
		{
			try
			{
				return values[value];
			}
			catch (Exception)
			{
				return false;//Makes sense to fail quietly here, it's obviously not in the set.
			}
		}
		public void insertElement(int value)
		{
			try
			{
				values[value] = true;
			}
			catch (Exception e)
			{
				throw e;//However this makes sense to fail LOUDLY.
			}
		}
		public void DeleteElement(int value)
		{
			try
			{
				values[value] = false;
			}
			catch (Exception e)
			{
				throw e;//Once again pass it up to the person who is writing the code for this ...
			}
		}
		public override string ToString()
		{
			string returner = "{ ";
			bool addCommas = false;
			for (int i = 0; i < values.Length; i++)
			{
				if (this.inSet(i))
				{
					if (addCommas)
					{
						returner += ", ";
					}
					returner += i + " ";
					addCommas = true;
				}
			}
			if (returner.Equals("{ "))
			{
				returner = "{ EMPTY }";
			}
			else 
			{
				returner += "}";
			}
			return returner;
		}
		public bool isEqualTo(IntegerSet toTest)
		{
			bool returner = true;
			for (int i = 0; returner && i < values.Length; i++)
			{
				returner = returner && (this.values[i] == toTest.values[i]);
			}
			return returner;
		}
		public IntegerSet Union(IntegerSet B)//this ∪ B
		{
			IntegerSet returner=new IntegerSet();
			for (int i = 0; i < values.Length; i++)
			{
				returner.values[i] = this.values[i] || B.values[i];//Lazy, but works.
			}
			return returner;
		}
		public IntegerSet Intersection(IntegerSet B)//this ∩ B
		{
			IntegerSet returner = new IntegerSet();
			for (int i = 0; i < values.Length; i++)
			{
				returner.values[i] = this.values[i] && B.values[i];//Lazy, but works.
			}
			return returner;
		}
		public IntegerSet SetDifference(IntegerSet B)//this \ B
		{
			IntegerSet returner = new IntegerSet();
			for (int i = 0; i < values.Length; i++)
			{
				returner.values[i] = this.values[i] && !B.values[i];
			}
			return returner;
		}
		public IntegerSet SymmetricDifference(IntegerSet B)//this △ B
		{
			IntegerSet returner = new IntegerSet();
			returner = this.Union(B).SetDifference(this.Intersection(B));//Eh, it works ...
			return returner;
		}
	}
}
