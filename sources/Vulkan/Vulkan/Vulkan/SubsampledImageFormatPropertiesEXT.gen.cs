// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkSubsampledImageFormatPropertiesEXT")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct SubsampledImageFormatPropertiesEXT
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_descriptor_heap", "VK_EXT_fragment_density_map"],
        ImpliesSets = [
            "VK_KHR_extended_flags+VK_KHR_buffer_device_address",
            "VK_KHR_extended_flags+VK_VERSION_1_2",
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_4",
        ],
        RequireAll = true
    )]
    public StructureType SType = StructureType.SubsampledImageFormatPropertiesEXT;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_descriptor_heap", "VK_EXT_fragment_density_map"],
        ImpliesSets = [
            "VK_KHR_extended_flags+VK_KHR_buffer_device_address",
            "VK_KHR_extended_flags+VK_VERSION_1_2",
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_4",
        ],
        RequireAll = true
    )]
    public void* PNext;

    [NativeName("subsampledImageDescriptorCount")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_descriptor_heap", "VK_EXT_fragment_density_map"],
        ImpliesSets = [
            "VK_KHR_extended_flags+VK_KHR_buffer_device_address",
            "VK_KHR_extended_flags+VK_VERSION_1_2",
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_4",
        ],
        RequireAll = true
    )]
    public uint SubsampledImageDescriptorCount;

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_descriptor_heap", "VK_EXT_fragment_density_map"],
        ImpliesSets = [
            "VK_KHR_extended_flags+VK_KHR_buffer_device_address",
            "VK_KHR_extended_flags+VK_VERSION_1_2",
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_4",
        ],
        RequireAll = true
    )]
    public SubsampledImageFormatPropertiesEXT() { }
}
