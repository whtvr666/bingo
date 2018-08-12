namespace Bingo
{
	partial class Bingo
	{
		/// <summary>
		/// Wymagana zmienna projektanta.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Wyczyść wszystkie używane zasoby.
		/// </summary>
		/// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Kod generowany przez Projektanta formularzy systemu Windows

		/// <summary>
		/// Metoda wymagana do obsługi projektanta — nie należy modyfikować
		/// jej zawartości w edytorze kodu.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnStartBingo = new System.Windows.Forms.Button();
			this.tblBingoBoard = new System.Windows.Forms.TableLayoutPanel();
			this.tbxList = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnStartBingo
			// 
			this.btnStartBingo.Location = new System.Drawing.Point(13, 13);
			this.btnStartBingo.Name = "btnStartBingo";
			this.btnStartBingo.Size = new System.Drawing.Size(75, 23);
			this.btnStartBingo.TabIndex = 0;
			this.btnStartBingo.Text = "Start";
			this.btnStartBingo.UseVisualStyleBackColor = true;
			this.btnStartBingo.Click += new System.EventHandler(this.btnStartBingo_Click);
			// 
			// tblBingoBoard
			// 
			this.tblBingoBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tblBingoBoard.ColumnCount = 5;
			this.tblBingoBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tblBingoBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tblBingoBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tblBingoBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tblBingoBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tblBingoBoard.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
			this.tblBingoBoard.Location = new System.Drawing.Point(103, 47);
			this.tblBingoBoard.Name = "tblBingoBoard";
			this.tblBingoBoard.RowCount = 6;
			this.tblBingoBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tblBingoBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tblBingoBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tblBingoBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tblBingoBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tblBingoBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tblBingoBoard.Size = new System.Drawing.Size(257, 231);
			this.tblBingoBoard.TabIndex = 2;
			// 
			// tbxList
			// 
			this.tbxList.Location = new System.Drawing.Point(405, 47);
			this.tbxList.Multiline = true;
			this.tbxList.Name = "tbxList";
			this.tbxList.Size = new System.Drawing.Size(312, 231);
			this.tbxList.TabIndex = 3;
			// 
			// Bingo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(819, 466);
			this.Controls.Add(this.tbxList);
			this.Controls.Add(this.tblBingoBoard);
			this.Controls.Add(this.btnStartBingo);
			this.Name = "Bingo";
			this.Text = "Bingo";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnStartBingo;
		private System.Windows.Forms.TableLayoutPanel tblBingoBoard;
		private System.Windows.Forms.TextBox tbxList;
	}
}

