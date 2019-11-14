// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using AdvancedDLSupport;

namespace Silk.NET.OpenAL.Native.Extensions.EXT
{
    /// <summary>
    /// Defines the public interface for buffer-related functions of the multi-channel buffers extension.
    /// </summary>
    [NativeSymbols(Prefix = "al")]
    public interface IIMA4Format
    {
        /// <summary>
        /// Fills a buffer with audio data.
        /// </summary>
        /// <param name="buffer">The buffer to fill.</param>
        /// <param name="format">The format of the data.</param>
        /// <param name="data">A pointer to the data.</param>
        /// <param name="size">The size of the data in bytes.</param>
        /// <param name="frequency">The frequency of the data.</param>
        unsafe void BufferData(uint buffer, IMA4BufferFormat format, void* data, int size, int frequency);
    }
}