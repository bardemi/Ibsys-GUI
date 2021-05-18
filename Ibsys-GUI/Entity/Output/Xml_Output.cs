using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ibsys_GUI.Entity.Output
{

    // HINWEIS: Für den generierten Code ist möglicherweise mindestens .NET Framework 4.5 oder .NET Core/Standard 2.0 erforderlich.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class input
    {

        private inputQualitycontrol qualitycontrolField;

        private inputItem[] sellwishField;

        private inputItem1[] selldirectField;

        private inputOrder[] orderlistField;

        private inputProduction[] productionlistField;

        private inputWorkingtime[] workingtimelistField;

        /// <remarks/>
        public inputQualitycontrol qualitycontrol
        {
            get
            {
                return this.qualitycontrolField;
            }
            set
            {
                this.qualitycontrolField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable = false)]
        public inputItem[] sellwish
        {
            get
            {
                return this.sellwishField;
            }
            set
            {
                this.sellwishField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable = false)]
        public inputItem1[] selldirect
        {
            get
            {
                return this.selldirectField;
            }
            set
            {
                this.selldirectField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("order", IsNullable = false)]
        public inputOrder[] orderlist
        {
            get
            {
                return this.orderlistField;
            }
            set
            {
                this.orderlistField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("production", IsNullable = false)]
        public inputProduction[] productionlist
        {
            get
            {
                return this.productionlistField;
            }
            set
            {
                this.productionlistField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("workingtime", IsNullable = false)]
        public inputWorkingtime[] workingtimelist
        {
            get
            {
                return this.workingtimelistField;
            }
            set
            {
                this.workingtimelistField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class inputQualitycontrol
    {

        private decimal typeField;

        private byte losequantityField;

        private byte delayField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte losequantity
        {
            get
            {
                return this.losequantityField;
            }
            set
            {
                this.losequantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte delay
        {
            get
            {
                return this.delayField;
            }
            set
            {
                this.delayField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class inputItem
    {

        private byte articleField;

        private byte quantityField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte article
        {
            get
            {
                return this.articleField;
            }
            set
            {
                this.articleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte quantity
        {
            get
            {
                return this.quantityField;
            }
            set
            {
                this.quantityField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class inputItem1
    {

        private byte articleField;

        private byte quantityField;

        private decimal priceField;

        private decimal penaltyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte article
        {
            get
            {
                return this.articleField;
            }
            set
            {
                this.articleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte quantity
        {
            get
            {
                return this.quantityField;
            }
            set
            {
                this.quantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal price
        {
            get
            {
                return this.priceField;
            }
            set
            {
                this.priceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal penalty
        {
            get
            {
                return this.penaltyField;
            }
            set
            {
                this.penaltyField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class inputOrder
    {

        private byte articleField;

        private ushort quantityField;

        private byte modusField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte article
        {
            get
            {
                return this.articleField;
            }
            set
            {
                this.articleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort quantity
        {
            get
            {
                return this.quantityField;
            }
            set
            {
                this.quantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte modus
        {
            get
            {
                return this.modusField;
            }
            set
            {
                this.modusField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class inputProduction
    {

        private byte articleField;

        private ushort quantityField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte article
        {
            get
            {
                return this.articleField;
            }
            set
            {
                this.articleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort quantity
        {
            get
            {
                return this.quantityField;
            }
            set
            {
                this.quantityField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class inputWorkingtime
    {

        private byte stationField;

        private byte shiftField;

        private byte overtimeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte station
        {
            get
            {
                return this.stationField;
            }
            set
            {
                this.stationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte shift
        {
            get
            {
                return this.shiftField;
            }
            set
            {
                this.shiftField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte overtime
        {
            get
            {
                return this.overtimeField;
            }
            set
            {
                this.overtimeField = value;
            }
        }
    }


}
