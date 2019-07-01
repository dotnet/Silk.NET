//
// ContextAttributes.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace Silk.NET.OpenAL
{
    /// <summary>
    /// Defines available context attributes.
    /// </summary>
    public enum ContextAttributes
    {
        /// <summary>
        /// Followed by System.Int32 Hz
        /// </summary>
        Frequency = 0x1007,

        /// <summary>
        /// Followed by System.Int32 Hz
        /// </summary>
        Refresh = 0x1008,

        /// <summary>
        /// Followed by AlBoolean.True, or AlBoolean.False
        /// </summary>
        Sync = 0x1009,

        /// <summary>
        /// Followed by System.Int32 Num of requested Mono (3D) Sources
        /// </summary>
        MonoSources = 0x1010,

        /// <summary>
        /// Followed by System.Int32 Num of requested Stereo Sources
        /// </summary>
        StereoSources = 0x1011,
    }
}
