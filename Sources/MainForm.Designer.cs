namespace BookConverter
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.textLog = new System.Windows.Forms.TextBox();
			this.dropletConvertBooks = new BookConverter.Droplet();
			this.SuspendLayout();
			// 
			// textLog
			// 
			this.textLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textLog.Location = new System.Drawing.Point(12, 104);
			this.textLog.Multiline = true;
			this.textLog.Name = "textLog";
			this.textLog.ReadOnly = true;
			this.textLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textLog.Size = new System.Drawing.Size(602, 451);
			this.textLog.TabIndex = 5;
			// 
			// dropletConvertBooks
			// 
			this.dropletConvertBooks.AllowDrop = true;
			this.dropletConvertBooks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dropletConvertBooks.BackColor = System.Drawing.Color.Silver;
			this.dropletConvertBooks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.dropletConvertBooks.Info = "Drop HTML books here to convert them into the FB2 format.\r\nOriginal book files wi" +
    "ll not change.";
			this.dropletConvertBooks.Location = new System.Drawing.Point(12, 12);
			this.dropletConvertBooks.Name = "dropletConvertBooks";
			this.dropletConvertBooks.Size = new System.Drawing.Size(602, 86);
			this.dropletConvertBooks.TabIndex = 6;
			this.dropletConvertBooks.Title = "Convert Books";
			this.dropletConvertBooks.DragDrop += new System.Windows.Forms.DragEventHandler(this.dropletConvertBooks_DragDrop);
			this.dropletConvertBooks.DragEnter += new System.Windows.Forms.DragEventHandler(this.dropletConvertBooks_DragEnter);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(626, 567);
			this.Controls.Add(this.dropletConvertBooks);
			this.Controls.Add(this.textLog);
			this.Name = "MainForm";
			this.Text = "Book Converter";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textLog;
		private Droplet dropletConvertBooks;
	}
}

