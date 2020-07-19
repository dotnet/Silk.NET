// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace Silk.NET.BuildTools.Common.Functions
{
    /// <summary>
    /// Represents a parameter of a C# function.
    /// </summary>
    public class Parameter
    {
        /// <summary>
        /// Gets or sets the name of the parameter.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the type of the parameter.
        /// </summary>
        public Type Type { get; set; }

        /// <summary>
        /// Gets or sets size information for this parameter.
        /// </summary>
        [CanBeNull]
        public Count Count { get; set; }

        /// <summary>
        /// Gets or sets the flow of the pointer.
        /// </summary>
        public FlowDirection Flow { get; set; }

        /// <summary>
        /// Gets or sets a list of attributes for this parameter.
        /// </summary>
        public List<Attribute> Attributes { get; set; } = new List<Attribute>();
        
        /// <summary>
        /// The function this parameter originates from.
        /// </summary>
        [JsonIgnore]
        public Function Origin { get; set; }
    }
}
