using System.Xml.Serialization;

namespace RemoteWork.Responses
{
	[XmlRoot(ElementName="Formats")]
 public class Formats { 
 
 	[XmlElement(ElementName="FormatEntity")] 
 	public FormatEntity FormatEntity { get; set; } 
 }
}