// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Video
{
    [NativeName("Name", "StdVideoAV1FrameType")]
    public enum StdVideoAV1FrameType : int
    {
        [Obsolete("Deprecated in favour of \"Key\"")]
        [NativeName("Name", "STD_VIDEO_AV1_FRAME_TYPE_KEY")]
        StdVideoAV1FrameTypeKey = 0x0,
        [Obsolete("Deprecated in favour of \"Inter\"")]
        [NativeName("Name", "STD_VIDEO_AV1_FRAME_TYPE_INTER")]
        StdVideoAV1FrameTypeInter = 0x1,
        [Obsolete("Deprecated in favour of \"IntraOnly\"")]
        [NativeName("Name", "STD_VIDEO_AV1_FRAME_TYPE_INTRA_ONLY")]
        StdVideoAV1FrameTypeIntraOnly = 0x2,
        [Obsolete("Deprecated in favour of \"Switch\"")]
        [NativeName("Name", "STD_VIDEO_AV1_FRAME_TYPE_SWITCH")]
        StdVideoAV1FrameTypeSwitch = 0x3,
        [Obsolete("Deprecated in favour of \"Invalid\"")]
        [NativeName("Name", "STD_VIDEO_AV1_FRAME_TYPE_INVALID")]
        StdVideoAV1FrameTypeInvalid = 0x7FFFFFFF,
        [Obsolete("Deprecated in favour of \"MaxEnum\"")]
        [NativeName("Name", "STD_VIDEO_AV1_FRAME_TYPE_MAX_ENUM")]
        StdVideoAV1FrameTypeMaxEnum = 0x7FFFFFFF,
        [NativeName("Name", "STD_VIDEO_AV1_FRAME_TYPE_KEY")]
        Key = 0x0,
        [NativeName("Name", "STD_VIDEO_AV1_FRAME_TYPE_INTER")]
        Inter = 0x1,
        [NativeName("Name", "STD_VIDEO_AV1_FRAME_TYPE_INTRA_ONLY")]
        IntraOnly = 0x2,
        [NativeName("Name", "STD_VIDEO_AV1_FRAME_TYPE_SWITCH")]
        Switch = 0x3,
        [NativeName("Name", "STD_VIDEO_AV1_FRAME_TYPE_INVALID")]
        Invalid = 0x7FFFFFFF,
        [NativeName("Name", "STD_VIDEO_AV1_FRAME_TYPE_MAX_ENUM")]
        MaxEnum = 0x7FFFFFFF,
    }
}
