using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using RemoteWork.Models;
using RemoteWork.Responses;
using Body = RemoteWork.Models.Body;
using Envelope = RemoteWork.Models.Envelope;
using State = RemoteWork.Models.State;

namespace RemoteWork
{
    public class XmlHelper
    {
        public static string LX_VDetail_OrderInteractiveRequest()
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
                            UserID = "01",
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
                                   // Full = string.Empty
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
            var result2 = XmlSerializationHelper.GetXml(envelope);
            return result2;
        }


        public static void LX_VDetail_OrderInteractiveResponse(Stream stream)
        {
           // string xml = new StreamReader(stream).ReadToEnd();
           XmlDocument document = new XmlDocument();
           document.Load(stream);

           var elements = document.GetElementsByTagName("Data");
           var innerText = elements[0]?.FirstChild?.InnerText;
           var response = innerText.DeserializeXML<Record>();
           // var result = XmlSerializationHelper.ReadFromXml<Responses.Envelope>(stream);
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