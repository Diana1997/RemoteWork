using System.Xml.Serialization;
using RemoteWork.Models;

namespace RemoteWork.Responses
{
    [XmlRoot(ElementName="Envelope")]
    public class Envelope { 

        [XmlElement(ElementName="Body")] 
        public Body Body { get; set; } 

        [XmlAttribute(AttributeName="s")] 
        public string S { get; set; } 

        
        [XmlText] 
        public string Text { get; set; } 
    }
    

}