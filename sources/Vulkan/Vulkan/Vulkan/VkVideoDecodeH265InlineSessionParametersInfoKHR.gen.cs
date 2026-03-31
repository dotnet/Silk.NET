// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkVideoDecodeH265InlineSessionParametersInfoKHR")]
[NameAffix("Suffix", "KhronosVendor", "KHR")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct VkVideoDecodeH265InlineSessionParametersInfoKHR
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h265", "VK_KHR_video_maintenance2"],
        ImpliesSets = ["VK_KHR_video_queue"],
        RequireAll = true
    )]
    public VkStructureType SType;

    [NativeName("pNext")]
    [NativeTypeName("const void *")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h265", "VK_KHR_video_maintenance2"],
        ImpliesSets = ["VK_KHR_video_queue"],
        RequireAll = true
    )]
    public void* PNext;

    [NativeName("pStdVPS")]
    [NativeTypeName("const StdVideoH265VideoParameterSet *")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h265", "VK_KHR_video_maintenance2"],
        ImpliesSets = ["VK_KHR_video_queue"],
        RequireAll = true
    )]
    public StdVideoH265VideoParameterSet* PStdVps;

    [NativeName("pStdSPS")]
    [NativeTypeName("const StdVideoH265SequenceParameterSet *")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h265", "VK_KHR_video_maintenance2"],
        ImpliesSets = ["VK_KHR_video_queue"],
        RequireAll = true
    )]
    public StdVideoH265SequenceParameterSet* PStdSps;

    [NativeName("pStdPPS")]
    [NativeTypeName("const StdVideoH265PictureParameterSet *")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h265", "VK_KHR_video_maintenance2"],
        ImpliesSets = ["VK_KHR_video_queue"],
        RequireAll = true
    )]
    public StdVideoH265PictureParameterSet* PStdPps;
}
