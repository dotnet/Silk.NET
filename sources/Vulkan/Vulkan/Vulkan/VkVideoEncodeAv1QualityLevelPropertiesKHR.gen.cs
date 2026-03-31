// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkVideoEncodeAV1QualityLevelPropertiesKHR")]
[NameAffix("Suffix", "KhronosVendor", "KHR")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct VkVideoEncodeAv1QualityLevelPropertiesKHR
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    public VkStructureType SType;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    public void* PNext;

    [NativeName("preferredRateControlFlags")]
    [NativeTypeName("VkVideoEncodeAV1RateControlFlagsKHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    public VkVideoEncodeAv1RateControlFlagsKHR PreferredRateControlFlags;

    [NativeName("preferredGopFrameCount")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    public uint PreferredGopFrameCount;

    [NativeName("preferredKeyFramePeriod")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    public uint PreferredKeyFramePeriod;

    [NativeName("preferredConsecutiveBipredictiveFrameCount")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    public uint PreferredConsecutiveBipredictiveFrameCount;

    [NativeName("preferredTemporalLayerCount")]
    [NativeTypeName("uint32_t")]
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
    public VkVideoEncodeAv1QIndexKHR PreferredConstantQIndex;

    [NativeName("preferredMaxSingleReferenceCount")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    public uint PreferredMaxSingleReferenceCount;

    [NativeName("preferredSingleReferenceNameMask")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    public uint PreferredSingleReferenceNameMask;

    [NativeName("preferredMaxUnidirectionalCompoundReferenceCount")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    public uint PreferredMaxUnidirectionalCompoundReferenceCount;

    [NativeName("preferredMaxUnidirectionalCompoundGroup1ReferenceCount")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    public uint PreferredMaxUnidirectionalCompoundGroup1ReferenceCount;

    [NativeName("preferredUnidirectionalCompoundReferenceNameMask")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    public uint PreferredUnidirectionalCompoundReferenceNameMask;

    [NativeName("preferredMaxBidirectionalCompoundReferenceCount")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    public uint PreferredMaxBidirectionalCompoundReferenceCount;

    [NativeName("preferredMaxBidirectionalCompoundGroup1ReferenceCount")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    public uint PreferredMaxBidirectionalCompoundGroup1ReferenceCount;

    [NativeName("preferredMaxBidirectionalCompoundGroup2ReferenceCount")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    public uint PreferredMaxBidirectionalCompoundGroup2ReferenceCount;

    [NativeName("preferredBidirectionalCompoundReferenceNameMask")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    public uint PreferredBidirectionalCompoundReferenceNameMask;
}
