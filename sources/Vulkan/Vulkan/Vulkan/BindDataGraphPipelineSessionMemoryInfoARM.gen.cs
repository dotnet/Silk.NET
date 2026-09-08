// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkBindDataGraphPipelineSessionMemoryInfoARM")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct BindDataGraphPipelineSessionMemoryInfoARM
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
    public StructureType SType = StructureType.BindDataGraphPipelineSessionMemoryInfoARM;

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

    [NativeName("session")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph"],
        ImpliesSets = [
            "VK_VERSION_1_3+VK_KHR_deferred_host_operations+VK_KHR_extended_flags",
            "VK_VERSION_1_3+VK_KHR_deferred_host_operations+VK_KHR_maintenance5",
        ]
    )]
    public DataGraphPipelineSessionHandleARM Session;

    [NativeName("bindPoint")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph"],
        ImpliesSets = [
            "VK_VERSION_1_3+VK_KHR_deferred_host_operations+VK_KHR_extended_flags",
            "VK_VERSION_1_3+VK_KHR_deferred_host_operations+VK_KHR_maintenance5",
        ]
    )]
    public DataGraphPipelineSessionBindPointARM BindPoint;

    [NativeName("objectIndex")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph"],
        ImpliesSets = [
            "VK_VERSION_1_3+VK_KHR_deferred_host_operations+VK_KHR_extended_flags",
            "VK_VERSION_1_3+VK_KHR_deferred_host_operations+VK_KHR_maintenance5",
        ]
    )]
    public uint ObjectIndex;

    [NativeName("memory")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph"],
        ImpliesSets = [
            "VK_VERSION_1_3+VK_KHR_deferred_host_operations+VK_KHR_extended_flags",
            "VK_VERSION_1_3+VK_KHR_deferred_host_operations+VK_KHR_maintenance5",
        ]
    )]
    public DeviceMemoryHandle Memory;

    [NativeName("memoryOffset")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph"],
        ImpliesSets = [
            "VK_VERSION_1_3+VK_KHR_deferred_host_operations+VK_KHR_extended_flags",
            "VK_VERSION_1_3+VK_KHR_deferred_host_operations+VK_KHR_maintenance5",
        ]
    )]
    public ulong MemoryOffset;

    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph"],
        ImpliesSets = [
            "VK_VERSION_1_3+VK_KHR_deferred_host_operations+VK_KHR_extended_flags",
            "VK_VERSION_1_3+VK_KHR_deferred_host_operations+VK_KHR_maintenance5",
        ]
    )]
    public BindDataGraphPipelineSessionMemoryInfoARM() { }
}
