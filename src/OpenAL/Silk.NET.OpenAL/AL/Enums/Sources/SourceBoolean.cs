// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.OpenAL
{
    /// <summary>
    /// A list of valid 8-bit boolean Source/GetSource parameters.
    /// </summary>
    public enum SourceBoolean
    {
        /// <summary>
        /// Indicate that the Source has relative coordinates. Type: bool Range: [True, False].
        /// </summary>
        SourceRelative = 0x202,

        /// <summary>
        /// Indicate whether the Source is looping. Type: bool Range: [True, False] Default: False.
        /// </summary>
        Looping = 0x1007
    }
}