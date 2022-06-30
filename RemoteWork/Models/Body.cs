using System.Xml.Serialization;

namespace RemoteWork.Models
{
    [XmlRoot(ElementName="Body")]
    public class Body { 

        [XmlElement(ElementName="OrderInteractive")] 
        public OrderInteractive OrderInteractive { get; set; } 
    }
}