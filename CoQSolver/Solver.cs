using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using CoQSolver.Utility;

namespace CoQSolver
{
	public class Solver
	{

		private static Regex Whitespace = new Regex("\\s+", RegexOptions.Compiled);
		private Dictionary<string, List<string>> Patterns = null;

		public Solver(string source, Dictionary<string, List<string>> patterns)
		{
			Source = source.ToLower();
			Patterns = patterns;
		}

		public string Source { get; set; }

		public List<Word> GetWords()
		{
			string[] Parts = Whitespace.Split(Source);
			List<Word> Words = new List<Word>();

			foreach (string tmpPart in Parts)
			{
				if (tmpPart.Length > 0)
					Words.Add(new Word(tmpPart, Patterns));
			}

			return Words;
		}

		public List<Mapping> Solve()
		{
			List<Word> Words = GetWords();
			Words.Sort((x, y) => x.Possibilities.Count.CompareTo(y.Possibilities.Count));

			List<Mapping> AllowableMappings = new List<Mapping>();

			foreach (KeyValuePair<string, Mapping> item0 in Words[0].Possibilities)
			{
				foreach (KeyValuePair<string, Mapping> item1 in Words[1].Possibilities)
				{
					Mapping tmpMapping = Mapping.AttemptMerge(item0.Value, item1.Value);

					if ((tmpMapping != null) && (!Mapping.Contains(tmpMapping, AllowableMappings)))
						AllowableMappings.Add(tmpMapping);
				}
			}

			for (int i = 2; i < Words.Count; i++)
			{
				List<Mapping> tmpAllowableMappings = CheckMappings(Words[i], AllowableMappings);

				if (tmpAllowableMappings.Count > 0)
					AllowableMappings = tmpAllowableMappings;
			}

			return AllowableMappings;
		}

		public List<Mapping> CheckMappings(Word word, List<Mapping> currentMappings)
		{
			List<Mapping> Result = new List<Mapping>();

			foreach (Mapping tmpMapping in currentMappings)
			{
				foreach (KeyValuePair<string, Mapping> itemX in word.Possibilities)
				{
					Mapping tmpMerge = Mapping.AttemptMerge(tmpMapping, itemX.Value);

					if ((tmpMerge != null) && (!Mapping.Contains(tmpMapping, Result)))
						Result.Add(tmpMerge);
				}
			}

			return Result;
		}
	}
}
