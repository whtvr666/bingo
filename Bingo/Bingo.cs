using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;
using System.Windows.Forms;
using Bingo.Logic;
using System.Speech;
using System.Speech.Synthesis;

namespace Bingo
{
	public partial class Bingo : Form
	{
		private readonly Core _core;
		private readonly SpeechSynthesizer _synth;

		public Bingo()
		{
			InitializeComponent();
			_core = new Core();
			_synth = new SpeechSynthesizer();
			List<string> letters = new List<string> { "B", "I", "N", "G", "O" };
			Button[] buttons = new Button[30];
			int buttonIndex = 0;

			AddButtonsIntoHeaderRow(letters, ref buttonIndex, ref buttons);
			AddButtonsIntoRows(_core.PlayableB, 0, ref buttonIndex, ref buttons);
			AddButtonsIntoRows(_core.PlayableI, 1, ref buttonIndex, ref buttons);
			AddButtonsIntoRows(_core.PlayableN, 2, ref buttonIndex, ref buttons);
			AddButtonsIntoRows(_core.PlayableG, 3, ref buttonIndex, ref buttons);
			AddButtonsIntoRows(_core.PlayableO, 4, ref buttonIndex, ref buttons);
		}

		private void AddButtonsIntoHeaderRow(List<string> listOfLetters, ref int buttonIndex, ref Button[] buttons)
		{
			for (buttonIndex = 0; buttonIndex < 5; buttonIndex++)
			{
				buttons[buttonIndex] = new Button();
				buttons[buttonIndex].Name = $"btn{listOfLetters[buttonIndex]}";
				buttons[buttonIndex].Text = listOfLetters[buttonIndex];
				buttons[buttonIndex].Enabled = false;
				buttons[buttonIndex].FlatStyle = FlatStyle.System;

				tblBingoBoard.Controls.Add(buttons[buttonIndex], buttonIndex, 0);
			}
		}
		private void AddButtonsIntoRows(List<string> listOfLetters, int tableColumn, ref int buttonIndex, ref Button[] buttons)
		{
			for (int i = 0; i < 5; i++)
			{
				buttons[buttonIndex] = new Button();
				buttons[buttonIndex].Name = $"btn{listOfLetters[i]}";
				buttons[buttonIndex].Text = listOfLetters[i];
				buttons[buttonIndex].FlatStyle = FlatStyle.System;
				buttons[buttonIndex].Click += Daub;

				tblBingoBoard.Controls.Add(buttons[buttonIndex], tableColumn, i + 1);
				buttonIndex++;
			}
		}

		private void Daub(object sender, EventArgs e)
		{
			var button = (Button)sender;
			if (_core.ListOfPlayingLetters.Contains(button.Text))
			{
				button.Enabled = false;
			}
		}

		private void btnStartBingo_Click(object sender, EventArgs e)
		{
			System.Timers.Timer timer = new System.Timers.Timer(3000);

			timer.Elapsed += OnTimedEvent;

			timer.Enabled = true;

			var middleButton = tblBingoBoard.GetControlFromPosition(2, 3) as Button;
			middleButton.Enabled = false;
		}

		private void OnTimedEvent(object source, ElapsedEventArgs e)
		{
			Random rnd = new Random();
			if (_core.ListOfPlayingLetters.Count < 40)
			{
				bool newLetterAdded = false;
				while (!newLetterAdded)
				{
					var randomizedLetter = _core.ListOfAllPossibleLetters.ElementAt(rnd.Next(0, 75));
					if (!_core.ListOfPlayingLetters.Contains(randomizedLetter))
					{
						newLetterAdded = true;
						_core.ListOfPlayingLetters.Add(randomizedLetter);
						tbxList.Invoke((MethodInvoker)delegate
						{
							tbxList.Text = tbxList.Text.Insert(0, randomizedLetter + "\t");
						});

						_synth.Speak(randomizedLetter);
					}
				}
			}
		}
	}
}
