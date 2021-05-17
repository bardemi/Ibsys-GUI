using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Ibsys2.Entity
{
    class Article
    {
		
		// ATTRIBUTES
		[XmlAttribute("id")]
		public int id { get; set; }

		[XmlAttribute("amount")]
		public int amount { get; set; }

		[XmlAttribute("startamount")]
		public int startamount { get; set; }

		[XmlAttribute("pct")]
		public decimal pct { get; set; }

		[XmlAttribute("price")]
		public decimal price { get; set; }

		[XmlAttribute("stockvalue")]
		public decimal stockvalue { get; set; }

		// ELEMENTS
		[XmlText]
		public string Value { get; set; }

		// CONSTRUCTOR
		public Article()
		{ }
	}
}
