using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using RemoteWork.Models;

namespace RemoteWork
{
    public class XmlHelper
    {
        public static string CreateObject()
        {
            Envelope envelope = new Envelope();
            envelope.Body = new Body
            {
                OrderInteractive = new OrderInteractive
                {
                    InCommunications = new InCommunications
                    {
                        Communications = new Communications
                        {
                            Account = "K1808",
                            UserID = 01,
                            Password = "Test_123",
                            ReportTypes = new ReportTypes()
                            {
                                Type = "XML2.03"
                            }
                        }
                    },
                    InOrder = new InOrder
                    {
                        OrderXml = new OrderXml
                        {
                            Order = new Order
                            {
                                Handling = "OL",
                                Misc = "Test Ref",
                                BillCode = "Test BC",
                                State = new State
                                {
                                    Abbrev = "AZ",
                                    Full = string.Empty
                                },
                                Subtype = "ST",
                                ProductID = "LX",
                                HintMvrInsuranceOption = "VDETAIL",
                                HintVertical = "Insurance",
                                Purpose = "AA",
                                License = "A20203005",
                                FirstName = "JOHN",
                                LastName = "DOE",
                                DOB = new DOB
                                {
                                    Year = 1990,
                                    Month = 06,
                                    Day = 04
                                }
                            }
                        }
                    }
                }
            };
            //var result = Serialize(envelope);
            var result2 = XmlSerializationHelper.GetXml(envelope);
            return result2;
        }


        private static string Serialize(Object o)
        {
            //Add an empty namespace and empty value
            // XmlSerializerNamespaces ns = new XmlSerializerNamespaces();

            using (var writer = new StringWriter())
            {
                new XmlSerializer(o.GetType()).Serialize(writer, o);
                return writer.ToString();
            }
        }
    }

    //  public class 
}