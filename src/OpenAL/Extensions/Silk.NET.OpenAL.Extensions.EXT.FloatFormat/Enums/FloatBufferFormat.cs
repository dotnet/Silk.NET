// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

namespace Silk.NET.OpenAL.Extensions.EXT.FloatFormat
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