// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.OpenAL
{
    /// <summary>
    /// A list of valid <see cref="bool" /> parameters for <see cref="IState.GetStateProperty(StateBoolean)" />.
    /// </summary>
    public enum StateBoolean
    {
        /// <summary>
        /// Determines whether or not the state has a doppler factor set.
        /// </summary>
        HasDopplerFactor = 0xC000,

        /// <summary>
        /// Determines whether or not the state has a doppler velocity set.
        /// </summary>
        HasDopplerVelocity = 0xC001,

        /// <summary>
        /// Determines whether or not the state's distance model is the clamped inverse distance model.
        /// </summary>
        IsDistanceModelInverseDistanceClamped = 0xD000,

        /// <summary>
        /// Determines whether or not the state has a speed of sound set.
        /// </summary>
        HasSpeedOfSound = 0xC003
    }
}