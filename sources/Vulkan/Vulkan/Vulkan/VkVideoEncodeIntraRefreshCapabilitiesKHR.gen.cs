// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkVideoEncodeIntraRefreshCapabilitiesKHR")]
[NameAffix("Suffix", "KhronosVendor", "KHR")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct VkVideoEncodeIntraRefreshCapabilitiesKHR
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_intra_refresh"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    public VkStructureType SType;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_intra_refresh"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    public void* PNext;

    [NativeName("intraRefreshModes")]
    [NativeTypeName("VkVideoEncodeIntraRefreshModeFlagsKHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_intra_refresh"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    public VkVideoEncodeIntraRefreshModeFlagsKHR IntraRefreshModes;

    [NativeName("maxIntraRefreshCycleDuration")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_intra_refresh"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    public uint MaxIntraRefreshCycleDuration;

    [NativeName("maxIntraRefreshActiveReferencePictures")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_intra_refresh"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    public uint MaxIntraRefreshActiveReferencePictures;

    [NativeName("partitionIndependentIntraRefreshRegions")]
    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_intra_refresh"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    public uint PartitionIndependentIntraRefreshRegions;

    [NativeName("nonRectangularIntraRefreshRegions")]
    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_intra_refresh"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    public uint NonRectangularIntraRefreshRegions;
}
