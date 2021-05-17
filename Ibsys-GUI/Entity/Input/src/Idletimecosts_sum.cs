using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Ibsys2.Entity
{
    class Idletimecosts_sum
    {
		// ATTRIBUTES
		[XmlAttribute("setupevents")]
		public int setupevents { get; set; }

		[XmlAttribute("idletime")]
		public int idletime { get; set; }

		[XmlAttribute("wageidletimecosts")]
		public decimal wageidletimecosts { get; set; }

		[XmlAttribute("wagecosts")]
		public decimal wagecosts { get; set; }

		[XmlAttribute("machineidletimecosts")]
		public decimal machineidletimecosts { get; set; }

		
	}
}
