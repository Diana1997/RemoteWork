using System.Xml.Serialization;

namespace RemoteWork.Models
{
    [XmlRoot(ElementName="State")]
    public class State { 

        [XmlElement(ElementName="Abbrev")] 
        public string Abbrev { get; set; } 

        [XmlElement(ElementName="Full")] 
        public object Full { get; set; } 
    }
}