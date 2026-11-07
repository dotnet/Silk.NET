// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkResolveModeFlags")]
[Flags]
public enum ResolveModeFlags : uint
{
    [NativeName("VK_RESOLVE_MODE_NONE")]
    None = 0x0,

    [NativeName("VK_RESOLVE_MODE_SAMPLE_ZERO_BIT")]
    SampleZeroBit = 0x1,

    [NativeName("VK_RESOLVE_MODE_AVERAGE_BIT")]
    AverageBit = 0x2,

    [NativeName("VK_RESOLVE_MODE_MIN_BIT")]
    MinBit = 0x4,

    [NativeName("VK_RESOLVE_MODE_MAX_BIT")]
    MaxBit = 0x8,

    [NativeName("VK_RESOLVE_MODE_EXTERNAL_FORMAT_DOWNSAMPLE_BIT_ANDROID")]
    ExternalFormatDownsampleBitANDROID = 0x10,

    [NativeName("VK_RESOLVE_MODE_CUSTOM_BIT_EXT")]
    CustomBitEXT = 0x20,

    [NativeName("VK_RESOLVE_MODE_NONE_KHR")]
    NoneKHR = None,

    [NativeName("VK_RESOLVE_MODE_SAMPLE_ZERO_BIT_KHR")]
    SampleZeroBitKHR = SampleZeroBit,

    [NativeName("VK_RESOLVE_MODE_AVERAGE_BIT_KHR")]
    AverageBitKHR = AverageBit,

    [NativeName("VK_RESOLVE_MODE_MIN_BIT_KHR")]
    MinBitKHR = MinBit,

    [NativeName("VK_RESOLVE_MODE_MAX_BIT_KHR")]
    MaxBitKHR = MaxBit,
}
