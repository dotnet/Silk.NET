// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.MediaFoundation
{
    [NativeName("Name", "MF_MEDIA_ENGINE_STATISTIC")]
    public enum MediaEngineStatistic : int
    {
        [NativeName("Name", "MF_MEDIA_ENGINE_STATISTIC_FRAMES_RENDERED")]
        FramesRendered = 0x0,
        [NativeName("Name", "MF_MEDIA_ENGINE_STATISTIC_FRAMES_DROPPED")]
        FramesDropped = 0x1,
        [NativeName("Name", "MF_MEDIA_ENGINE_STATISTIC_BYTES_DOWNLOADED")]
        BytesDownloaded = 0x2,
        [NativeName("Name", "MF_MEDIA_ENGINE_STATISTIC_BUFFER_PROGRESS")]
        BufferProgress = 0x3,
        [NativeName("Name", "MF_MEDIA_ENGINE_STATISTIC_FRAMES_PER_SECOND")]
        FramesPerSecond = 0x4,
        [NativeName("Name", "MF_MEDIA_ENGINE_STATISTIC_PLAYBACK_JITTER")]
        PlaybackJitter = 0x5,
        [NativeName("Name", "MF_MEDIA_ENGINE_STATISTIC_FRAMES_CORRUPTED")]
        FramesCorrupted = 0x6,
        [NativeName("Name", "MF_MEDIA_ENGINE_STATISTIC_TOTAL_FRAME_DELAY")]
        TotalFrameDelay = 0x7,
    }
}
