using System;
using System.Text;

namespace HomePractice
{
	public class Combination
	{
		public Combination ()
		{
		}

		private StringBuilder builder = new StringBuilder();
		private string inputString;
		public Combination(string str)
		{
			inputString = str;
			Console.WriteLine("INput string is-:{0}", inputString);
		}

		public void Combine()
		{
			Combine(0);
		}

		public void Combine(int start)
		{
			for(int i = start; i < inputString.Length; i++ )
			{
				builder.Append(inputString[i]);
				Console.WriteLine(builder);
				if(i<inputString.Length)
				{
					Combine(i + 1); 
				}
				builder.Length = builder.Length - 1;
			}

		}
	}
}

