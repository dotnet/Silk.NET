// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "KHR", 0)]
[NativeName("VkVideoDecodeAV1DpbSlotInfoKHR")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct VideoDecodeAV1DpbSlotInfoKHR
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_av1"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    public StructureType SType;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_av1"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    public void* PNext;

    [NativeName("pStdReferenceInfo")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_av1"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    public StdVideoDecodeAV1ReferenceInfo* PStdReferenceInfo;
}
