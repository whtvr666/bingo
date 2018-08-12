using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bingo.Logic;

namespace Bingo
{
	public partial class Bingo : Form
	{
		List<string> listOfPlayingLetters = new List<string>();

		public Bingo()
		{
			InitializeComponent();
			Core core = new Core();
			listOfPlayingLetters.AddRange(core.ListOfPlayingLetters);
			tbxList.Text = string.Join(",",listOfPlayingLetters.ToArray());
			List<string> Letters = new List<string> {"B","I","N","G","O"};
			Button[] buttons = new Button[30];
			int buttonIndex = 0;

			AddButtonsIntoHeaderRow(Letters, ref buttonIndex, ref buttons);
			AddButtonsIntoRows(core.PlayableB, 0, ref buttonIndex, ref buttons);
			AddButtonsIntoRows(core.PlayableI, 1, ref buttonIndex, ref buttons);
			AddButtonsIntoRows(core.PlayableN, 2, ref buttonIndex, ref buttons);
			AddButtonsIntoRows(core.PlayableG, 3, ref buttonIndex, ref buttons);
			AddButtonsIntoRows(core.PlayableO, 4, ref buttonIndex, ref buttons);
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

				tblBingoBoard.Controls.Add(buttons[buttonIndex], tableColumn, i+1);
				buttonIndex++;
			}
		}

		private void Daub(object sender, EventArgs e)
		{
			var button = (Button)sender;
			if (listOfPlayingLetters.Contains(button.Text))
			{
				button.Enabled = false;
			}
		}

		private void btnStartBingo_Click(object sender, EventArgs e)
		{
			var middleButton = tblBingoBoard.GetControlFromPosition(2, 3) as Button;
			middleButton.Enabled = false;
		}
	}
}
