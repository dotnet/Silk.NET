// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.OpenAL
{
    /// <summary>
    /// A list of valid Int32 GetBuffer parameters.
    /// </summary>
    public enum GetBufferInteger
    {
        /// <summary>
        /// Sound sample's frequency, in units of hertz [Hz]. This is the number of samples per second. Half of the sample
        /// frequency marks the maximum significant frequency component.
        /// </summary>
        Frequency = 0x2001,

        /// <summary>
        /// Bit depth of the buffer. Should be 8 or 16.
        /// </summary>
        Bits = 0x2002,

        /// <summary>
        /// Number of channels in buffer. > 1 is valid, but buffer won’t be positioned when played. 1 for Mono, 2 for
        /// Stereo.
        /// </summary>
        Channels = 0x2003,

        /// <summary>
        /// size of the Buffer in bytes.
        /// </summary>
        Size = 0x2004
    }
}