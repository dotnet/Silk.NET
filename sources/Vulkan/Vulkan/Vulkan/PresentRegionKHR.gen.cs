// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct PresentRegionKHR
{
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_incremental_present"],
        ImpliesSets = ["VK_KHR_swapchain"]
    )]
    public uint RectangleCount;

    [NativeTypeName("const VkRectLayerKHR *")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_incremental_present"],
        ImpliesSets = ["VK_KHR_swapchain"]
    )]
    public RectLayerKHR* PRectangles;
}
