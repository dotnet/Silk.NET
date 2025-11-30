// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "VALVE", 0)]
[NativeName("VkDescriptorSetBindingReferenceVALVE")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct DescriptorSetBindingReferenceValve
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_VALVE_descriptor_set_host_mapping"],
        ImpliesSets = [
            "VK_VALVE_descriptor_set_host_mapping+VK_KHR_get_physical_device_properties2",
            "VK_VALVE_descriptor_set_host_mapping+VK_VERSION_1_1",
        ]
    )]
    public StructureType SType;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_VALVE_descriptor_set_host_mapping"],
        ImpliesSets = [
            "VK_VALVE_descriptor_set_host_mapping+VK_KHR_get_physical_device_properties2",
            "VK_VALVE_descriptor_set_host_mapping+VK_VERSION_1_1",
        ]
    )]
    public void* PNext;

    [NativeName("descriptorSetLayout")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_VALVE_descriptor_set_host_mapping"],
        ImpliesSets = [
            "VK_VALVE_descriptor_set_host_mapping+VK_KHR_get_physical_device_properties2",
            "VK_VALVE_descriptor_set_host_mapping+VK_VERSION_1_1",
        ]
    )]
    public DescriptorSetLayoutHandle DescriptorSetLayout;

    [NativeName("binding")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_VALVE_descriptor_set_host_mapping"],
        ImpliesSets = [
            "VK_VALVE_descriptor_set_host_mapping+VK_KHR_get_physical_device_properties2",
            "VK_VALVE_descriptor_set_host_mapping+VK_VERSION_1_1",
        ]
    )]
    public uint Binding;
}
