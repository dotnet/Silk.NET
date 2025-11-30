// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDescriptorSetLayoutCreateFlagBits")]
[Flags]
[SupportedApiProfile("vulkan")]
public enum DescriptorSetLayoutCreateFlags : uint
{
    None = 0x0,

    [NativeName("VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.2"
    )]
    UpdateAfterBindPoolBit = 0x2,

    [NativeName("VK_DESCRIPTOR_SET_LAYOUT_CREATE_PUSH_DESCRIPTOR_BIT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_COMPUTE_VERSION_1_4", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_4"],
        MinVersion = "1.4"
    )]
    PushDescriptorBit = 0x1,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DESCRIPTOR_SET_LAYOUT_CREATE_DESCRIPTOR_BUFFER_BIT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_descriptor_buffer"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_KHR_buffer_device_address+VK_EXT_descriptor_indexing+VK_KHR_get_physical_device_properties2",
            "VK_KHR_synchronization2+VK_KHR_buffer_device_address+VK_EXT_descriptor_indexing+VK_VERSION_1_1",
            "VK_KHR_synchronization2+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    DescriptorBufferBitext = 0x10,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DESCRIPTOR_SET_LAYOUT_CREATE_EMBEDDED_IMMUTABLE_SAMPLERS_BIT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_descriptor_buffer"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_KHR_buffer_device_address+VK_EXT_descriptor_indexing+VK_KHR_get_physical_device_properties2",
            "VK_KHR_synchronization2+VK_KHR_buffer_device_address+VK_EXT_descriptor_indexing+VK_VERSION_1_1",
            "VK_KHR_synchronization2+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    EmbeddedImmutableSamplersBitext = 0x20,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_DESCRIPTOR_SET_LAYOUT_CREATE_INDIRECT_BINDABLE_BIT_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_generated_commands_compute"],
        ImpliesSets = ["VK_NV_device_generated_commands"]
    )]
    IndirectBindableBitnv = 0x80,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DESCRIPTOR_SET_LAYOUT_CREATE_HOST_ONLY_POOL_BIT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_mutable_descriptor_type"],
        ImpliesSets = [
            "VK_EXT_mutable_descriptor_type+VK_KHR_maintenance3",
            "VK_EXT_mutable_descriptor_type+VK_VERSION_1_1",
        ]
    )]
    HostOnlyPoolBitext = 0x4,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_DESCRIPTOR_SET_LAYOUT_CREATE_PER_STAGE_BIT_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_per_stage_descriptor_set"],
        ImpliesSets = [
            "VK_NV_per_stage_descriptor_set+VK_KHR_maintenance6",
            "VK_NV_per_stage_descriptor_set+VK_VERSION_1_4",
        ]
    )]
    PerStageBitnv = 0x40,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_DESCRIPTOR_SET_LAYOUT_CREATE_PUSH_DESCRIPTOR_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_push_descriptor"],
        ImpliesSets = [
            "VK_KHR_push_descriptor+VK_KHR_get_physical_device_properties2",
            "VK_KHR_push_descriptor+VK_VERSION_1_1",
        ]
    )]
    PushDescriptorBitkhr = PushDescriptorBit,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_descriptor_indexing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_maintenance3",
            "VK_VERSION_1_1",
        ]
    )]
    UpdateAfterBindPoolBitext = UpdateAfterBindPoolBit,

    [NameAffix("Suffix", "VALVE", 0)]
    [NativeName("VK_DESCRIPTOR_SET_LAYOUT_CREATE_HOST_ONLY_POOL_BIT_VALVE")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_VALVE_mutable_descriptor_type"],
        ImpliesSets = ["VK_KHR_maintenance3"]
    )]
    HostOnlyPoolBitvalve = HostOnlyPoolBitext,
}
