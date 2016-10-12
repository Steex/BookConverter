using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using System.Windows.Forms;


namespace BookConverter
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();

			// Log into text view.
			Logger.OnWrite += (level, message) => textLog.Invoke((MethodInvoker)delegate { textLog.AppendText(message); });
			Logger.OnClear += () => textLog.Invoke((MethodInvoker)delegate { textLog.Clear(); });
		}


		private void dropletConvertBooks_DragEnter(object sender, DragEventArgs e)
		{
			e.Effect = e.Data.GetDataPresent("FileDrop") ? DragDropEffects.Link : DragDropEffects.None;
		}

		private void dropletConvertBooks_DragDrop(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent("FileDrop"))
			{
				string[] paths = (string[])e.Data.GetData("FileDrop");

				foreach (string path in paths.Where(p => Path.GetExtension(p) == ".html" && File.Exists(p)))
				{
					string sourceFile = path;
					string targetFile = Path.Combine(Path.GetDirectoryName(path), Path.GetFileNameWithoutExtension(path) + ".fb2");
					Book book = new Book(path);
				}
			}
		}
	}
}
