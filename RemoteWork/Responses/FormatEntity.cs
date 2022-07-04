using System.Xml.Serialization;

namespace RemoteWork.Responses
{
    
    [XmlRoot(ElementName="FormatEntity")]
    public class FormatEntity { 

        [XmlElement(ElementName="Data")] 
        public string Data { get; set; } 

        [XmlElement(ElementName="Type")] 
        public string Type { get; set; } 
    }
}