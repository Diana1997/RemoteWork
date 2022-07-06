using System.Collections.Generic;
using System.Xml.Serialization;

namespace RemoteWork.Responses.LX_VDetail_OrderInteractive
{

    [XmlRoot(ElementName = "OrderDate")]
    public class OrderDate
    {
        [XmlElement(ElementName = "Year")] public int Year { get; set; }

        [XmlElement(ElementName = "Month")] public int Month { get; set; }

        [XmlElement(ElementName = "Day")] public int Day { get; set; }
    }

    [XmlRoot(ElementName = "OrderTime")]
    public class OrderTime
    {
        [XmlElement(ElementName = "Hour")] public int Hour { get; set; }

        [XmlElement(ElementName = "Minute")] public int Minute { get; set; }

        [XmlElement(ElementName = "Second")] public int Second { get; set; }
    }

    [XmlRoot(ElementName = "State")]
    public class State
    {
        [XmlElement(ElementName = "Abbrev")] public string Abbrev { get; set; }

        [XmlElement(ElementName = "Full")] public string Full { get; set; }
    }

    [XmlRoot(ElementName = "BirthDate")]
    public class BirthDate
    {
        [XmlElement(ElementName = "Year")] public int Year { get; set; }

        [XmlElement(ElementName = "Month")] public int Month { get; set; }

        [XmlElement(ElementName = "Day")] public int Day { get; set; }
    }

    [XmlRoot(ElementName = "Criteria")]
    public class Criteria
    {
        [XmlElement(ElementName = "OrderDate")]
        public OrderDate OrderDate { get; set; }

        [XmlElement(ElementName = "OrderTime")]
        public OrderTime OrderTime { get; set; }

        [XmlElement(ElementName = "AccountID")]
        public string AccountID { get; set; }

        [XmlElement(ElementName = "Routing")] public string Routing { get; set; }

        [XmlElement(ElementName = "Purpose")] public string Purpose { get; set; }

        [XmlElement(ElementName = "Reference")]
        public string Reference { get; set; }

        [XmlElement(ElementName = "TrackingNumber")]
        public int TrackingNumber { get; set; }

        [XmlElement(ElementName = "Host")] public string Host { get; set; }

        [XmlElement(ElementName = "ProductID")]
        public string ProductID { get; set; }

        [XmlElement(ElementName = "State")] public State State { get; set; }

        [XmlElement(ElementName = "Subtype")] public string Subtype { get; set; }

        [XmlElement(ElementName = "SubtypeFull")]
        public string SubtypeFull { get; set; }

        [XmlElement(ElementName = "FirstName")]
        public string FirstName { get; set; }

        [XmlElement(ElementName = "MiddleName")]
        public string MiddleName { get; set; }

        [XmlElement(ElementName = "LastName")] public string LastName { get; set; }

        [XmlElement(ElementName = "BirthDate")]
        public BirthDate BirthDate { get; set; }

        [XmlElement(ElementName = "LicenseNumber")]
        public string LicenseNumber { get; set; }
    }

    [XmlRoot(ElementName = "ReturnedDate")]
    public class ReturnedDate
    {
        [XmlElement(ElementName = "Year")] public int Year { get; set; }

        [XmlElement(ElementName = "Month")] public int Month { get; set; }

        [XmlElement(ElementName = "Day")] public int Day { get; set; }
    }

    [XmlRoot(ElementName = "ReturnedTime")]
    public class ReturnedTime
    {
        [XmlElement(ElementName = "Hour")] public int Hour { get; set; }

        [XmlElement(ElementName = "Minute")] public int Minute { get; set; }

        [XmlElement(ElementName = "Second")] public int Second { get; set; }
    }

    [XmlRoot(ElementName = "Result")]
    public class Result
    {
        [XmlElement(ElementName = "Control")] public string Control { get; set; }

        [XmlElement(ElementName = "Valid")] public string Valid { get; set; }

        [XmlElement(ElementName = "ErrorDescription")]
        public string ErrorDescription { get; set; }

        [XmlElement(ElementName = "ReturnedDate")]
        public ReturnedDate ReturnedDate { get; set; }

        [XmlElement(ElementName = "ReturnedTime")]
        public ReturnedTime ReturnedTime { get; set; }

        [XmlElement(ElementName = "IsClear")] public string IsClear { get; set; }
    }

    [XmlRoot(ElementName = "MessageItem")]
    public class MessageItem
    {
        [XmlElement(ElementName = "Line")] public string Line { get; set; }
    }

    [XmlRoot(ElementName = "MessageList")]
    public class MessageList
    {
        [XmlElement(ElementName = "MessageItem")]
        public MessageItem MessageItem { get; set; }
    }

    [XmlRoot(ElementName = "Date")]
    public class Date
    {
        [XmlElement(ElementName = "Year")] public int Year { get; set; }

        [XmlElement(ElementName = "Month")] public int Month { get; set; }

        [XmlElement(ElementName = "Day")] public int Day { get; set; }
    }

    [XmlRoot(ElementName = "Common")]
    public class Common
    {
        [XmlElement(ElementName = "State")] public State State { get; set; }

        [XmlElement(ElementName = "Date")] public Date Date { get; set; }
    }

    [XmlRoot(ElementName = "AdjudicatedDate")]
    public class AdjudicatedDate
    {
        [XmlElement(ElementName = "Year")] public int Year { get; set; }

        [XmlElement(ElementName = "Month")] public int Month { get; set; }

        [XmlElement(ElementName = "Day")] public int Day { get; set; }
    }

    [XmlRoot(ElementName = "DescriptionItem")]
    public class DescriptionItem
    {
        [XmlElement(ElementName = "AdjudicatedDate")]
        public AdjudicatedDate AdjudicatedDate { get; set; }

        [XmlElement(ElementName = "Avd1")] public string Avd1 { get; set; }

        [XmlElement(ElementName = "Avd2")] public string Avd2 { get; set; }
    }

    [XmlRoot(ElementName = "DescriptionList")]
    public class DescriptionList
    {
        [XmlElement(ElementName = "DescriptionItem")]
        public DescriptionItem DescriptionItem { get; set; }
    }

    [XmlRoot(ElementName = "Violation")]
    public class Violation
    {
        [XmlElement(ElementName = "ViolDisposition")]
        public string ViolDisposition { get; set; }

        [XmlElement(ElementName = "ViolStatute")]
        public string ViolStatute { get; set; }

        [XmlElement(ElementName = "ViolDescState")]
        public string ViolDescState { get; set; }

        [XmlElement(ElementName = "NewViolation")]
        public string NewViolation { get; set; }
    }

    [XmlRoot(ElementName = "EventItem")]
    public class EventItem
    {
        [XmlElement(ElementName = "Common")] public Common Common { get; set; }

        [XmlElement(ElementName = "DescriptionList")]
        public DescriptionList DescriptionList { get; set; }

        [XmlElement(ElementName = "Violation")]
        public Violation Violation { get; set; }

        [XmlElement(ElementName = "County")] public string County { get; set; }

        [XmlElement(ElementName = "Summons")] public string Summons { get; set; }

        [XmlElement(ElementName = "Docket")] public string Docket { get; set; }

        [XmlElement(ElementName = "EventCompCode")]
        public string EventCompCode { get; set; }
    }

    [XmlRoot(ElementName = "EventList")]
    public class EventList
    {
        [XmlElement(ElementName = "EventItem")]
        public List<EventItem> EventItem { get; set; }
    }

    [XmlRoot(ElementName = "JrRecord")]
    public class JrRecord
    {
        [XmlElement(ElementName = "Criteria")] public Criteria Criteria { get; set; }

        [XmlElement(ElementName = "Result")] public Result Result { get; set; }

        [XmlElement(ElementName = "MessageList")]
        public MessageList MessageList { get; set; }

        [XmlElement(ElementName = "EventList")]
        public EventList EventList { get; set; }
    }

    [XmlRoot(ElementName = "Record")]
    public class Record
    {
        [XmlElement(ElementName = "JrRecord")] public JrRecord JrRecord { get; set; }
    }
}