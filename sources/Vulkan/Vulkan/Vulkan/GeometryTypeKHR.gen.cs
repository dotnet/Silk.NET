// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "KHR", 0)]
[NativeName("VkGeometryTypeKHR")]
[SupportedApiProfile("vulkan")]
public enum GeometryTypeKHR : uint
{
    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_GEOMETRY_TYPE_TRIANGLES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_acceleration_structure"],
        ImpliesSets = [
            "VK_KHR_deferred_host_operations+VK_VERSION_1_1+VK_EXT_descriptor_indexing+VK_KHR_buffer_device_address",
            "VK_KHR_deferred_host_operations+VK_VERSION_1_2",
        ]
    )]
    Triangleskhr = 0,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_GEOMETRY_TYPE_AABBS_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_acceleration_structure"],
        ImpliesSets = [
            "VK_KHR_deferred_host_operations+VK_VERSION_1_1+VK_EXT_descriptor_indexing+VK_KHR_buffer_device_address",
            "VK_KHR_deferred_host_operations+VK_VERSION_1_2",
        ]
    )]
    Aabbskhr = 1,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_GEOMETRY_TYPE_INSTANCES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_acceleration_structure"],
        ImpliesSets = [
            "VK_KHR_deferred_host_operations+VK_VERSION_1_1+VK_EXT_descriptor_indexing+VK_KHR_buffer_device_address",
            "VK_KHR_deferred_host_operations+VK_VERSION_1_2",
        ]
    )]
    Instanceskhr = 2,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_GEOMETRY_TYPE_SPHERES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing_linear_swept_spheres"],
        ImpliesSets = ["VK_KHR_ray_tracing_pipeline"]
    )]
    Spheresnv = 1000429004,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_GEOMETRY_TYPE_LINEAR_SWEPT_SPHERES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing_linear_swept_spheres"],
        ImpliesSets = ["VK_KHR_ray_tracing_pipeline"]
    )]
    LinearSweptSpheresnv = 1000429005,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_GEOMETRY_TYPE_TRIANGLES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_get_memory_requirements2",
            "VK_VERSION_1_1",
        ]
    )]
    Trianglesnv = Triangleskhr,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_GEOMETRY_TYPE_AABBS_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_get_memory_requirements2",
            "VK_VERSION_1_1",
        ]
    )]
    Aabbsnv = Aabbskhr,
}
