// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public enum VkSurfaceTransformFlagsKHR
{
    [SupportedApiProfile("vulkan", ["VK_KHR_display"], ImpliesSets = ["VK_KHR_surface"])]
    VK_SURFACE_TRANSFORM_IDENTITY_BIT_KHR = 0x00000001,

    [SupportedApiProfile("vulkan", ["VK_KHR_display"], ImpliesSets = ["VK_KHR_surface"])]
    VK_SURFACE_TRANSFORM_ROTATE_90_BIT_KHR = 0x00000002,

    [SupportedApiProfile("vulkan", ["VK_KHR_display"], ImpliesSets = ["VK_KHR_surface"])]
    VK_SURFACE_TRANSFORM_ROTATE_180_BIT_KHR = 0x00000004,

    [SupportedApiProfile("vulkan", ["VK_KHR_display"], ImpliesSets = ["VK_KHR_surface"])]
    VK_SURFACE_TRANSFORM_ROTATE_270_BIT_KHR = 0x00000008,

    [SupportedApiProfile("vulkan", ["VK_KHR_display"], ImpliesSets = ["VK_KHR_surface"])]
    VK_SURFACE_TRANSFORM_HORIZONTAL_MIRROR_BIT_KHR = 0x00000010,

    [SupportedApiProfile("vulkan", ["VK_KHR_display"], ImpliesSets = ["VK_KHR_surface"])]
    VK_SURFACE_TRANSFORM_HORIZONTAL_MIRROR_ROTATE_90_BIT_KHR = 0x00000020,

    [SupportedApiProfile("vulkan", ["VK_KHR_display"], ImpliesSets = ["VK_KHR_surface"])]
    VK_SURFACE_TRANSFORM_HORIZONTAL_MIRROR_ROTATE_180_BIT_KHR = 0x00000040,

    [SupportedApiProfile("vulkan", ["VK_KHR_display"], ImpliesSets = ["VK_KHR_surface"])]
    VK_SURFACE_TRANSFORM_HORIZONTAL_MIRROR_ROTATE_270_BIT_KHR = 0x00000080,

    [SupportedApiProfile("vulkan", ["VK_KHR_display"], ImpliesSets = ["VK_KHR_surface"])]
    VK_SURFACE_TRANSFORM_INHERIT_BIT_KHR = 0x00000100,

    [SupportedApiProfile("vulkan", ["VK_KHR_display"], ImpliesSets = ["VK_KHR_surface"])]
    VK_SURFACE_TRANSFORM_FLAG_BITS_MAX_ENUM_KHR = 0x7FFFFFFF,
}
