using System;
using System.ComponentModel;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Globalization;

namespace Ibsys2.Entity
{
	
	public class Futureinwardstockmovementorder
	{
		// ATTRIBUTES
		[XmlAttribute("orderperiod")]
		public int orderperiod  { get; set; }
		
		[XmlAttribute("id")]
		public int id  { get; set; }
		
		[XmlAttribute("mode")]
		public int mode  { get; set; }
		
		[XmlAttribute("article")]
		public int article  { get; set; }
		
		[XmlAttribute("amount")]
		public int amount  { get; set; }
		
		// ELEMENTS
		[XmlText]
		public string Value { get; set; }
		
		// CONSTRUCTOR
		public Futureinwardstockmovementorder()
		{}
	}
}
