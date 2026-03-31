// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkVideoEncodeH265CapabilitiesKHR")]
[NameAffix("Suffix", "KhronosVendor", "KHR")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct VkVideoEncodeH265CapabilitiesKHR
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    public VkStructureType SType;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    public void* PNext;

    [NativeName("flags")]
    [NativeTypeName("VkVideoEncodeH265CapabilityFlagsKHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    public VkVideoEncodeH265CapabilityFlagsKHR Flags;

    [NativeName("maxLevelIdc")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    public StdVideoH265LevelIdc MaxLevelIdc;

    [NativeName("maxSliceSegmentCount")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    public uint MaxSliceSegmentCount;

    [NativeName("maxTiles")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    public VkExtent2D MaxTiles;

    [NativeName("ctbSizes")]
    [NativeTypeName("VkVideoEncodeH265CtbSizeFlagsKHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    public VkVideoEncodeH265CtbSizeFlagsKHR CtbSizes;

    [NativeName("transformBlockSizes")]
    [NativeTypeName("VkVideoEncodeH265TransformBlockSizeFlagsKHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    public VkVideoEncodeH265TransformBlockSizeFlagsKHR TransformBlockSizes;

    [NativeName("maxPPictureL0ReferenceCount")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    public uint MaxPPictureL0ReferenceCount;

    [NativeName("maxBPictureL0ReferenceCount")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    public uint MaxBPictureL0ReferenceCount;

    [NativeName("maxL1ReferenceCount")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    public uint MaxL1ReferenceCount;

    [NativeName("maxSubLayerCount")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    public uint MaxSubLayerCount;

    [NativeName("expectDyadicTemporalSubLayerPattern")]
    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    public uint ExpectDyadicTemporalSubLayerPattern;

    [NativeName("minQp")]
    [NativeTypeName("int32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    public int MinQp;

    [NativeName("maxQp")]
    [NativeTypeName("int32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    public int MaxQp;

    [NativeName("prefersGopRemainingFrames")]
    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    public uint PrefersGopRemainingFrames;

    [NativeName("requiresGopRemainingFrames")]
    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    public uint RequiresGopRemainingFrames;

    [NativeName("stdSyntaxFlags")]
    [NativeTypeName("VkVideoEncodeH265StdFlagsKHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    public VkVideoEncodeH265StdFlagsKHR StdSyntaxFlags;
}
