// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;

namespace Silk.NET.Core.Native
{
    /// <summary>
    /// Represents the count of a parameter.
    /// </summary>
    [AttributeUsage(AttributeTargets.Parameter)]
    public class CountAttribute : Attribute
    {
        /// <summary>
        /// Gets or sets the static count.
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// Gets or sets the deterministic parameter for this count.
        /// </summary>
        public string Parameter { get; set; }

        /// <summary>
        /// Gets or sets the computed count.
        /// </summary>
        public string Computed { get; set; }
    }
}
