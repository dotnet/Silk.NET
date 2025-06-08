// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VkDisplayPropertiesKHR
{
    [NativeTypeName("VkDisplayKHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_display"], ImpliesSets = ["VK_KHR_surface"])]
    public VkDisplayKHR_T* display;

    [NativeTypeName("const char *")]
    [SupportedApiProfile("vulkan", ["VK_KHR_display"], ImpliesSets = ["VK_KHR_surface"])]
    public sbyte* displayName;

    [SupportedApiProfile("vulkan", ["VK_KHR_display"], ImpliesSets = ["VK_KHR_surface"])]
    public VkExtent2D physicalDimensions;

    [SupportedApiProfile("vulkan", ["VK_KHR_display"], ImpliesSets = ["VK_KHR_surface"])]
    public VkExtent2D physicalResolution;

    [NativeTypeName("VkSurfaceTransformFlagsKHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_display"], ImpliesSets = ["VK_KHR_surface"])]
    public uint supportedTransforms;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_KHR_display"], ImpliesSets = ["VK_KHR_surface"])]
    public uint planeReorderPossible;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_KHR_display"], ImpliesSets = ["VK_KHR_surface"])]
    public uint persistentContent;
}
