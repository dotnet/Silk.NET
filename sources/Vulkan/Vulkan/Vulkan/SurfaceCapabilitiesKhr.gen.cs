// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "KHR", 0)]
[NativeName("VkSurfaceCapabilitiesKHR")]
[SupportedApiProfile("vulkan")]
public partial struct SurfaceCapabilitiesKhr
{
    [NativeName("minImageCount")]
    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    public uint MinImageCount;

    [NativeName("maxImageCount")]
    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    public uint MaxImageCount;

    [NativeName("currentExtent")]
    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    public Extent2D CurrentExtent;

    [NativeName("minImageExtent")]
    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    public Extent2D MinImageExtent;

    [NativeName("maxImageExtent")]
    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    public Extent2D MaxImageExtent;

    [NativeName("maxImageArrayLayers")]
    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    public uint MaxImageArrayLayers;

    [NativeName("supportedTransforms")]
    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    public SurfaceTransformFlagsKhr SupportedTransforms;

    [NativeName("currentTransform")]
    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    public SurfaceTransformFlagsKhr CurrentTransform;

    [NativeName("supportedCompositeAlpha")]
    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    public CompositeAlphaFlagsKhr SupportedCompositeAlpha;

    [NativeName("supportedUsageFlags")]
    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    public ImageUsageFlags SupportedUsageFlags;
}
