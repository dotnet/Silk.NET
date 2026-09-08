// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPerfHintTypeQCOM")]
[SupportedApiProfile("vulkan")]
public enum PerfHintTypeQCOM : uint
{
    [NativeName("VK_PERF_HINT_TYPE_DEFAULT_QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_queue_perf_hint"],
        ImpliesSets = [
            "VK_QCOM_queue_perf_hint+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_queue_perf_hint+VK_VERSION_1_1",
        ]
    )]
    Default = 0,

    [NativeName("VK_PERF_HINT_TYPE_FREQUENCY_MIN_QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_queue_perf_hint"],
        ImpliesSets = [
            "VK_QCOM_queue_perf_hint+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_queue_perf_hint+VK_VERSION_1_1",
        ]
    )]
    FrequencyMin = 1,

    [NativeName("VK_PERF_HINT_TYPE_FREQUENCY_MAX_QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_queue_perf_hint"],
        ImpliesSets = [
            "VK_QCOM_queue_perf_hint+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_queue_perf_hint+VK_VERSION_1_1",
        ]
    )]
    FrequencyMax = 2,

    [NativeName("VK_PERF_HINT_TYPE_FREQUENCY_SCALED_QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_queue_perf_hint"],
        ImpliesSets = [
            "VK_QCOM_queue_perf_hint+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_queue_perf_hint+VK_VERSION_1_1",
        ]
    )]
    FrequencyScaled = 3,
}
