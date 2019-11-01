using System.Linq;
using System.Xml.Linq;

namespace Vk.Generator
{
    public class StructureDefinition
    {
        public string Name { get; }
        public MemberSpec[] Members { get; }

        public StructureDefinition(string name, MemberSpec[] members)
        {
            Name = name;
            Members = members;
        }

        public static StructureDefinition CreateFromXml(XElement xe)
        {
            Require.NotNull(xe);

            string name = xe.GetNameAttribute();
            MemberSpec[] members = xe.Elements("member").Select(memberx => MemberSpec.CreateFromXml(memberx)).ToArray();
            return new StructureDefinition(name, members);
        }

        public override string ToString()
        {
            return $"struct {Name}[{Members.Length}]";
        }
    }
}
