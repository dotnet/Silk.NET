// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkCullModeFlags")]
[Flags]
public enum CullModeFlags : uint
{
    [NativeName("VK_CULL_MODE_NONE")]
    None = 0x0,

    [NativeName("VK_CULL_MODE_FRONT_BIT")]
    FrontBit = 0x1,

    [NativeName("VK_CULL_MODE_BACK_BIT")]
    BackBit = 0x2,

    [NativeName("VK_CULL_MODE_FRONT_AND_BACK")]
    FrontAndBack = 0x3,
}
