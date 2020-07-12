// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkColorSpaceKHR")]
    public enum ColorSpaceKHR
    {
        [NativeName("Name", "VK_COLOR_SPACE_SRGB_NONLINEAR_KHR")]
        ColorSpaceSrgbNonlinearKhr = 0,
        [NativeName("Name", "VK_COLORSPACE_SRGB_NONLINEAR_KHR")]
        ColorspaceSrgbNonlinearKhr = 0,
        [NativeName("Name", "VK_COLOR_SPACE_DISPLAY_P3_NONLINEAR_EXT")]
        ColorSpaceDisplayP3NonlinearExt = 1000104001,
        [NativeName("Name", "VK_COLOR_SPACE_EXTENDED_SRGB_LINEAR_EXT")]
        ColorSpaceExtendedSrgbLinearExt = 1000104002,
        [NativeName("Name", "VK_COLOR_SPACE_DISPLAY_P3_LINEAR_EXT")]
        ColorSpaceDisplayP3LinearExt = 1000104003,
        [NativeName("Name", "VK_COLOR_SPACE_DCI_P3_NONLINEAR_EXT")]
        ColorSpaceDciP3NonlinearExt = 1000104004,
        [NativeName("Name", "VK_COLOR_SPACE_BT709_LINEAR_EXT")]
        ColorSpaceBT709LinearExt = 1000104005,
        [NativeName("Name", "VK_COLOR_SPACE_BT709_NONLINEAR_EXT")]
        ColorSpaceBT709NonlinearExt = 1000104006,
        [NativeName("Name", "VK_COLOR_SPACE_BT2020_LINEAR_EXT")]
        ColorSpaceBT2020LinearExt = 1000104007,
        [NativeName("Name", "VK_COLOR_SPACE_HDR10_ST2084_EXT")]
        ColorSpaceHdr10ST2084Ext = 1000104008,
        [NativeName("Name", "VK_COLOR_SPACE_DOLBYVISION_EXT")]
        ColorSpaceDolbyvisionExt = 1000104009,
        [NativeName("Name", "VK_COLOR_SPACE_HDR10_HLG_EXT")]
        ColorSpaceHdr10HlgExt = 1000104010,
        [NativeName("Name", "VK_COLOR_SPACE_ADOBERGB_LINEAR_EXT")]
        ColorSpaceAdobergbLinearExt = 1000104011,
        [NativeName("Name", "VK_COLOR_SPACE_ADOBERGB_NONLINEAR_EXT")]
        ColorSpaceAdobergbNonlinearExt = 1000104012,
        [NativeName("Name", "VK_COLOR_SPACE_PASS_THROUGH_EXT")]
        ColorSpacePassThroughExt = 1000104013,
        [NativeName("Name", "VK_COLOR_SPACE_EXTENDED_SRGB_NONLINEAR_EXT")]
        ColorSpaceExtendedSrgbNonlinearExt = 1000104014,
        [NativeName("Name", "VK_COLOR_SPACE_DCI_P3_LINEAR_EXT")]
        ColorSpaceDciP3LinearExt = 1000104003,
        [NativeName("Name", "VK_COLOR_SPACE_DISPLAY_NATIVE_AMD")]
        ColorSpaceDisplayNativeAmd = 1000213000,
    }
}
