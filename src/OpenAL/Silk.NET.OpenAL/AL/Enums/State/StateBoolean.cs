// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using Silk.NET.OpenAL.Interfaces;

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