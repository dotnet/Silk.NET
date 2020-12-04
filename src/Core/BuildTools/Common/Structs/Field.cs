// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Silk.NET.BuildTools.Common.Functions;
using Type = Silk.NET.BuildTools.Common.Functions.Type;

namespace Silk.NET.BuildTools.Common.Structs
{
    /// <summary>
    /// Represents a field on a native struct.
    /// </summary>
    public class Field
    {
        /// <summary>
        /// A list of types that can be marked as fixed.
        /// </summary>
        public static readonly HashSet<string> FixedCapableTypes = new HashSet<string>
        {
            "byte", "short", "int", "long", "char", "sbyte", "ushort", "uint", "ulong", "float", "double"
        };

        /// <summary>
        /// A list of all attributes that apply to this field.
        /// </summary>
        public List<Attribute> Attributes { get; set; } = new List<Attribute>();

        /// <summary>
        /// The documentation for this field.
        /// </summary>
        public string Doc { get; set; }

        /// <summary>
        /// The type of this field.
        /// </summary>
        public Type Type { get; set; }

        // TODO: Be sure this is right
        /// <summary>
        /// The number of elements this field contains; if greater than 1, this field is an array.
        /// </summary>
        public Count Count { get; set; }

        /// <summary>
        /// The name of this field.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The native name of this field.
        /// </summary>
        public string NativeName { get; set; }

        /// <summary>
        /// The native type of this field.
        /// </summary>
        public string NativeType { get; set; }

        /// <summary>
        /// The default value of this field.
        /// </summary>
        public string DefaultAssignment { get; set; }

        /// <summary>
        /// Convert this field into a string.
        /// </summary>
        /// <param name="project">The project to use during conversion.</param>
        /// <returns>A string representing this field.</returns>
        public string ToString(Project project)
        {
            var sb = new StringBuilder();
            if (!(Count is null))
            {
                if (!FixedCapableTypes.Contains(Type.Name))
                {
                    var count = Count.IsConstant
                        ? int.Parse
                        (
                            project.Enums.SelectMany(x => x.Tokens)
                                .FirstOrDefault(x => x.NativeName == Count.ConstantName)?
                                .Value ?? throw new InvalidDataException()
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
                                .Value ?? throw new InvalidDataException()
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
