using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoQSolver.Utility
{
	public class CoQUtility
	{

		private static string SourceChars = "abcdefghijklmnopqrstuvwxyz0123456789";

		public static string GetMask(string word)
		{
			Dictionary<string, string> UsedLetters = new Dictionary<string, string>();
			int NextNum = 0;
			string Result = "";

			for (int i = 0; i < word.Length; i++)
			{
				string ch = word.Substring(i, 1).ToLower();

				if (ch == "'")
				{
					Result += ch;
				}
				else
				{
					string patternChar = SourceChars.Substring(NextNum, 1);

					if (!UsedLetters.ContainsKey(ch))
					{
						UsedLetters.Add(ch, patternChar);
						NextNum++;
					}

					Result += UsedLetters[ch];
				}
			}

			return Result;
		}
	}
}
