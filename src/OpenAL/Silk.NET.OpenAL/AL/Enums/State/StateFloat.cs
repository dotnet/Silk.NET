// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

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
        SpeedOfSound = 0xC003
    }
}