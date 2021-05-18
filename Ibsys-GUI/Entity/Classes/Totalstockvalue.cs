using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Ibsys_GUI.Entity.Classes
{
    class Totalstockvalue
    {
		// ELEMENTS
		[XmlText]
		public decimal Value { get; set; }

		// CONSTRUCTOR
		public Totalstockvalue()
		{ }
	}
}
