//
// VorbisBufferFormat.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace OpenToolkit.OpenAL.Extensions.EXT.VorbisFormat
{
    /// <summary>
    /// Defines valid format specifiers for sound samples. This covers the additions from the multi-channel buffers
    /// extension.
    /// </summary>
    public enum VorbisBufferFormat
    {
        /// <summary>
        /// Ogg Vorbis encoded data.
        /// </summary>
        Vorbis = 0x10003,
    }
}
