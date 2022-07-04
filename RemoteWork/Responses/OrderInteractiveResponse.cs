using System.Xml.Serialization;

namespace RemoteWork.Responses
{
   
        [XmlRoot(ElementName="OrderInteractiveResponse")]
        public class OrderInteractiveResponse { 

            [XmlElement(ElementName="OrderInteractiveResult")] 
            public OrderInteractiveResult OrderInteractiveResult { get; set; } 

            [XmlAttribute(AttributeName="xmlns")] 
            public string Xmlns { get; set; } 

            [XmlText] 
            public string Text { get; set; } 
        }

    
}