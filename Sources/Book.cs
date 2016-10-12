using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;


namespace BookConverter
{
	public class Book
	{
		public string Name { get; private set; }
		public string Path { get; private set; }
		public XmlDocument Xml { get; private set; }

		public Book(string path)
		{
			Name = System.IO.Path.GetFileNameWithoutExtension(path);
			Path = path;

			try
			{
				Logger.Write("Open book \"" + Name + "\"... ");
				Xml = new XmlDocument();
				Xml.Load(path);
				Logger.WriteLine("OK");
			}
			catch (Exception ex)
			{
				Logger.WriteError(ex.Message);
			}
		}
	}
}
