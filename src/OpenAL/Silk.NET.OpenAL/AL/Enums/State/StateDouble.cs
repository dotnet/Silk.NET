// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.OpenAL
{
    /// <summary>
    /// A list of valid <see cref="double" /> <see cref="IState.GetStateProperty(StateDouble)" /> parameters.
    /// </summary>
    public enum StateDouble
    {
        /// <summary>
        /// Scale for source and listener velocities.
        /// </summary>
        DopplerFactor = 0xC000,

        /// <summary>
        /// The speed at which sound waves are assumed to travel, when calculating the doppler effect.
        /// </summary>
        SpeedOfSound = 0xC003
    }
}