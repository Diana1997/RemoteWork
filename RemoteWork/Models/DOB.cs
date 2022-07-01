using System.Xml.Serialization;

namespace RemoteWork.Models
{
    [XmlRoot(ElementName="DOB")]
    public class DOB { 

        [XmlElement(ElementName="Year")] 
        public int Year { get; set; } 

        [XmlElement(ElementName="Month")] 
        public int Month { get; set; } 

        [XmlElement(ElementName="Day")] 
        public int Day { get; set; } 
    }

}