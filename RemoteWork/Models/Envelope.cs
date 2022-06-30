using System.Xml.Serialization;

namespace RemoteWork.Models
{

    [XmlRoot(ElementName="Envelope", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]

    public class Envelope { 

        [XmlElement(ElementName="Body")] 
        public Body Body { get; set; } 

        [XmlAttribute(AttributeName="xmlns")] 
        public string Xmlns { get; set; } 

        [XmlText] 
        public string Text { get; set; } 
    }
}