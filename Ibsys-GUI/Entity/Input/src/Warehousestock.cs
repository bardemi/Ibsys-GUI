using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Ibsys2.Entity
{
    class Warehousestock
    {
		// ELEMENTS
		[XmlElement("article")]
		public List<Article> article { get; set; }

		[XmlElement("totalstockvalue")]
		public Totalstockvalue totalstockvalue { get; set; }

		// CONSTRUCTOR
		public Warehousestock()
		{ }
	}
}
