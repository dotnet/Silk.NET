//
// IMA4BufferFormat.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace OpenToolkit.OpenAL.Native.Extensions.EXT.IMA4Format
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
        Stereo = 0x1301,
    }
}
