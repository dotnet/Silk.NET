// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "KhronosVendor", "NV")]
[NativeName("VkOutOfBandQueueTypeNV")]
[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum VkOutOfBandQueueTypeNV : uint
{
    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_OUT_OF_BAND_QUEUE_TYPE_RENDER_NV")]
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
    VkOutOfBandQueueTypeRender = 0,

    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_OUT_OF_BAND_QUEUE_TYPE_PRESENT_NV")]
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
    VkOutOfBandQueueTypePresent = 1,

    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_OUT_OF_BAND_QUEUE_TYPE_MAX_ENUM_NV")]
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
    VkOutOfBandQueueTypeMaxEnum = 0x7FFFFFFF,
}
