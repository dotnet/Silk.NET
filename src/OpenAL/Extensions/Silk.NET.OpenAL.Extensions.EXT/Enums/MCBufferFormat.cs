// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.OpenAL.Extensions.EXT.Enums
{
    /// <summary>
    /// Defines valid format specifiers for sound samples. This covers the additions from the OpenAL multi-channel buffers
    /// extension.
    /// </summary>
    public enum MCBufferFormat
    {
        /// <summary>
        /// 4 channels, unsigned 8-bit
        /// </summary>
        Quad8 = 0x1204,
        /// <summary>
        /// 4 channels, signed 16-bit
        /// </summary>
        Quad16 = 0x1205,
        /// <summary>
        /// 4 channels, 32-bit float
        /// </summary>
        Quad32 = 0x1206,
            
        /// <summary>
        /// 2 channels, unsigned 8-bit
        /// </summary>
        Rear8 = 0x1207,
        /// <summary>
        /// 2 channels, signed 16-bit
        /// </summary>
        Rear16 = 0x1208,
        /// <summary>
        /// 2 channels, 32-bit float
        /// </summary>
        Rear32 = 0x1209,
        
        /// <summary>
        /// 5.1 (6 channels), unsigned 8-bit
        /// </summary>
        S51Chn8 = 0x120A,
        /// <summary>
        /// 5.1 (6 channels), signed 16-bit
        /// </summary>
        S51Chn16 = 0x120B,
        /// <summary>
        /// 5.1 (6 channels), 32-bit float
        /// </summary>
        S51Chn32 = 0x120C,
        
        /// <summary>
        /// 6.1 (7 channels), unsigned 8-bit
        /// </summary>
        S61Chn8 = 0x120D,
        /// <summary>
        /// 6.1 (7 channels), signed 16-bit
        /// </summary>
        S61Chn16 = 0x120E,
        /// <summary>
        /// 6.1 (7 channels), 32-bit float
        /// </summary>
        S61Chn32 = 0x120F,
        
        /// <summary>
        /// 7.1 (8 channels), unsigned 8-bit
        /// </summary>
        S71Chn8 = 0x1210,
        /// <summary>
        /// 7.1 (8 channels), signed 16-bit
        /// </summary>
        S71Chn16 = 0x1211,
        /// <summary>
        /// 7.1 (8 channels), 32-bit float
        /// </summary>
        S71Chn32 = 0x1212
    }
}
