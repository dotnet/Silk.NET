// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;

namespace Silk.NET.Core.Native
{
    /// <summary>
    /// The direction a parameter flows.
    /// </summary>
    public class FlowAttribute : Attribute
    {
        /// <summary>
        /// Create a new FlowAttribute.
        /// </summary>
        /// <param name="flowDirection">The direction this attribute flows.</param>
        public FlowAttribute(FlowDirection flowDirection)
        {
            Direction = flowDirection;
        }

        /// <summary>
        /// The direction this parameter flows.
        /// </summary>
        public FlowDirection Direction { get; }
    }
}
