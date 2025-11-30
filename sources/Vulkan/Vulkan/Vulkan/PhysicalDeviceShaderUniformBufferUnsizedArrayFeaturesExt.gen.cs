// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "EXT", 0)]
[NativeName("VkPhysicalDeviceShaderUniformBufferUnsizedArrayFeaturesEXT")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct PhysicalDeviceShaderUniformBufferUnsizedArrayFeaturesExt
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_uniform_buffer_unsized_array"],
        ImpliesSets = [
            "VK_EXT_shader_uniform_buffer_unsized_array+VK_KHR_get_physical_device_properties2",
            "VK_EXT_shader_uniform_buffer_unsized_array+VK_VERSION_1_1",
        ]
    )]
    public StructureType SType;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_uniform_buffer_unsized_array"],
        ImpliesSets = [
            "VK_EXT_shader_uniform_buffer_unsized_array+VK_KHR_get_physical_device_properties2",
            "VK_EXT_shader_uniform_buffer_unsized_array+VK_VERSION_1_1",
        ]
    )]
    public void* PNext;

    [NativeName("shaderUniformBufferUnsizedArray")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_uniform_buffer_unsized_array"],
        ImpliesSets = [
            "VK_EXT_shader_uniform_buffer_unsized_array+VK_KHR_get_physical_device_properties2",
            "VK_EXT_shader_uniform_buffer_unsized_array+VK_VERSION_1_1",
        ]
    )]
    public uint ShaderUniformBufferUnsizedArray;
}
