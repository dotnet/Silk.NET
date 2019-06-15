using System;

namespace Silk.NET.Core.Attributes
{
    public class ExtensionAttribute : Attribute
    {
        public ExtensionAttribute(string name)
        {
            Name = name;
        }
        
        public string Name { get; }
    }
}
