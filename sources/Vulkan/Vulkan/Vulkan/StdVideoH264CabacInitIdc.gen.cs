// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoH264CabacInitIdc")]
[SupportedApiProfile("vulkan")]
public enum StdVideoH264CabacInitIdc : uint
{
    [NativeName("STD_VIDEO_H264_CABAC_INIT_IDC_0")]
    [SupportedApiProfile("vulkan")]
    Idc0 = 0,

    [NativeName("STD_VIDEO_H264_CABAC_INIT_IDC_1")]
    [SupportedApiProfile("vulkan")]
    Idc1 = 1,

    [NativeName("STD_VIDEO_H264_CABAC_INIT_IDC_2")]
    [SupportedApiProfile("vulkan")]
    Idc2 = 2,
}
