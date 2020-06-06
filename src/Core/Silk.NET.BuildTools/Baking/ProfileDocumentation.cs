// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections.Generic;

namespace Silk.NET.BuildTools.Baking
{
    /// <summary>
    /// Represents parsed documentation for all functions in a profile.
    /// </summary>
    public class ProfileDocumentation
    {
        /// <summary>
        /// Gets or sets a dictionary where the function name (without the prefix) is the key, and its documentation
        /// is the value.
        /// </summary>
        public Dictionary<string, FunctionDocumentation> Functions { get; set; }
    }
}
