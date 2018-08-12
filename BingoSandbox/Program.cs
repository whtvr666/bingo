using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bingo.Logic;

namespace BingoSandbox
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> listOfPlayingLetters = new List<string>();

			Core core = new Core();

			var playableB = core.PlayableB;
			var playableI = core.PlayableI;
			var playableN = core.PlayableN;
			var playableG = core.PlayableG;
			var playableO = core.PlayableO;

			listOfPlayingLetters.AddRange(playableB);
			listOfPlayingLetters.AddRange(playableI);
			listOfPlayingLetters.AddRange(playableN);
			listOfPlayingLetters.AddRange(playableG);
			listOfPlayingLetters.AddRange(playableO);


			
		}

		
	}
}
