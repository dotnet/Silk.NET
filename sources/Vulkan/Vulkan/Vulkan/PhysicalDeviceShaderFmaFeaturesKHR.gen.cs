// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameSuffix("KHR", 0)]
[NativeName("VkPhysicalDeviceShaderFmaFeaturesKHR")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct PhysicalDeviceShaderFmaFeaturesKHR
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_fma"],
        ImpliesSets = [
            "VK_KHR_shader_fma+VK_KHR_get_physical_device_properties2",
            "VK_KHR_shader_fma+VK_VERSION_1_1",
        ]
    )]
    public StructureType SType;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_fma"],
        ImpliesSets = [
            "VK_KHR_shader_fma+VK_KHR_get_physical_device_properties2",
            "VK_KHR_shader_fma+VK_VERSION_1_1",
        ]
    )]
    public void* PNext;

    [NativeName("shaderFmaFloat16")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_fma"],
        ImpliesSets = [
            "VK_KHR_shader_fma+VK_KHR_get_physical_device_properties2",
            "VK_KHR_shader_fma+VK_VERSION_1_1",
        ]
    )]
    public uint ShaderFmaFloat16;

    [NativeName("shaderFmaFloat32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_fma"],
        ImpliesSets = [
            "VK_KHR_shader_fma+VK_KHR_get_physical_device_properties2",
            "VK_KHR_shader_fma+VK_VERSION_1_1",
        ]
    )]
    public uint ShaderFmaFloat32;

    [NativeName("shaderFmaFloat64")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_fma"],
        ImpliesSets = [
            "VK_KHR_shader_fma+VK_KHR_get_physical_device_properties2",
            "VK_KHR_shader_fma+VK_VERSION_1_1",
        ]
    )]
    public uint ShaderFmaFloat64;
}
