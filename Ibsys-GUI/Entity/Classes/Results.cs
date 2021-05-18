using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Ibsys_GUI.Entity.Classes
{
    class Results
    {
		// ATTRIBUTES
		[XmlAttribute("game")]
		public int game { get; set; }

		[XmlAttribute("group")]
		public int group { get; set; }

		[XmlAttribute("period")]
		public int period { get; set; }

		// ELEMENTS
		[XmlElement("warehousestock")]
		public warehousestock warehousestock { get; set; }

		[XmlElement("inwardstockmovement")]
		public inwardstockmovement inwardstockmovement { get; set; }

		[XmlElement("futureinwardstockmovement")]
		public futureinwardstockmovement futureinwardstockmovement { get; set; }

		[XmlElement("idletimecosts")]
		public resultsidletimecosts resultsidletimecosts { get; set; }

		[XmlElement("waitinglistworkstations")]
		public waitinglistworkstations waitinglistworkstations { get; set; }

		[XmlElement("waitingliststock")]
		public waitingliststock waitingliststock { get; set; }

		[XmlElement("ordersinwork")]
		public ordersinwork ordersinwork { get; set; }

		[XmlElement("completedorders")]
		public completedorders completedorders { get; set; }

		[XmlElement("cycletimes")]
		public cycletimes cycletimes { get; set; }

		[XmlElement("result")]
		public result result { get; set; }

		// CONSTRUCTOR
		public Results()
		{ }
	}
}
