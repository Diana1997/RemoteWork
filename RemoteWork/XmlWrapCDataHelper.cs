using System;
using System.Linq;
using System.Reflection;
using System.Xml;
using System.Xml.Linq;

namespace RemoteWork
{
    public static class XmlWrapCDataHelper
    {
        static Tuple<PropertyInfo, XmlWrapCDataAttribute> [] XmlWrapCDataProperties(Type type)
        {
            return type.GetProperties()
                .Where(p => p.GetGetMethod() != null && p.GetSetMethod() != null)
                .Select(p => Tuple.Create(p, p.GetCustomAttribute<XmlWrapCDataAttribute>()))
                .Where(p => p.Item2 != null)
                .ToArray();
        }

        public static XmlNode[] GetCDataContent(object obj)
        {
            var index = new object[0];
            var properties = XmlWrapCDataProperties(obj.GetType());
            return properties.Select(p => (XmlNode)p.Item1.GetValue(obj, index).GetCData(p.Item2.Name ?? p.Item1.Name, p.Item2.Namespace)).ToArray();
        }

        public static void SetCDataContent(object obj, XmlNode [] nodes)
        {
            if (nodes == null || nodes.Length < 1)
                return;
            var index = new object[0];
            var properties = XmlWrapCDataProperties(obj.GetType()).ToDictionary(p => XName.Get(p.Item2.Name ?? p.Item1.Name, p.Item2.Namespace), p => p);
            var xml = "<Root>" + String.Concat(nodes.Select(c => c.Value)) + "</Root>";
            foreach (var element in XElement.Parse(xml).Elements())
            {
                Tuple<PropertyInfo, XmlWrapCDataAttribute> pair;
                if (properties.TryGetValue(element.Name, out pair))
                {
                    var value = element.Deserialize(pair.Item1.PropertyType, element.Name.LocalName, element.Name.Namespace.NamespaceName);
                    pair.Item1.SetValue(obj, value, index);
                }
            }
        }
    }
}