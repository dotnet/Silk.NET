// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPresentGravityFlagsKHR")]
[Flags]
public enum PresentGravityFlagsKHR : uint
{
    None = 0x0,

    [NativeName("VK_PRESENT_GRAVITY_MIN_BIT_KHR")]
    MinBit = 0x1,

    [NativeName("VK_PRESENT_GRAVITY_MAX_BIT_KHR")]
    MaxBit = 0x2,

    [NativeName("VK_PRESENT_GRAVITY_CENTERED_BIT_KHR")]
    CenteredBit = 0x4,

    [NativeName("VK_PRESENT_GRAVITY_MIN_BIT_EXT")]
    MinBitEXT = MinBit,

    [NativeName("VK_PRESENT_GRAVITY_MAX_BIT_EXT")]
    MaxBitEXT = MaxBit,

    [NativeName("VK_PRESENT_GRAVITY_CENTERED_BIT_EXT")]
    CenteredBitEXT = CenteredBit,
}
