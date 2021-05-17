using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Ibsys2.Entity
{
    class Workplace
    {
		
		// ATTRIBUTES
		[XmlAttribute("id")]
		public int id { get; set; }

		[XmlAttribute("timeneed")]
		public int timeneed { get; set; }

		[XmlElement("waitinglist")]
		public List<Waitinglist> waitinglists { get; set; }
		

		// CONSTRUCTOR
		public Workplace()
		{ }
	}
}
