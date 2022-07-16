using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using RemoteWork.Models;
using RemoteWork.Responses;
using RemoteWork.Responses;
using Body = RemoteWork.Models.Body;
using Envelope = RemoteWork.Models.Envelope;
using State = RemoteWork.Models.State;

namespace RemoteWork
{
    public class XmlService
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
                                HintMvrInsuranceOption = "Full",
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


        public static Responses.LX_VDetail_OrderInteractive.Record LX_VDetail_OrderInteractiveResponse(Stream stream)
        {
            XmlDocument document = new XmlDocument();
            document.Load(stream);

            var elements = document.GetElementsByTagName("Data");
            var innerText = elements[0]?.FirstChild?.InnerText;
            innerText = innerText.Replace("<![CDATA[", "").Replace("]]>", "");
            var response = innerText.DeserializeXML<Responses.LX_VDetail_OrderInteractive.Record>();
            return response;
        }


        public static string DL_OrderInteractiveRequest()
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
                                Subtype = "3Y",
                                ProductID = "DL",
                                Purpose = "AA",
                                License = "Z24202003",
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

        public static Responses.DL_OrderInteractive.Record DL_OrderInteractiveResponse(Stream stream)
        {
            XmlDocument document = new XmlDocument();
            document.Load(stream);

            var elements = document.GetElementsByTagName("Data");
            var innerText = elements[0]?.FirstChild?.InnerText;
            innerText = innerText.Replace("<![CDATA[", "").Replace("]]>", "");
            var response = innerText.DeserializeXML<Responses.DL_OrderInteractive.Record>();
            return response;
        }

        
        #region LX_Full_OrderInteractiveRequest

        public static string LX_Full_OrderInteractiveRequest()
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
                                    Abbrev = "CA",
                                    // Full = string.Empty
                                },
                                Subtype = "ST",
                                ProductID = "LX",
                                HintMvrInsuranceOption = "Full",
                                HintVertical = "Insurance",
                                Purpose = "AA",
                                License = "L2019101",
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

        public static Responses.LX_Full_OrderInteractive.Record LX_Full_OrderInteractiveResponse(Stream stream)
        {
            XmlDocument document = new XmlDocument();
            document.Load(stream);

            var elements = document.GetElementsByTagName("Data");
            var innerText = elements[0]?.FirstChild?.InnerText;
            innerText = innerText.Replace("<![CDATA[", "").Replace("]]>", "").Trim();
            var response = DeserializeXmlToObject<Responses.LX_Full_OrderInteractive.Record>(innerText);
         //   var response = innerText.DeserializeXML<Responses.LX_Full_OrderInteractive.Record>();
            return response;
            
            
        }

        public static T DeserializeXmlToObject<T>(string xml)
        {
            using (MemoryStream memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(xml)))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                StreamReader reader = new StreamReader(memoryStream, Encoding.UTF8);
                return (T)xmlSerializer.Deserialize(reader);
            }
        }
        
        #endregion

        #region  LX_Activity_OrderInteractive
        public static string LX_Activity_OrderInteractiveRequest()
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
                                HintMvrInsuranceOption = "Activity",
                                HintVertical = "Insurance",
                                Purpose = "AA",
                                License = "201841001",
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

        public static Responses.LX_Activity_OrderInteractive.Record LX_Activity_OrderInteractiveResponse(Stream stream)
        {
            XmlDocument document = new XmlDocument();
            document.Load(stream);

            var elements = document.GetElementsByTagName("Data");
            var innerText = elements[0]?.FirstChild?.InnerText;
            innerText = innerText.Replace("<![CDATA[", "").Replace("]]>", "");
            var response = innerText.DeserializeXML<Responses.LX_Activity_OrderInteractive.Record>();
            return response;
        }

        
        #endregion

        #region  DL_SendOrders

         public static string DL_SendOrdersRequest()
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
                                Misc = "121001",
                                BillCode = "Test BC",
                                State = new State
                                {
                                    Abbrev = "AZ",
                                    // Full = string.Empty
                                },
                                Subtype = "3Y",
                                ProductID = "DL",
                                Purpose = "AA",
                                License = "S20181006",
                                FirstName = "Chris",
                                LastName = "Henderson",
                                DOB = new DOB
                                {
                                    Year = 1989,
                                    Month = 10,
                                    Day = 08
                                }
                            }
                        }
                    }
                }
            };
            var result2 = XmlSerializationHelper.GetXml(envelope);
            return result2;
        }

        public static Responses.DL_SendOrders.Record DL_SendOrdersResponse(Stream stream)
        {
            XmlDocument document = new XmlDocument();
            document.Load(stream);

            var elements = document.GetElementsByTagName("Data");
            var innerText = elements[0]?.FirstChild?.InnerText;
            innerText = innerText.Replace("<![CDATA[", "").Replace("]]>", "");
            var response = innerText.DeserializeXML<Responses.DL_SendOrders.Record>();
            return response;
        }

        #endregion
        
        
    }
}