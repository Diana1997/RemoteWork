using System.Xml.Serialization;

namespace RemoteWork.Responses
{
   
    [XmlRoot(ElementName="Report")]
    public class Report { 

        [XmlElement(ElementName="Formats")] 
        public Formats Formats { get; set; } 
    }

}