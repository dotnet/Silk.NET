//
// SourceBoolean.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

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
        Looping = 0x1007,
    }
}
