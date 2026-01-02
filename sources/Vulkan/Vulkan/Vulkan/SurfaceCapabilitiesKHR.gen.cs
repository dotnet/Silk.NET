// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public partial struct SurfaceCapabilitiesKHR
{
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    public uint MinImageCount;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    public uint MaxImageCount;

    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    public Extent2D CurrentExtent;

    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    public Extent2D MinImageExtent;

    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    public Extent2D MaxImageExtent;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    public uint MaxImageArrayLayers;

    [NativeTypeName("VkSurfaceTransformFlagsKHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    public SurfaceTransformFlagsKHR SupportedTransforms;

    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    public SurfaceTransformFlagsKHR CurrentTransform;

    [NativeTypeName("VkCompositeAlphaFlagsKHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    public CompositeAlphaFlagsKHR SupportedCompositeAlpha;

    [NativeTypeName("VkImageUsageFlags")]
    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    public ImageUsageFlags SupportedUsageFlags;
}
