// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VkPhysicalDeviceColorWriteEnableFeaturesEXT
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_color_write_enable"],
        ImpliesSets = [
            "VK_EXT_color_write_enable+VK_KHR_get_physical_device_properties2",
            "VK_EXT_color_write_enable+VK_VERSION_1_1",
        ]
    )]
    public VkStructureType sType;

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_color_write_enable"],
        ImpliesSets = [
            "VK_EXT_color_write_enable+VK_KHR_get_physical_device_properties2",
            "VK_EXT_color_write_enable+VK_VERSION_1_1",
        ]
    )]
    public void* pNext;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_color_write_enable"],
        ImpliesSets = [
            "VK_EXT_color_write_enable+VK_KHR_get_physical_device_properties2",
            "VK_EXT_color_write_enable+VK_VERSION_1_1",
        ]
    )]
    public uint colorWriteEnable;
}
