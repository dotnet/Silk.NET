// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.OpenAL.Extensions.EXT
{
    /// <summary>
    /// Defines valid format specifiers for sound samples. This covers the additions from the multi-channel buffers
    /// extension.
    /// </summary>
    public enum ALAWBufferFormat
    {
        /// <summary>
        /// 1 Channel, A-law encoded data.
        /// </summary>
        Mono = 0x10016,

        /// <summary>
        /// 2 Channels, A-law encoded data.
        /// </summary>
        Stereo = 0x10017
    }
}