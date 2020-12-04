using System;
using System.Linq;
using System.Xml.Linq;

namespace Silk.NET.BuildTools.Converters.Khronos
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

            if (!(xe.Attribute("alias") is null))
            {
                var ret = CreateFromXml
                (
                    xe.Document.Element("registry")
                        .Elements("types")
                        .Elements("type")
                        .Where(typex => typex.HasCategoryAttribute("struct"))
                        .FirstOrDefault(x => x.GetNameAttribute() == xe.Attribute("alias").Value) ?? throw new Exception("wat")
                );

                return new StructureDefinition(xe.GetNameAttribute(), ret.Members);
            }

            var name = xe.GetNameAttribute();
            var members = xe.Elements
                    ("member")
                .Where(x => !(x.Element("name") is null))
                .Select(memberx => MemberSpec.CreateFromXml(memberx))
                .ToArray();
            return new StructureDefinition(name, members);
        }

        public override string ToString()
        {
            return $"struct {Name}[{Members.Length}]";
        }
    }
}
