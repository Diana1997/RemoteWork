﻿using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Serialization;

namespace RemoteWork.Models
{
    [XmlRoot(ElementName="inCommunications")]
    public class InCommunications
    {
        [XmlIgnore]
        [XmlWrapCData]
        public Communications Communications { set; get; }
                
        [XmlText] // NECESSARY TO EMIT CDATA NODES
        [IgnoreDataMember]
        [JsonIgnore]
        public XmlNode[] CDataContent
        {
            get
            {
                return XmlWrapCDataHelper.GetCDataContent(this);
            }
            set
            {
                XmlWrapCDataHelper.SetCDataContent(this, value);
            }
        }
    }
}