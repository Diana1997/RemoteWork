using System.Xml.Serialization;

namespace RemoteWork.Models
{
    [XmlRoot(ElementName="Body")]
    public class Body { 

        [XmlElement(ElementName="OrderInteractive",  Namespace = "http://adrconnect.mvrs.com/adrconnect/2013/04/")] 
        public OrderInteractive OrderInteractive { get; set; } 
    }
}