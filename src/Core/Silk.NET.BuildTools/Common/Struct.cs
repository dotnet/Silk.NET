// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Silk.NET.BuildTools.Common.Functions;
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
        [JsonIgnore] public string[] ClangMetadata { get; set; }
        
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

        /// <summary>
        /// A list of functions contained in the LpVtbl field.
        /// </summary>
        public List<Function> Vtbl { get; set; } = new List<Function>();
        
        /// <summary>
        /// A list of interface names which this interface inherits.
        /// </summary>
        public List<string> ComBases { get; set; } = new List<string>();

        /// <summary>
        /// This struct's UUID attribute. 
        /// </summary>
        public Guid? Uuid { get; set; }
    }
}