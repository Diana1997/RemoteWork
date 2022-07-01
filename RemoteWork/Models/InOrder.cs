using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Serialization;

namespace RemoteWork.Models
{
    [XmlRoot(ElementName="inOrder")]
    public class InOrder { 

        [XmlElement(ElementName="OrderXml")] 
        public OrderXml OrderXml { get; set; }
    }
}