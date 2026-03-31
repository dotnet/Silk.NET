// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkVideoDecodeVP9PictureInfoKHR")]
[NameAffix("Suffix", "KhronosVendor", "KHR")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct VkVideoDecodeVp9PictureInfoKHR
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_vp9"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    public VkStructureType SType;

    [NativeName("pNext")]
    [NativeTypeName("const void *")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_vp9"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    public void* PNext;

    [NativeName("pStdPictureInfo")]
    [NativeTypeName("const StdVideoDecodeVP9PictureInfo *")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_vp9"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    public StdVideoDecodeVp9PictureInfo* PStdPictureInfo;

    [NativeName("referenceNameSlotIndices")]
    [NativeTypeName("int32_t[3]")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_vp9"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    public VkVideoDecodeVp9PictureInfoKHRReferenceNameSlotIndices ReferenceNameSlotIndices;

    [NativeName("uncompressedHeaderOffset")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_vp9"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    public uint UncompressedHeaderOffset;

    [NativeName("compressedHeaderOffset")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_vp9"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    public uint CompressedHeaderOffset;

    [NativeName("tilesOffset")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_vp9"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    public uint TilesOffset;
}
