// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections.Generic;
using Newtonsoft.Json;
using Silk.NET.BuildTools.Common.Functions;

namespace Silk.NET.BuildTools.Common
{
    /// <summary>
    /// Represents an AdvancedDLSupport interface.
    /// </summary>
    public class Interface
    {
        /// <summary>
        /// Gets or sets the name of this interface.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the functions contained within this interface.
        /// </summary>
        public List<Function> Functions { get; set; }

        /// <summary>
        /// Gets or sets a list of attributes to be applied to this interface.
        /// </summary>
        public List<Attribute> Attributes { get; set; }

        [JsonConstructor]
        public Interface(string name, List<Function>? functions = null, List<Attribute>? attributes = null)
        {
            Name = name;
            Functions = functions ?? new List<Function>();
            Attributes = attributes ?? new List<Attribute>();
        }
    }
}
