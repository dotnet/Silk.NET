// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkColorSpaceKHR")]
    public enum ColorSpaceKHR : int
    {
        [Obsolete("Deprecated in favour of \"SpaceSrgbNonlinearKhr\"")]
        [NativeName("Name", "VK_COLOR_SPACE_SRGB_NONLINEAR_KHR")]
        ColorSpaceSrgbNonlinearKhr = 0,
        [Obsolete("Deprecated in favour of \"PaceSrgbNonlinearKhr\"")]
        [NativeName("Name", "VK_COLORSPACE_SRGB_NONLINEAR_KHR")]
        ColorspaceSrgbNonlinearKhr = 0,
        [Obsolete("Deprecated in favour of \"SpaceDisplayP3NonlinearExt\"")]
        [NativeName("Name", "VK_COLOR_SPACE_DISPLAY_P3_NONLINEAR_EXT")]
        ColorSpaceDisplayP3NonlinearExt = 1000104001,
        [Obsolete("Deprecated in favour of \"SpaceExtendedSrgbLinearExt\"")]
        [NativeName("Name", "VK_COLOR_SPACE_EXTENDED_SRGB_LINEAR_EXT")]
        ColorSpaceExtendedSrgbLinearExt = 1000104002,
        [Obsolete("Deprecated in favour of \"SpaceDisplayP3LinearExt\"")]
        [NativeName("Name", "VK_COLOR_SPACE_DISPLAY_P3_LINEAR_EXT")]
        ColorSpaceDisplayP3LinearExt = 1000104003,
        [Obsolete("Deprecated in favour of \"SpaceDciP3NonlinearExt\"")]
        [NativeName("Name", "VK_COLOR_SPACE_DCI_P3_NONLINEAR_EXT")]
        ColorSpaceDciP3NonlinearExt = 1000104004,
        [Obsolete("Deprecated in favour of \"SpaceBT709LinearExt\"")]
        [NativeName("Name", "VK_COLOR_SPACE_BT709_LINEAR_EXT")]
        ColorSpaceBT709LinearExt = 1000104005,
        [Obsolete("Deprecated in favour of \"SpaceBT709NonlinearExt\"")]
        [NativeName("Name", "VK_COLOR_SPACE_BT709_NONLINEAR_EXT")]
        ColorSpaceBT709NonlinearExt = 1000104006,
        [Obsolete("Deprecated in favour of \"SpaceBT2020LinearExt\"")]
        [NativeName("Name", "VK_COLOR_SPACE_BT2020_LINEAR_EXT")]
        ColorSpaceBT2020LinearExt = 1000104007,
        [Obsolete("Deprecated in favour of \"SpaceHdr10ST2084Ext\"")]
        [NativeName("Name", "VK_COLOR_SPACE_HDR10_ST2084_EXT")]
        ColorSpaceHdr10ST2084Ext = 1000104008,
        [Obsolete("Deprecated in favour of \"SpaceDolbyvisionExt\"")]
        [NativeName("Name", "VK_COLOR_SPACE_DOLBYVISION_EXT")]
        ColorSpaceDolbyvisionExt = 1000104009,
        [Obsolete("Deprecated in favour of \"SpaceHdr10HlgExt\"")]
        [NativeName("Name", "VK_COLOR_SPACE_HDR10_HLG_EXT")]
        ColorSpaceHdr10HlgExt = 1000104010,
        [Obsolete("Deprecated in favour of \"SpaceAdobergbLinearExt\"")]
        [NativeName("Name", "VK_COLOR_SPACE_ADOBERGB_LINEAR_EXT")]
        ColorSpaceAdobergbLinearExt = 1000104011,
        [Obsolete("Deprecated in favour of \"SpaceAdobergbNonlinearExt\"")]
        [NativeName("Name", "VK_COLOR_SPACE_ADOBERGB_NONLINEAR_EXT")]
        ColorSpaceAdobergbNonlinearExt = 1000104012,
        [Obsolete("Deprecated in favour of \"SpacePassThroughExt\"")]
        [NativeName("Name", "VK_COLOR_SPACE_PASS_THROUGH_EXT")]
        ColorSpacePassThroughExt = 1000104013,
        [Obsolete("Deprecated in favour of \"SpaceExtendedSrgbNonlinearExt\"")]
        [NativeName("Name", "VK_COLOR_SPACE_EXTENDED_SRGB_NONLINEAR_EXT")]
        ColorSpaceExtendedSrgbNonlinearExt = 1000104014,
        [Obsolete("Deprecated in favour of \"SpaceDciP3LinearExt\"")]
        [NativeName("Name", "VK_COLOR_SPACE_DCI_P3_LINEAR_EXT")]
        ColorSpaceDciP3LinearExt = 1000104003,
        [Obsolete("Deprecated in favour of \"SpaceDisplayNativeAmd\"")]
        [NativeName("Name", "VK_COLOR_SPACE_DISPLAY_NATIVE_AMD")]
        ColorSpaceDisplayNativeAmd = 1000213000,
        [NativeName("Name", "VK_COLOR_SPACE_SRGB_NONLINEAR_KHR")]
        SpaceSrgbNonlinearKhr = 0,
        [NativeName("Name", "VK_COLORSPACE_SRGB_NONLINEAR_KHR")]
        PaceSrgbNonlinearKhr = 0,
        [NativeName("Name", "VK_COLOR_SPACE_DISPLAY_P3_NONLINEAR_EXT")]
        SpaceDisplayP3NonlinearExt = 1000104001,
        [NativeName("Name", "VK_COLOR_SPACE_EXTENDED_SRGB_LINEAR_EXT")]
        SpaceExtendedSrgbLinearExt = 1000104002,
        [NativeName("Name", "VK_COLOR_SPACE_DISPLAY_P3_LINEAR_EXT")]
        SpaceDisplayP3LinearExt = 1000104003,
        [NativeName("Name", "VK_COLOR_SPACE_DCI_P3_NONLINEAR_EXT")]
        SpaceDciP3NonlinearExt = 1000104004,
        [NativeName("Name", "VK_COLOR_SPACE_BT709_LINEAR_EXT")]
        SpaceBT709LinearExt = 1000104005,
        [NativeName("Name", "VK_COLOR_SPACE_BT709_NONLINEAR_EXT")]
        SpaceBT709NonlinearExt = 1000104006,
        [NativeName("Name", "VK_COLOR_SPACE_BT2020_LINEAR_EXT")]
        SpaceBT2020LinearExt = 1000104007,
        [NativeName("Name", "VK_COLOR_SPACE_HDR10_ST2084_EXT")]
        SpaceHdr10ST2084Ext = 1000104008,
        [NativeName("Name", "VK_COLOR_SPACE_DOLBYVISION_EXT")]
        SpaceDolbyvisionExt = 1000104009,
        [NativeName("Name", "VK_COLOR_SPACE_HDR10_HLG_EXT")]
        SpaceHdr10HlgExt = 1000104010,
        [NativeName("Name", "VK_COLOR_SPACE_ADOBERGB_LINEAR_EXT")]
        SpaceAdobergbLinearExt = 1000104011,
        [NativeName("Name", "VK_COLOR_SPACE_ADOBERGB_NONLINEAR_EXT")]
        SpaceAdobergbNonlinearExt = 1000104012,
        [NativeName("Name", "VK_COLOR_SPACE_PASS_THROUGH_EXT")]
        SpacePassThroughExt = 1000104013,
        [NativeName("Name", "VK_COLOR_SPACE_EXTENDED_SRGB_NONLINEAR_EXT")]
        SpaceExtendedSrgbNonlinearExt = 1000104014,
        [NativeName("Name", "VK_COLOR_SPACE_DCI_P3_LINEAR_EXT")]
        SpaceDciP3LinearExt = 1000104003,
        [NativeName("Name", "VK_COLOR_SPACE_DISPLAY_NATIVE_AMD")]
        SpaceDisplayNativeAmd = 1000213000,
    }
}
