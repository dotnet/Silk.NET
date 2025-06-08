// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public enum VkViewportCoordinateSwizzleNV
{
    [SupportedApiProfile("vulkan", ["VK_NV_viewport_swizzle"])]
    VK_VIEWPORT_COORDINATE_SWIZZLE_POSITIVE_X_NV = 0,

    [SupportedApiProfile("vulkan", ["VK_NV_viewport_swizzle"])]
    VK_VIEWPORT_COORDINATE_SWIZZLE_NEGATIVE_X_NV = 1,

    [SupportedApiProfile("vulkan", ["VK_NV_viewport_swizzle"])]
    VK_VIEWPORT_COORDINATE_SWIZZLE_POSITIVE_Y_NV = 2,

    [SupportedApiProfile("vulkan", ["VK_NV_viewport_swizzle"])]
    VK_VIEWPORT_COORDINATE_SWIZZLE_NEGATIVE_Y_NV = 3,

    [SupportedApiProfile("vulkan", ["VK_NV_viewport_swizzle"])]
    VK_VIEWPORT_COORDINATE_SWIZZLE_POSITIVE_Z_NV = 4,

    [SupportedApiProfile("vulkan", ["VK_NV_viewport_swizzle"])]
    VK_VIEWPORT_COORDINATE_SWIZZLE_NEGATIVE_Z_NV = 5,

    [SupportedApiProfile("vulkan", ["VK_NV_viewport_swizzle"])]
    VK_VIEWPORT_COORDINATE_SWIZZLE_POSITIVE_W_NV = 6,

    [SupportedApiProfile("vulkan", ["VK_NV_viewport_swizzle"])]
    VK_VIEWPORT_COORDINATE_SWIZZLE_NEGATIVE_W_NV = 7,

    [SupportedApiProfile("vulkan", ["VK_NV_viewport_swizzle"])]
    VK_VIEWPORT_COORDINATE_SWIZZLE_MAX_ENUM_NV = 0x7FFFFFFF,
}
