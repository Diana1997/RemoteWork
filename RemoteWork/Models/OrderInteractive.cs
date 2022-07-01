using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Serialization;

namespace RemoteWork.Models
{

    public class OrderInteractive { 

 
        
        [XmlElement(ElementName="inCommunications")] 
        public InCommunications InCommunications { get; set; } 
        
        /*[XmlElement(ElementName="inCommunications")]
        public System.Xml.XmlCDataSection MyStringCDATA
        {
            get
            {
                return new System.Xml.XmlDocument().CreateCDataSection(
                    InCommunications);
            }
            set
            {
                InCommunications = value.Value;
            }
        }*/
        


        [XmlElement(ElementName="inOrder")] 
        public InOrder InOrder { get; set; } 

        [XmlAttribute(AttributeName="xmlns")] 
        public string Xmlns { get; set; } 
        
    }
}