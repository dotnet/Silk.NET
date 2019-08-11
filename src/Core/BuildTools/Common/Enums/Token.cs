// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Silk.NET.BuildTools.Common.Enums
{
    /// <summary>
    /// Represents an enum token.
    /// </summary>
    public class Token
    {
        /// <summary>
        /// Gets or sets the name of this token.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the name of this token, as defined by the API specification.
        /// </summary>
        public string NativeName { get; set; }

        /// <summary>
        /// Gets or sets the numeric value of this token.
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets the formatted XML documentation.
        /// </summary>
        public string Doc { get; set; }

        /// <summary>
        /// Gets or sets a list of attributes to be assigned to this token.
        /// </summary>
        public List<Attribute> Attributes { get; set; }

        [JsonConstructor]
        public Token(string? name = null, string? nativeName = null, string? value = null, string? doc = null, List<Attribute>? attributes = null)
        {
            Name = name ?? string.Empty;
            NativeName = nativeName ?? string.Empty;
            Value = value ?? string.Empty;
            Doc = doc ?? string.Empty;
            Attributes = attributes ?? new List<Attribute>();
        }
    }
}
