﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ibsys_GUI.Entity.Input
{

    // HINWEIS: Für den generierten Code ist möglicherweise mindestens .NET Framework 4.5 oder .NET Core/Standard 2.0 erforderlich.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class results
    {

        private resultsForecast forecastField;

        private resultsWarehousestock warehousestockField;

        private resultsOrder[] inwardstockmovementField;

        private resultsOrder1[] futureinwardstockmovementField;

        private resultsIdletimecosts idletimecostsField;

        private resultsWorkplace[] waitinglistworkstationsField;

        private resultsMissingpart[] waitingliststockField;

        private resultsWorkplace1[] ordersinworkField;

        private resultsOrder2[] completedordersField;

        private resultsCycletimes cycletimesField;

        private resultsResult resultField;

        private ushort gameField;

        private byte groupField;

        private byte periodField;

        /// <remarks/>
        public resultsForecast forecast
        {
            get
            {
                return this.forecastField;
            }
            set
            {
                this.forecastField = value;
            }
        }

        /// <remarks/>
        public resultsWarehousestock warehousestock
        {
            get
            {
                return this.warehousestockField;
            }
            set
            {
                this.warehousestockField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("order", IsNullable = false)]
        public resultsOrder[] inwardstockmovement
        {
            get
            {
                return this.inwardstockmovementField;
            }
            set
            {
                this.inwardstockmovementField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("order", IsNullable = false)]
        public resultsOrder1[] futureinwardstockmovement
        {
            get
            {
                return this.futureinwardstockmovementField;
            }
            set
            {
                this.futureinwardstockmovementField = value;
            }
        }

        /// <remarks/>
        public resultsIdletimecosts idletimecosts
        {
            get
            {
                return this.idletimecostsField;
            }
            set
            {
                this.idletimecostsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("workplace", IsNullable = false)]
        public resultsWorkplace[] waitinglistworkstations
        {
            get
            {
                return this.waitinglistworkstationsField;
            }
            set
            {
                this.waitinglistworkstationsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("missingpart", IsNullable = false)]
        public resultsMissingpart[] waitingliststock
        {
            get
            {
                return this.waitingliststockField;
            }
            set
            {
                this.waitingliststockField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("workplace", IsNullable = false)]
        public resultsWorkplace1[] ordersinwork
        {
            get
            {
                return this.ordersinworkField;
            }
            set
            {
                this.ordersinworkField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("order", IsNullable = false)]
        public resultsOrder2[] completedorders
        {
            get
            {
                return this.completedordersField;
            }
            set
            {
                this.completedordersField = value;
            }
        }

        /// <remarks/>
        public resultsCycletimes cycletimes
        {
            get
            {
                return this.cycletimesField;
            }
            set
            {
                this.cycletimesField = value;
            }
        }

        /// <remarks/>
        public resultsResult result
        {
            get
            {
                return this.resultField;
            }
            set
            {
                this.resultField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort game
        {
            get
            {
                return this.gameField;
            }
            set
            {
                this.gameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte group
        {
            get
            {
                return this.groupField;
            }
            set
            {
                this.groupField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte period
        {
            get
            {
                return this.periodField;
            }
            set
            {
                this.periodField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class resultsForecast
    {

        private byte p1Field;

        private byte p2Field;

        private byte p3Field;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte p1
        {
            get
            {
                return this.p1Field;
            }
            set
            {
                this.p1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte p2
        {
            get
            {
                return this.p2Field;
            }
            set
            {
                this.p2Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte p3
        {
            get
            {
                return this.p3Field;
            }
            set
            {
                this.p3Field = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class resultsWarehousestock
    {

        private resultsWarehousestockArticle[] articleField;

        private string totalstockvalueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("article")]
        public resultsWarehousestockArticle[] article
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
        public string totalstockvalue
        {
            get
            {
                return this.totalstockvalueField;
            }
            set
            {
                this.totalstockvalueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class resultsWarehousestockArticle
    {

        private byte idField;

        private ushort amountField;

        private ushort startamountField;

        private string pctField;

        private string priceField;

        private string stockvalueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort startamount
        {
            get
            {
                return this.startamountField;
            }
            set
            {
                this.startamountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string pct
        {
            get
            {
                return this.pctField;
            }
            set
            {
                this.pctField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string price
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
        public string stockvalue
        {
            get
            {
                return this.stockvalueField;
            }
            set
            {
                this.stockvalueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class resultsOrder
    {

        private byte orderperiodField;

        private byte idField;

        private byte modeField;

        private byte articleField;

        private ushort amountField;

        private ushort timeField;

        private string materialcostsField;

        private string ordercostsField;

        private string entirecostsField;

        private string piececostsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte orderperiod
        {
            get
            {
                return this.orderperiodField;
            }
            set
            {
                this.orderperiodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte mode
        {
            get
            {
                return this.modeField;
            }
            set
            {
                this.modeField = value;
            }
        }

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
        public ushort amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort time
        {
            get
            {
                return this.timeField;
            }
            set
            {
                this.timeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string materialcosts
        {
            get
            {
                return this.materialcostsField;
            }
            set
            {
                this.materialcostsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ordercosts
        {
            get
            {
                return this.ordercostsField;
            }
            set
            {
                this.ordercostsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string entirecosts
        {
            get
            {
                return this.entirecostsField;
            }
            set
            {
                this.entirecostsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string piececosts
        {
            get
            {
                return this.piececostsField;
            }
            set
            {
                this.piececostsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class resultsOrder1
    {

        private byte orderperiodField;

        private byte idField;

        private byte modeField;

        private byte articleField;

        private ushort amountField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte orderperiod
        {
            get
            {
                return this.orderperiodField;
            }
            set
            {
                this.orderperiodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte mode
        {
            get
            {
                return this.modeField;
            }
            set
            {
                this.modeField = value;
            }
        }

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
        public ushort amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class resultsIdletimecosts
    {

        private resultsIdletimecostsWorkplace[] workplaceField;

        private resultsIdletimecostsSum sumField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("workplace")]
        public resultsIdletimecostsWorkplace[] workplace
        {
            get
            {
                return this.workplaceField;
            }
            set
            {
                this.workplaceField = value;
            }
        }

        /// <remarks/>
        public resultsIdletimecostsSum sum
        {
            get
            {
                return this.sumField;
            }
            set
            {
                this.sumField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class resultsIdletimecostsWorkplace
    {

        private byte idField;

        private byte setupeventsField;

        private ushort idletimeField;

        private string wageidletimecostsField;

        private string wagecostsField;

        private string machineidletimecostsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte setupevents
        {
            get
            {
                return this.setupeventsField;
            }
            set
            {
                this.setupeventsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort idletime
        {
            get
            {
                return this.idletimeField;
            }
            set
            {
                this.idletimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string wageidletimecosts
        {
            get
            {
                return this.wageidletimecostsField;
            }
            set
            {
                this.wageidletimecostsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string wagecosts
        {
            get
            {
                return this.wagecostsField;
            }
            set
            {
                this.wagecostsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string machineidletimecosts
        {
            get
            {
                return this.machineidletimecostsField;
            }
            set
            {
                this.machineidletimecostsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class resultsIdletimecostsSum
    {

        private byte setupeventsField;

        private ushort idletimeField;

        private string wageidletimecostsField;

        private string wagecostsField;

        private string machineidletimecostsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte setupevents
        {
            get
            {
                return this.setupeventsField;
            }
            set
            {
                this.setupeventsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort idletime
        {
            get
            {
                return this.idletimeField;
            }
            set
            {
                this.idletimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string wageidletimecosts
        {
            get
            {
                return this.wageidletimecostsField;
            }
            set
            {
                this.wageidletimecostsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string wagecosts
        {
            get
            {
                return this.wagecostsField;
            }
            set
            {
                this.wagecostsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string machineidletimecosts
        {
            get
            {
                return this.machineidletimecostsField;
            }
            set
            {
                this.machineidletimecostsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class resultsWorkplace
    {

        private resultsWorkplaceWaitinglist[] waitinglistField;

        private byte idField;

        private ushort timeneedField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("waitinglist")]
        public resultsWorkplaceWaitinglist[] waitinglist
        {
            get
            {
                return this.waitinglistField;
            }
            set
            {
                this.waitinglistField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort timeneed
        {
            get
            {
                return this.timeneedField;
            }
            set
            {
                this.timeneedField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class resultsWorkplaceWaitinglist
    {

        private byte periodField;

        private byte orderField;

        private byte firstbatchField;

        private byte lastbatchField;

        private byte itemField;

        private byte amountField;

        private ushort timeneedField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte period
        {
            get
            {
                return this.periodField;
            }
            set
            {
                this.periodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte order
        {
            get
            {
                return this.orderField;
            }
            set
            {
                this.orderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte firstbatch
        {
            get
            {
                return this.firstbatchField;
            }
            set
            {
                this.firstbatchField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte lastbatch
        {
            get
            {
                return this.lastbatchField;
            }
            set
            {
                this.lastbatchField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort timeneed
        {
            get
            {
                return this.timeneedField;
            }
            set
            {
                this.timeneedField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class resultsMissingpart
    {

        private byte idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class resultsWorkplace1
    {

        private byte idField;

        private byte periodField;

        private byte orderField;

        private byte batchField;

        private byte itemField;

        private byte amountField;

        private byte timeneedField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte period
        {
            get
            {
                return this.periodField;
            }
            set
            {
                this.periodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte order
        {
            get
            {
                return this.orderField;
            }
            set
            {
                this.orderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte batch
        {
            get
            {
                return this.batchField;
            }
            set
            {
                this.batchField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte timeneed
        {
            get
            {
                return this.timeneedField;
            }
            set
            {
                this.timeneedField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class resultsOrder2
    {

        private resultsOrderBatch[] batchField;

        private byte periodField;

        private byte idField;

        private byte itemField;

        private ushort quantityField;

        private string costField;

        private string averageunitcostsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("batch")]
        public resultsOrderBatch[] batch
        {
            get
            {
                return this.batchField;
            }
            set
            {
                this.batchField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte period
        {
            get
            {
                return this.periodField;
            }
            set
            {
                this.periodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
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
        public string cost
        {
            get
            {
                return this.costField;
            }
            set
            {
                this.costField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string averageunitcosts
        {
            get
            {
                return this.averageunitcostsField;
            }
            set
            {
                this.averageunitcostsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class resultsOrderBatch
    {

        private byte idField;

        private byte amountField;

        private ushort cycletimeField;

        private string costField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort cycletime
        {
            get
            {
                return this.cycletimeField;
            }
            set
            {
                this.cycletimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string cost
        {
            get
            {
                return this.costField;
            }
            set
            {
                this.costField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class resultsCycletimes
    {

        private resultsCycletimesOrder[] orderField;

        private byte startedordersField;

        private byte waitingordersField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("order")]
        public resultsCycletimesOrder[] order
        {
            get
            {
                return this.orderField;
            }
            set
            {
                this.orderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte startedorders
        {
            get
            {
                return this.startedordersField;
            }
            set
            {
                this.startedordersField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte waitingorders
        {
            get
            {
                return this.waitingordersField;
            }
            set
            {
                this.waitingordersField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class resultsCycletimesOrder
    {

        private byte idField;

        private byte periodField;

        private string starttimeField;

        private string finishtimeField;

        private ushort cycletimeminField;

        private string cycletimefactorField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte period
        {
            get
            {
                return this.periodField;
            }
            set
            {
                this.periodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string starttime
        {
            get
            {
                return this.starttimeField;
            }
            set
            {
                this.starttimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string finishtime
        {
            get
            {
                return this.finishtimeField;
            }
            set
            {
                this.finishtimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort cycletimemin
        {
            get
            {
                return this.cycletimeminField;
            }
            set
            {
                this.cycletimeminField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string cycletimefactor
        {
            get
            {
                return this.cycletimefactorField;
            }
            set
            {
                this.cycletimefactorField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class resultsResult
    {

        private resultsResultGeneral generalField;

        private resultsResultDefectivegoods defectivegoodsField;

        private resultsResultNormalsale normalsaleField;

        private resultsResultDirectsale directsaleField;

        private resultsResultMarketplacesale marketplacesaleField;

        private resultsResultSummary summaryField;

        /// <remarks/>
        public resultsResultGeneral general
        {
            get
            {
                return this.generalField;
            }
            set
            {
                this.generalField = value;
            }
        }

        /// <remarks/>
        public resultsResultDefectivegoods defectivegoods
        {
            get
            {
                return this.defectivegoodsField;
            }
            set
            {
                this.defectivegoodsField = value;
            }
        }

        /// <remarks/>
        public resultsResultNormalsale normalsale
        {
            get
            {
                return this.normalsaleField;
            }
            set
            {
                this.normalsaleField = value;
            }
        }

        /// <remarks/>
        public resultsResultDirectsale directsale
        {
            get
            {
                return this.directsaleField;
            }
            set
            {
                this.directsaleField = value;
            }
        }

        /// <remarks/>
        public resultsResultMarketplacesale marketplacesale
        {
            get
            {
                return this.marketplacesaleField;
            }
            set
            {
                this.marketplacesaleField = value;
            }
        }

        /// <remarks/>
        public resultsResultSummary summary
        {
            get
            {
                return this.summaryField;
            }
            set
            {
                this.summaryField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class resultsResultGeneral
    {

        private resultsResultGeneralCapacity capacityField;

        private resultsResultGeneralPossiblecapacity possiblecapacityField;

        private resultsResultGeneralRelpossiblenormalcapacity relpossiblenormalcapacityField;

        private resultsResultGeneralProductivetime productivetimeField;

        private resultsResultGeneralEffiency effiencyField;

        private resultsResultGeneralSellwish sellwishField;

        private resultsResultGeneralSalesquantity salesquantityField;

        private resultsResultGeneralDeliveryreliability deliveryreliabilityField;

        private resultsResultGeneralIdletime idletimeField;

        private resultsResultGeneralIdletimecosts idletimecostsField;

        private resultsResultGeneralStorevalue storevalueField;

        private resultsResultGeneralStoragecosts storagecostsField;

        /// <remarks/>
        public resultsResultGeneralCapacity capacity
        {
            get
            {
                return this.capacityField;
            }
            set
            {
                this.capacityField = value;
            }
        }

        /// <remarks/>
        public resultsResultGeneralPossiblecapacity possiblecapacity
        {
            get
            {
                return this.possiblecapacityField;
            }
            set
            {
                this.possiblecapacityField = value;
            }
        }

        /// <remarks/>
        public resultsResultGeneralRelpossiblenormalcapacity relpossiblenormalcapacity
        {
            get
            {
                return this.relpossiblenormalcapacityField;
            }
            set
            {
                this.relpossiblenormalcapacityField = value;
            }
        }

        /// <remarks/>
        public resultsResultGeneralProductivetime productivetime
        {
            get
            {
                return this.productivetimeField;
            }
            set
            {
                this.productivetimeField = value;
            }
        }

        /// <remarks/>
        public resultsResultGeneralEffiency effiency
        {
            get
            {
                return this.effiencyField;
            }
            set
            {
                this.effiencyField = value;
            }
        }

        /// <remarks/>
        public resultsResultGeneralSellwish sellwish
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
        public resultsResultGeneralSalesquantity salesquantity
        {
            get
            {
                return this.salesquantityField;
            }
            set
            {
                this.salesquantityField = value;
            }
        }

        /// <remarks/>
        public resultsResultGeneralDeliveryreliability deliveryreliability
        {
            get
            {
                return this.deliveryreliabilityField;
            }
            set
            {
                this.deliveryreliabilityField = value;
            }
        }

        /// <remarks/>
        public resultsResultGeneralIdletime idletime
        {
            get
            {
                return this.idletimeField;
            }
            set
            {
                this.idletimeField = value;
            }
        }

        /// <remarks/>
        public resultsResultGeneralIdletimecosts idletimecosts
        {
            get
            {
                return this.idletimecostsField;
            }
            set
            {
                this.idletimecostsField = value;
            }
        }

        /// <remarks/>
        public resultsResultGeneralStorevalue storevalue
        {
            get
            {
                return this.storevalueField;
            }
            set
            {
                this.storevalueField = value;
            }
        }

        /// <remarks/>
        public resultsResultGeneralStoragecosts storagecosts
        {
            get
            {
                return this.storagecostsField;
            }
            set
            {
                this.storagecostsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class resultsResultGeneralCapacity
    {

        private ushort currentField;

        private string averageField;

        private ushort allField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort current
        {
            get
            {
                return this.currentField;
            }
            set
            {
                this.currentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string average
        {
            get
            {
                return this.averageField;
            }
            set
            {
                this.averageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort all
        {
            get
            {
                return this.allField;
            }
            set
            {
                this.allField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class resultsResultGeneralPossiblecapacity
    {

        private ushort currentField;

        private string averageField;

        private ushort allField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort current
        {
            get
            {
                return this.currentField;
            }
            set
            {
                this.currentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string average
        {
            get
            {
                return this.averageField;
            }
            set
            {
                this.averageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort all
        {
            get
            {
                return this.allField;
            }
            set
            {
                this.allField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class resultsResultGeneralRelpossiblenormalcapacity
    {

        private string currentField;

        private string averageField;

        private string allField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string current
        {
            get
            {
                return this.currentField;
            }
            set
            {
                this.currentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string average
        {
            get
            {
                return this.averageField;
            }
            set
            {
                this.averageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string all
        {
            get
            {
                return this.allField;
            }
            set
            {
                this.allField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class resultsResultGeneralProductivetime
    {

        private ushort currentField;

        private string averageField;

        private ushort allField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort current
        {
            get
            {
                return this.currentField;
            }
            set
            {
                this.currentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string average
        {
            get
            {
                return this.averageField;
            }
            set
            {
                this.averageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort all
        {
            get
            {
                return this.allField;
            }
            set
            {
                this.allField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class resultsResultGeneralEffiency
    {

        private string currentField;

        private string averageField;

        private string allField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string current
        {
            get
            {
                return this.currentField;
            }
            set
            {
                this.currentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string average
        {
            get
            {
                return this.averageField;
            }
            set
            {
                this.averageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string all
        {
            get
            {
                return this.allField;
            }
            set
            {
                this.allField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class resultsResultGeneralSellwish
    {

        private ushort currentField;

        private string averageField;

        private ushort allField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort current
        {
            get
            {
                return this.currentField;
            }
            set
            {
                this.currentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string average
        {
            get
            {
                return this.averageField;
            }
            set
            {
                this.averageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort all
        {
            get
            {
                return this.allField;
            }
            set
            {
                this.allField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class resultsResultGeneralSalesquantity
    {

        private ushort currentField;

        private string averageField;

        private ushort allField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort current
        {
            get
            {
                return this.currentField;
            }
            set
            {
                this.currentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string average
        {
            get
            {
                return this.averageField;
            }
            set
            {
                this.averageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort all
        {
            get
            {
                return this.allField;
            }
            set
            {
                this.allField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class resultsResultGeneralDeliveryreliability
    {

        private string currentField;

        private string averageField;

        private string allField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string current
        {
            get
            {
                return this.currentField;
            }
            set
            {
                this.currentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string average
        {
            get
            {
                return this.averageField;
            }
            set
            {
                this.averageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string all
        {
            get
            {
                return this.allField;
            }
            set
            {
                this.allField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class resultsResultGeneralIdletime
    {

        private ushort currentField;

        private string averageField;

        private ushort allField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort current
        {
            get
            {
                return this.currentField;
            }
            set
            {
                this.currentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string average
        {
            get
            {
                return this.averageField;
            }
            set
            {
                this.averageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort all
        {
            get
            {
                return this.allField;
            }
            set
            {
                this.allField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class resultsResultGeneralIdletimecosts
    {

        private string currentField;

        private string averageField;

        private string allField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string current
        {
            get
            {
                return this.currentField;
            }
            set
            {
                this.currentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string average
        {
            get
            {
                return this.averageField;
            }
            set
            {
                this.averageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string all
        {
            get
            {
                return this.allField;
            }
            set
            {
                this.allField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class resultsResultGeneralStorevalue
    {

        private string currentField;

        private string averageField;

        private string allField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string current
        {
            get
            {
                return this.currentField;
            }
            set
            {
                this.currentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string average
        {
            get
            {
                return this.averageField;
            }
            set
            {
                this.averageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string all
        {
            get
            {
                return this.allField;
            }
            set
            {
                this.allField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class resultsResultGeneralStoragecosts
    {

        private string currentField;

        private string averageField;

        private string allField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string current
        {
            get
            {
                return this.currentField;
            }
            set
            {
                this.currentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string average
        {
            get
            {
                return this.averageField;
            }
            set
            {
                this.averageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string all
        {
            get
            {
                return this.allField;
            }
            set
            {
                this.allField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class resultsResultDefectivegoods
    {

        private resultsResultDefectivegoodsQuantity quantityField;

        private resultsResultDefectivegoodsCosts costsField;

        /// <remarks/>
        public resultsResultDefectivegoodsQuantity quantity
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
        public resultsResultDefectivegoodsCosts costs
        {
            get
            {
                return this.costsField;
            }
            set
            {
                this.costsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class resultsResultDefectivegoodsQuantity
    {

        private byte currentField;

        private string averageField;

        private byte allField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte current
        {
            get
            {
                return this.currentField;
            }
            set
            {
                this.currentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string average
        {
            get
            {
                return this.averageField;
            }
            set
            {
                this.averageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte all
        {
            get
            {
                return this.allField;
            }
            set
            {
                this.allField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class resultsResultDefectivegoodsCosts
    {

        private string currentField;

        private string averageField;

        private string allField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string current
        {
            get
            {
                return this.currentField;
            }
            set
            {
                this.currentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string average
        {
            get
            {
                return this.averageField;
            }
            set
            {
                this.averageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string all
        {
            get
            {
                return this.allField;
            }
            set
            {
                this.allField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class resultsResultNormalsale
    {

        private resultsResultNormalsaleSalesprice salespriceField;

        private resultsResultNormalsaleProfit profitField;

        private resultsResultNormalsaleProfitperunit profitperunitField;

        /// <remarks/>
        public resultsResultNormalsaleSalesprice salesprice
        {
            get
            {
                return this.salespriceField;
            }
            set
            {
                this.salespriceField = value;
            }
        }

        /// <remarks/>
        public resultsResultNormalsaleProfit profit
        {
            get
            {
                return this.profitField;
            }
            set
            {
                this.profitField = value;
            }
        }

        /// <remarks/>
        public resultsResultNormalsaleProfitperunit profitperunit
        {
            get
            {
                return this.profitperunitField;
            }
            set
            {
                this.profitperunitField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class resultsResultNormalsaleSalesprice
    {

        private string currentField;

        private string averageField;

        private string allField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string current
        {
            get
            {
                return this.currentField;
            }
            set
            {
                this.currentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string average
        {
            get
            {
                return this.averageField;
            }
            set
            {
                this.averageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string all
        {
            get
            {
                return this.allField;
            }
            set
            {
                this.allField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class resultsResultNormalsaleProfit
    {

        private string currentField;

        private string averageField;

        private string allField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string current
        {
            get
            {
                return this.currentField;
            }
            set
            {
                this.currentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string average
        {
            get
            {
                return this.averageField;
            }
            set
            {
                this.averageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string all
        {
            get
            {
                return this.allField;
            }
            set
            {
                this.allField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class resultsResultNormalsaleProfitperunit
    {

        private string currentField;

        private string averageField;

        private string allField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string current
        {
            get
            {
                return this.currentField;
            }
            set
            {
                this.currentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string average
        {
            get
            {
                return this.averageField;
            }
            set
            {
                this.averageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string all
        {
            get
            {
                return this.allField;
            }
            set
            {
                this.allField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class resultsResultDirectsale
    {

        private resultsResultDirectsaleProfit profitField;

        private resultsResultDirectsaleContractpenalty contractpenaltyField;

        /// <remarks/>
        public resultsResultDirectsaleProfit profit
        {
            get
            {
                return this.profitField;
            }
            set
            {
                this.profitField = value;
            }
        }

        /// <remarks/>
        public resultsResultDirectsaleContractpenalty contractpenalty
        {
            get
            {
                return this.contractpenaltyField;
            }
            set
            {
                this.contractpenaltyField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class resultsResultDirectsaleProfit
    {

        private string currentField;

        private string averageField;

        private string allField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string current
        {
            get
            {
                return this.currentField;
            }
            set
            {
                this.currentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string average
        {
            get
            {
                return this.averageField;
            }
            set
            {
                this.averageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string all
        {
            get
            {
                return this.allField;
            }
            set
            {
                this.allField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class resultsResultDirectsaleContractpenalty
    {

        private string currentField;

        private string averageField;

        private string allField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string current
        {
            get
            {
                return this.currentField;
            }
            set
            {
                this.currentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string average
        {
            get
            {
                return this.averageField;
            }
            set
            {
                this.averageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string all
        {
            get
            {
                return this.allField;
            }
            set
            {
                this.allField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class resultsResultMarketplacesale
    {

        private resultsResultMarketplacesaleProfit profitField;

        /// <remarks/>
        public resultsResultMarketplacesaleProfit profit
        {
            get
            {
                return this.profitField;
            }
            set
            {
                this.profitField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class resultsResultMarketplacesaleProfit
    {

        private string currentField;

        private string averageField;

        private string allField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string current
        {
            get
            {
                return this.currentField;
            }
            set
            {
                this.currentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string average
        {
            get
            {
                return this.averageField;
            }
            set
            {
                this.averageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string all
        {
            get
            {
                return this.allField;
            }
            set
            {
                this.allField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class resultsResultSummary
    {

        private resultsResultSummaryProfit profitField;

        /// <remarks/>
        public resultsResultSummaryProfit profit
        {
            get
            {
                return this.profitField;
            }
            set
            {
                this.profitField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class resultsResultSummaryProfit
    {

        private string currentField;

        private string averageField;

        private string allField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string current
        {
            get
            {
                return this.currentField;
            }
            set
            {
                this.currentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string average
        {
            get
            {
                return this.averageField;
            }
            set
            {
                this.averageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string all
        {
            get
            {
                return this.allField;
            }
            set
            {
                this.allField = value;
            }
        }
    }


}
