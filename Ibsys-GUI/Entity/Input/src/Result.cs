using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Ibsys2.Entity
{
    class Result
    {
		// ELEMENTS
		[XmlElement("general")]
		public general general { get; set; }

		[XmlElement("defectivegoods")]
		public defectivegoods defectivegoods { get; set; }

		[XmlElement("normalsale")]
		public normalsale normalsale { get; set; }

		[XmlElement("directsale")]
		public directsale directsale { get; set; }

		[XmlElement("marketplacesale")]
		public marketplacesale marketplacesale { get; set; }

		[XmlElement("summary")]
		public summary summary { get; set; }

		// CONSTRUCTOR
		public Result()
		{ }
	}
}
