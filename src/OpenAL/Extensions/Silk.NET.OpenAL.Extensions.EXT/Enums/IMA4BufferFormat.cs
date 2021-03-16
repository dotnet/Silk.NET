// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.OpenAL.Native.Extensions.EXT
{
    /// <summary>
    /// Defines valid format specifiers for sound samples. This covers the additions from the multi-channel buffers
    /// extension.
    /// </summary>
    public enum IMA4BufferFormat
    {
        /// <summary>
        /// 1 Channel, IMA4 ADPCM encoded data.
        /// </summary>
        Mono = 0x1300,

        /// <summary>
        /// 2 Channels, IMA4 ADPCM encoded data.
        /// </summary>
        Stereo = 0x1301
    }
}