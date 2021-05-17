using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Ibsys2.Entity
{
    class Waitinglist
    {
		// ATTRIBUTES
		[XmlAttribute("period")]
		public int period { get; set; }

		[XmlAttribute("order")]
		public int order { get; set; }

		[XmlAttribute("firstbatch")]
		public int firstbatch { get; set; }

		[XmlAttribute("lastbatch")]
		public int lastbatch { get; set; }

		[XmlAttribute("item")]
		public int item { get; set; }

		[XmlAttribute("amount")]
		public int amount { get; set; }

		
		// CONSTRUCTOR
		public Waitinglist()
		{ }
	}
}
