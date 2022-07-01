using System;

namespace RemoteWork
{
    [System.AttributeUsage(System.AttributeTargets.Property, AllowMultiple = false)]
    public class XmlWrapCDataAttribute : Attribute
    {
        public XmlWrapCDataAttribute() { this.Namespace = string.Empty;  }
        public XmlWrapCDataAttribute(string name) : this() { this.Name = name; }

        public string Name { get; set; }

        public string Namespace { get; set; }
    }
}