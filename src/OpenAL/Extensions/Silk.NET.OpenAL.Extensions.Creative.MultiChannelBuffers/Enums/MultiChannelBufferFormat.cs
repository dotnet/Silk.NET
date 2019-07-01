//
// MultiChannelBufferFormat.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace OpenToolkit.OpenAL.Extensions.Creative.MultiChannelBuffers
{
    /// <summary>
    /// Defines valid format specifiers for sound samples. This covers the additions from the multi-channel buffers
    /// extension.
    /// </summary>
    public enum MultiChannelBufferFormat
    {
        /// <summary>
        /// Multichannel 5.1, 16-bit data.
        /// </summary>
        Multi51Chn16 = 0x120B,

        /// <summary>
        /// Multichannel 5.1, 32-bit data.
        /// </summary>
        Multi51Chn32 = 0x120C,

        /// <summary>
        /// Multichannel 5.1, 8-bit data.
        /// </summary>
        Multi51Chn8 = 0x120A,

        /// <summary>
        /// Multichannel 6.1, 16-bit data.
        /// </summary>
        Multi61Chn16 = 0x120E,

        /// <summary>
        /// Multichannel 6.1, 32-bit data.
        /// </summary>
        Multi61Chn32 = 0x120F,

        /// <summary>
        /// Multichannel 6.1, 8-bit data.
        /// </summary>
        Multi61Chn8 = 0x120D,

        /// <summary>
        /// Multichannel 7.1, 16-bit data.
        /// </summary>
        Multi71Chn16 = 0x1211,

        /// <summary>
        /// Multichannel 7.1, 32-bit data.
        /// </summary>
        Multi71Chn32 = 0x1212,

        /// <summary>
        /// Multichannel 7.1, 8-bit data.
        /// </summary>
        Multi71Chn8 = 0x1210,

        /// <summary>
        /// Multichannel 4.0, 16-bit data.
        /// </summary>
        MultiQuad16 = 0x1205,

        /// <summary>
        /// Multichannel 4.0, 32-bit data.
        /// </summary>
        MultiQuad32 = 0x1206,

        /// <summary>
        /// Multichannel 4.0, 8-bit data.
        /// </summary>
        MultiQuad8 = 0x1204,

        /// <summary>
        /// 1 Channel rear speaker, 16-bit data. See Quadrophonic setups.
        /// </summary>
        MultiRear16 = 0x1208,

        /// <summary>
        /// 1 Channel rear speaker, 32-bit data. See Quadrophonic setups.
        /// </summary>
        MultiRear32 = 0x1209,

        /// <summary>
        /// 1 Channel rear speaker, 8-bit data. See Quadrophonic setups.
        /// </summary>
        MultiRear8 = 0x1207,
    }
}
