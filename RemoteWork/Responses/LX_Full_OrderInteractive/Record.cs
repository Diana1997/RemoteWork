using System.Collections.Generic;
using System.Xml.Serialization;

namespace RemoteWork.Responses.LX_Full_OrderInteractive
{
	
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
	public string Reference { get; set; } 

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

	[XmlElement(ElementName="InvoicePath")] 
	public string InvoicePath { get; set; } 
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

	[XmlElement(ElementName="Explanation")] 
	public string Explanation { get; set; } 
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

	[XmlElement(ElementName="IssueDate")] 
	public IssueDate IssueDate { get; set; } 

	[XmlElement(ElementName="ExpirationDate")] 
	public ExpirationDate ExpirationDate { get; set; } 

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

	[XmlElement(ElementName="ContrivedOriginalIssueYear")] 
	public int ContrivedOriginalIssueYear { get; set; } 
}

[XmlRoot(ElementName="MessageItem")]
public class MessageItem { 

	[XmlElement(ElementName="Line")] 
	public string Line { get; set; } 
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

[XmlRoot(ElementName="ModifiedDate")]
public class ModifiedDate { 

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

	[XmlElement(ElementName="ModifiedDate")] 
	public ModifiedDate ModifiedDate { get; set; } 

	[XmlElement(ElementName="Location")] 
	public string Location { get; set; } 

	[XmlElement(ElementName="IsHazMat")] 
	public string IsHazMat { get; set; } 

	[XmlElement(ElementName="IsCommercial")] 
	public string IsCommercial { get; set; } 

	[XmlElement(ElementName="Plate")] 
	public string Plate { get; set; } 

	[XmlElement(ElementName="LocationCode")] 
	public int LocationCode { get; set; } 

	[XmlElement(ElementName="DocketNumber")] 
	public string DocketNumber { get; set; } 
}

[XmlRoot(ElementName="DescriptionItem")]
public class DescriptionItem { 

	[XmlElement(ElementName="AdrLargeDescription")] 
	public string AdrLargeDescription { get; set; } 

	[XmlElement(ElementName="AdrSmallDescription")] 
	public string AdrSmallDescription { get; set; } 

	[XmlElement(ElementName="StateDescription")] 
	public string StateDescription { get; set; } 

	[XmlElement(ElementName="Acd")] 
	public string Acd { get; set; } 

	[XmlElement(ElementName="Avd1")] 
	public string Avd1 { get; set; } 

	[XmlElement(ElementName="TableKey")] 
	public string TableKey { get; set; } 

	[XmlElement(ElementName="StateCode")] 
	public int StateCode { get; set; } 
}

[XmlRoot(ElementName="DescriptionList")]
public class DescriptionList { 

	[XmlElement(ElementName="DescriptionItem")] 
	public List<DescriptionItem> DescriptionItem { get; set; } 
}

[XmlRoot(ElementName="Accident")]
public class Accident { 

	[XmlElement(ElementName="ReportNumber")] 
	public double ReportNumber { get; set; } 
}

[XmlRoot(ElementName="EventItem")]
public class EventItem { 

	[XmlElement(ElementName="Common")] 
	public Common Common { get; set; } 

	[XmlElement(ElementName="DescriptionList")] 
	public DescriptionList DescriptionList { get; set; } 

	[XmlElement(ElementName="Accident")] 
	public Accident Accident { get; set; } 

	[XmlElement(ElementName="NoteList")] 
	public NoteList NoteList { get; set; } 

	[XmlElement(ElementName="Action")] 
	public Action Action { get; set; } 
}

[XmlRoot(ElementName="NoteItem")]
public class NoteItem { 

	[XmlElement(ElementName="Note")] 
	public string Note { get; set; } 
}

[XmlRoot(ElementName="NoteList")]
public class NoteList { 

	[XmlElement(ElementName="NoteItem")] 
	public NoteItem NoteItem { get; set; } 
}

[XmlRoot(ElementName="ActualDate")]
public class ActualDate { 

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

	[XmlElement(ElementName="ActualDate")] 
	public ActualDate ActualDate { get; set; } 

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

	/*[XmlElement(ElementName="EventList")] 
	public EventList EventList { get; set; } */
}

[XmlRoot(ElementName="Record")]
public class Record { 

	[XmlElement(ElementName="DlRecord")] 
	public DlRecord DlRecord { get; set; } 
}


}