// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkColorSpaceKHR")]
public enum ColorSpaceKHR : uint
{
    [NativeName("VK_COLOR_SPACE_SRGB_NONLINEAR_KHR")]
    SrgbNonlinear = 0,

    [NativeName("VK_COLOR_SPACE_DISPLAY_P3_NONLINEAR_EXT")]
    DisplayP3NonlinearEXT = 1000104001,

    [NativeName("VK_COLOR_SPACE_EXTENDED_SRGB_LINEAR_EXT")]
    ExtendedSrgbLinearEXT = 1000104002,

    [NativeName("VK_COLOR_SPACE_DISPLAY_P3_LINEAR_EXT")]
    DisplayP3LinearEXT = 1000104003,

    [NativeName("VK_COLOR_SPACE_DCI_P3_NONLINEAR_EXT")]
    DciP3NonlinearEXT = 1000104004,

    [NativeName("VK_COLOR_SPACE_BT709_LINEAR_EXT")]
    Bt709LinearEXT = 1000104005,

    [NativeName("VK_COLOR_SPACE_BT709_NONLINEAR_EXT")]
    Bt709NonlinearEXT = 1000104006,

    [NativeName("VK_COLOR_SPACE_BT2020_LINEAR_EXT")]
    Bt2020LinearEXT = 1000104007,

    [NativeName("VK_COLOR_SPACE_HDR10_ST2084_EXT")]
    Hdr10St2084EXT = 1000104008,

    [NativeName("VK_COLOR_SPACE_DOLBYVISION_EXT")]
    DolbyvisionEXT = 1000104009,

    [NativeName("VK_COLOR_SPACE_HDR10_HLG_EXT")]
    Hdr10HlgEXT = 1000104010,

    [NativeName("VK_COLOR_SPACE_ADOBERGB_LINEAR_EXT")]
    AdobergbLinearEXT = 1000104011,

    [NativeName("VK_COLOR_SPACE_ADOBERGB_NONLINEAR_EXT")]
    AdobergbNonlinearEXT = 1000104012,

    [NativeName("VK_COLOR_SPACE_PASS_THROUGH_EXT")]
    PassThroughEXT = 1000104013,

    [NativeName("VK_COLOR_SPACE_EXTENDED_SRGB_NONLINEAR_EXT")]
    ExtendedSrgbNonlinearEXT = 1000104014,

    [NativeName("VK_COLOR_SPACE_DISPLAY_NATIVE_AMD")]
    DisplayNativeAMD = 1000213000,
}
