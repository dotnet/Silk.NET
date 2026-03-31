// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkSurfaceCapabilitiesKHR")]
[NameAffix("Suffix", "KhronosVendor", "KHR")]
[SupportedApiProfile("vulkan")]
public partial struct VkSurfaceCapabilitiesKHR
{
    [NativeName("minImageCount")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    public uint MinImageCount;

    [NativeName("maxImageCount")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    public uint MaxImageCount;

    [NativeName("currentExtent")]
    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    public VkExtent2D CurrentExtent;

    [NativeName("minImageExtent")]
    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    public VkExtent2D MinImageExtent;

    [NativeName("maxImageExtent")]
    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    public VkExtent2D MaxImageExtent;

    [NativeName("maxImageArrayLayers")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    public uint MaxImageArrayLayers;

    [NativeName("supportedTransforms")]
    [NativeTypeName("VkSurfaceTransformFlagsKHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    public VkSurfaceTransformFlagsKHR SupportedTransforms;

    [NativeName("currentTransform")]
    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    public VkSurfaceTransformFlagsKHR CurrentTransform;

    [NativeName("supportedCompositeAlpha")]
    [NativeTypeName("VkCompositeAlphaFlagsKHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    public VkCompositeAlphaFlagsKHR SupportedCompositeAlpha;

    [NativeName("supportedUsageFlags")]
    [NativeTypeName("VkImageUsageFlags")]
    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    public VkImageUsageFlags SupportedUsageFlags;
}
