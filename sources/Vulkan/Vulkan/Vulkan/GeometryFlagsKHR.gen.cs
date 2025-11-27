// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameSuffix("KHR", 0)]
[NativeName("VkGeometryFlagBitsKHR")]
[Flags]
[SupportedApiProfile("vulkan")]
public enum GeometryFlagsKHR : uint
{
    None = 0x0,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_GEOMETRY_OPAQUE_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_acceleration_structure"],
        ImpliesSets = [
            "VK_KHR_deferred_host_operations+VK_VERSION_1_1+VK_EXT_descriptor_indexing+VK_KHR_buffer_device_address",
            "VK_KHR_deferred_host_operations+VK_VERSION_1_2",
        ]
    )]
    OpaqueBitKHR = 0x1,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_GEOMETRY_NO_DUPLICATE_ANY_HIT_INVOCATION_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_acceleration_structure"],
        ImpliesSets = [
            "VK_KHR_deferred_host_operations+VK_VERSION_1_1+VK_EXT_descriptor_indexing+VK_KHR_buffer_device_address",
            "VK_KHR_deferred_host_operations+VK_VERSION_1_2",
        ]
    )]
    NoDuplicateAnyHitInvocationBitKHR = 0x2,

    [NameSuffix("NV", 0)]
    [NativeName("VK_GEOMETRY_OPAQUE_BIT_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_get_memory_requirements2",
            "VK_VERSION_1_1",
        ]
    )]
    OpaqueBitNV = OpaqueBitKHR,

    [NameSuffix("NV", 0)]
    [NativeName("VK_GEOMETRY_NO_DUPLICATE_ANY_HIT_INVOCATION_BIT_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_get_memory_requirements2",
            "VK_VERSION_1_1",
        ]
    )]
    NoDuplicateAnyHitInvocationBitNV = NoDuplicateAnyHitInvocationBitKHR,
}
