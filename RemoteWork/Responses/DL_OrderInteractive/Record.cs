using System.Xml.Serialization;

namespace RemoteWork.Responses.DL_OrderInteractive
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

        [XmlElement(ElementName = "UserID")] public string UserID { get; set; }

        [XmlElement(ElementName = "Routing")] public string Routing { get; set; }

        [XmlElement(ElementName = "Purpose")] public string Purpose { get; set; }

        [XmlElement(ElementName = "Reference")]
        public string Reference { get; set; }

        [XmlElement(ElementName = "TrackingNumber")]
        public int TrackingNumber { get; set; }

        [XmlElement(ElementName = "Host")] public string Host { get; set; }

        [XmlElement(ElementName = "ProductID")]
        public string ProductID { get; set; }

        [XmlElement(ElementName = "FirstName")]
        public string FirstName { get; set; }

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

        [XmlElement(ElementName = "ErrorCode")]
        public string ErrorCode { get; set; }

        [XmlElement(ElementName = "ErrorDescription")]
        public string ErrorDescription { get; set; }

        [XmlElement(ElementName = "ReturnedDate")]
        public ReturnedDate ReturnedDate { get; set; }

        [XmlElement(ElementName = "ReturnedTime")]
        public ReturnedTime ReturnedTime { get; set; }

        [XmlElement(ElementName = "ReklamiErrorCode")]
        public string ReklamiErrorCode { get; set; }
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

    [XmlRoot(ElementName = "RjRecord")]
    public class RjRecord
    {
        [XmlElement(ElementName = "Criteria")] public Criteria Criteria { get; set; }

        [XmlElement(ElementName = "Result")] public Result Result { get; set; }

        [XmlElement(ElementName = "MessageList")]
        public MessageList MessageList { get; set; }
    }

    [XmlRoot(ElementName = "Record")]
    public class Record
    {
        [XmlElement(ElementName = "RjRecord")] public RjRecord RjRecord { get; set; }
    }
}