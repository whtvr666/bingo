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
			this.txbList = new System.Windows.Forms.TextBox();
			this.txbCount = new System.Windows.Forms.TextBox();
			this.lblFocusGainer = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnStartBingo
			// 
			this.btnStartBingo.Location = new System.Drawing.Point(12, 14);
			this.btnStartBingo.Name = "btnStartBingo";
			this.btnStartBingo.Size = new System.Drawing.Size(75, 23);
			this.btnStartBingo.TabIndex = 0;
			this.btnStartBingo.Text = "Start";
			this.btnStartBingo.UseVisualStyleBackColor = true;
			this.btnStartBingo.Click += new System.EventHandler(this.btnStartBingo_Click);
			// 
			// tblBingoBoard
			// 
			this.tblBingoBoard.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.tblBingoBoard.ColumnCount = 5;
			this.tblBingoBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tblBingoBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tblBingoBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tblBingoBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tblBingoBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tblBingoBoard.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
			this.tblBingoBoard.Location = new System.Drawing.Point(94, 42);
			this.tblBingoBoard.Name = "tblBingoBoard";
			this.tblBingoBoard.RowCount = 6;
			this.tblBingoBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tblBingoBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tblBingoBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tblBingoBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tblBingoBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tblBingoBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tblBingoBoard.Size = new System.Drawing.Size(261, 237);
			this.tblBingoBoard.TabIndex = 2;
			// 
			// txbList
			// 
			this.txbList.Enabled = false;
			this.txbList.Location = new System.Drawing.Point(94, 16);
			this.txbList.Name = "txbList";
			this.txbList.Size = new System.Drawing.Size(261, 20);
			this.txbList.TabIndex = 3;
			// 
			// txbCount
			// 
			this.txbCount.Enabled = false;
			this.txbCount.Location = new System.Drawing.Point(375, 16);
			this.txbCount.Name = "txbCount";
			this.txbCount.Size = new System.Drawing.Size(58, 20);
			this.txbCount.TabIndex = 4;
			// 
			// lblFocusGainer
			// 
			this.lblFocusGainer.AutoSize = true;
			this.lblFocusGainer.Location = new System.Drawing.Point(9, 324);
			this.lblFocusGainer.Name = "lblFocusGainer";
			this.lblFocusGainer.Size = new System.Drawing.Size(0, 13);
			this.lblFocusGainer.TabIndex = 5;
			// 
			// Bingo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(445, 346);
			this.Controls.Add(this.lblFocusGainer);
			this.Controls.Add(this.txbCount);
			this.Controls.Add(this.txbList);
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
		private System.Windows.Forms.TextBox txbList;
		private System.Windows.Forms.TextBox txbCount;
		private System.Windows.Forms.Label lblFocusGainer;
	}
}

