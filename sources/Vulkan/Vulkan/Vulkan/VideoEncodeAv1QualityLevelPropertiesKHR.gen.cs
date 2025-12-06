// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkVideoEncodeAV1QualityLevelPropertiesKHR")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct VideoEncodeAv1QualityLevelPropertiesKHR
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    public StructureType SType;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    public void* PNext;

    [NativeName("preferredRateControlFlags")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    public VideoEncodeAv1RateControlFlagsKHR PreferredRateControlFlags;

    [NativeName("preferredGopFrameCount")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    public uint PreferredGopFrameCount;

    [NativeName("preferredKeyFramePeriod")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    public uint PreferredKeyFramePeriod;

    [NativeName("preferredConsecutiveBipredictiveFrameCount")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    public uint PreferredConsecutiveBipredictiveFrameCount;

    [NativeName("preferredTemporalLayerCount")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    public uint PreferredTemporalLayerCount;

    [NativeName("preferredConstantQIndex")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    public VideoEncodeAv1QIndexKHR PreferredConstantQIndex;

    [NativeName("preferredMaxSingleReferenceCount")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    public uint PreferredMaxSingleReferenceCount;

    [NativeName("preferredSingleReferenceNameMask")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    public uint PreferredSingleReferenceNameMask;

    [NativeName("preferredMaxUnidirectionalCompoundReferenceCount")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    public uint PreferredMaxUnidirectionalCompoundReferenceCount;

    [NativeName("preferredMaxUnidirectionalCompoundGroup1ReferenceCount")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    public uint PreferredMaxUnidirectionalCompoundGroup1ReferenceCount;

    [NativeName("preferredUnidirectionalCompoundReferenceNameMask")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    public uint PreferredUnidirectionalCompoundReferenceNameMask;

    [NativeName("preferredMaxBidirectionalCompoundReferenceCount")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    public uint PreferredMaxBidirectionalCompoundReferenceCount;

    [NativeName("preferredMaxBidirectionalCompoundGroup1ReferenceCount")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    public uint PreferredMaxBidirectionalCompoundGroup1ReferenceCount;

    [NativeName("preferredMaxBidirectionalCompoundGroup2ReferenceCount")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    public uint PreferredMaxBidirectionalCompoundGroup2ReferenceCount;

    [NativeName("preferredBidirectionalCompoundReferenceNameMask")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    public uint PreferredBidirectionalCompoundReferenceNameMask;
}
