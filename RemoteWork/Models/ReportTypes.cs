using System.Xml.Serialization;

namespace RemoteWork.Models
{
    [XmlRoot(ElementName="ReportTypes")]
    public class ReportTypes { 

        [XmlElement(ElementName="Type")] 
        public string Type { get; set; } 
    }
}