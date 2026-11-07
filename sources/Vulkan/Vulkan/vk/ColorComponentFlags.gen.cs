// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkColorComponentFlags")]
[Flags]
public enum ColorComponentFlags : uint
{
    None = 0x0,

    [NativeName("VK_COLOR_COMPONENT_R_BIT")]
    RBit = 0x1,

    [NativeName("VK_COLOR_COMPONENT_G_BIT")]
    GBit = 0x2,

    [NativeName("VK_COLOR_COMPONENT_B_BIT")]
    BBit = 0x4,

    [NativeName("VK_COLOR_COMPONENT_A_BIT")]
    ABit = 0x8,
}
