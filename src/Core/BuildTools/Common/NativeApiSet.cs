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
    /// Represents an interface containing native functions. As of Preview 4, all
    /// interfaces are merged into the appropriate mixed-mode classes at bind time. 
    /// </summary>
    public class NativeApiSet
    {
        /// <summary>
        /// Gets or sets the name of this interface.
        /// </summary>
        public string Name { get; set; }
        
        [JsonIgnore]
        public Class NativeApiBase { get; set; }

        /// <summary>
        /// Gets or sets the functions contained within this interface.
        /// </summary>
        public List<Function> Functions { get; set; } = new List<Function>();
    }
}
