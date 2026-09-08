// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDataGraphProcessingEngineCreateInfoARM")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct DataGraphProcessingEngineCreateInfoARM
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph"],
        ImpliesSets = [
            "VK_VERSION_1_3+VK_KHR_deferred_host_operations+VK_KHR_extended_flags",
            "VK_VERSION_1_3+VK_KHR_deferred_host_operations+VK_KHR_maintenance5",
        ]
    )]
    public StructureType SType = StructureType.DataGraphProcessingEngineCreateInfoARM;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph"],
        ImpliesSets = [
            "VK_VERSION_1_3+VK_KHR_deferred_host_operations+VK_KHR_extended_flags",
            "VK_VERSION_1_3+VK_KHR_deferred_host_operations+VK_KHR_maintenance5",
        ]
    )]
    public void* PNext;

    [NativeName("processingEngineCount")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph"],
        ImpliesSets = [
            "VK_VERSION_1_3+VK_KHR_deferred_host_operations+VK_KHR_extended_flags",
            "VK_VERSION_1_3+VK_KHR_deferred_host_operations+VK_KHR_maintenance5",
        ]
    )]
    public uint ProcessingEngineCount;

    [NativeName("pProcessingEngines")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph"],
        ImpliesSets = [
            "VK_VERSION_1_3+VK_KHR_deferred_host_operations+VK_KHR_extended_flags",
            "VK_VERSION_1_3+VK_KHR_deferred_host_operations+VK_KHR_maintenance5",
        ]
    )]
    public PhysicalDeviceDataGraphProcessingEngineARM* PProcessingEngines;

    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph"],
        ImpliesSets = [
            "VK_VERSION_1_3+VK_KHR_deferred_host_operations+VK_KHR_extended_flags",
            "VK_VERSION_1_3+VK_KHR_deferred_host_operations+VK_KHR_maintenance5",
        ]
    )]
    public DataGraphProcessingEngineCreateInfoARM() { }
}
