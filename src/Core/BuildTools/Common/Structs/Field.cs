// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections.Generic;
using System.Linq;
using System.Text;
using Silk.NET.BuildTools.Common.Functions;

namespace Silk.NET.BuildTools.Common.Structs
{
    public class Field
    {
        public static readonly HashSet<string> _fixedCapableTypes = new HashSet<string>
        {
            "byte", "short", "int", "long", "char", "sbyte", "ushort", "uint", "ulong", "float", "double"
        };

        public List<Attribute> Attributes { get; set; } = new List<Attribute>();
        public string Doc { get; set; }
        public Type Type { get; set; }
        public Count Count { get; set; }
        public string Name { get; set; }
        public string NativeName { get; set; }
        public string NativeType { get; set; }
        public string DefaultAssignment { get; set; }
        public string ToString(Project project)
        {
            var sb = new StringBuilder();
            if (!(Count is null))
            {
                if (!_fixedCapableTypes.Contains(Type.Name))
                {
                    var count = Count.IsConstant
                        ? int.Parse
                        (
                            project.Enums.SelectMany(x => x.Tokens)
                                .FirstOrDefault(x => x.NativeName == Count.ConstantName)?
                                .Value
                        )
                        : Count.IsStatic
                            ? Count.StaticCount
                            : 1;
                    for (var i = 0; i < count; i++)
                    {
                        sb.AppendLine($"{Doc}");
                        sb.AppendLine
                        (
                            $"public {Type} {Name}{i};"
                        );
                    }
                }
                else
                {
                    if (!string.IsNullOrEmpty(Doc))
                    {
                        sb.AppendLine($"{Doc}");
                    }

                    var count = Count.IsConstant
                        ? int.Parse
                        (
                            project.Enums.SelectMany(x => x.Tokens)
                                .FirstOrDefault(x => x.NativeName == Count.ConstantName)?
                                .Value
                        )
                        : Count.IsStatic
                            ? Count.StaticCount
                            : 1;
                    sb.AppendLine
                    (
                        $"public fixed {Type} {Name}[{count}];"
                    );
                }
            }
            else
            {
                sb.AppendLine(Doc);
                sb.AppendLine($"public {Type} {Name};");
            }

            return sb.ToString();
        }
    }
}
