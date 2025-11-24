// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum LatencyMarkerNV
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_low_latency2"],
        ImpliesSets = [
            "VK_KHR_timeline_semaphore+VK_KHR_present_id",
            "VK_KHR_timeline_semaphore+VK_KHR_present_id2",
            "VK_VERSION_1_2+VK_KHR_present_id",
            "VK_VERSION_1_2+VK_KHR_present_id2",
        ]
    )]
    SimulationStartNV = 0,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_low_latency2"],
        ImpliesSets = [
            "VK_KHR_timeline_semaphore+VK_KHR_present_id",
            "VK_KHR_timeline_semaphore+VK_KHR_present_id2",
            "VK_VERSION_1_2+VK_KHR_present_id",
            "VK_VERSION_1_2+VK_KHR_present_id2",
        ]
    )]
    SimulationEndNV = 1,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_low_latency2"],
        ImpliesSets = [
            "VK_KHR_timeline_semaphore+VK_KHR_present_id",
            "VK_KHR_timeline_semaphore+VK_KHR_present_id2",
            "VK_VERSION_1_2+VK_KHR_present_id",
            "VK_VERSION_1_2+VK_KHR_present_id2",
        ]
    )]
    RendersubmitStartNV = 2,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_low_latency2"],
        ImpliesSets = [
            "VK_KHR_timeline_semaphore+VK_KHR_present_id",
            "VK_KHR_timeline_semaphore+VK_KHR_present_id2",
            "VK_VERSION_1_2+VK_KHR_present_id",
            "VK_VERSION_1_2+VK_KHR_present_id2",
        ]
    )]
    RendersubmitEndNV = 3,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_low_latency2"],
        ImpliesSets = [
            "VK_KHR_timeline_semaphore+VK_KHR_present_id",
            "VK_KHR_timeline_semaphore+VK_KHR_present_id2",
            "VK_VERSION_1_2+VK_KHR_present_id",
            "VK_VERSION_1_2+VK_KHR_present_id2",
        ]
    )]
    PresentStartNV = 4,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_low_latency2"],
        ImpliesSets = [
            "VK_KHR_timeline_semaphore+VK_KHR_present_id",
            "VK_KHR_timeline_semaphore+VK_KHR_present_id2",
            "VK_VERSION_1_2+VK_KHR_present_id",
            "VK_VERSION_1_2+VK_KHR_present_id2",
        ]
    )]
    PresentEndNV = 5,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_low_latency2"],
        ImpliesSets = [
            "VK_KHR_timeline_semaphore+VK_KHR_present_id",
            "VK_KHR_timeline_semaphore+VK_KHR_present_id2",
            "VK_VERSION_1_2+VK_KHR_present_id",
            "VK_VERSION_1_2+VK_KHR_present_id2",
        ]
    )]
    InputSampleNV = 6,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_low_latency2"],
        ImpliesSets = [
            "VK_KHR_timeline_semaphore+VK_KHR_present_id",
            "VK_KHR_timeline_semaphore+VK_KHR_present_id2",
            "VK_VERSION_1_2+VK_KHR_present_id",
            "VK_VERSION_1_2+VK_KHR_present_id2",
        ]
    )]
    TriggerFlashNV = 7,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_low_latency2"],
        ImpliesSets = [
            "VK_KHR_timeline_semaphore+VK_KHR_present_id",
            "VK_KHR_timeline_semaphore+VK_KHR_present_id2",
            "VK_VERSION_1_2+VK_KHR_present_id",
            "VK_VERSION_1_2+VK_KHR_present_id2",
        ]
    )]
    OutOfBandRendersubmitStartNV = 8,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_low_latency2"],
        ImpliesSets = [
            "VK_KHR_timeline_semaphore+VK_KHR_present_id",
            "VK_KHR_timeline_semaphore+VK_KHR_present_id2",
            "VK_VERSION_1_2+VK_KHR_present_id",
            "VK_VERSION_1_2+VK_KHR_present_id2",
        ]
    )]
    OutOfBandRendersubmitEndNV = 9,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_low_latency2"],
        ImpliesSets = [
            "VK_KHR_timeline_semaphore+VK_KHR_present_id",
            "VK_KHR_timeline_semaphore+VK_KHR_present_id2",
            "VK_VERSION_1_2+VK_KHR_present_id",
            "VK_VERSION_1_2+VK_KHR_present_id2",
        ]
    )]
    OutOfBandPresentStartNV = 10,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_low_latency2"],
        ImpliesSets = [
            "VK_KHR_timeline_semaphore+VK_KHR_present_id",
            "VK_KHR_timeline_semaphore+VK_KHR_present_id2",
            "VK_VERSION_1_2+VK_KHR_present_id",
            "VK_VERSION_1_2+VK_KHR_present_id2",
        ]
    )]
    OutOfBandPresentEndNV = 11,
}
