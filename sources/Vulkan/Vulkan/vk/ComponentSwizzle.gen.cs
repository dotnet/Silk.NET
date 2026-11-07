// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkComponentSwizzle")]
public enum ComponentSwizzle : uint
{
    [NativeName("VK_COMPONENT_SWIZZLE_IDENTITY")]
    Identity = 0,

    [NativeName("VK_COMPONENT_SWIZZLE_ZERO")]
    Zero = 1,

    [NativeName("VK_COMPONENT_SWIZZLE_ONE")]
    One = 2,

    [NativeName("VK_COMPONENT_SWIZZLE_R")]
    R = 3,

    [NativeName("VK_COMPONENT_SWIZZLE_G")]
    G = 4,

    [NativeName("VK_COMPONENT_SWIZZLE_B")]
    B = 5,

    [NativeName("VK_COMPONENT_SWIZZLE_A")]
    A = 6,
}
