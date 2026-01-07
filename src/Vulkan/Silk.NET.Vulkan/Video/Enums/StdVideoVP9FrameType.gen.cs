// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Video
{
    [NativeName("Name", "StdVideoVP9FrameType")]
    public enum StdVideoVP9FrameType : int
    {
        [Obsolete("Deprecated in favour of \"Key\"")]
        [NativeName("Name", "STD_VIDEO_VP9_FRAME_TYPE_KEY")]
        StdVideoVP9FrameTypeKey = 0x0,
        [Obsolete("Deprecated in favour of \"NonKey\"")]
        [NativeName("Name", "STD_VIDEO_VP9_FRAME_TYPE_NON_KEY")]
        StdVideoVP9FrameTypeNonKey = 0x1,
        [Obsolete("Deprecated in favour of \"Invalid\"")]
        [NativeName("Name", "STD_VIDEO_VP9_FRAME_TYPE_INVALID")]
        StdVideoVP9FrameTypeInvalid = 0x7FFFFFFF,
        [Obsolete("Deprecated in favour of \"MaxEnum\"")]
        [NativeName("Name", "STD_VIDEO_VP9_FRAME_TYPE_MAX_ENUM")]
        StdVideoVP9FrameTypeMaxEnum = 0x7FFFFFFF,
        [NativeName("Name", "STD_VIDEO_VP9_FRAME_TYPE_KEY")]
        Key = 0x0,
        [NativeName("Name", "STD_VIDEO_VP9_FRAME_TYPE_NON_KEY")]
        NonKey = 0x1,
        [NativeName("Name", "STD_VIDEO_VP9_FRAME_TYPE_INVALID")]
        Invalid = 0x7FFFFFFF,
        [NativeName("Name", "STD_VIDEO_VP9_FRAME_TYPE_MAX_ENUM")]
        MaxEnum = 0x7FFFFFFF,
    }
}
