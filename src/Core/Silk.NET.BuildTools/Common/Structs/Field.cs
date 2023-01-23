// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

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
    public class Field : IProfileConstituent
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
        
        /// <summary>
        /// The number of elements this field contains; if greater than 1, this field is a fixed array.
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
        /// The number of bits this field occupies. If null, this field is not a bitfield.
        /// </summary>
        public int? NumBits { get; set; }

        /// <summary>
        /// The access of this field.
        /// </summary>
        public Accessibility Accessibility { get; set; }
    }
}
