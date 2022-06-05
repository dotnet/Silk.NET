// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrColorSpaceFB")]
    public enum ColorSpaceFB : int
    {
        [Obsolete("Deprecated in favour of \"UnmanagedFB\"")]
        [NativeName("Name", "XR_COLOR_SPACE_UNMANAGED_FB")]
        ColorSpaceUnmanagedFB = 0,
        [Obsolete("Deprecated in favour of \"Rec2020FB\"")]
        [NativeName("Name", "XR_COLOR_SPACE_REC2020_FB")]
        ColorSpaceRec2020FB = 1,
        [Obsolete("Deprecated in favour of \"Rec709FB\"")]
        [NativeName("Name", "XR_COLOR_SPACE_REC709_FB")]
        ColorSpaceRec709FB = 2,
        [Obsolete("Deprecated in favour of \"RiftCV1FB\"")]
        [NativeName("Name", "XR_COLOR_SPACE_RIFT_CV1_FB")]
        ColorSpaceRiftCV1FB = 3,
        [Obsolete("Deprecated in favour of \"RiftSFB\"")]
        [NativeName("Name", "XR_COLOR_SPACE_RIFT_S_FB")]
        ColorSpaceRiftSFB = 4,
        [Obsolete("Deprecated in favour of \"QuestFB\"")]
        [NativeName("Name", "XR_COLOR_SPACE_QUEST_FB")]
        ColorSpaceQuestFB = 5,
        [Obsolete("Deprecated in favour of \"P3FB\"")]
        [NativeName("Name", "XR_COLOR_SPACE_P3_FB")]
        ColorSpaceP3FB = 6,
        [Obsolete("Deprecated in favour of \"AdobeRgbFB\"")]
        [NativeName("Name", "XR_COLOR_SPACE_ADOBE_RGB_FB")]
        ColorSpaceAdobeRgbFB = 7,
        [NativeName("Name", "XR_COLOR_SPACE_UNMANAGED_FB")]
        UnmanagedFB = 0,
        [NativeName("Name", "XR_COLOR_SPACE_REC2020_FB")]
        Rec2020FB = 1,
        [NativeName("Name", "XR_COLOR_SPACE_REC709_FB")]
        Rec709FB = 2,
        [NativeName("Name", "XR_COLOR_SPACE_RIFT_CV1_FB")]
        RiftCV1FB = 3,
        [NativeName("Name", "XR_COLOR_SPACE_RIFT_S_FB")]
        RiftSFB = 4,
        [NativeName("Name", "XR_COLOR_SPACE_QUEST_FB")]
        QuestFB = 5,
        [NativeName("Name", "XR_COLOR_SPACE_P3_FB")]
        P3FB = 6,
        [NativeName("Name", "XR_COLOR_SPACE_ADOBE_RGB_FB")]
        AdobeRgbFB = 7,
    }
}
