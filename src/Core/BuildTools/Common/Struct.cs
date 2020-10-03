// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Silk.NET.BuildTools.Common.Structs;

namespace Silk.NET.BuildTools.Common
{
    /// <summary>
    /// A struct from a native library.
    /// </summary>
    public class Struct
    {
        /// <summary>
        /// The name of the struct.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The name of the struct in the native library.
        /// </summary>
        public string NativeName { get; set; }

        /// <summary>
        /// The extension name.
        /// </summary>
        public string ExtensionName { get; set; }
        [JsonIgnore] public string ProfileName { get; set; }
        [JsonIgnore] public Version ProfileVersion { get; set; }

        /// <summary>
        /// A list of fields this struct contains.
        /// </summary>
        public List<Field> Fields { get; set; } = new List<Field>();

        /// <summary>
        /// A list of attributes this struct has. 
        /// </summary>
        public List<Attribute> Attributes { get; set; } = new List<Attribute>();

        /// <summary>
        /// A list of functions this struct has.
        /// </summary>
        public List<ImplementedFunction> Functions { get; set; } = new List<ImplementedFunction>();
    }
}