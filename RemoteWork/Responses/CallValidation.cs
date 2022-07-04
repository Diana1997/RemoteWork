using System.Xml.Serialization;

namespace RemoteWork.Responses
{
    [XmlRoot(ElementName="CallValidation")]
    public class CallValidation { 

        [XmlElement(ElementName="DaysLeft")] 
        public int DaysLeft { get; set; } 

        [XmlElement(ElementName="ErrorDescription")] 
        public string ErrorDescription { get; set; } 

        [XmlElement(ElementName="ErrorId")] 
        public int ErrorId { get; set; } 

        [XmlElement(ElementName="Message")] 
        public string Message { get; set; } 
    }
}