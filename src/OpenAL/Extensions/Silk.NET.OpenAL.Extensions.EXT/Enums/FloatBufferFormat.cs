// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.OpenAL.Extensions.EXT
{
    /// <summary>
    /// Defines valid format specifiers for sound samples. This covers the additions from the multi-channel buffers
    /// extension.
    /// </summary>
    public enum FloatBufferFormat
    {
        /// <summary>
        /// 1 Channel, single-precision floating-point data.
        /// </summary>
        Mono = 0x10010,

        /// <summary>
        /// 2 Channels, single-precision floating-point data.
        /// </summary>
        Stereo = 0x10011
    }
}