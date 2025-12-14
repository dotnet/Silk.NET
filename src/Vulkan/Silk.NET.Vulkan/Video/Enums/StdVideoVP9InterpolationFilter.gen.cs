// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Video
{
    [Flags]
    [NativeName("Name", "StdVideoVP9InterpolationFilter")]
    public enum StdVideoVP9InterpolationFilter : int
    {
        [Obsolete("Deprecated in favour of \"Eighttap\"")]
        [NativeName("Name", "STD_VIDEO_VP9_INTERPOLATION_FILTER_EIGHTTAP")]
        StdVideoVP9InterpolationFilterEighttap = 0x0,
        [Obsolete("Deprecated in favour of \"EighttapSmooth\"")]
        [NativeName("Name", "STD_VIDEO_VP9_INTERPOLATION_FILTER_EIGHTTAP_SMOOTH")]
        StdVideoVP9InterpolationFilterEighttapSmooth = 0x1,
        [Obsolete("Deprecated in favour of \"EighttapSharp\"")]
        [NativeName("Name", "STD_VIDEO_VP9_INTERPOLATION_FILTER_EIGHTTAP_SHARP")]
        StdVideoVP9InterpolationFilterEighttapSharp = 0x2,
        [Obsolete("Deprecated in favour of \"Bilinear\"")]
        [NativeName("Name", "STD_VIDEO_VP9_INTERPOLATION_FILTER_BILINEAR")]
        StdVideoVP9InterpolationFilterBilinear = 0x3,
        [Obsolete("Deprecated in favour of \"Switchable\"")]
        [NativeName("Name", "STD_VIDEO_VP9_INTERPOLATION_FILTER_SWITCHABLE")]
        StdVideoVP9InterpolationFilterSwitchable = 0x4,
        [Obsolete("Deprecated in favour of \"Invalid\"")]
        [NativeName("Name", "STD_VIDEO_VP9_INTERPOLATION_FILTER_INVALID")]
        StdVideoVP9InterpolationFilterInvalid = 0x7FFFFFFF,
        [Obsolete("Deprecated in favour of \"MaxEnum\"")]
        [NativeName("Name", "STD_VIDEO_VP9_INTERPOLATION_FILTER_MAX_ENUM")]
        StdVideoVP9InterpolationFilterMaxEnum = 0x7FFFFFFF,
        [NativeName("Name", "STD_VIDEO_VP9_INTERPOLATION_FILTER_EIGHTTAP")]
        Eighttap = 0x0,
        [NativeName("Name", "STD_VIDEO_VP9_INTERPOLATION_FILTER_EIGHTTAP_SMOOTH")]
        EighttapSmooth = 0x1,
        [NativeName("Name", "STD_VIDEO_VP9_INTERPOLATION_FILTER_EIGHTTAP_SHARP")]
        EighttapSharp = 0x2,
        [NativeName("Name", "STD_VIDEO_VP9_INTERPOLATION_FILTER_BILINEAR")]
        Bilinear = 0x3,
        [NativeName("Name", "STD_VIDEO_VP9_INTERPOLATION_FILTER_SWITCHABLE")]
        Switchable = 0x4,
        [NativeName("Name", "STD_VIDEO_VP9_INTERPOLATION_FILTER_INVALID")]
        Invalid = 0x7FFFFFFF,
        [NativeName("Name", "STD_VIDEO_VP9_INTERPOLATION_FILTER_MAX_ENUM")]
        MaxEnum = 0x7FFFFFFF,
    }
}
