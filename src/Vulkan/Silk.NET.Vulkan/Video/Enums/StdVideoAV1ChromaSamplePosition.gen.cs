// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Video
{
    [NativeName("Name", "StdVideoAV1ChromaSamplePosition")]
    public enum StdVideoAV1ChromaSamplePosition : int
    {
        [Obsolete("Deprecated in favour of \"Unknown\"")]
        [NativeName("Name", "STD_VIDEO_AV1_CHROMA_SAMPLE_POSITION_UNKNOWN")]
        StdVideoAV1ChromaSamplePositionUnknown = 0x0,
        [Obsolete("Deprecated in favour of \"Vertical\"")]
        [NativeName("Name", "STD_VIDEO_AV1_CHROMA_SAMPLE_POSITION_VERTICAL")]
        StdVideoAV1ChromaSamplePositionVertical = 0x1,
        [Obsolete("Deprecated in favour of \"Colocated\"")]
        [NativeName("Name", "STD_VIDEO_AV1_CHROMA_SAMPLE_POSITION_COLOCATED")]
        StdVideoAV1ChromaSamplePositionColocated = 0x2,
        [Obsolete("Deprecated in favour of \"Reserved\"")]
        [NativeName("Name", "STD_VIDEO_AV1_CHROMA_SAMPLE_POSITION_RESERVED")]
        StdVideoAV1ChromaSamplePositionReserved = 0x3,
        [Obsolete("Deprecated in favour of \"Invalid\"")]
        [NativeName("Name", "STD_VIDEO_AV1_CHROMA_SAMPLE_POSITION_INVALID")]
        StdVideoAV1ChromaSamplePositionInvalid = 0x7FFFFFFF,
        [Obsolete("Deprecated in favour of \"MaxEnum\"")]
        [NativeName("Name", "STD_VIDEO_AV1_CHROMA_SAMPLE_POSITION_MAX_ENUM")]
        StdVideoAV1ChromaSamplePositionMaxEnum = 0x7FFFFFFF,
        [NativeName("Name", "STD_VIDEO_AV1_CHROMA_SAMPLE_POSITION_UNKNOWN")]
        Unknown = 0x0,
        [NativeName("Name", "STD_VIDEO_AV1_CHROMA_SAMPLE_POSITION_VERTICAL")]
        Vertical = 0x1,
        [NativeName("Name", "STD_VIDEO_AV1_CHROMA_SAMPLE_POSITION_COLOCATED")]
        Colocated = 0x2,
        [NativeName("Name", "STD_VIDEO_AV1_CHROMA_SAMPLE_POSITION_RESERVED")]
        Reserved = 0x3,
        [NativeName("Name", "STD_VIDEO_AV1_CHROMA_SAMPLE_POSITION_INVALID")]
        Invalid = 0x7FFFFFFF,
        [NativeName("Name", "STD_VIDEO_AV1_CHROMA_SAMPLE_POSITION_MAX_ENUM")]
        MaxEnum = 0x7FFFFFFF,
    }
}
