// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoH265ProfileIdc")]
[SupportedApiProfile("vulkan")]
public enum StdVideoH265ProfileIdc : uint
{
    [NativeName("STD_VIDEO_H265_PROFILE_IDC_MAIN")]
    [SupportedApiProfile("vulkan")]
    Main = 1,

    [NativeName("STD_VIDEO_H265_PROFILE_IDC_MAIN_10")]
    [SupportedApiProfile("vulkan")]
    Main10 = 2,

    [NativeName("STD_VIDEO_H265_PROFILE_IDC_MAIN_STILL_PICTURE")]
    [SupportedApiProfile("vulkan")]
    MainStillPicture = 3,

    [NativeName("STD_VIDEO_H265_PROFILE_IDC_FORMAT_RANGE_EXTENSIONS")]
    [SupportedApiProfile("vulkan")]
    FormatRangeExtensions = 4,

    [NativeName("STD_VIDEO_H265_PROFILE_IDC_SCC_EXTENSIONS")]
    [SupportedApiProfile("vulkan")]
    SccExtensions = 9,
}
