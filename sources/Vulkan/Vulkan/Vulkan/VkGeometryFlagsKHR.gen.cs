// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "KhronosVendor", "KHR")]
[NativeName("VkGeometryFlagBitsKHR")]
[NativeTypeName("unsigned int")]
[Flags]
[SupportedApiProfile("vulkan")]
public enum VkGeometryFlagsKHR : uint
{
    [NameAffix("Suffix", "KhronosImpliedVendor", "KHR")]
    [NativeName("VK_GEOMETRY_OPAQUE_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_acceleration_structure"],
        ImpliesSets = [
            "VK_KHR_deferred_host_operations+VK_VERSION_1_1+VK_EXT_descriptor_indexing+VK_KHR_buffer_device_address",
            "VK_KHR_deferred_host_operations+VK_VERSION_1_2",
        ]
    )]
    VkGeometryOpaqueBit = 0x00000001,

    [NameAffix("Suffix", "KhronosImpliedVendor", "KHR")]
    [NativeName("VK_GEOMETRY_NO_DUPLICATE_ANY_HIT_INVOCATION_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_acceleration_structure"],
        ImpliesSets = [
            "VK_KHR_deferred_host_operations+VK_VERSION_1_1+VK_EXT_descriptor_indexing+VK_KHR_buffer_device_address",
            "VK_KHR_deferred_host_operations+VK_VERSION_1_2",
        ]
    )]
    VkGeometryNoDuplicateAnyHitInvocationBit = 0x00000002,

    [NativeName("VK_GEOMETRY_OPAQUE_BIT_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_get_memory_requirements2",
            "VK_VERSION_1_1",
        ]
    )]
    VkGeometryOpaqueBitNV = VkGeometryOpaqueBit,

    [NativeName("VK_GEOMETRY_NO_DUPLICATE_ANY_HIT_INVOCATION_BIT_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_get_memory_requirements2",
            "VK_VERSION_1_1",
        ]
    )]
    VkGeometryNoDuplicateAnyHitInvocationBitNV = VkGeometryNoDuplicateAnyHitInvocationBit,

    [NameAffix("Suffix", "KhronosImpliedVendor", "KHR")]
    [NativeName("VK_GEOMETRY_FLAG_BITS_MAX_ENUM_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_acceleration_structure"],
        ImpliesSets = [
            "VK_KHR_deferred_host_operations+VK_VERSION_1_1+VK_EXT_descriptor_indexing+VK_KHR_buffer_device_address",
            "VK_KHR_deferred_host_operations+VK_VERSION_1_2",
        ]
    )]
    VkGeometryFlagBitsMaxEnum = 0x7FFFFFFF,
}
