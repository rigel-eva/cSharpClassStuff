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
			if (yN("Print list?"))
			{
				for (int i = 0; i < j; i++)
				{
					Console.WriteLine(validWords[i]);
				}
			}
			Console.WriteLine(solve(validWords, testString));
		}
		static bool yN(string text)
		{
			Console.Write(text + ": ");
			string test = Console.ReadLine();
			if (test.ToLower()[0] == 'y')
			{
				return true;
			}
			else if (test.ToLower()[0] == 'n')
			{
				return false;
			}
			else {
				return yN(text);
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
			for (int i = 0; i < testeeString.Length; i++)
			{
				if (!testString.Contains(testeeString[i].ToString()))
				{
					return true;
				}
			}
			return false;//Well we can't eliminate it ... shoot.
		}
		static bool validSentince(string toCheck, string test)
		{
			string testee;
			{
				char[] testChar = toCheck.ToCharArray();
				Array.Sort(testChar);
				testee = testChar.ToString();
			}
			return test.Equals(testee);
		}
		static string solve(List<string> input, string testString)
		{
			List<string> twoCharacter, threeCharacter, fourCharacter, fiveCharacter, sixCharacter;
			twoCharacter = new List<string>();
			threeCharacter= new List<string>();
			fourCharacter= new List<string>();
			fiveCharacter= new List<string>();
			sixCharacter= new List<string>();
			foreach (string inset in input)
			{
				switch (inset.Length)
				{
					case 2:
						twoCharacter.Add(inset);
						break;
					case 3:
						threeCharacter.Add(inset);
						break;
					case 4:
						fourCharacter.Add(inset);
						break;
					case 5:
						fiveCharacter.Add(inset);
						break;
					case 6:
						sixCharacter.Add(inset);
						break;

				}
			}
				foreach (string a in threeCharacter)
				{
					foreach (string b in fiveCharacter)
					{
						foreach (string c in fiveCharacter)
						{
							foreach (string d in sixCharacter)
							{
								foreach (string e in fiveCharacter)
								{
									foreach (string f in twoCharacter)
									{
										foreach (string g in twoCharacter)
										{
											foreach (string h in fiveCharacter)
											{
												string test = a + b + c + d + e + f + g + h;
												if (validSentince(test, testString))
												{
													return a +" "+ b +" " + c +" " + d +" " + e +" " + f +" " + g +" " + h;
												}
											}
										}
									}
								}
							}
						}
					}
				}
			return "nope";
		}
	}
}
