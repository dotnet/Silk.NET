// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPresentScalingFlagsKHR")]
[Flags]
public enum PresentScalingFlagsKHR : uint
{
    None = 0x0,

    [NativeName("VK_PRESENT_SCALING_ONE_TO_ONE_BIT_KHR")]
    OneToOneBit = 0x1,

    [NativeName("VK_PRESENT_SCALING_ASPECT_RATIO_STRETCH_BIT_KHR")]
    AspectRatioStretchBit = 0x2,

    [NativeName("VK_PRESENT_SCALING_STRETCH_BIT_KHR")]
    StretchBit = 0x4,

    [NativeName("VK_PRESENT_SCALING_ONE_TO_ONE_BIT_EXT")]
    OneToOneBitEXT = OneToOneBit,

    [NativeName("VK_PRESENT_SCALING_ASPECT_RATIO_STRETCH_BIT_EXT")]
    AspectRatioStretchBitEXT = AspectRatioStretchBit,

    [NativeName("VK_PRESENT_SCALING_STRETCH_BIT_EXT")]
    StretchBitEXT = StretchBit,
}
