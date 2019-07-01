//
// IState.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using AdvancedDLSupport;

// ReSharper disable ExplicitCallerInfoArgument
namespace Silk.NET.OpenAL.Interfaces
{
    /// <summary>
    /// Defines the public interface for the state-related functions of OpenAL 1.1.
    /// </summary>
    [NativeSymbols(Prefix = "al")]
    internal interface IState
    {
        /// <summary>
        /// Enables a capability in the state.
        /// </summary>
        /// <param name="capability">The capability.</param>
        void Enable(Capability capability);

        /// <summary>
        /// Disables a capability in the state.
        /// </summary>
        /// <param name="capability">The capability.</param>
        void Disable(Capability capability);

        /// <summary>
        /// Determines whether or not the given capability is enabled.
        /// </summary>
        /// <param name="capability">The capability.</param>
        /// <returns>true if the capability is enabled; otherwise, false.</returns>
        bool IsEnabled(Capability capability);

        /// <summary>
        /// Gets a named value from the state.
        /// </summary>
        /// <param name="param">The name of the value to retrieve.</param>
        /// <returns>The value.</returns>
        [NativeSymbol("GetBoolean")]
        bool GetStateProperty(StateBoolean param);

        /// <summary>
        /// Gets a named value from the state.
        /// </summary>
        /// <param name="param">The name of the value to retrieve.</param>
        /// <returns>The value.</returns>
        [NativeSymbol("GetDouble")]
        double GetStateProperty(StateDouble param);

        /// <summary>
        /// Gets a named value from the state.
        /// </summary>
        /// <param name="param">The name of the value to retrieve.</param>
        /// <returns>The value.</returns>
        [NativeSymbol("GetFloat")]
        float GetStateProperty(StateFloat param);

        /// <summary>
        /// Gets a named value from the state.
        /// </summary>
        /// <param name="param">The name of the value to retrieve.</param>
        /// <returns>The value.</returns>
        [NativeSymbol("GetInteger")]
        int GetStateProperty(StateInteger param);

        /// <summary>
        /// Gets a named value from the state.
        /// </summary>
        /// <param name="param">The name of the value to retrieve.</param>
        /// <returns>The value.</returns>
        [NativeSymbol("GetString")]
        string GetStateProperty(StateString param);

        /// <summary>
        /// Sets the model by which sources attenuate with distance.
        /// </summary>
        /// <param name="distanceModel">The distance model.</param>
        void DistanceModel(DistanceModel distanceModel);

        /// <summary>
        /// Doppler scale.
        /// Range: [0.0 - ]
        /// Default: 1.0
        ///
        /// Sets the scale for source and listener velocities.
        /// </summary>
        /// <param name="value">The scale.</param>
        void DopplerFactor(float value);

        /// <summary>
        /// Speed of sound, in units per second.
        ///
        /// Range: [0.0001 - ]
        /// Default: 343.3
        ///
        /// Sets the speed at which sound waves are assumed to travel, when calculating the doppler effect.
        /// </summary>
        /// <param name="value">The speed of sound.</param>
        void SpeedOfSound(float value);
    }
}
