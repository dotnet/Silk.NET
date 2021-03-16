// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.OpenAL
{
    /// <summary>
    /// A list of valid 32-bit Float Source/GetSource parameters.
    /// </summary>
    public enum SourceFloat
    {
        /// <summary>
        /// Source specific reference distance. Type: float Range: [0.0f - float.PositiveInfinity] At 0.0f, no distance
        /// attenuation occurs. Type: float Default: 1.0f.
        /// </summary>
        ReferenceDistance = 0x1020,

        /// <summary>
        /// Indicate distance above which Sources are not attenuated using the inverse clamped distance model. Default:
        /// float.PositiveInfinity Type: float Range: [0.0f - float.PositiveInfinity].
        /// </summary>
        MaxDistance = 0x1023,

        /// <summary>
        /// Source specific rolloff factor. Type: float Range: [0.0f - float.PositiveInfinity].
        /// </summary>
        RolloffFactor = 0x1021,

        /// <summary>
        /// Specify the pitch to be applied, either at Source, or on mixer results, at Listener. Range: [0.5f - 2.0f]
        /// Default: 1.0f.
        /// </summary>
        Pitch = 0x1003,

        /// <summary>
        /// Indicate the gain (volume amplification) applied. Type: float. Range: [0.0f - ? ] A value of 1.0 means
        /// un-attenuated/unchanged. Each division by 2 equals an attenuation of -6dB. Each multiplicaton with 2 equals an
        /// amplification of +6dB. A value of 0.0f is meaningless with respect to a logarithmic scale; it is interpreted as
        /// zero volume - the channel is effectively disabled.
        /// </summary>
        Gain = 0x100A,

        /// <summary>
        /// Indicate minimum Source attenuation. Type: float Range: [0.0f - 1.0f] (Logarthmic).
        /// </summary>
        MinGain = 0x100D,

        /// <summary>
        /// Indicate maximum Source attenuation. Type: float Range: [0.0f - 1.0f] (Logarthmic).
        /// </summary>
        MaxGain = 0x100E,

        /// <summary>
        /// Directional Source, inner cone angle, in degrees. Range: [0-360] Default: 360.
        /// </summary>
        ConeInnerAngle = 0x1001,

        /// <summary>
        /// Directional Source, outer cone angle, in degrees. Range: [0-360] Default: 360.
        /// </summary>
        ConeOuterAngle = 0x1002,

        /// <summary>
        /// Directional Source, outer cone gain. Default: 0.0f Range: [0.0f - 1.0] (Logarithmic).
        /// </summary>
        ConeOuterGain = 0x1022,

        /// <summary>
        /// The playback position, expressed in seconds.
        /// </summary>
        SecOffset = 0x1024
    }
}