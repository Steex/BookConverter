using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;


namespace BookConverter
{
	public static class BookUtils
	{
		public static XmlDocument OpenBook(string path)
		{
			XmlDocument book = new XmlDocument();
			book.Load(path);
			return book;
		}

		public static void CheckBookConsistency(XmlDocument book)
		{

		}
	}
}
