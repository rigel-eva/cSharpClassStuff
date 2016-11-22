using System;
using System.Collections.Generic;
namespace Application
{
	public abstract class quizQuestion
	{
		#region variables
		private string _question;
		#endregion
		#region properties
		public string question
		{
			get
			{
				return _question;
			}
			protected set
			{
				_question = value;
			}
		}
		#endregion
		#region constructors
		public quizQuestion()
		{
		}
		public quizQuestion(string question)
		{
			this.question = question;
		}
		#endregion
		#region abstract methods
		public abstract bool checkAnswer(object toCheck);
		public abstract bool getAnswerFromUser();
		#endregion
		#region methods
		public override string ToString()
		{
			return question;
		}
		protected static string genBar()
		{
			string bar = "";
			for (int i = 0; i < Console.WindowWidth; i++)
			{
				bar += "-";
			}
			return bar;
		}
		#endregion
	}
	public class trueFalseQuizQustion : quizQuestion
	{
		#region variables
		private bool _answer;
		#endregion
		#region properties
		public bool answer
		{
			get
			{
				return _answer;
			}
			protected set
			{
				_answer = value;
			}
		}
		#endregion
		#region constructors
		public trueFalseQuizQustion(string question, bool answer) : base(question)
		{
			this.answer = answer;
		}
		#endregion
		#region unabstracted methods
		public override bool checkAnswer(object toCheck)
		{
			return toCheck.Equals(answer);
		}
		public override bool getAnswerFromUser()
		{
			string input="";
			do
			{
				Console.Write("{0}\n{1}\nT/F: ");
				input = Console.ReadLine().ToLower();
			} while (input[0] != 'y' || input[0] != 'n');
			return checkAnswer(input[0] == 'y');
		}
		#endregion
	}
	public class multipuleChoiseQuizQuestion : quizQuestion
	{
		#region varaibles
		private int _answer;
		private string[] _possibleAnswers;
		#endregion
		#region properties
		public int answer
		{
			get
			{
				return _answer;
			}
			protected set
			{
				_answer = value;
			}
		}
		public string[] possibleAnswers
		{
			get
			{
				return _possibleAnswers;
			}
			protected set
			{
				_possibleAnswers = value;
			}
		}
		#endregion
		#region constructors
		public multipuleChoiseQuizQuestion(string question, int answer) : base(question)
		{
			this.answer = answer;
		}
		#endregion
		#region unabstracted methods
		public override bool checkAnswer(object toCheck)
		{
			return toCheck.Equals(answer);
		}
		public override bool getAnswerFromUser()
		{
			int choice;
			string input;
			do
			{
				Console.Clear();
				Console.WriteLine("{0}\n{1}", question, genBar());
				for (int i = 0; i < possibleAnswers.Length; i++)
				{
					Console.WriteLine("{0}) {1}", i, possibleAnswers[i]);
				}

				Console.Write("Choice (0-{0}: ",possibleAnswers.Length-1);
				input = Console.ReadLine();
			} while (!int.TryParse(input, out choice) && choice >= possibleAnswers.Length);
			return checkAnswer(choice);
		}
		#endregion
	}
	public class fillInTheBlankQuizQuestion : quizQuestion
	{
		#region variables
		string[] _answer;
		#endregion
		#region properties
		public string[] answer
		{
			get
			{
				return _answer;
			}
			protected set
			{
				_answer = value;
			}
		}
		#endregion
		#region constructors
		public fillInTheBlankQuizQuestion(string question, string[] answer) : base(question)
		{
			Array.Copy(answer, this.answer, answer.Length);
		}
		public override bool getAnswerFromUser()
		{
			throw new NotImplementedException();
		}
		#endregion
		#region unabstractedmethods
		public override bool checkAnswer(object toCheck)
		{
			return Array.Equals(answer, toCheck);
		}
		public override bool getAnswerFromUser()
		{
			string[] userAnswers = new string[answer.Length];
			Console.WriteLine("{0}\n{1}", question, genBar());
			for (int i = 0; i < answer.Length; i++)
			{
				Console.Write(" 0)");
				userAnswers[i] = Console.ReadLine();
			}
			return checkAnswer(userAnswers);
		}
		#endregion
	}
}
