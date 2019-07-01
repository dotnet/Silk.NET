//
// SourceState.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace Silk.NET.OpenAL
{
    /// <summary>
    /// Source state information, can be retrieved by AL.Source() with SourceInteger.SourceState.
    /// </summary>
    public enum SourceState
    {
        /// <summary>
        /// Default State when loaded, can be manually set with AL.SourceRewind().
        /// </summary>
        Initial = 0x1011,

        /// <summary>
        /// The source is currently playing.
        /// </summary>
        Playing = 0x1012,

        /// <summary>
        /// The source has paused playback.
        /// </summary>
        Paused = 0x1013,

        /// <summary>
        /// The source is not playing.
        /// </summary>
        Stopped = 0x1014,
    }
}
