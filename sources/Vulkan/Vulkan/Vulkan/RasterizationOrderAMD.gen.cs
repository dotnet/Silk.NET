// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameSuffix("AMD", 0)]
[NativeName("VkRasterizationOrderAMD")]
[SupportedApiProfile("vulkan")]
public enum RasterizationOrderAMD : uint
{
    [NameSuffix("AMD", 0)]
    [NativeName("VK_RASTERIZATION_ORDER_STRICT_AMD")]
    [SupportedApiProfile("vulkan", ["VK_AMD_rasterization_order"])]
    StrictAMD = 0,

    [NameSuffix("AMD", 0)]
    [NativeName("VK_RASTERIZATION_ORDER_RELAXED_AMD")]
    [SupportedApiProfile("vulkan", ["VK_AMD_rasterization_order"])]
    RelaxedAMD = 1,
}
