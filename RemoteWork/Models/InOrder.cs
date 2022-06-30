using System.Xml.Serialization;

namespace RemoteWork.Models
{
    [XmlRoot(ElementName="inOrder")]
    public class InOrder { 

        [XmlElement(ElementName="OrderXml")] 
        public string OrderXml { get; set; } 
    }
}