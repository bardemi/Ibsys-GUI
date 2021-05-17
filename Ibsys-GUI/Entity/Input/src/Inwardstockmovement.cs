using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Ibsys2.Entity
{
    class Inwardstockmovement
    {
        // ELEMENTS
        [XmlElement("order")]
        public List<Inwardstockmovementorder> inwardstockmovementorders { get; set; }

        public Inwardstockmovement()
        { }
    }
}
