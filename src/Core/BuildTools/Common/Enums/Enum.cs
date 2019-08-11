// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections.Generic;
using Newtonsoft.Json;

namespace Silk.NET.BuildTools.Common.Enums
{
    /// <summary>
    /// Represents a C# enum.
    /// </summary>
    public class Enum
    {
        /// <summary>
        /// Gets or sets a list of tokens contained within this enum.
        /// </summary>
        public List<Token> Tokens { get; set; }

        /// <summary>
        /// Gets or sets the name of this enum.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the name of this enum as defined by the Khronos spec.
        /// </summary>
        public string NativeName { get; set; }

        /// <summary>
        /// Gets or sets the extension to which this enum belongs. Generally, this is either Core or the
        /// enum's <see cref="NativeName"/>.
        /// </summary>
        public string ExtensionName { get; set; }

        /// <summary>
        /// Gets or sets a list of attributes.
        /// </summary>
        public List<Attribute> Attributes { get; set; }

        [JsonConstructor]
        public Enum(List<Token>? tokens = null, string? name = null, string? nativeName = null, string? extensionName = null, List<Attribute>? attributes = null)
        {
            Tokens = tokens ?? new List<Token>();
            Name = name ?? string.Empty;
            NativeName = nativeName ?? string.Empty;
            ExtensionName = extensionName ?? string.Empty;
            Attributes = attributes ?? new List<Attribute>();
        }
    }
}
