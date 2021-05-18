using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Ibsys_GUI.Entity.Classes
{
    class Waitinglistworkstations
    {
		// ELEMENTS
		[XmlElement("workplace")]
		public List<Workplace> workplaces { get; set; }

		
		// CONSTRUCTOR
		public Waitinglistworkstations()
		{ }
	}
}
