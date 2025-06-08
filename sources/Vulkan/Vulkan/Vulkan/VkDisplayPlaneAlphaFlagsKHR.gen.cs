// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public enum VkDisplayPlaneAlphaFlagsKHR
{
    [SupportedApiProfile("vulkan", ["VK_KHR_display"], ImpliesSets = ["VK_KHR_surface"])]
    VK_DISPLAY_PLANE_ALPHA_OPAQUE_BIT_KHR = 0x00000001,

    [SupportedApiProfile("vulkan", ["VK_KHR_display"], ImpliesSets = ["VK_KHR_surface"])]
    VK_DISPLAY_PLANE_ALPHA_GLOBAL_BIT_KHR = 0x00000002,

    [SupportedApiProfile("vulkan", ["VK_KHR_display"], ImpliesSets = ["VK_KHR_surface"])]
    VK_DISPLAY_PLANE_ALPHA_PER_PIXEL_BIT_KHR = 0x00000004,

    [SupportedApiProfile("vulkan", ["VK_KHR_display"], ImpliesSets = ["VK_KHR_surface"])]
    VK_DISPLAY_PLANE_ALPHA_PER_PIXEL_PREMULTIPLIED_BIT_KHR = 0x00000008,

    [SupportedApiProfile("vulkan", ["VK_KHR_display"], ImpliesSets = ["VK_KHR_surface"])]
    VK_DISPLAY_PLANE_ALPHA_FLAG_BITS_MAX_ENUM_KHR = 0x7FFFFFFF,
}
