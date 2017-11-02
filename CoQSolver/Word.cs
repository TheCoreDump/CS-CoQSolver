using System;
using System.Collections.Generic;
using CoQSolver.Utility;

namespace CoQSolver
{
	public class Word
	{
		public Word(string text, Dictionary<string, List<string>> words)
		{
			Text = text;
			Mask = CoQUtility.GetMask(text);
			Possibilities = new Dictionary<string, Mapping>();

			if (!words.ContainsKey(Mask))
				throw new ApplicationException(string.Format("Unable to find Mask: {0}", Mask));

			foreach (string tmpWord in words[Mask])
				Possibilities.Add(tmpWord, new Mapping(text, tmpWord));
		}

		public string Text { get; set; }

		public string Mask { get; set; }

		public Dictionary<string, Mapping> Possibilities { get; set; }
		
	}
}
