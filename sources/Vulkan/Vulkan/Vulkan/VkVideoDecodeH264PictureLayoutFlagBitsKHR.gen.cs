// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public enum VideoDecodeH264PictureLayoutFlagsKHR
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h264"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    ProgressiveKHR = 0,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h264"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    InterlacedInterleavedLinesBitKHR = 0x00000001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h264"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    InterlacedSeparatePlanesBitKHR = 0x00000002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h264"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    FlagBitsMaxEnumKHR = 0x7FFFFFFF,
}
