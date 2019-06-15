using System;
using System.Collections.Generic;

namespace Generator.Common.Enums
{
    /// <summary>
    /// Represents a C# enum.
    /// </summary>
    public class Enum
    {
        /// <summary>
        /// Gets or sets a list of tokens contained within this enum.
        /// </summary>
        public List<Token> Tokens { get; set; } = new List<Token>();

        /// <summary>
        /// Gets or sets the name of this enum.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the name of this enum as defined by the Khronos spec.
        /// </summary>
        public string NativeName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets a list of attributes.
        /// </summary>
        public List<Attribute> Attributes { get; set; } = new List<Attribute>();
    }
}
