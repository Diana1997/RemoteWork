using System;
using System.IO;
using System.Xml.Serialization;
using RemoteWork.Models;

namespace RemoteWork
{
    public class XmlHelper
    {
        public static void CreateObject()
        {
            Envelope envelope = new Envelope();
            envelope.Body = new Body
            {
                OrderInteractive = new OrderInteractive
                {
                }
            };
            var result = Serialize(envelope);
        }
        
        
        private static string Serialize(Object o)
        {
            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();

//Add an empty namespace and empty value
            using (var writer = new StringWriter())
            {
                new XmlSerializer (o.GetType()).Serialize(writer, o, ns);
                return writer.ToString();
            }
        }
    }
    
  //  public class 
}