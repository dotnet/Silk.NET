// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkVideoEncodeFeedback2CapabilitiesKHR")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct VideoEncodeFeedback2CapabilitiesKHR
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_feedback2"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    public StructureType SType = StructureType.VideoEncodeFeedback2CapabilitiesKHR;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_feedback2"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    public void* PNext;

    [NativeName("maxPerPartitionFeedbackEntries")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_feedback2"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    public uint MaxPerPartitionFeedbackEntries;

    [NativeName("supportedPerPartitionEncodeFeedbackFlags")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_feedback2"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    public VideoEncodePerPartitionFeedbackFlagsKHR SupportedPerPartitionEncodeFeedbackFlags;

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_feedback2"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    public VideoEncodeFeedback2CapabilitiesKHR() { }
}
