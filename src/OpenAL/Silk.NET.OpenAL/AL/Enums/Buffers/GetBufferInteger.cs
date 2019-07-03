// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

namespace Silk.NET.OpenAL
{
    /// <summary>
    /// A list of valid Int32 GetBuffer parameters.
    /// </summary>
    public enum GetBufferInteger
    {
        /// <summary>
        /// Sound sample's frequency, in units of hertz [Hz]. This is the number of samples per second. Half of the sample
        /// frequency marks the maximum significant frequency component.
        /// </summary>
        Frequency = 0x2001,

        /// <summary>
        /// Bit depth of the buffer. Should be 8 or 16.
        /// </summary>
        Bits = 0x2002,

        /// <summary>
        /// Number of channels in buffer. > 1 is valid, but buffer won’t be positioned when played. 1 for Mono, 2 for
        /// Stereo.
        /// </summary>
        Channels = 0x2003,

        /// <summary>
        /// size of the Buffer in bytes.
        /// </summary>
        Size = 0x2004
    }
}