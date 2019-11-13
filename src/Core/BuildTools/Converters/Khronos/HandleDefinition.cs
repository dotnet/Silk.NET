using System;
using System.Linq;
using System.Xml.Linq;

namespace Silk.NET.BuildTools.Converters.Khronos
{
    public class HandleDefinition
    {
        public string Name { get; }
        public bool Dispatchable { get; }
        public string Parent { get; }

        public HandleDefinition(string name, bool dispatchable, string parent)
        {
            Name = name;
            Dispatchable = dispatchable;
            Parent = parent;
        }

        public static HandleDefinition CreateFromXml(XElement xe)
        {
            Require.NotNull(xe);

            if (!(xe.Attribute("alias") is null))
            {
                var ret = CreateFromXml
                (
                    xe.Document.Element("registry")
                        .Elements("types")
                        .Elements("type")
                        .Where(typex => typex.HasCategoryAttribute("handle"))
                        .FirstOrDefault(x => x.GetNameElementOrNull() == xe.Attribute("alias").Value) ?? throw new Exception("wat")
                );
                
                return new HandleDefinition(xe.GetNameAttribute(), ret.Dispatchable, ret.Parent);
            }
            
            string name = xe.GetNameElement();
            bool dispatchable = xe.GetTypeElement() == "VK_DEFINE_HANDLE";
            string parent = xe.Attribute("parent")?.Value;

            return new HandleDefinition(name, dispatchable, parent);
        }
    }
}
