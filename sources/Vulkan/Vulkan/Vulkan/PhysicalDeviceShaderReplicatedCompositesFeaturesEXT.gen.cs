// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2026 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceShaderReplicatedCompositesFeaturesEXT")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct PhysicalDeviceShaderReplicatedCompositesFeaturesEXT
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_replicated_composites"],
        ImpliesSets = [
            "VK_EXT_shader_replicated_composites+VK_KHR_get_physical_device_properties2",
            "VK_EXT_shader_replicated_composites+VK_VERSION_1_1",
        ]
    )]
    public StructureType SType = StructureType.PhysicalDeviceShaderReplicatedCompositesFeaturesEXT;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_replicated_composites"],
        ImpliesSets = [
            "VK_EXT_shader_replicated_composites+VK_KHR_get_physical_device_properties2",
            "VK_EXT_shader_replicated_composites+VK_VERSION_1_1",
        ]
    )]
    public void* PNext;

    [NativeName("shaderReplicatedComposites")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_replicated_composites"],
        ImpliesSets = [
            "VK_EXT_shader_replicated_composites+VK_KHR_get_physical_device_properties2",
            "VK_EXT_shader_replicated_composites+VK_VERSION_1_1",
        ]
    )]
    public MaybeBool<uint> ShaderReplicatedComposites;

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_replicated_composites"],
        ImpliesSets = [
            "VK_EXT_shader_replicated_composites+VK_KHR_get_physical_device_properties2",
            "VK_EXT_shader_replicated_composites+VK_VERSION_1_1",
        ]
    )]
    public PhysicalDeviceShaderReplicatedCompositesFeaturesEXT() { }
}
