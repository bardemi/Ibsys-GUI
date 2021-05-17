using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Ibsys2.Entity
{
    class Idletimecosts
    {
		// ELEMENTS
		[XmlElement("workplace")]
		public List<Workplace> workplaces { get; set; }

		[XmlElement("sum")]
		public Idletimecosts_sum sum { get; set; }

		// CONSTRUCTOR
		public Idletimecosts()
		{ }
	}
}
