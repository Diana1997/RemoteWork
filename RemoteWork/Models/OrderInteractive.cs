using System.Xml.Serialization;

namespace RemoteWork.Models
{

    [XmlRoot(ElementName="OrderInteractive", Namespace = "http://adrconnect.mvrs.com/adrconnect/2013/04/")]
    public class OrderInteractive { 

        [XmlElement(ElementName="inCommunications")] 
        public string InCommunications { get; set; } 

        [XmlElement(ElementName="inOrder")] 
        public InOrder InOrder { get; set; } 

        [XmlAttribute(AttributeName="xmlns")] 
        public string Xmlns { get; set; } 

        [XmlText] 
        public string Text { get; set; } 
    }
}