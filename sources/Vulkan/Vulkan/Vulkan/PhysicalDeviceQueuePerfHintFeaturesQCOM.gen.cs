// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceQueuePerfHintFeaturesQCOM")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct PhysicalDeviceQueuePerfHintFeaturesQCOM
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_queue_perf_hint"],
        ImpliesSets = [
            "VK_QCOM_queue_perf_hint+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_queue_perf_hint+VK_VERSION_1_1",
        ]
    )]
    public StructureType SType = StructureType.PhysicalDeviceQueuePerfHintFeaturesQCOM;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_queue_perf_hint"],
        ImpliesSets = [
            "VK_QCOM_queue_perf_hint+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_queue_perf_hint+VK_VERSION_1_1",
        ]
    )]
    public void* PNext;

    [NativeName("queuePerfHint")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_queue_perf_hint"],
        ImpliesSets = [
            "VK_QCOM_queue_perf_hint+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_queue_perf_hint+VK_VERSION_1_1",
        ]
    )]
    public MaybeBool<uint> QueuePerfHint;

    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_queue_perf_hint"],
        ImpliesSets = [
            "VK_QCOM_queue_perf_hint+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_queue_perf_hint+VK_VERSION_1_1",
        ]
    )]
    public PhysicalDeviceQueuePerfHintFeaturesQCOM() { }
}
