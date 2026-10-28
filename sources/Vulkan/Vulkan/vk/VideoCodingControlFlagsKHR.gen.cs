// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkVideoCodingControlFlagsKHR")]
[Flags]
public enum VideoCodingControlFlagsKHR : uint
{
    None = 0x0,

    [NativeName("VK_VIDEO_CODING_CONTROL_RESET_BIT_KHR")]
    ResetBit = 0x1,

    [NativeName("VK_VIDEO_CODING_CONTROL_ENCODE_RATE_CONTROL_BIT_KHR")]
    EncodeRateControlBit = 0x2,

    [NativeName("VK_VIDEO_CODING_CONTROL_ENCODE_QUALITY_LEVEL_BIT_KHR")]
    EncodeQualityLevelBit = 0x4,
}
