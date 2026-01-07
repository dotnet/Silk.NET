// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkVideoDecodeH264SessionParametersAddInfoKHR")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct VideoDecodeH264SessionParametersAddInfoKHR
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h264"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    public StructureType SType;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h264"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    public void* PNext;

    [NativeName("stdSPSCount")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h264"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    public uint StdSPSCount;

    [NativeName("pStdSPSs")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h264"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    public StdVideoH264SequenceParameterSet* PStdSPSs;

    [NativeName("stdPPSCount")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h264"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    public uint StdPPSCount;

    [NativeName("pStdPPSs")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h264"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    public StdVideoH264PictureParameterSet* PStdPPSs;
}
