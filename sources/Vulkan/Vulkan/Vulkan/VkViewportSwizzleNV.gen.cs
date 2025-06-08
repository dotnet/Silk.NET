// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public partial struct VkViewportSwizzleNV
{
    [SupportedApiProfile("vulkan", ["VK_NV_viewport_swizzle"])]
    public VkViewportCoordinateSwizzleNV x;

    [SupportedApiProfile("vulkan", ["VK_NV_viewport_swizzle"])]
    public VkViewportCoordinateSwizzleNV y;

    [SupportedApiProfile("vulkan", ["VK_NV_viewport_swizzle"])]
    public VkViewportCoordinateSwizzleNV z;

    [SupportedApiProfile("vulkan", ["VK_NV_viewport_swizzle"])]
    public VkViewportCoordinateSwizzleNV w;
}
