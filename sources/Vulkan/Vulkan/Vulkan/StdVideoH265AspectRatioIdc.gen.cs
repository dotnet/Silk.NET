// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoH265AspectRatioIdc")]
[SupportedApiProfile("vulkan")]
public enum StdVideoH265AspectRatioIdc : uint
{
    [NativeName("STD_VIDEO_H265_ASPECT_RATIO_IDC_UNSPECIFIED")]
    [SupportedApiProfile("vulkan")]
    IdcUnspecified = 0,

    [NativeName("STD_VIDEO_H265_ASPECT_RATIO_IDC_SQUARE")]
    [SupportedApiProfile("vulkan")]
    IdcSquare = 1,

    [NativeName("STD_VIDEO_H265_ASPECT_RATIO_IDC_12_11")]
    [SupportedApiProfile("vulkan")]
    Idc12X11 = 2,

    [NativeName("STD_VIDEO_H265_ASPECT_RATIO_IDC_10_11")]
    [SupportedApiProfile("vulkan")]
    Idc10X11 = 3,

    [NativeName("STD_VIDEO_H265_ASPECT_RATIO_IDC_16_11")]
    [SupportedApiProfile("vulkan")]
    Idc16X11 = 4,

    [NativeName("STD_VIDEO_H265_ASPECT_RATIO_IDC_40_33")]
    [SupportedApiProfile("vulkan")]
    Idc40X33 = 5,

    [NativeName("STD_VIDEO_H265_ASPECT_RATIO_IDC_24_11")]
    [SupportedApiProfile("vulkan")]
    Idc24X11 = 6,

    [NativeName("STD_VIDEO_H265_ASPECT_RATIO_IDC_20_11")]
    [SupportedApiProfile("vulkan")]
    Idc20X11 = 7,

    [NativeName("STD_VIDEO_H265_ASPECT_RATIO_IDC_32_11")]
    [SupportedApiProfile("vulkan")]
    Idc32X11 = 8,

    [NativeName("STD_VIDEO_H265_ASPECT_RATIO_IDC_80_33")]
    [SupportedApiProfile("vulkan")]
    Idc80X33 = 9,

    [NativeName("STD_VIDEO_H265_ASPECT_RATIO_IDC_18_11")]
    [SupportedApiProfile("vulkan")]
    Idc18X11 = 10,

    [NativeName("STD_VIDEO_H265_ASPECT_RATIO_IDC_15_11")]
    [SupportedApiProfile("vulkan")]
    Idc15X11 = 11,

    [NativeName("STD_VIDEO_H265_ASPECT_RATIO_IDC_64_33")]
    [SupportedApiProfile("vulkan")]
    Idc64X33 = 12,

    [NativeName("STD_VIDEO_H265_ASPECT_RATIO_IDC_160_99")]
    [SupportedApiProfile("vulkan")]
    Idc160X99 = 13,

    [NativeName("STD_VIDEO_H265_ASPECT_RATIO_IDC_4_3")]
    [SupportedApiProfile("vulkan")]
    Idc4X3 = 14,

    [NativeName("STD_VIDEO_H265_ASPECT_RATIO_IDC_3_2")]
    [SupportedApiProfile("vulkan")]
    Idc3X2 = 15,

    [NativeName("STD_VIDEO_H265_ASPECT_RATIO_IDC_2_1")]
    [SupportedApiProfile("vulkan")]
    Idc2X1 = 16,

    [NativeName("STD_VIDEO_H265_ASPECT_RATIO_IDC_EXTENDED_SAR")]
    [SupportedApiProfile("vulkan")]
    IdcExtendedSar = 255,
}
