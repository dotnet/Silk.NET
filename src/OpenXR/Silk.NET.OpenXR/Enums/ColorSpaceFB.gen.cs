// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrColorSpaceFB")]
    public enum ColorSpaceFB : int
    {
        [NativeName("Name", "XR_COLOR_SPACE_UNMANAGED_FB")]
        ColorSpaceUnmanagedFB = 0,
        [NativeName("Name", "XR_COLOR_SPACE_REC2020_FB")]
        ColorSpaceRec2020FB = 1,
        [NativeName("Name", "XR_COLOR_SPACE_REC709_FB")]
        ColorSpaceRec709FB = 2,
        [NativeName("Name", "XR_COLOR_SPACE_RIFT_CV1_FB")]
        ColorSpaceRiftCV1FB = 3,
        [NativeName("Name", "XR_COLOR_SPACE_RIFT_S_FB")]
        ColorSpaceRiftSFB = 4,
        [NativeName("Name", "XR_COLOR_SPACE_QUEST_FB")]
        ColorSpaceQuestFB = 5,
        [NativeName("Name", "XR_COLOR_SPACE_P3_FB")]
        ColorSpaceP3FB = 6,
        [NativeName("Name", "XR_COLOR_SPACE_ADOBE_RGB_FB")]
        ColorSpaceAdobeRgbFB = 7,
    }
}
