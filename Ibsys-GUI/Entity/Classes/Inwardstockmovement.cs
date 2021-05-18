using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Ibsys_GUI.Entity.Classes
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
