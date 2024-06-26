// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Video
{
    [NativeName("Name", "StdVideoAV1FrameRestorationType")]
    public enum StdVideoAV1FrameRestorationType : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "STD_VIDEO_AV1_FRAME_RESTORATION_TYPE_NONE")]
        StdVideoAV1FrameRestorationTypeNone = 0x0,
        [Obsolete("Deprecated in favour of \"Wiener\"")]
        [NativeName("Name", "STD_VIDEO_AV1_FRAME_RESTORATION_TYPE_WIENER")]
        StdVideoAV1FrameRestorationTypeWiener = 0x1,
        [Obsolete("Deprecated in favour of \"Sgrproj\"")]
        [NativeName("Name", "STD_VIDEO_AV1_FRAME_RESTORATION_TYPE_SGRPROJ")]
        StdVideoAV1FrameRestorationTypeSgrproj = 0x2,
        [Obsolete("Deprecated in favour of \"Switchable\"")]
        [NativeName("Name", "STD_VIDEO_AV1_FRAME_RESTORATION_TYPE_SWITCHABLE")]
        StdVideoAV1FrameRestorationTypeSwitchable = 0x3,
        [Obsolete("Deprecated in favour of \"Invalid\"")]
        [NativeName("Name", "STD_VIDEO_AV1_FRAME_RESTORATION_TYPE_INVALID")]
        StdVideoAV1FrameRestorationTypeInvalid = 0x7FFFFFFF,
        [Obsolete("Deprecated in favour of \"MaxEnum\"")]
        [NativeName("Name", "STD_VIDEO_AV1_FRAME_RESTORATION_TYPE_MAX_ENUM")]
        StdVideoAV1FrameRestorationTypeMaxEnum = 0x7FFFFFFF,
        [NativeName("Name", "STD_VIDEO_AV1_FRAME_RESTORATION_TYPE_NONE")]
        None = 0x0,
        [NativeName("Name", "STD_VIDEO_AV1_FRAME_RESTORATION_TYPE_WIENER")]
        Wiener = 0x1,
        [NativeName("Name", "STD_VIDEO_AV1_FRAME_RESTORATION_TYPE_SGRPROJ")]
        Sgrproj = 0x2,
        [NativeName("Name", "STD_VIDEO_AV1_FRAME_RESTORATION_TYPE_SWITCHABLE")]
        Switchable = 0x3,
        [NativeName("Name", "STD_VIDEO_AV1_FRAME_RESTORATION_TYPE_INVALID")]
        Invalid = 0x7FFFFFFF,
        [NativeName("Name", "STD_VIDEO_AV1_FRAME_RESTORATION_TYPE_MAX_ENUM")]
        MaxEnum = 0x7FFFFFFF,
    }
}
