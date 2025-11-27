// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameSuffix("KHR", 0)]
[NativeName("VkDisplayPlaneAlphaFlagBitsKHR")]
[Flags]
[SupportedApiProfile("vulkan")]
public enum DisplayPlaneAlphaFlagsKHR : uint
{
    None = 0x0,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_DISPLAY_PLANE_ALPHA_OPAQUE_BIT_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_display"], ImpliesSets = ["VK_KHR_surface"])]
    OpaqueBitKHR = 0x1,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_DISPLAY_PLANE_ALPHA_GLOBAL_BIT_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_display"], ImpliesSets = ["VK_KHR_surface"])]
    GlobalBitKHR = 0x2,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_DISPLAY_PLANE_ALPHA_PER_PIXEL_BIT_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_display"], ImpliesSets = ["VK_KHR_surface"])]
    PerPixelBitKHR = 0x4,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_DISPLAY_PLANE_ALPHA_PER_PIXEL_PREMULTIPLIED_BIT_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_display"], ImpliesSets = ["VK_KHR_surface"])]
    PerPixelPremultipliedBitKHR = 0x8,
}
