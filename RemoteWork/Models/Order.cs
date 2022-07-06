using System.Xml.Serialization;

namespace RemoteWork.Models
{
    [XmlRoot(ElementName="Order")]
    public class Order { 

        [XmlElement(ElementName="Handling")] 
        public string Handling { get; set; } 

        [XmlElement(ElementName="Misc")] 
        public string Misc { get; set; } 

        [XmlElement(ElementName="BillCode")] 
        public string BillCode { get; set; } 

        [XmlElement(ElementName="State")] 
        public State State { get; set; } 

        [XmlElement(ElementName="Subtype")] 
        public string Subtype { get; set; } 

        [XmlElement(ElementName="ProductID")] 
        public string ProductID { get; set; } 

        [XmlElement(ElementName="HintMvrInsuranceOption")] 
        public string HintMvrInsuranceOption { get; set; } 

        [XmlElement(ElementName="HintVertical")] 
        public string HintVertical { get; set; } 

        [XmlElement(ElementName="Purpose")] 
        public string Purpose { get; set; } 

        [XmlElement(ElementName="License")] 
        public string License { get; set; } 

        [XmlElement(ElementName="FirstName")] 
        public string FirstName { get; set; } 

        [XmlElement(ElementName="LastName")] 
        public string LastName { get; set; } 

        [XmlElement(ElementName="DOB")] 
        public DOB DOB { get; set; }
    }
}