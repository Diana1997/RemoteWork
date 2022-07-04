using System.Xml.Serialization;

namespace RemoteWork.Responses
{
    
    [XmlRoot(ElementName="OrderInteractiveResult")]
    public class OrderInteractiveResult { 

        [XmlElement(ElementName="CallValidation")] 
        public CallValidation CallValidation { get; set; } 

        [XmlElement(ElementName="Report")] 
        public Report Report { get; set; } 

        [XmlAttribute(AttributeName="i")] 
        public string I { get; set; } 

        [XmlText] 
        public string Text { get; set; } 
    }
}