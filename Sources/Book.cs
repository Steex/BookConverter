using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using HtmlAgilityPack;

namespace BookConverter
{
	public class Book
	{
		public string Name { get; private set; }
		public string Path { get; private set; }
		public HtmlDocument Html { get; private set; }

		public Book(string path)
		{
			Name = System.IO.Path.GetFileNameWithoutExtension(path);
			Path = path;

			try
			{
				Logger.Write("Open book \"" + Name + "\"... ");

				Html = new HtmlDocument();
				Html.Load(path, Encoding.GetEncoding(1251));

				Logger.WriteLine("OK");
			}
			catch (Exception ex)
			{
				Logger.WriteError(ex.Message);
			}
		}

		public void PrintStructure()
		{
			try
			{
				var nodeStack = new Stack<IEnumerator<HtmlNode>>();
				nodeStack.Push((Html.DocumentNode.ChildNodes as IEnumerable<HtmlNode>).GetEnumerator());

				while (nodeStack.Count > 0)
				{
					IEnumerator<HtmlNode> nodeEnumerator = nodeStack.Peek();
					if (nodeEnumerator.MoveNext())
					{
						if (nodeEnumerator.Current.NodeType == HtmlNodeType.Element)
						{
							Logger.WriteLine(string.Format("{0,4}", nodeEnumerator.Current.Line) + new string(' ', nodeStack.Count * 2) + nodeEnumerator.Current.Name);
							nodeStack.Push((nodeEnumerator.Current.ChildNodes as IEnumerable<HtmlNode>).GetEnumerator());
						}
					}
					else
					{
						nodeStack.Pop();
					}
				}

				Logger.WriteLine("-- end of file --");
			}
			catch (Exception ex)
			{
				Logger.WriteError(ex.Message);
			}
		}
	}
}
