// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.OpenAL
{
    /// <summary>
    /// A list of valid 32-bit Float Listener/GetListener parameters.
    /// </summary>
    public enum ListenerFloat
    {
        /// <summary>
        /// Indicate the gain (Volume amplification) applied. Type: float Range: [0.0f - ? ] A value of 1.0 means
        /// un-attenuated/unchanged. Each division by 2 equals an attenuation of -6dB. Each multiplicaton with 2 equals an
        /// amplification of +6dB. A value of 0.0f is interpreted as zero volume and the channel is effectively disabled.
        /// </summary>
        Gain = 0x100A
    }
}