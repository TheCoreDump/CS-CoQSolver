using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoQSolver
{
	public class Mapping
	{

		private Dictionary<char, char> map = new Dictionary<char, char>();

		public Mapping(string encrypted, string unencrypted)
		{
			for (int index = 0; index < encrypted.Length; index++)
			{
				char e = encrypted.ToCharArray()[index];
				char u = unencrypted.ToCharArray()[index];

				if (!map.ContainsKey(e))
					map.Add(e, u);
			}
		}

		private Mapping()
		{
		}

		public override string ToString()
		{
			string Result = "";

			foreach (KeyValuePair<char, char> tmpMapping in map)
			{
				Result += Result.Length == 0 ? "" : " ";
				Result += string.Format("{0}={1}", tmpMapping.Key, tmpMapping.Value);
			}

			return Result;
		}

		public static Mapping AttemptMerge(Mapping a, Mapping b)
		{
			Mapping Result = new Mapping();

			foreach (KeyValuePair<char, char> item in a.map)
			{
				if ((b.map.ContainsKey(item.Key)) && (b.map[item.Key] != item.Value))
					return null;

				Result.map.Add(item.Key, item.Value);
			}

			foreach (KeyValuePair<char, char> item in b.map)
			{
				if ((a.map.ContainsKey(item.Key)) && (a.map[item.Key] != item.Value))
					return null;

				if (!Result.map.ContainsKey(item.Key))
					Result.map.Add(item.Key, item.Value);
			}

			return Result;			
		}

		public string Replace(string source)
		{
			string Result = "";

			foreach (char c in source.ToLower().ToCharArray())
			{
				if (!map.ContainsKey(c))
					Result += "*";
				else
					Result += map[c];
			}
		
			return Result;
		}

		public static bool Contains(Mapping mapping, List<Mapping> mappingList)
		{
			foreach (Mapping tmpMapping in mappingList)
			{
				if (tmpMapping.map.Count == mapping.map.Count)
				{
					bool found = true;

					foreach (KeyValuePair<char, char> item in mapping.map)
					{
						if (!tmpMapping.map.ContainsKey(item.Key))
							found = false;
						else if (tmpMapping.map[item.Key] != item.Value)
							found = false;
					}

					foreach (KeyValuePair<char, char> item in tmpMapping.map)
					{
						if (!mapping.map.ContainsKey(item.Key))
							found = false;
						else if (mapping.map[item.Key] != item.Value)
							found = false;
					}

					if (found)
						return true;
				}
			}

			return false;
		}
	}
}
