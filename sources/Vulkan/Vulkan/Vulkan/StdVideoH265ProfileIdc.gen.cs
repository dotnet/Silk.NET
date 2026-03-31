// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoH265ProfileIdc")]
[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum StdVideoH265ProfileIdc : uint
{
    [NativeName("STD_VIDEO_H265_PROFILE_IDC_MAIN")]
    [SupportedApiProfile("vulkan")]
    StdVideoH265ProfileIdcMain = 1,

    [NativeName("STD_VIDEO_H265_PROFILE_IDC_MAIN_10")]
    [SupportedApiProfile("vulkan")]
    StdVideoH265ProfileIdcMain10 = 2,

    [NativeName("STD_VIDEO_H265_PROFILE_IDC_MAIN_STILL_PICTURE")]
    [SupportedApiProfile("vulkan")]
    StdVideoH265ProfileIdcMainStillPicture = 3,

    [NativeName("STD_VIDEO_H265_PROFILE_IDC_FORMAT_RANGE_EXTENSIONS")]
    [SupportedApiProfile("vulkan")]
    StdVideoH265ProfileIdcFormatRangeExtensions = 4,

    [NativeName("STD_VIDEO_H265_PROFILE_IDC_SCC_EXTENSIONS")]
    [SupportedApiProfile("vulkan")]
    StdVideoH265ProfileIdcSccExtensions = 9,

    [NativeName("STD_VIDEO_H265_PROFILE_IDC_INVALID")]
    [SupportedApiProfile("vulkan")]
    StdVideoH265ProfileIdcInvalid = 0x7FFFFFFF,

    [NativeName("STD_VIDEO_H265_PROFILE_IDC_MAX_ENUM")]
    [SupportedApiProfile("vulkan")]
    StdVideoH265ProfileIdcMaxEnum = 0x7FFFFFFF,
}
