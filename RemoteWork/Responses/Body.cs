using System.Xml.Serialization;

namespace RemoteWork.Responses
{
  
        [XmlRoot(ElementName="Body")]
        public class Body { 

            [XmlElement(ElementName="OrderInteractiveResponse")] 
            public OrderInteractiveResponse OrderInteractiveResponse { get; set; } 
        }
    
}