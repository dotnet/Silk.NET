// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkViewportCoordinateSwizzleNV")]
[SupportedApiProfile("vulkan")]
public enum ViewportCoordinateSwizzleNV : uint
{
    [NativeName("VK_VIEWPORT_COORDINATE_SWIZZLE_POSITIVE_X_NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_viewport_swizzle"])]
    PositiveXNV = 0,

    [NativeName("VK_VIEWPORT_COORDINATE_SWIZZLE_NEGATIVE_X_NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_viewport_swizzle"])]
    NegativeXNV = 1,

    [NativeName("VK_VIEWPORT_COORDINATE_SWIZZLE_POSITIVE_Y_NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_viewport_swizzle"])]
    PositiveYNV = 2,

    [NativeName("VK_VIEWPORT_COORDINATE_SWIZZLE_NEGATIVE_Y_NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_viewport_swizzle"])]
    NegativeYNV = 3,

    [NativeName("VK_VIEWPORT_COORDINATE_SWIZZLE_POSITIVE_Z_NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_viewport_swizzle"])]
    PositiveZNV = 4,

    [NativeName("VK_VIEWPORT_COORDINATE_SWIZZLE_NEGATIVE_Z_NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_viewport_swizzle"])]
    NegativeZNV = 5,

    [NativeName("VK_VIEWPORT_COORDINATE_SWIZZLE_POSITIVE_W_NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_viewport_swizzle"])]
    PositiveWNV = 6,

    [NativeName("VK_VIEWPORT_COORDINATE_SWIZZLE_NEGATIVE_W_NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_viewport_swizzle"])]
    NegativeWNV = 7,
}
