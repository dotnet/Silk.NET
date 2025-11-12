// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct CheckpointData2NV
{
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_NV_device_diagnostic_checkpoints+VK_KHR_synchronization2",
            "VK_NV_device_diagnostic_checkpoints+VK_VERSION_1_3",
        ],
        ImpliesSets = [
            "VK_NV_device_diagnostic_checkpoints+VK_KHR_get_physical_device_properties2",
            "VK_NV_device_diagnostic_checkpoints+VK_VERSION_1_1",
        ]
    )]
    public StructureType SType;

    [SupportedApiProfile(
        "vulkan",
        [
            "VK_NV_device_diagnostic_checkpoints+VK_KHR_synchronization2",
            "VK_NV_device_diagnostic_checkpoints+VK_VERSION_1_3",
        ],
        ImpliesSets = [
            "VK_NV_device_diagnostic_checkpoints+VK_KHR_get_physical_device_properties2",
            "VK_NV_device_diagnostic_checkpoints+VK_VERSION_1_1",
        ]
    )]
    public void* PNext;

    [NativeTypeName("VkPipelineStageFlags2")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_NV_device_diagnostic_checkpoints+VK_KHR_synchronization2",
            "VK_NV_device_diagnostic_checkpoints+VK_VERSION_1_3",
        ],
        ImpliesSets = [
            "VK_NV_device_diagnostic_checkpoints+VK_KHR_get_physical_device_properties2",
            "VK_NV_device_diagnostic_checkpoints+VK_VERSION_1_1",
        ]
    )]
    public PipelineStageFlags2 Stage;

    [SupportedApiProfile(
        "vulkan",
        [
            "VK_NV_device_diagnostic_checkpoints+VK_KHR_synchronization2",
            "VK_NV_device_diagnostic_checkpoints+VK_VERSION_1_3",
        ],
        ImpliesSets = [
            "VK_NV_device_diagnostic_checkpoints+VK_KHR_get_physical_device_properties2",
            "VK_NV_device_diagnostic_checkpoints+VK_VERSION_1_1",
        ]
    )]
    public void* PCheckpointMarker;
}
