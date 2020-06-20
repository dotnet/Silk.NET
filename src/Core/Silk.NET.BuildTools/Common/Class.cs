// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections.Generic;

namespace Silk.NET.BuildTools.Common
{
    public class Class
    {
        /// <summary>
        /// Gets or sets this profile's constants.
        /// </summary>
        
        public List<Constant> Constants { get; set; } = new List<Constant>();
        /// <summary>
        /// Gets or sets the name of the mixed-mode class.
        /// </summary>
        public string ClassName { get; set; }

        /// <summary>
        /// Gets or sets a dictionary where the category names are the keys, and <see cref="NativeApiSet" />s
        /// are the values.
        /// </summary>
        public Dictionary<string, NativeApiSet> NativeApis { get; set; } = new Dictionary<string, NativeApiSet>();
        
        public List<ImplementedFunction> Functions { get; set; } = new List<ImplementedFunction>();
    }
}
