using System.Xml.Linq;

namespace Vk.Generator
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
            string name = xe.GetNameElement();
            bool dispatchable = xe.GetTypeElement() == "VK_DEFINE_HANDLE";
            string parent = xe.Attribute("parent")?.Value;

            return new HandleDefinition(name, dispatchable, parent);
        }
    }
}
