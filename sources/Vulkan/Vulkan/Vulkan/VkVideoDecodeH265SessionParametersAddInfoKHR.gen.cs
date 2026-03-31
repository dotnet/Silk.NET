// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkVideoDecodeH265SessionParametersAddInfoKHR")]
[NameAffix("Suffix", "KhronosVendor", "KHR")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct VkVideoDecodeH265SessionParametersAddInfoKHR
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h265"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    public VkStructureType SType;

    [NativeName("pNext")]
    [NativeTypeName("const void *")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h265"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    public void* PNext;

    [NativeName("stdVPSCount")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h265"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    public uint StdVpsCount;

    [NativeName("pStdVPSs")]
    [NativeTypeName("const StdVideoH265VideoParameterSet *")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h265"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    public StdVideoH265VideoParameterSet* PStdVPSs;

    [NativeName("stdSPSCount")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h265"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    public uint StdSpsCount;

    [NativeName("pStdSPSs")]
    [NativeTypeName("const StdVideoH265SequenceParameterSet *")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h265"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    public StdVideoH265SequenceParameterSet* PStdSPSs;

    [NativeName("stdPPSCount")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h265"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    public uint StdPpsCount;

    [NativeName("pStdPPSs")]
    [NativeTypeName("const StdVideoH265PictureParameterSet *")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h265"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    public StdVideoH265PictureParameterSet* PStdPPSs;
}
