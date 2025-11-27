// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameSuffix("KHR", 0)]
[NativeName("VkVideoDecodeH264InlineSessionParametersInfoKHR")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct VideoDecodeH264InlineSessionParametersInfoKHR
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h264", "VK_KHR_video_maintenance2"],
        ImpliesSets = ["VK_KHR_video_queue"],
        RequireAll = true
    )]
    public StructureType SType;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h264", "VK_KHR_video_maintenance2"],
        ImpliesSets = ["VK_KHR_video_queue"],
        RequireAll = true
    )]
    public void* PNext;

    [NativeName("pStdSPS")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h264", "VK_KHR_video_maintenance2"],
        ImpliesSets = ["VK_KHR_video_queue"],
        RequireAll = true
    )]
    public StdVideoH264SequenceParameterSet* PStdSPS;

    [NativeName("pStdPPS")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h264", "VK_KHR_video_maintenance2"],
        ImpliesSets = ["VK_KHR_video_queue"],
        RequireAll = true
    )]
    public StdVideoH264PictureParameterSet* PStdPPS;
}
