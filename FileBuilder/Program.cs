using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using CoQSolver.Utility;

namespace FileBuilder
{
	public class Program
	{

		private static string SourceChars = "abcdefghijklmnopqrstuvwxyz0123456789";

		static void Main(string[] args)
		{
			//Combiner.Combine(args);
			//return;

			Dictionary<string, List<string>> Items = new Dictionary<string, List<string>>();

			for (int i = 1; i < args.Length; i++)
			{
				using (StreamReader SR = new StreamReader(args[i]))
				{
					string Word = SR.ReadLine();

					while (Word != null)
					{
						Word = Word.ToLower();

						if (!Items.ContainsKey(CoQUtility.GetMask(Word)))
							Items.Add(CoQUtility.GetMask(Word), new List<string>());

						List<string> Words = Items[CoQUtility.GetMask(Word)];

						if (!Words.Contains(Word))
							Words.Add(Word);

						Word = SR.ReadLine();
					}
				}
			}


			List<string> Keys = new List<string>();

			foreach (string tmpKey in Items.Keys)
				Keys.Add(tmpKey);

			Keys.Sort((x, y) => x.Length.CompareTo(y.Length));

			BinaryFormatter BF = new BinaryFormatter();

			using (FileStream FS = new FileStream(args[0], FileMode.Create, FileAccess.Write))
			{
				BF.Serialize(FS, Items);
			}
		}
	}
}
