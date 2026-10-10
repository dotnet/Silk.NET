// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDescriptorMappingSourceEXT")]
[SupportedApiProfile("vulkan")]
public enum DescriptorMappingSourceEXT : uint
{
    [NativeName("VK_DESCRIPTOR_MAPPING_SOURCE_HEAP_WITH_CONSTANT_OFFSET_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_descriptor_heap"],
        ImpliesSets = [
            "VK_KHR_extended_flags+VK_KHR_buffer_device_address",
            "VK_KHR_extended_flags+VK_VERSION_1_2",
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_4",
        ]
    )]
    HeapWithConstantOffset = 0,

    [NativeName("VK_DESCRIPTOR_MAPPING_SOURCE_HEAP_WITH_PUSH_INDEX_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_descriptor_heap"],
        ImpliesSets = [
            "VK_KHR_extended_flags+VK_KHR_buffer_device_address",
            "VK_KHR_extended_flags+VK_VERSION_1_2",
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_4",
        ]
    )]
    HeapWithPushIndex = 1,

    [NativeName("VK_DESCRIPTOR_MAPPING_SOURCE_HEAP_WITH_INDIRECT_INDEX_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_descriptor_heap"],
        ImpliesSets = [
            "VK_KHR_extended_flags+VK_KHR_buffer_device_address",
            "VK_KHR_extended_flags+VK_VERSION_1_2",
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_4",
        ]
    )]
    HeapWithIndirectIndex = 2,

    [NativeName("VK_DESCRIPTOR_MAPPING_SOURCE_HEAP_WITH_INDIRECT_INDEX_ARRAY_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_descriptor_heap"],
        ImpliesSets = [
            "VK_KHR_extended_flags+VK_KHR_buffer_device_address",
            "VK_KHR_extended_flags+VK_VERSION_1_2",
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_4",
        ]
    )]
    HeapWithIndirectIndexArray = 3,

    [NativeName("VK_DESCRIPTOR_MAPPING_SOURCE_RESOURCE_HEAP_DATA_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_descriptor_heap"],
        ImpliesSets = [
            "VK_KHR_extended_flags+VK_KHR_buffer_device_address",
            "VK_KHR_extended_flags+VK_VERSION_1_2",
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_4",
        ]
    )]
    ResourceHeapData = 4,

    [NativeName("VK_DESCRIPTOR_MAPPING_SOURCE_PUSH_DATA_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_descriptor_heap"],
        ImpliesSets = [
            "VK_KHR_extended_flags+VK_KHR_buffer_device_address",
            "VK_KHR_extended_flags+VK_VERSION_1_2",
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_4",
        ]
    )]
    PushData = 5,

    [NativeName("VK_DESCRIPTOR_MAPPING_SOURCE_PUSH_ADDRESS_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_descriptor_heap"],
        ImpliesSets = [
            "VK_KHR_extended_flags+VK_KHR_buffer_device_address",
            "VK_KHR_extended_flags+VK_VERSION_1_2",
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_4",
        ]
    )]
    PushAddress = 6,

    [NativeName("VK_DESCRIPTOR_MAPPING_SOURCE_INDIRECT_ADDRESS_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_descriptor_heap"],
        ImpliesSets = [
            "VK_KHR_extended_flags+VK_KHR_buffer_device_address",
            "VK_KHR_extended_flags+VK_VERSION_1_2",
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_4",
        ]
    )]
    IndirectAddress = 7,

    [NativeName("VK_DESCRIPTOR_MAPPING_SOURCE_HEAP_WITH_SHADER_RECORD_INDEX_EXT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_EXT_descriptor_heap+VK_KHR_ray_tracing_pipeline",
            "VK_EXT_descriptor_heap+VK_NV_ray_tracing",
        ],
        ImpliesSets = [
            "VK_KHR_extended_flags+VK_KHR_buffer_device_address",
            "VK_KHR_extended_flags+VK_VERSION_1_2",
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_4",
        ]
    )]
    HeapWithShaderRecordIndex = 8,

    [NativeName("VK_DESCRIPTOR_MAPPING_SOURCE_SHADER_RECORD_DATA_EXT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_EXT_descriptor_heap+VK_KHR_ray_tracing_pipeline",
            "VK_EXT_descriptor_heap+VK_NV_ray_tracing",
        ],
        ImpliesSets = [
            "VK_KHR_extended_flags+VK_KHR_buffer_device_address",
            "VK_KHR_extended_flags+VK_VERSION_1_2",
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_4",
        ]
    )]
    ShaderRecordData = 9,

    [NativeName("VK_DESCRIPTOR_MAPPING_SOURCE_SHADER_RECORD_ADDRESS_EXT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_EXT_descriptor_heap+VK_KHR_ray_tracing_pipeline",
            "VK_EXT_descriptor_heap+VK_NV_ray_tracing",
        ],
        ImpliesSets = [
            "VK_KHR_extended_flags+VK_KHR_buffer_device_address",
            "VK_KHR_extended_flags+VK_VERSION_1_2",
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_4",
        ]
    )]
    ShaderRecordAddress = 10,
}
