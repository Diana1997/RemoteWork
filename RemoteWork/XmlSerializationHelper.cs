using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace RemoteWork
{
    public static class XmlSerializationHelper
    {
        public static XmlCDataSection GetCData(this object obj, string rootName, string rootNamespace)
        {
            return obj == null
                ? null
                : new System.Xml.XmlDocument().CreateCDataSection(
                    obj.GetXml(XmlSerializerFactory.Create(obj.GetType(), rootName, rootNamespace)));
        }

        public static XCData GetCData(this object obj, XmlSerializer serializer = null)
        {
            return obj == null ? null : new XCData(obj.GetXml(serializer));
        }

        public static string GetXml(this object obj, XmlSerializer serializer = null)
        {
            using (var textWriter = new StringWriter())
            {
              //  var ns = new XmlSerializerNamespaces();
             //   ns.Add("", ""); // Disable the xmlns:xsi and xmlns:xsd lines.
                var settings = new XmlWriterSettings()
                    { Indent = true, IndentChars = "  ", OmitXmlDeclaration = true }; // For cosmetic purposes.
                using (var xmlWriter = XmlWriter.Create(textWriter, settings))
                    (serializer ?? new XmlSerializer(obj.GetType())).Serialize(xmlWriter, obj);
                return textWriter.ToString();
            }
        }

        public static object Deserialize(this XContainer element, Type type, string rootName = null,
            string rootNamespace = null)
        {
            return element.Deserialize(type, XmlSerializerFactory.Create(type, rootName, rootNamespace));
        }

        public static object Deserialize(this XContainer element, Type type, XmlSerializer serializer = null)
        {
            using (var reader = element.CreateReader())
            {
                return (serializer ?? new XmlSerializer(type)).Deserialize(reader);
            }
        }

        public static T DeserializeXML<T>(this string xmlString, XmlSerializer serializer = null)
        {
            using (StringReader reader = new StringReader(xmlString))
            {
                return (T)(serializer ?? new XmlSerializer(typeof(T))).Deserialize(reader);
            }
        }
    }

    public static class XmlSerializerFactory
    {
        readonly static Dictionary<Tuple<Type, string, string>, XmlSerializer> cache;
        readonly static object padlock;

        static XmlSerializerFactory()
        {
            padlock = new object();
            cache = new Dictionary<Tuple<Type, string, string>, XmlSerializer>();
        }

        public static XmlSerializer Create(Type serializedType, string rootName, string rootNamespace)
        {
            if (serializedType == null)
                throw new ArgumentNullException();
            if (rootName == null && rootNamespace == null)
                return new XmlSerializer(serializedType);
            lock (padlock)
            {
                XmlSerializer serializer;
                var key = Tuple.Create(serializedType, rootName, rootNamespace);
                if (!cache.TryGetValue(key, out serializer))
                    cache[key] = serializer = new XmlSerializer(serializedType,
                        new XmlRootAttribute { ElementName = rootName, Namespace = rootNamespace });
                return serializer;
            }
        }
    }
}