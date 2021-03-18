// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.OpenAL
{
    /// <summary>
    /// A list of valid Int32 Source parameters.
    /// </summary>
    public enum SourceInteger
    {
        /// <summary>
        /// The playback position, expressed in bytes.
        /// </summary>
        ByteOffset = 0x1026, // AL_EXT_OFFSET extension.

        /// <summary>
        /// The playback position, expressed in samples.
        /// </summary>
        SampleOffset = 0x1025, // AL_EXT_OFFSET extension.

        /// <summary>
        /// Indicate the Buffer to provide sound samples. Type: uint Range: any valid Buffer Handle.
        /// </summary>
        Buffer = 0x1009,

        /// <summary>
        /// Source type (Static, Streaming or undetermined). Use enum AlSourceType for comparison.
        /// </summary>
        SourceType = 0x1027
    }
}