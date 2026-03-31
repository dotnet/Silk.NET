// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoH264DisableDeblockingFilterIdc")]
[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum StdVideoH264DisableDeblockingFilterIdc : uint
{
    [NativeName("STD_VIDEO_H264_DISABLE_DEBLOCKING_FILTER_IDC_DISABLED")]
    [SupportedApiProfile("vulkan")]
    StdVideoH264DisableDeblockingFilterIdcDisabled = 0,

    [NativeName("STD_VIDEO_H264_DISABLE_DEBLOCKING_FILTER_IDC_ENABLED")]
    [SupportedApiProfile("vulkan")]
    StdVideoH264DisableDeblockingFilterIdcEnabled = 1,

    [NativeName("STD_VIDEO_H264_DISABLE_DEBLOCKING_FILTER_IDC_PARTIAL")]
    [SupportedApiProfile("vulkan")]
    StdVideoH264DisableDeblockingFilterIdcPartial = 2,

    [NativeName("STD_VIDEO_H264_DISABLE_DEBLOCKING_FILTER_IDC_INVALID")]
    [SupportedApiProfile("vulkan")]
    StdVideoH264DisableDeblockingFilterIdcInvalid = 0x7FFFFFFF,

    [NativeName("STD_VIDEO_H264_DISABLE_DEBLOCKING_FILTER_IDC_MAX_ENUM")]
    [SupportedApiProfile("vulkan")]
    StdVideoH264DisableDeblockingFilterIdcMaxEnum = 0x7FFFFFFF,
}
