using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;
using System.Windows.Forms;
using Bingo.Logic;
using System.Speech;
using System.Speech.Synthesis;
using System.Threading.Tasks;

namespace Bingo
{
	public partial class Bingo : Form
	{
		private readonly Core _core;
		private readonly SpeechSynthesizer _synth;
		private const int MAX_DRAWN_LETTERS = 40;
		private const int LETTER_DRAWING_INTERVAL = 3500;
		private bool IsGamePlaying { get; set; }

		private bool[,] Daubed;

		private bool IsOneBingo { get; set; }
		private bool IsTwoBingo { get; set; }
		private bool IsThreeBingo { get; set; }
		private bool IsFourBingo { get; set; }

		private bool CheckCornerBingo { get; set; }
		private bool CheckColumn0Bingo { get; set; }
		private bool CheckColumn1Bingo { get; set; }
		private bool CheckColumn2Bingo { get; set; }
		private bool CheckColumn3Bingo { get; set; }
		private bool CheckColumn4Bingo { get; set; }
		private bool CheckRow0Bingo { get; set; }
		private bool CheckRow1Bingo { get; set; }
		private bool CheckRow2Bingo { get; set; }
		private bool CheckRow3Bingo { get; set; }
		private bool CheckRow4Bingo { get; set; }
		private bool CheckLeftCrossBingo { get; set; }
		private bool CheckRightCrossBingo { get; set; }

		private bool IsCornerBingo
		{
			get
			{
				return Daubed[0, 0] && Daubed[0, 4] && Daubed[4, 0] && Daubed[4, 4];
			}
		}
		private bool IsColumn0Bingo
		{
			get
			{
				return Daubed[0, 0] && Daubed[0, 1] && Daubed[0, 2] && Daubed[0, 3] && Daubed[0, 4];
			}
		}
		private bool IsColumn1Bingo
		{
			get
			{
				return Daubed[1, 0] && Daubed[1, 1] && Daubed[1, 2] && Daubed[1, 3] && Daubed[1, 4];
			}
		}
		private bool IsColumn2Bingo
		{
			get
			{
				return Daubed[2, 0] && Daubed[2, 1] && Daubed[2, 2] && Daubed[0, 3] && Daubed[2, 4];
			}
		}
		private bool IsColumn3Bingo
		{
			get
			{
				return Daubed[3, 0] && Daubed[3, 1] && Daubed[3, 2] && Daubed[3, 3] && Daubed[3, 4];
			}
		}
		private bool IsColumn4Bingo
		{
			get
			{
				return Daubed[4, 0] && Daubed[4, 1] && Daubed[4, 2] && Daubed[4, 3] && Daubed[4, 4];
			}
		}
		private bool IsRow0Bingo
		{
			get
			{
				return Daubed[0, 0] && Daubed[1, 0] && Daubed[2, 0] && Daubed[3, 0] && Daubed[4, 0];
			}
		}
		private bool IsRow1Bingo
		{
			get
			{
				return Daubed[0, 1] && Daubed[1, 1] && Daubed[2, 1] && Daubed[3, 1] && Daubed[4, 1];
			}
		}
		private bool IsRow2Bingo
		{
			get
			{
				return Daubed[0, 2] && Daubed[1, 2] && Daubed[2, 2] && Daubed[3, 2] && Daubed[4, 2];
			}
		}
		private bool IsRow3Bingo
		{
			get
			{
				return Daubed[0, 3] && Daubed[1, 3] && Daubed[2, 3] && Daubed[3, 3] && Daubed[4, 3];
			}
		}
		private bool IsRow4Bingo
		{
			get
			{
				return Daubed[0, 4] && Daubed[1, 4] && Daubed[2, 4] && Daubed[3, 4] && Daubed[4, 4];
			}
		}
		private bool IsLeftCrossBingo
		{
			get
			{
				return Daubed[0, 0] && Daubed[1, 1] && Daubed[2, 2] && Daubed[3, 3] && Daubed[4, 4];
			}
		}
		private bool IsRightCrossBingo
		{
			get
			{
				return Daubed[4, 0] && Daubed[3, 1] && Daubed[2, 2] && Daubed[1, 3] && Daubed[0, 4];
			}
		}

		public Bingo()
		{
			IsGamePlaying = false;
			InitializeComponent();
			_core = new Core();
			_synth = new SpeechSynthesizer();
			List<string> letters = new List<string> { "B", "I", "N", "G", "O" };
			Button[] buttons = new Button[30];
			BingoButton[] bingoButtonsbuttons = new BingoButton[30];
			int buttonIndex = 0;
			Daubed = new bool[5, 5];
			//For testing bingo
			//_core.ListOfPlayingLetters.AddRange(_core.ListOfAllPossibleLetters);
			CheckCornerBingo = true;
			CheckColumn0Bingo = true;
			CheckColumn1Bingo = true;
			CheckColumn2Bingo = true;
			CheckColumn3Bingo = true;
			CheckColumn4Bingo = true;
			CheckRow0Bingo = true;
			CheckRow1Bingo = true;
			CheckRow2Bingo = true;
			CheckRow3Bingo = true;
			CheckRow4Bingo = true;
			CheckLeftCrossBingo = true;
			CheckRightCrossBingo = true;
			AddButtonsIntoHeaderRow(letters, ref buttonIndex, ref buttons);
			//AddButtonsIntoRows(_core.PlayableB, 0, ref buttonIndex, ref buttons);
			//AddButtonsIntoRows(_core.PlayableI, 1, ref buttonIndex, ref buttons);
			//AddButtonsIntoRows(_core.PlayableN, 2, ref buttonIndex, ref buttons);
			//AddButtonsIntoRows(_core.PlayableG, 3, ref buttonIndex, ref buttons);
			//AddButtonsIntoRows(_core.PlayableO, 4, ref buttonIndex, ref buttons);
			AddButtonsIntoRows(_core.PlayableB, 0, ref buttonIndex, ref bingoButtonsbuttons);
			AddButtonsIntoRows(_core.PlayableI, 1, ref buttonIndex, ref bingoButtonsbuttons);
			AddButtonsIntoRows(_core.PlayableN, 2, ref buttonIndex, ref bingoButtonsbuttons);
			AddButtonsIntoRows(_core.PlayableG, 3, ref buttonIndex, ref bingoButtonsbuttons);
			AddButtonsIntoRows(_core.PlayableO, 4, ref buttonIndex, ref bingoButtonsbuttons);
		}

		private void AddButtonsIntoRows(List<string> listOfLetters, int tableColumn, ref int buttonIndex, ref BingoButton[] buttons)
		{
			for (int i = 0; i < 5; i++)
			{
				buttons[buttonIndex] = new BingoButton();
				buttons[buttonIndex].Name = $"btn{listOfLetters[i]}";
				buttons[buttonIndex].Text = listOfLetters[i];
				buttons[buttonIndex].FlatStyle = FlatStyle.System;
				buttons[buttonIndex].Click += DaubAsync;
				buttons[buttonIndex].Row = i;
				buttons[buttonIndex].Column = tableColumn;
				tblBingoBoard.Controls.Add(buttons[buttonIndex], tableColumn, i + 1);
				buttonIndex++;
			}
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
				buttons[buttonIndex].Click += DaubAsync;

				tblBingoBoard.Controls.Add(buttons[buttonIndex], tableColumn, i + 1);
				buttonIndex++;
			}
		}

		private async Task CheckBingoes()
		{
			if (CheckCornerBingo && IsCornerBingo)
			{
				CheckCornerBingo = false;
				await Task.Run(async () => CallBingo());
			}
			if (CheckRightCrossBingo && IsRightCrossBingo)
			{
				CheckRightCrossBingo = false;
				await Task.Run(async () => CallBingo());
			}
			if (CheckLeftCrossBingo && IsLeftCrossBingo)
			{
				CheckLeftCrossBingo = false;
				await Task.Run(async () => CallBingo());
			}
			if (CheckColumn0Bingo && IsColumn0Bingo)
			{
				CheckColumn0Bingo = false;
				await Task.Run(async () => CallBingo());
			}
			if (CheckColumn1Bingo && IsColumn1Bingo)
			{
				CheckColumn1Bingo = false;
				await Task.Run(async () => CallBingo());
			}
			if (CheckColumn2Bingo && IsColumn2Bingo)
			{
				CheckColumn2Bingo = false;
				await Task.Run(async () => CallBingo());
			}
			if (CheckColumn3Bingo && IsColumn3Bingo)
			{
				CheckColumn3Bingo = false;
				await Task.Run(async () => CallBingo());
			}
			if (CheckColumn4Bingo && IsColumn4Bingo)
			{
				CheckColumn4Bingo = false;
				await Task.Run(async () => CallBingo());
			}
			if (CheckRow0Bingo && IsRow0Bingo)
			{
				CheckRow0Bingo = false;
				await Task.Run(async () => CallBingo());
			}
			if (CheckRow1Bingo && IsRow1Bingo)
			{
				CheckRow1Bingo = false;
				await Task.Run(async () => CallBingo());
			}
			if (CheckRow2Bingo && IsRow2Bingo)
			{
				CheckRow2Bingo = false;
				await Task.Run(async () => CallBingo());
			}
			if (CheckRow3Bingo && IsRow3Bingo)
			{
				CheckRow3Bingo = false;
				await Task.Run(async () => CallBingo());
			}
			if (CheckRow4Bingo && IsRow4Bingo)
			{
				CheckRow4Bingo = false;
				await Task.Run(async () => CallBingo());
			}
		}

		private void CallBingo()
		{
			if (IsFourBingo)
			{
				return;
			}
			if (IsThreeBingo)
			{
				IsFourBingo = true;
				_synth.Speak("Multi Bingo!");
				return;
			}
			if (IsTwoBingo)
			{
				IsThreeBingo = true;
				_synth.Speak("Triple Bingo!");
				return;
			}
			if (IsOneBingo)
			{
				IsTwoBingo = true;
				_synth.Speak("Double Bingo!");
				return;
			}

			IsOneBingo = true;
			_synth.Speak("Bingo!");
		}


		private async void DaubAsync(object sender, EventArgs e)
		{
			var button = (BingoButton)sender;
			if (_core.ListOfPlayingLetters.Contains(button.Text))
			{
				button.Enabled = false;
				AddToDaubArray(button.Column, button.Row);
				await CheckBingoes();
			}

			lblFocusGainer.Focus();
		}

		private void AddToDaubArray(int column, int row)
		{
			Daubed[column, row] = true;
		}

		private void btnStartBingo_Click(object sender, EventArgs e)
		{
			if (IsGamePlaying)
			{
				return;
			}

			IsGamePlaying = true;

			System.Timers.Timer timer = new System.Timers.Timer(LETTER_DRAWING_INTERVAL);

			timer.Elapsed += OnTimedEvent;

			timer.Enabled = true;

			var middleButton = tblBingoBoard.GetControlFromPosition(2, 3) as BingoButton;
			middleButton.Enabled = false;
			AddToDaubArray(middleButton.Column, middleButton.Row);
		}

		private void OnTimedEvent(object source, ElapsedEventArgs e)
		{
			Random rnd = new Random();

			if (_core.ListOfPlayingLetters.Count < MAX_DRAWN_LETTERS)
			{
				bool newLetterAdded = false;
				while (!newLetterAdded)
				{
					var randomizedLetter = _core.ListOfAllPossibleLetters.ElementAt(rnd.Next(0, 75));
					if (!_core.ListOfPlayingLetters.Contains(randomizedLetter))
					{
						newLetterAdded = true;
						_core.ListOfPlayingLetters.Add(randomizedLetter);

						txbList.Invoke((MethodInvoker)delegate
						{
							txbList.Text = txbList.Text.Insert(0, randomizedLetter + "\t");
						});
						txbCount.Invoke((MethodInvoker)delegate
						{
							txbCount.Text = $@"{_core.ListOfPlayingLetters.Count}/{MAX_DRAWN_LETTERS}";
						});
						_synth.Speak(randomizedLetter);
					}
				}
			}
		}
	}
	class BingoButton : Button
	{
		public int Row;
		public int Column;
	}
}
