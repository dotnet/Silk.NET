// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "KhronosVendor", "KHR")]
[NativeName("VkVideoEncodeIntraRefreshModeFlagBitsKHR")]
[NativeTypeName("unsigned int")]
[Flags]
[SupportedApiProfile("vulkan")]
public enum VkVideoEncodeIntraRefreshModeFlagsKHR : uint
{
    [NameAffix("Suffix", "KhronosImpliedVendor", "KHR")]
    [NativeName("VK_VIDEO_ENCODE_INTRA_REFRESH_MODE_NONE_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_intra_refresh"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VkVideoEncodeIntraRefreshModeNone = 0,

    [NameAffix("Suffix", "KhronosImpliedVendor", "KHR")]
    [NativeName("VK_VIDEO_ENCODE_INTRA_REFRESH_MODE_PER_PICTURE_PARTITION_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_intra_refresh"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VkVideoEncodeIntraRefreshModePerPicturePartitionBit = 0x00000001,

    [NameAffix("Suffix", "KhronosImpliedVendor", "KHR")]
    [NativeName("VK_VIDEO_ENCODE_INTRA_REFRESH_MODE_BLOCK_BASED_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_intra_refresh"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VkVideoEncodeIntraRefreshModeBlockBasedBit = 0x00000002,

    [NameAffix("Suffix", "KhronosImpliedVendor", "KHR")]
    [NativeName("VK_VIDEO_ENCODE_INTRA_REFRESH_MODE_BLOCK_ROW_BASED_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_intra_refresh"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VkVideoEncodeIntraRefreshModeBlockRowBasedBit = 0x00000004,

    [NameAffix("Suffix", "KhronosImpliedVendor", "KHR")]
    [NativeName("VK_VIDEO_ENCODE_INTRA_REFRESH_MODE_BLOCK_COLUMN_BASED_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_intra_refresh"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VkVideoEncodeIntraRefreshModeBlockColumnBasedBit = 0x00000008,

    [NameAffix("Suffix", "KhronosImpliedVendor", "KHR")]
    [NativeName("VK_VIDEO_ENCODE_INTRA_REFRESH_MODE_FLAG_BITS_MAX_ENUM_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_intra_refresh"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VkVideoEncodeIntraRefreshModeFlagBitsMaxEnum = 0x7FFFFFFF,
}
