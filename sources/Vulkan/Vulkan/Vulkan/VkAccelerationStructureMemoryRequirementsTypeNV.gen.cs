// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "KhronosVendor", "NV")]
[NativeName("VkAccelerationStructureMemoryRequirementsTypeNV")]
[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum VkAccelerationStructureMemoryRequirementsTypeNV : uint
{
    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_TYPE_OBJECT_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_get_memory_requirements2",
            "VK_VERSION_1_1",
        ]
    )]
    VkAccelerationStructureMemoryRequirementsTypeObject = 0,

    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_TYPE_BUILD_SCRATCH_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_get_memory_requirements2",
            "VK_VERSION_1_1",
        ]
    )]
    VkAccelerationStructureMemoryRequirementsTypeBuildScratch = 1,

    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_TYPE_UPDATE_SCRATCH_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_get_memory_requirements2",
            "VK_VERSION_1_1",
        ]
    )]
    VkAccelerationStructureMemoryRequirementsTypeUpdateScratch = 2,

    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_TYPE_MAX_ENUM_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_get_memory_requirements2",
            "VK_VERSION_1_1",
        ]
    )]
    VkAccelerationStructureMemoryRequirementsTypeMaxEnum = 0x7FFFFFFF,
}
