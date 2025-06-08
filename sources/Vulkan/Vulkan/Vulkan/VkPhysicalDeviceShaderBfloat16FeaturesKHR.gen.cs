// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VkPhysicalDeviceShaderBfloat16FeaturesKHR
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_bfloat16"],
        ImpliesSets = [
            "VK_KHR_shader_bfloat16+VK_KHR_get_physical_device_properties2",
            "VK_KHR_shader_bfloat16+VK_VERSION_1_1",
        ]
    )]
    public VkStructureType sType;

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_bfloat16"],
        ImpliesSets = [
            "VK_KHR_shader_bfloat16+VK_KHR_get_physical_device_properties2",
            "VK_KHR_shader_bfloat16+VK_VERSION_1_1",
        ]
    )]
    public void* pNext;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_bfloat16"],
        ImpliesSets = [
            "VK_KHR_shader_bfloat16+VK_KHR_get_physical_device_properties2",
            "VK_KHR_shader_bfloat16+VK_VERSION_1_1",
        ]
    )]
    public uint shaderBFloat16Type;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_bfloat16"],
        ImpliesSets = [
            "VK_KHR_shader_bfloat16+VK_KHR_get_physical_device_properties2",
            "VK_KHR_shader_bfloat16+VK_VERSION_1_1",
        ]
    )]
    public uint shaderBFloat16DotProduct;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_bfloat16"],
        ImpliesSets = [
            "VK_KHR_shader_bfloat16+VK_KHR_get_physical_device_properties2",
            "VK_KHR_shader_bfloat16+VK_VERSION_1_1",
        ]
    )]
    public uint shaderBFloat16CooperativeMatrix;
}
