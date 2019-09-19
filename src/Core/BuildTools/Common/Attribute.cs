// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections.Generic;
using System.Text;

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
        public List<string> Arguments { get; set; }

        /// <inheritdoc />
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append($"[{Name}(");
            for (var index = 0; index < Arguments.Count; index++)
            {
                var argument = Arguments[index];
                sb.Append(argument);
                if (index != Arguments.Count - 1)
                {
                    sb.Append(", ");
                }
            }

            sb.Append(")]");
            return sb.ToString();
        }
    }
}
