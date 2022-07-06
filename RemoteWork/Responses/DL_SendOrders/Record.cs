using System.Xml.Serialization;
using System.Collections.Generic;

namespace RemoteWork.Responses.DL_SendOrders
{
  // using System.Xml.Serialization;
  // XmlSerializer serializer = new XmlSerializer(typeof(Record));
  // using (StringReader reader = new StringReader(xml))
  // {
  //    var test = (Record)serializer.Deserialize(reader);
  // }
  
  [XmlRoot(ElementName="OrderDate")]
  public class OrderDate { 
  
  	[XmlElement(ElementName="Year")] 
  	public int Year { get; set; } 
  
  	[XmlElement(ElementName="Month")] 
  	public int Month { get; set; } 
  
  	[XmlElement(ElementName="Day")] 
  	public int Day { get; set; } 
  }
  
  [XmlRoot(ElementName="OrderTime")]
  public class OrderTime { 
  
  	[XmlElement(ElementName="Hour")] 
  	public int Hour { get; set; } 
  
  	[XmlElement(ElementName="Minute")] 
  	public int Minute { get; set; } 
  
  	[XmlElement(ElementName="Second")] 
  	public int Second { get; set; } 
  }
  
  [XmlRoot(ElementName="State")]
  public class State { 
  
  	[XmlElement(ElementName="Abbrev")] 
  	public string Abbrev { get; set; } 
  
  	[XmlElement(ElementName="Full")] 
  	public string Full { get; set; } 
  }
  
  [XmlRoot(ElementName="BirthDate")]
  public class BirthDate { 
  
  	[XmlElement(ElementName="Year")] 
  	public int Year { get; set; } 
  
  	[XmlElement(ElementName="Month")] 
  	public int Month { get; set; } 
  
  	[XmlElement(ElementName="Day")] 
  	public int Day { get; set; } 
  }
  
  [XmlRoot(ElementName="Criteria")]
  public class Criteria { 
  
  	[XmlElement(ElementName="OrderDate")] 
  	public OrderDate OrderDate { get; set; } 
  
  	[XmlElement(ElementName="OrderTime")] 
  	public OrderTime OrderTime { get; set; } 
  
  	[XmlElement(ElementName="AccountID")] 
  	public string AccountID { get; set; } 
  
  	[XmlElement(ElementName="UserID")] 
  	public string UserID { get; set; } 
  
  	[XmlElement(ElementName="Routing")] 
  	public string Routing { get; set; } 
  
  	[XmlElement(ElementName="Purpose")] 
  	public string Purpose { get; set; } 
  
  	[XmlElement(ElementName="Reference")] 
  	public int Reference { get; set; } 
  
  	[XmlElement(ElementName="TrackingNumber")] 
  	public int TrackingNumber { get; set; } 
  
  	[XmlElement(ElementName="Host")] 
  	public string Host { get; set; } 
  
  	[XmlElement(ElementName="ProductID")] 
  	public string ProductID { get; set; } 
  
  	[XmlElement(ElementName="State")] 
  	public State State { get; set; } 
  
  	[XmlElement(ElementName="Subtype")] 
  	public string Subtype { get; set; } 
  
  	[XmlElement(ElementName="SubtypeFull")] 
  	public string SubtypeFull { get; set; } 
  
  	[XmlElement(ElementName="FirstName")] 
  	public string FirstName { get; set; } 
  
  	[XmlElement(ElementName="MiddleName")] 
  	public string MiddleName { get; set; } 
  
  	[XmlElement(ElementName="LastName")] 
  	public string LastName { get; set; } 
  
  	[XmlElement(ElementName="BirthDate")] 
  	public BirthDate BirthDate { get; set; } 
  
  	[XmlElement(ElementName="LicenseNumber")] 
  	public string LicenseNumber { get; set; } 
  }
  
  [XmlRoot(ElementName="ReturnedDate")]
  public class ReturnedDate { 
  
  	[XmlElement(ElementName="Year")] 
  	public int Year { get; set; } 
  
  	[XmlElement(ElementName="Month")] 
  	public int Month { get; set; } 
  
  	[XmlElement(ElementName="Day")] 
  	public int Day { get; set; } 
  }
  
  [XmlRoot(ElementName="ReturnedTime")]
  public class ReturnedTime { 
  
  	[XmlElement(ElementName="Hour")] 
  	public int Hour { get; set; } 
  
  	[XmlElement(ElementName="Minute")] 
  	public int Minute { get; set; } 
  
  	[XmlElement(ElementName="Second")] 
  	public int Second { get; set; } 
  }
  
  [XmlRoot(ElementName="Result")]
  public class Result { 
  
  	[XmlElement(ElementName="Control")] 
  	public string Control { get; set; } 
  
  	[XmlElement(ElementName="Valid")] 
  	public string Valid { get; set; } 
  
  	[XmlElement(ElementName="ReturnedDate")] 
  	public ReturnedDate ReturnedDate { get; set; } 
  
  	[XmlElement(ElementName="ReturnedTime")] 
  	public ReturnedTime ReturnedTime { get; set; } 
  
  	[XmlElement(ElementName="IsClear")] 
  	public string IsClear { get; set; } 
  }
  
  [XmlRoot(ElementName="AddressItem")]
  public class AddressItem { 
  
  	[XmlElement(ElementName="Street")] 
  	public string Street { get; set; } 
  
  	[XmlElement(ElementName="City")] 
  	public string City { get; set; } 
  
  	[XmlElement(ElementName="State")] 
  	public State State { get; set; } 
  
  	[XmlElement(ElementName="Zip")] 
  	public int Zip { get; set; } 
  }
  
  [XmlRoot(ElementName="AddressList")]
  public class AddressList { 
  
  	[XmlElement(ElementName="AddressItem")] 
  	public AddressItem AddressItem { get; set; } 
  }
  
  [XmlRoot(ElementName="Driver")]
  public class Driver { 
  
  	[XmlElement(ElementName="FirstName")] 
  	public string FirstName { get; set; } 
  
  	[XmlElement(ElementName="MiddleName")] 
  	public string MiddleName { get; set; } 
  
  	[XmlElement(ElementName="LastName")] 
  	public string LastName { get; set; } 
  
  	[XmlElement(ElementName="BirthDate")] 
  	public BirthDate BirthDate { get; set; } 
  
  	[XmlElement(ElementName="Age")] 
  	public int Age { get; set; } 
  
  	[XmlElement(ElementName="EyeColor")] 
  	public string EyeColor { get; set; } 
  
  	[XmlElement(ElementName="HairColor")] 
  	public string HairColor { get; set; } 
  
  	[XmlElement(ElementName="Weight")] 
  	public int Weight { get; set; } 
  
  	[XmlElement(ElementName="Height")] 
  	public int Height { get; set; } 
  
  	[XmlElement(ElementName="Gender")] 
  	public string Gender { get; set; } 
  
  	[XmlElement(ElementName="AddressList")] 
  	public AddressList AddressList { get; set; } 
  }
  
  [XmlRoot(ElementName="IssueDate")]
  public class IssueDate { 
  
  	[XmlElement(ElementName="Year")] 
  	public int Year { get; set; } 
  
  	[XmlElement(ElementName="Month")] 
  	public int Month { get; set; } 
  
  	[XmlElement(ElementName="Day")] 
  	public int Day { get; set; } 
  }
  
  [XmlRoot(ElementName="ExpirationDate")]
  public class ExpirationDate { 
  
  	[XmlElement(ElementName="Year")] 
  	public int Year { get; set; } 
  
  	[XmlElement(ElementName="Month")] 
  	public int Month { get; set; } 
  
  	[XmlElement(ElementName="Day")] 
  	public int Day { get; set; } 
  }
  
  [XmlRoot(ElementName="StatusItem")]
  public class StatusItem { 
  
  	[XmlElement(ElementName="Name")] 
  	public string Name { get; set; } 
  }
  
  [XmlRoot(ElementName="StatusList")]
  public class StatusList { 
  
  	[XmlElement(ElementName="StatusItem")] 
  	public StatusItem StatusItem { get; set; } 
  }
  
  [XmlRoot(ElementName="Personal")]
  public class Personal { 
  
  	[XmlElement(ElementName="Type")] 
  	public string Type { get; set; } 
  
  	[XmlElement(ElementName="ClassDescription")] 
  	public string ClassDescription { get; set; } 
  
  	[XmlElement(ElementName="ClassCode")] 
  	public string ClassCode { get; set; } 
  
  	[XmlElement(ElementName="IssueDate")] 
  	public IssueDate IssueDate { get; set; } 
  
  	[XmlElement(ElementName="ExpirationDate")] 
  	public ExpirationDate ExpirationDate { get; set; } 
  
  	[XmlElement(ElementName="StatusList")] 
  	public StatusList StatusList { get; set; } 
  }
  
  [XmlRoot(ElementName="Identification")]
  public class Identification { 
  
  	[XmlElement(ElementName="Type")] 
  	public string Type { get; set; } 
  
  	[XmlElement(ElementName="ClassDescription")] 
  	public string ClassDescription { get; set; } 
  
  	[XmlElement(ElementName="ClassCode")] 
  	public string ClassCode { get; set; } 
  
  	[XmlElement(ElementName="IssueDate")] 
  	public IssueDate IssueDate { get; set; } 
  
  	[XmlElement(ElementName="StatusList")] 
  	public StatusList StatusList { get; set; } 
  }
  
  [XmlRoot(ElementName="CurrentLicense")]
  public class CurrentLicense { 
  
  	[XmlElement(ElementName="Personal")] 
  	public Personal Personal { get; set; } 
  
  	[XmlElement(ElementName="Identification")] 
  	public Identification Identification { get; set; } 
  
  	[XmlElement(ElementName="Number")] 
  	public string Number { get; set; } 
  }
  
  [XmlRoot(ElementName="MessageItem")]
  public class MessageItem { 
  
  	[XmlElement(ElementName="Line")] 
  	public List<string> Line { get; set; } 
  }
  
  [XmlRoot(ElementName="MessageList")]
  public class MessageList { 
  
  	[XmlElement(ElementName="MessageItem")] 
  	public MessageItem MessageItem { get; set; } 
  }
  
  [XmlRoot(ElementName="Date")]
  public class Date { 
  
  	[XmlElement(ElementName="Year")] 
  	public int Year { get; set; } 
  
  	[XmlElement(ElementName="Month")] 
  	public int Month { get; set; } 
  
  	[XmlElement(ElementName="Day")] 
  	public int Day { get; set; } 
  }
  
  [XmlRoot(ElementName="Common")]
  public class Common { 
  
  	[XmlElement(ElementName="Subtype")] 
  	public string Subtype { get; set; } 
  
  	[XmlElement(ElementName="State")] 
  	public State State { get; set; } 
  
  	[XmlElement(ElementName="Date")] 
  	public Date Date { get; set; } 
  
  	[XmlElement(ElementName="Location")] 
  	public string Location { get; set; } 
  
  	[XmlElement(ElementName="LocationCode")] 
  	public int LocationCode { get; set; } 
  
  	[XmlElement(ElementName="Plate")] 
  	public string Plate { get; set; } 
  }
  
  [XmlRoot(ElementName="DescriptionItem")]
  public class DescriptionItem { 
  
  	[XmlElement(ElementName="AdrLargeDescription")] 
  	public string AdrLargeDescription { get; set; } 
  
  	[XmlElement(ElementName="AdrSmallDescription")] 
  	public string AdrSmallDescription { get; set; } 
  
  	[XmlElement(ElementName="StateDescription")] 
  	public string StateDescription { get; set; } 
  
  	[XmlElement(ElementName="StateCode")] 
  	public string StateCode { get; set; } 
  
  	[XmlElement(ElementName="Acd")] 
  	public string Acd { get; set; } 
  
  	[XmlElement(ElementName="Avd1")] 
  	public string Avd1 { get; set; } 
  
  	[XmlElement(ElementName="Avd2")] 
  	public string Avd2 { get; set; } 
  
  	[XmlElement(ElementName="TableKey")] 
  	public string TableKey { get; set; } 
  }
  
  [XmlRoot(ElementName="DescriptionList")]
  public class DescriptionList { 
  
  	[XmlElement(ElementName="DescriptionItem")] 
  	public DescriptionItem DescriptionItem { get; set; } 
  }
  
  [XmlRoot(ElementName="Violation")]
  public class Violation { 
  
  	[XmlElement(ElementName="ActualSpeed")] 
  	public int ActualSpeed { get; set; } 
  
  	[XmlElement(ElementName="PostedSpeed")] 
  	public int PostedSpeed { get; set; } 
  
  	[XmlElement(ElementName="Disposition")] 
  	public string Disposition { get; set; } 
  
  	[XmlElement(ElementName="FineAmount")] 
  	public double FineAmount { get; set; } 
  }
  
  [XmlRoot(ElementName="EventItem")]
  public class EventItem { 
  
  	[XmlElement(ElementName="Common")] 
  	public Common Common { get; set; } 
  
  	[XmlElement(ElementName="DescriptionList")] 
  	public DescriptionList DescriptionList { get; set; } 
  
  	[XmlElement(ElementName="Violation")] 
  	public Violation Violation { get; set; } 
  
  	[XmlElement(ElementName="Action")] 
  	public Action Action { get; set; } 
  }
  
  [XmlRoot(ElementName="ClearDate")]
  public class ClearDate { 
  
  	[XmlElement(ElementName="Year")] 
  	public int Year { get; set; } 
  
  	[XmlElement(ElementName="Month")] 
  	public int Month { get; set; } 
  
  	[XmlElement(ElementName="Day")] 
  	public int Day { get; set; } 
  }
  
  [XmlRoot(ElementName="MailDate")]
  public class MailDate { 
  
  	[XmlElement(ElementName="Year")] 
  	public int Year { get; set; } 
  
  	[XmlElement(ElementName="Month")] 
  	public int Month { get; set; } 
  
  	[XmlElement(ElementName="Day")] 
  	public int Day { get; set; } 
  }
  
  [XmlRoot(ElementName="Action")]
  public class Action { 
  
  	[XmlElement(ElementName="ClearDate")] 
  	public ClearDate ClearDate { get; set; } 
  
  	[XmlElement(ElementName="MailDate")] 
  	public MailDate MailDate { get; set; } 
  }
  
  [XmlRoot(ElementName="EventList")]
  public class EventList { 
  
  	[XmlElement(ElementName="EventItem")] 
  	public List<EventItem> EventItem { get; set; } 
  }
  
  [XmlRoot(ElementName="DlRecord")]
  public class DlRecord { 
  
  	[XmlElement(ElementName="Criteria")] 
  	public Criteria Criteria { get; set; } 
  
  	[XmlElement(ElementName="Result")] 
  	public Result Result { get; set; } 
  
  	[XmlElement(ElementName="Driver")] 
  	public Driver Driver { get; set; } 
  
  	[XmlElement(ElementName="CurrentLicense")] 
  	public CurrentLicense CurrentLicense { get; set; } 
  
  	[XmlElement(ElementName="MessageList")] 
  	public MessageList MessageList { get; set; } 
  
  	[XmlElement(ElementName="EventList")] 
  	public EventList EventList { get; set; } 
  }
  
  [XmlRoot(ElementName="Record")]
  public class Record { 
  
  	[XmlElement(ElementName="DlRecord")] 
  	public DlRecord DlRecord { get; set; } 
  }
  

}