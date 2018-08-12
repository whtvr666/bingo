using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo.Logic
{
	public class Core
	{
		public readonly List<string> ListOfAllPossibleLetters = new List<string>();
		public readonly List<string> ListOfPlayingLetters = new List<string>();


		public readonly List<string> PossibleB = new List<string> { "B1", "B2", "B3", "B4", "B5", "B6", "B7", "B8", "B9", "B10", "B11", "B12", "B13", "B14", "B15" };
		public readonly List<string> PossibleI = new List<string> { "I16", "I17", "I18", "I19", "I20", "I21", "I22", "I23", "I24", "I25", "I26", "I27", "I28", "I29", "I30" };
		public readonly List<string> PossibleN = new List<string> { "N31", "N32", "N33", "N34", "N35", "N36", "N37", "N38", "N39", "N40", "N41", "N42", "N43", "N44", "N45" };
		public readonly List<string> PossibleG = new List<string> { "G46", "G47", "G48", "G49", "G50", "G51", "G52", "G53", "G54", "G55", "G56", "G57", "G58", "G59", "G60" };
		public readonly List<string> PossibleO = new List<string> { "O61", "O62", "O63", "O64", "O65", "O66", "O67", "O68", "O69", "O70", "O71", "O72", "O73", "O74", "O75" };

		public List<string> PlayableB = new List<string>();
		public List<string> PlayableI = new List<string>();
		public List<string> PlayableN = new List<string>();
		public List<string> PlayableG = new List<string>();
		public List<string> PlayableO = new List<string>();

		public Core()
		{
			ListOfAllPossibleLetters.AddRange(PossibleB);
			ListOfAllPossibleLetters.AddRange(PossibleI);
			ListOfAllPossibleLetters.AddRange(PossibleN);
			ListOfAllPossibleLetters.AddRange(PossibleG);
			ListOfAllPossibleLetters.AddRange(PossibleO);

			FillPlayableB();
			FillPlayableI();
			FillPlayableN();
			FillPlayableG();
			FillPlayableO();

			FillPlayingLetters();
		}

		private void FillPlayingLetters()
		{
			Random rnd = new Random();
			List<int> indexList = new List<int>();

			while (indexList.Count < 40)
			{
				var x = rnd.Next(0, 75);
				if (!indexList.Contains(x))
				{
					indexList.Add(x);
				}
			}

			foreach (int i in indexList)
			{
				ListOfPlayingLetters.Add(ListOfAllPossibleLetters.ElementAt(i));
			}
		}

		private void FillPlayableB()
		{
			Random rnd = new Random();
			List<int> indexList = new List<int>();

			while (indexList.Count < 5)
			{
				var x = rnd.Next(0, 14);
				if (!indexList.Contains(x))
				{
					indexList.Add(x);
				}
			}

			foreach (int i in indexList)
			{
				PlayableB.Add(PossibleB.ElementAt(i));
			}
		}

		private void FillPlayableI()
		{
			Random rnd = new Random();
			List<int> indexList = new List<int>();

			while (indexList.Count < 5)
			{
				var x = rnd.Next(0, 14);
				if (!indexList.Contains(x))
				{
					indexList.Add(x);
				}
			}

			foreach (int i in indexList)
			{
				PlayableI.Add(PossibleI.ElementAt(i));
			}
		}

		private void FillPlayableN()
		{
			Random rnd = new Random();
			List<int> indexList = new List<int>();

			while (indexList.Count < 5)
			{
				var x = rnd.Next(0, 14);
				if (!indexList.Contains(x))
				{
					indexList.Add(x);
				}
			}

			foreach (int i in indexList)
			{
				PlayableN.Add(PossibleN.ElementAt(i));
			}
		}

		private void FillPlayableG()
		{
			Random rnd = new Random();
			List<int> indexList = new List<int>();

			while (indexList.Count < 5)
			{
				var x = rnd.Next(0, 14);
				if (!indexList.Contains(x))
				{
					indexList.Add(x);
				}
			}

			foreach (int i in indexList)
			{
				PlayableG.Add(PossibleG.ElementAt(i));
			}
		}

		private void FillPlayableO()
		{
			Random rnd = new Random();
			List<int> indexList = new List<int>();

			while (indexList.Count < 5)
			{
				var x = rnd.Next(0, 14);
				if (!indexList.Contains(x))
				{
					indexList.Add(x);
				}
			}

			foreach (int i in indexList)
			{
				PlayableO.Add(PossibleO.ElementAt(i));
			}
		}

	}
}
