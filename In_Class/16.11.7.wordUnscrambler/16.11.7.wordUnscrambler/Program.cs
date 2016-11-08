using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApplication1
{
	class Program
	{
		static List<string> wordList = new List<string>();
		static string[] wordArray = new string[109583];
		const string testString = "bcghlllmppprrrssssstttyyyyyyyyyyy";
		const string allowedLetterList = "bcghlmprsty";
		static void Main(string[] args)
		{
			LoadDataFromFile("wordsEn.txt");
			// wordList and wordArray are now both initialized and ready for use
			List<string> validWords = new List<string>();
			int j = 0;
			for (int i = 0; i < 109583; i++)
			{
				if (!eliminate(allowedLetterList, wordArray[i]))
				{
					validWords.Add(wordArray[i]);
					j++;
				}
			}
			Console.WriteLine("Narrowed word list from " + 109583 + " to: " + j);
			for (int i = 0; i < j; i++)
			{
				Console.WriteLine(validWords[i]);
			}
		}

		static void LoadDataFromFile(string filename)
		{
			int index = 0;
			try
			{
				StreamReader sr = new StreamReader(filename);
				while (sr.EndOfStream == false)
				{
					string line = sr.ReadLine();
					wordList.Add(line);
					wordArray[index++] = line;
				}
			}

			catch (IndexOutOfRangeException e)
			{
				Console.WriteLine("Index out of range...  Index " + index);
			}

			catch (Exception e)
			{
				Console.WriteLine("The file could not be read:" + e.Message);
			}
		}
		static bool eliminate(string testString, string testeeString)
		{
			for (int i = 0; i < testeeString.Length-1; i++)
			{
				bool inSet = false;//We are just going to assume that the letter isn't in the set, will be quicker; 
				for (int j = 0; j < testString.Length-1; j++)
				{
					inSet = (testString[j] == testeeString[i])||inSet;	
				}
				if (!inSet)//Oh this character isn't in the set,
				{
					return true;//cool, let's go ahead and just eliminate the entire word.
				}
			}
			return false;//Well we can't eliminate it ... shoot.
		}
			
	}
}