// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.OpenAL.Extensions.Creative
{
    /// <summary>
    /// A list of valid <see cref="float" /> Filter/GetFilter parameters.
    /// </summary>
    public enum FilterFloat
    {
        /// <summary>
        /// Range [0.0f .. 1.0f] Default: 1.0f
        /// </summary>
        LowpassGain = 0x0001,

        /// <summary>
        /// Range [0.0f .. 1.0f] Default: 1.0f
        /// </summary>
        LowpassGainHF = 0x0002,

        /// <summary>
        /// Range [0.0f .. 1.0f] Default: 1.0f
        /// </summary>
        HighpassGain = 0x0001,

        /// <summary>
        /// Range [0.0f .. 1.0f] Default: 1.0f
        /// </summary>
        HighpassGainLF = 0x0002,

        /// <summary>
        /// Range [0.0f .. 1.0f] Default: 1.0f
        /// </summary>
        BandpassGain = 0x0001,

        /// <summary>
        /// Range [0.0f .. 1.0f] Default: 1.0f
        /// </summary>
        BandpassGainLF = 0x0002,

        /// <summary>
        /// Range [0.0f .. 1.0f] Default: 1.0f
        /// </summary>
        BandpassGainHF = 0x0003
    }
}