// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Video
{
    [Flags]
    [NativeName("Name", "StdVideoAV1Profile")]
    public enum StdVideoAV1Profile : int
    {
        [Obsolete("Deprecated in favour of \"Main\"")]
        [NativeName("Name", "STD_VIDEO_AV1_PROFILE_MAIN")]
        StdVideoAV1ProfileMain = 0x0,
        [Obsolete("Deprecated in favour of \"High\"")]
        [NativeName("Name", "STD_VIDEO_AV1_PROFILE_HIGH")]
        StdVideoAV1ProfileHigh = 0x1,
        [Obsolete("Deprecated in favour of \"Professional\"")]
        [NativeName("Name", "STD_VIDEO_AV1_PROFILE_PROFESSIONAL")]
        StdVideoAV1ProfileProfessional = 0x2,
        [Obsolete("Deprecated in favour of \"Invalid\"")]
        [NativeName("Name", "STD_VIDEO_AV1_PROFILE_INVALID")]
        StdVideoAV1ProfileInvalid = 0x7FFFFFFF,
        [Obsolete("Deprecated in favour of \"MaxEnum\"")]
        [NativeName("Name", "STD_VIDEO_AV1_PROFILE_MAX_ENUM")]
        StdVideoAV1ProfileMaxEnum = 0x7FFFFFFF,
        [NativeName("Name", "STD_VIDEO_AV1_PROFILE_MAIN")]
        Main = 0x0,
        [NativeName("Name", "STD_VIDEO_AV1_PROFILE_HIGH")]
        High = 0x1,
        [NativeName("Name", "STD_VIDEO_AV1_PROFILE_PROFESSIONAL")]
        Professional = 0x2,
        [NativeName("Name", "STD_VIDEO_AV1_PROFILE_INVALID")]
        Invalid = 0x7FFFFFFF,
        [NativeName("Name", "STD_VIDEO_AV1_PROFILE_MAX_ENUM")]
        MaxEnum = 0x7FFFFFFF,
    }
}
