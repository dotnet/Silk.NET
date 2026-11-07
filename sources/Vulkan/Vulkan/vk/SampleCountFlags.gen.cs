// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkSampleCountFlags")]
[Flags]
public enum SampleCountFlags : uint
{
    None = 0x0,

    [NativeName("VK_SAMPLE_COUNT_1_BIT")]
    Count1Bit = 0x1,

    [NativeName("VK_SAMPLE_COUNT_2_BIT")]
    Count2Bit = 0x2,

    [NativeName("VK_SAMPLE_COUNT_4_BIT")]
    Count4Bit = 0x4,

    [NativeName("VK_SAMPLE_COUNT_8_BIT")]
    Count8Bit = 0x8,

    [NativeName("VK_SAMPLE_COUNT_16_BIT")]
    Count16Bit = 0x10,

    [NativeName("VK_SAMPLE_COUNT_32_BIT")]
    Count32Bit = 0x20,

    [NativeName("VK_SAMPLE_COUNT_64_BIT")]
    Count64Bit = 0x40,
}
