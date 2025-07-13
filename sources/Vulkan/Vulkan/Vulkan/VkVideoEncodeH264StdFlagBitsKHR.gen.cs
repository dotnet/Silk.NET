// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
[Flags]
public enum VideoEncodeH264StdFlagsKHR : uint
{
    None = 0,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    SeparateColorPlaneFlagSetBitKHR = 0x00000001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    QpprimeYZeroTransformBypassFlagSetBitKHR = 0x00000002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    ScalingMatrixPresentFlagSetBitKHR = 0x00000004,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    ChromaQpIndexOffsetBitKHR = 0x00000008,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    SecondChromaQpIndexOffsetBitKHR = 0x00000010,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    PicInitQpMinus26BitKHR = 0x00000020,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    WeightedPredFlagSetBitKHR = 0x00000040,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    WeightedBipredIdcExplicitBitKHR = 0x00000080,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    WeightedBipredIdcImplicitBitKHR = 0x00000100,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    Transform8X8ModeFlagSetBitKHR = 0x00000200,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    DirectSpatialMvPredFlagUnsetBitKHR = 0x00000400,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    EntropyCodingModeFlagUnsetBitKHR = 0x00000800,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    EntropyCodingModeFlagSetBitKHR = 0x00001000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    Direct8X8InferenceFlagUnsetBitKHR = 0x00002000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    ConstrainedIntraPredFlagSetBitKHR = 0x00004000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    DeblockingFilterDisabledBitKHR = 0x00008000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    DeblockingFilterEnabledBitKHR = 0x00010000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    DeblockingFilterPartialBitKHR = 0x00020000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    SliceQpDeltaBitKHR = 0x00080000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    DifferentSliceQpDeltaBitKHR = 0x00100000,
}
