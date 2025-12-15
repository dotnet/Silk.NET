// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Video
{
    [NativeName("Name", "StdVideoVP9Profile")]
    public enum StdVideoVP9Profile : int
    {
        [Obsolete("Deprecated in favour of \"Profile0\"")]
        [NativeName("Name", "STD_VIDEO_VP9_PROFILE_0")]
        StdVideoVP9Profile0 = 0x0,
        [Obsolete("Deprecated in favour of \"Profile1\"")]
        [NativeName("Name", "STD_VIDEO_VP9_PROFILE_1")]
        StdVideoVP9Profile1 = 0x1,
        [Obsolete("Deprecated in favour of \"Profile2\"")]
        [NativeName("Name", "STD_VIDEO_VP9_PROFILE_2")]
        StdVideoVP9Profile2 = 0x2,
        [Obsolete("Deprecated in favour of \"Profile3\"")]
        [NativeName("Name", "STD_VIDEO_VP9_PROFILE_3")]
        StdVideoVP9Profile3 = 0x3,
        [Obsolete("Deprecated in favour of \"ProfileInvalid\"")]
        [NativeName("Name", "STD_VIDEO_VP9_PROFILE_INVALID")]
        StdVideoVP9ProfileInvalid = 0x7FFFFFFF,
        [Obsolete("Deprecated in favour of \"ProfileMaxEnum\"")]
        [NativeName("Name", "STD_VIDEO_VP9_PROFILE_MAX_ENUM")]
        StdVideoVP9ProfileMaxEnum = 0x7FFFFFFF,
        [NativeName("Name", "STD_VIDEO_VP9_PROFILE_0")]
        Profile0 = 0x0,
        [NativeName("Name", "STD_VIDEO_VP9_PROFILE_1")]
        Profile1 = 0x1,
        [NativeName("Name", "STD_VIDEO_VP9_PROFILE_2")]
        Profile2 = 0x2,
        [NativeName("Name", "STD_VIDEO_VP9_PROFILE_3")]
        Profile3 = 0x3,
        [NativeName("Name", "STD_VIDEO_VP9_PROFILE_INVALID")]
        ProfileInvalid = 0x7FFFFFFF,
        [NativeName("Name", "STD_VIDEO_VP9_PROFILE_MAX_ENUM")]
        ProfileMaxEnum = 0x7FFFFFFF,
    }
}
