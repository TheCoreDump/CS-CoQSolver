using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;

namespace CoQSolver
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void ProcessButton_Click(object sender, EventArgs e)
		{
			Dictionary<string, List<string>> Patterns = GetWords("Dictionary.dat");

			Solver tmpSolver = new Solver(SourceTextBox.Text, Patterns);
			List<Mapping> Mappings = tmpSolver.Solve();

			OutputMappings(SourceTextBox.Text, Mappings);
			return;

			List<Word> Words = tmpSolver.GetWords();
			Words.Sort((x, y) => x.Possibilities.Count.CompareTo(y.Possibilities.Count));

			using (FileStream FS = new FileStream("C:\\Solver\\CoQOutput.txt", FileMode.Create, FileAccess.Write))
			{
				using (StreamWriter SW = new StreamWriter(FS))
				{
					foreach (Word tmpWord in Words)
					{
						SW.WriteLine("Text: {0}", tmpWord.Text);
						SW.WriteLine("Mask: {0}", tmpWord.Mask);

						foreach (KeyValuePair<string, Mapping> tmpPossibility in tmpWord.Possibilities)
							SW.WriteLine("Possibility: {0}{2}\t\tMapping: {1}{2}", tmpPossibility.Key, tmpPossibility.Value.ToString(), Environment.NewLine);

						SW.WriteLine();
					}
				}
			}
		}


		public void OutputMappings(string source, List<Mapping> mappings)
		{
			/*
			using (FileStream FS = new FileStream("C:\\Solver\\FinalOutput.txt", FileMode.Create, FileAccess.Write))
			{
				using (StreamWriter SW = new StreamWriter(FS))
				{
					foreach (Mapping tmpMapping in mappings)
					{
						SW.WriteLine("{0}{2}\t\tMapping: {1}", tmpMapping.Replace(source), tmpMapping.ToString(), Environment.NewLine);
					}
				}
			}
			 */

			StringWriter SW = new StringWriter();

			foreach (Mapping tmpMapping in mappings)
			{
				SW.WriteLine("{0}{2}\t\tMapping: {1}", tmpMapping.Replace(source), tmpMapping.ToString(), Environment.NewLine);
			}

			TargetTextBox.Text = SW.ToString();
		}

		public Dictionary<string, List<string>> GetWords(string FileName)
		{
			BinaryFormatter BF = new BinaryFormatter();

			using (FileStream FS = new FileStream(FileName, FileMode.Open, FileAccess.Read))
			{
				return (Dictionary<string, List<string>>)BF.Deserialize(FS);
			}
		}
	}
}
