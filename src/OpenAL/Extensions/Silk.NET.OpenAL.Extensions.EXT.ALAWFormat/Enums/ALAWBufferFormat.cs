//
// ALAWBufferFormat.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace OpenToolkit.OpenAL.Extensions.EXT.ALAWFormat
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
        Stereo = 0x10017,
    }
}
