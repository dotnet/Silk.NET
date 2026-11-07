// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceShaderConstantDataFeaturesKHR")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct PhysicalDeviceShaderConstantDataFeaturesKHR
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_constant_data"],
        ImpliesSets = [
            "VK_KHR_shader_constant_data+VK_KHR_get_physical_device_properties2",
            "VK_KHR_shader_constant_data+VK_VERSION_1_1",
        ]
    )]
    public StructureType SType = StructureType.PhysicalDeviceShaderConstantDataFeaturesKHR;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_constant_data"],
        ImpliesSets = [
            "VK_KHR_shader_constant_data+VK_KHR_get_physical_device_properties2",
            "VK_KHR_shader_constant_data+VK_VERSION_1_1",
        ]
    )]
    public void* PNext;

    [NativeName("shaderConstantData")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_constant_data"],
        ImpliesSets = [
            "VK_KHR_shader_constant_data+VK_KHR_get_physical_device_properties2",
            "VK_KHR_shader_constant_data+VK_VERSION_1_1",
        ]
    )]
    public MaybeBool<uint> ShaderConstantData;

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_constant_data"],
        ImpliesSets = [
            "VK_KHR_shader_constant_data+VK_KHR_get_physical_device_properties2",
            "VK_KHR_shader_constant_data+VK_VERSION_1_1",
        ]
    )]
    public PhysicalDeviceShaderConstantDataFeaturesKHR() { }
}
