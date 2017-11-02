using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace FileBuilder
{
	public class Combiner
	{

		public static void Combine(string[] args)
		{
			Dictionary<string, object> Words = new Dictionary<string, object>();

			for (int index = 1; index < args.Length; index++)
			{
				using (StreamReader SR = new StreamReader(args[index]))
				{
					string tmpWord = null;

					while (null != (tmpWord = SR.ReadLine()))
					{
						if (!Words.ContainsKey(tmpWord.ToLower()))
							Words.Add(tmpWord.ToLower(), null);
					}
				}
			}

			List<string> WordList = new List<string>();

			foreach (string tmpKey in Words.Keys)
				WordList.Add(tmpKey);

			WordList.Sort((x, y) => string.Compare(x, y));
			WordList.Sort((x, y) => x.Length.CompareTo(y.Length));

			using (FileStream FS = new FileStream(args[0], FileMode.Create, FileAccess.Write))
			{
				using (StreamWriter SW = new StreamWriter(FS))
				{
					foreach (string tmpWord in WordList)
						SW.WriteLine(tmpWord);
				}
			}
		}
	}
}
