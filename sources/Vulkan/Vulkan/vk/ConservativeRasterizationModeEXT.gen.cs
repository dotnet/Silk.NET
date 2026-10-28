// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkConservativeRasterizationModeEXT")]
public enum ConservativeRasterizationModeEXT : uint
{
    [NativeName("VK_CONSERVATIVE_RASTERIZATION_MODE_DISABLED_EXT")]
    Disabled = 0,

    [NativeName("VK_CONSERVATIVE_RASTERIZATION_MODE_OVERESTIMATE_EXT")]
    Overestimate = 1,

    [NativeName("VK_CONSERVATIVE_RASTERIZATION_MODE_UNDERESTIMATE_EXT")]
    Underestimate = 2,
}
