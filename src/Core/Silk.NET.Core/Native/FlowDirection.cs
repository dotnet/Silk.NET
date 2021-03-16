// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Core.Native
{
    /// <summary>
    /// How the parameter should flow - in or out?
    /// </summary>
    public enum FlowDirection
    {
        /// <summary>
        /// The flow direction is undefined.
        /// </summary>
        Undefined = 0,

        /// <summary>
        /// An input parameter.
        /// </summary>
        In = 1,

        /// <summary>
        /// An output parameter.
        /// </summary>
        Out = 2
    }
}
