// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Type = Silk.NET.BuildTools.Common.Functions.Type;

namespace Silk.NET.BuildTools.Common.Enums
{
    /// <summary>
    /// Represents a C# enum.
    /// </summary>
    public class Enum : IProfileConstituent
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

        //[JsonIgnore]
        public string ProfileName { get; set; }

        //[JsonIgnore]
        public Version ProfileVersion { get; set; }
        
        [JsonIgnore]
        public string[] ClangMetadata { get; set; }

        public Type EnumBaseType { get; set; } = new Type {Name = "int"};

        /// <summary>
        /// Gets or sets the extension to which this enum belongs. Generally, this is either Core or the
        /// enum's <see cref="NativeName"/>.
        /// </summary>
        public string ExtensionName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets a list of attributes.
        /// </summary>
        public List<Attribute> Attributes { get; set; } = new List<Attribute>();
    }
}
