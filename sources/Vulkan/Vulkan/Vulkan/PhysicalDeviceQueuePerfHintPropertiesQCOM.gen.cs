// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceQueuePerfHintPropertiesQCOM")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct PhysicalDeviceQueuePerfHintPropertiesQCOM
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
    public StructureType SType = StructureType.PhysicalDeviceQueuePerfHintPropertiesQCOM;

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

    [NativeName("supportedQueues")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_queue_perf_hint"],
        ImpliesSets = [
            "VK_QCOM_queue_perf_hint+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_queue_perf_hint+VK_VERSION_1_1",
        ]
    )]
    public QueueFlags SupportedQueues;

    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_queue_perf_hint"],
        ImpliesSets = [
            "VK_QCOM_queue_perf_hint+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_queue_perf_hint+VK_VERSION_1_1",
        ]
    )]
    public PhysicalDeviceQueuePerfHintPropertiesQCOM() { }
}
