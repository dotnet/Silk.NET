// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "NV", 0)]
[NativeName("VkViewportCoordinateSwizzleNV")]
[SupportedApiProfile("vulkan")]
public enum ViewportCoordinateSwizzleNv : uint
{
    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_VIEWPORT_COORDINATE_SWIZZLE_POSITIVE_X_NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_viewport_swizzle"])]
    PositiveXnv = 0,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_VIEWPORT_COORDINATE_SWIZZLE_NEGATIVE_X_NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_viewport_swizzle"])]
    NegativeXnv = 1,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_VIEWPORT_COORDINATE_SWIZZLE_POSITIVE_Y_NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_viewport_swizzle"])]
    PositiveYnv = 2,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_VIEWPORT_COORDINATE_SWIZZLE_NEGATIVE_Y_NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_viewport_swizzle"])]
    NegativeYnv = 3,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_VIEWPORT_COORDINATE_SWIZZLE_POSITIVE_Z_NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_viewport_swizzle"])]
    PositiveZnv = 4,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_VIEWPORT_COORDINATE_SWIZZLE_NEGATIVE_Z_NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_viewport_swizzle"])]
    NegativeZnv = 5,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_VIEWPORT_COORDINATE_SWIZZLE_POSITIVE_W_NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_viewport_swizzle"])]
    PositiveWnv = 6,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_VIEWPORT_COORDINATE_SWIZZLE_NEGATIVE_W_NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_viewport_swizzle"])]
    NegativeWnv = 7,
}
