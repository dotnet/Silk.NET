//
// FloatBufferFormat.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace OpenToolkit.OpenAL.Extensions.EXT.FloatFormat
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
        Stereo = 0x10011,
    }
}
