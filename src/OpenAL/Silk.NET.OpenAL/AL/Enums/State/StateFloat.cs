//
// StateFloat.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace Silk.NET.OpenAL
{
    /// <summary>
    /// A list of valid 32-bit Float AL.Get() parameters.
    /// </summary>
    public enum StateFloat
    {
        /// <summary>
        /// Doppler scale. Default 1.0f.
        /// </summary>
        DopplerFactor = 0xC000,

        /// <summary>
        /// Speed of Sound in units per second. Default: 343.3f.
        /// </summary>
        SpeedOfSound = 0xC003,
    }
}
