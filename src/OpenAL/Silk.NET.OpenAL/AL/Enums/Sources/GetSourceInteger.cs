// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

namespace Silk.NET.OpenAL
{
    /// <summary>
    /// A list of valid Int32 GetSource parameters.
    /// </summary>
    public enum GetSourceInteger
    {
        /// <summary>
        /// The playback position, expressed in bytes. AL_EXT_OFFSET Extension.
        /// </summary>
        ByteOffset = 0x1026,

        /// <summary>
        /// The playback position, expressed in samples. AL_EXT_OFFSET Extension.
        /// </summary>
        SampleOffset = 0x1025,

        /// <summary>
        /// Indicate the Buffer to provide sound samples. Type: uint Range: any valid Buffer Handle.
        /// </summary>
        Buffer = 0x1009,

        /// <summary>
        /// The state of the source (Stopped, Playing, etc.) Use the enum AlSourceState for comparison.
        /// </summary>
        SourceState = 0x1010,

        /// <summary>
        /// The number of buffers queued on this source.
        /// </summary>
        BuffersQueued = 0x1015,

        /// <summary>
        /// The number of buffers in the queue that have been processed.
        /// </summary>
        BuffersProcessed = 0x1016,

        /// <summary>
        /// Source type (Static, Streaming or undetermined). Use enum AlSourceType for comparison.
        /// </summary>
        SourceType = 0x1027
    }
}