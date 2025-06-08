// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VkPhysicalDeviceFragmentShaderInterlockFeaturesEXT
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_fragment_shader_interlock"],
        ImpliesSets = [
            "VK_EXT_fragment_shader_interlock+VK_KHR_get_physical_device_properties2",
            "VK_EXT_fragment_shader_interlock+VK_VERSION_1_1",
        ]
    )]
    public VkStructureType sType;

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_fragment_shader_interlock"],
        ImpliesSets = [
            "VK_EXT_fragment_shader_interlock+VK_KHR_get_physical_device_properties2",
            "VK_EXT_fragment_shader_interlock+VK_VERSION_1_1",
        ]
    )]
    public void* pNext;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_fragment_shader_interlock"],
        ImpliesSets = [
            "VK_EXT_fragment_shader_interlock+VK_KHR_get_physical_device_properties2",
            "VK_EXT_fragment_shader_interlock+VK_VERSION_1_1",
        ]
    )]
    public uint fragmentShaderSampleInterlock;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_fragment_shader_interlock"],
        ImpliesSets = [
            "VK_EXT_fragment_shader_interlock+VK_KHR_get_physical_device_properties2",
            "VK_EXT_fragment_shader_interlock+VK_VERSION_1_1",
        ]
    )]
    public uint fragmentShaderPixelInterlock;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_fragment_shader_interlock"],
        ImpliesSets = [
            "VK_EXT_fragment_shader_interlock+VK_KHR_get_physical_device_properties2",
            "VK_EXT_fragment_shader_interlock+VK_VERSION_1_1",
        ]
    )]
    public uint fragmentShaderShadingRateInterlock;
}
