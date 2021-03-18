// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using Silk.NET.Core.Native;

namespace Silk.NET.Core.Attributes
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
