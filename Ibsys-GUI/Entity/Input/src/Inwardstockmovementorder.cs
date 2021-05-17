using System;
using System.ComponentModel;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Globalization;

namespace Ibsys2.Entity
{
	
	public class Inwardstockmovementorder
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
		
		[XmlAttribute("time")]
		public int time  { get; set; }
		
		[XmlAttribute("materialcosts")]
		public decimal materialcosts  { get; set; }
		
		[XmlAttribute("ordercosts")]
		public decimal ordercosts  { get; set; }
		
		[XmlAttribute("entirecosts")]
		public decimal entirecosts  { get; set; }
		
		[XmlAttribute("piececosts")]
		public decimal piececosts  { get; set; }
		
		// ELEMENTS
		[XmlText]
		public string Value { get; set; }
		
		// CONSTRUCTOR
		public Inwardstockmovementorder()
		{}
	}
}
