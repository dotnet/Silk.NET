// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public enum VkLatencyMarkerNV
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_low_latency2"],
        ImpliesSets = [
            "VK_NV_low_latency2+VK_KHR_timeline_semaphore",
            "VK_NV_low_latency2+VK_VERSION_1_2",
        ]
    )]
    VK_LATENCY_MARKER_SIMULATION_START_NV = 0,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_low_latency2"],
        ImpliesSets = [
            "VK_NV_low_latency2+VK_KHR_timeline_semaphore",
            "VK_NV_low_latency2+VK_VERSION_1_2",
        ]
    )]
    VK_LATENCY_MARKER_SIMULATION_END_NV = 1,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_low_latency2"],
        ImpliesSets = [
            "VK_NV_low_latency2+VK_KHR_timeline_semaphore",
            "VK_NV_low_latency2+VK_VERSION_1_2",
        ]
    )]
    VK_LATENCY_MARKER_RENDERSUBMIT_START_NV = 2,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_low_latency2"],
        ImpliesSets = [
            "VK_NV_low_latency2+VK_KHR_timeline_semaphore",
            "VK_NV_low_latency2+VK_VERSION_1_2",
        ]
    )]
    VK_LATENCY_MARKER_RENDERSUBMIT_END_NV = 3,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_low_latency2"],
        ImpliesSets = [
            "VK_NV_low_latency2+VK_KHR_timeline_semaphore",
            "VK_NV_low_latency2+VK_VERSION_1_2",
        ]
    )]
    VK_LATENCY_MARKER_PRESENT_START_NV = 4,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_low_latency2"],
        ImpliesSets = [
            "VK_NV_low_latency2+VK_KHR_timeline_semaphore",
            "VK_NV_low_latency2+VK_VERSION_1_2",
        ]
    )]
    VK_LATENCY_MARKER_PRESENT_END_NV = 5,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_low_latency2"],
        ImpliesSets = [
            "VK_NV_low_latency2+VK_KHR_timeline_semaphore",
            "VK_NV_low_latency2+VK_VERSION_1_2",
        ]
    )]
    VK_LATENCY_MARKER_INPUT_SAMPLE_NV = 6,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_low_latency2"],
        ImpliesSets = [
            "VK_NV_low_latency2+VK_KHR_timeline_semaphore",
            "VK_NV_low_latency2+VK_VERSION_1_2",
        ]
    )]
    VK_LATENCY_MARKER_TRIGGER_FLASH_NV = 7,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_low_latency2"],
        ImpliesSets = [
            "VK_NV_low_latency2+VK_KHR_timeline_semaphore",
            "VK_NV_low_latency2+VK_VERSION_1_2",
        ]
    )]
    VK_LATENCY_MARKER_OUT_OF_BAND_RENDERSUBMIT_START_NV = 8,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_low_latency2"],
        ImpliesSets = [
            "VK_NV_low_latency2+VK_KHR_timeline_semaphore",
            "VK_NV_low_latency2+VK_VERSION_1_2",
        ]
    )]
    VK_LATENCY_MARKER_OUT_OF_BAND_RENDERSUBMIT_END_NV = 9,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_low_latency2"],
        ImpliesSets = [
            "VK_NV_low_latency2+VK_KHR_timeline_semaphore",
            "VK_NV_low_latency2+VK_VERSION_1_2",
        ]
    )]
    VK_LATENCY_MARKER_OUT_OF_BAND_PRESENT_START_NV = 10,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_low_latency2"],
        ImpliesSets = [
            "VK_NV_low_latency2+VK_KHR_timeline_semaphore",
            "VK_NV_low_latency2+VK_VERSION_1_2",
        ]
    )]
    VK_LATENCY_MARKER_OUT_OF_BAND_PRESENT_END_NV = 11,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_low_latency2"],
        ImpliesSets = [
            "VK_NV_low_latency2+VK_KHR_timeline_semaphore",
            "VK_NV_low_latency2+VK_VERSION_1_2",
        ]
    )]
    VK_LATENCY_MARKER_MAX_ENUM_NV = 0x7FFFFFFF,
}
