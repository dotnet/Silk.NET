// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDisplayPlaneCapabilitiesKHR")]
[NameAffix("Suffix", "KhronosVendor", "KHR")]
[SupportedApiProfile("vulkan")]
public partial struct VkDisplayPlaneCapabilitiesKHR
{
    [NativeName("supportedAlpha")]
    [NativeTypeName("VkDisplayPlaneAlphaFlagsKHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_display"], ImpliesSets = ["VK_KHR_surface"])]
    public VkDisplayPlaneAlphaFlagsKHR SupportedAlpha;

    [NativeName("minSrcPosition")]
    [SupportedApiProfile("vulkan", ["VK_KHR_display"], ImpliesSets = ["VK_KHR_surface"])]
    public VkOffset2D MinSrcPosition;

    [NativeName("maxSrcPosition")]
    [SupportedApiProfile("vulkan", ["VK_KHR_display"], ImpliesSets = ["VK_KHR_surface"])]
    public VkOffset2D MaxSrcPosition;

    [NativeName("minSrcExtent")]
    [SupportedApiProfile("vulkan", ["VK_KHR_display"], ImpliesSets = ["VK_KHR_surface"])]
    public VkExtent2D MinSrcExtent;

    [NativeName("maxSrcExtent")]
    [SupportedApiProfile("vulkan", ["VK_KHR_display"], ImpliesSets = ["VK_KHR_surface"])]
    public VkExtent2D MaxSrcExtent;

    [NativeName("minDstPosition")]
    [SupportedApiProfile("vulkan", ["VK_KHR_display"], ImpliesSets = ["VK_KHR_surface"])]
    public VkOffset2D MinDstPosition;

    [NativeName("maxDstPosition")]
    [SupportedApiProfile("vulkan", ["VK_KHR_display"], ImpliesSets = ["VK_KHR_surface"])]
    public VkOffset2D MaxDstPosition;

    [NativeName("minDstExtent")]
    [SupportedApiProfile("vulkan", ["VK_KHR_display"], ImpliesSets = ["VK_KHR_surface"])]
    public VkExtent2D MinDstExtent;

    [NativeName("maxDstExtent")]
    [SupportedApiProfile("vulkan", ["VK_KHR_display"], ImpliesSets = ["VK_KHR_surface"])]
    public VkExtent2D MaxDstExtent;
}
