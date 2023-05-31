// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Silk.NET.BuildTools.Common
{
    /// <summary>
    /// Represents a C# attribute.
    /// </summary>
    public class Attribute
    {
        /// <summary>
        /// Gets or sets the class of the attribute.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets arguments to be added to this <see cref="Attribute" />'s constructors.
        /// </summary>
        public List<string> Arguments { get; set; } = new List<string>();
        
        [JsonIgnore]
        public string? Origin { get; set; }

        /// <inheritdoc />
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append($"[{Name}");
            for (var index = 0; index < Arguments.Count; index++)
            {
                if (index == 0)
                {
                    sb.Append('(');
                }
            
                var argument = Arguments[index];
                sb.Append(argument);
                if (index != Arguments.Count - 1)
                {
                    sb.Append(", ");
                }
                else
                {
                    sb.Append(')');
                }
            }

            sb.Append(']');
            return sb.ToString();
        }

        /// <summary>
        /// Clones this attribute.
        /// </summary>
        /// <returns>A copy.</returns>
        public Attribute Clone()
        {
            return new Attribute
            {
                Name = Name,
                Arguments = Arguments.ToList()
            };
        }
    }
}
