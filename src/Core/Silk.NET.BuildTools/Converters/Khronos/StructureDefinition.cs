using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Silk.NET.BuildTools.Converters.Khronos
{
    public class StructureDefinition
    {
        public string Name { get; }
        
        /// <summary>
        /// The alias holds the concrete structure definition's name.
        /// </summary>
        public string Alias { get; }
        public MemberSpec[] Members { get; }
        public IReadOnlyList<string> Extends { get; }
        public string? Api { get; }

        public StructureDefinition(string name, string alias, MemberSpec[] members, string extends, string? api)
        {
            Name = name;
            Alias = alias;
            Members = members;
            Extends = string.IsNullOrWhiteSpace(extends)
                ? Array.Empty<string>()
                : extends.Split(',', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);
            Api = api;
        }

        public static StructureDefinition CreateFromXml(XElement xe)
        {
            Require.NotNull(xe);
            var name = xe.GetNameAttribute();

            // Find original definition if this is an alias (this should usually be one step, but we handle gracefully)
            var aliases = new HashSet<string> { name };
            string alias = null;
            string a;
            while ((a = xe.Attribute("alias")?.Value) is not null)
            {
                alias = a;
                if (aliases.Contains(alias))
                {
                    throw new Exception($"A loop of aliases was found as we have seen the '{alias}' alias before.");
                }
                aliases.Add(alias);

                xe = xe.Document.Element("registry")
                         .Elements("types")
                         .Elements("type")
                         .Where(typex => typex.HasCategoryAttribute("struct"))
                         .FirstOrDefault(x => x.GetNameAttribute() == alias) ??
                     throw new Exception($"Could not find the '{alias}' alias.");
            }

            var members = xe.Elements
                    ("member")
                .Where(x => !(x.Element("name") is null))
                .Select(memberx => MemberSpec.CreateFromXml(memberx))
                .ToArray();
            var extends = xe.Attribute("structextends")?.Value;
            var api = xe.Attribute("api")?.Value;
            return new StructureDefinition(name, alias, members, extends, api);
        }

        public override string ToString()
        {
            return $"struct {Name}[{Members.Length}]";
        }
    }
}
