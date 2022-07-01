using System.Xml.Serialization;

namespace RemoteWork.Models
{
    [XmlRoot(ElementName="Communications")]
    public class Communications { 

        [XmlElement(ElementName="Account")] 
        public string Account { get; set; } 

        [XmlElement(ElementName="UserID")] 
        public string UserID { get; set; } 

        [XmlElement(ElementName="Password")] 
        public string Password { get; set; } 

        [XmlElement(ElementName="ReportTypes")] 
        public ReportTypes ReportTypes { get; set; } 
    }
}