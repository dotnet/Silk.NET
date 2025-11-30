// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoAV1TransferCharacteristics")]
[SupportedApiProfile("vulkan")]
public enum StdVideoAv1TransferCharacteristics : uint
{
    [NativeName("STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_RESERVED_0")]
    [SupportedApiProfile("vulkan")]
    Reserved0 = 0,

    [NativeName("STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_BT_709")]
    [SupportedApiProfile("vulkan")]
    Bt709 = 1,

    [NativeName("STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_UNSPECIFIED")]
    [SupportedApiProfile("vulkan")]
    Unspecified = 2,

    [NativeName("STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_RESERVED_3")]
    [SupportedApiProfile("vulkan")]
    Reserved3 = 3,

    [NativeName("STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_BT_470_M")]
    [SupportedApiProfile("vulkan")]
    Bt470M = 4,

    [NativeName("STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_BT_470_B_G")]
    [SupportedApiProfile("vulkan")]
    Bt470BG = 5,

    [NativeName("STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_BT_601")]
    [SupportedApiProfile("vulkan")]
    Bt601 = 6,

    [NativeName("STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_SMPTE_240")]
    [SupportedApiProfile("vulkan")]
    Smpte240 = 7,

    [NativeName("STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_LINEAR")]
    [SupportedApiProfile("vulkan")]
    Linear = 8,

    [NativeName("STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_LOG_100")]
    [SupportedApiProfile("vulkan")]
    Log100 = 9,

    [NativeName("STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_LOG_100_SQRT10")]
    [SupportedApiProfile("vulkan")]
    Log100Sqrt10 = 10,

    [NativeName("STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_IEC_61966")]
    [SupportedApiProfile("vulkan")]
    Iec61966 = 11,

    [NativeName("STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_BT_1361")]
    [SupportedApiProfile("vulkan")]
    Bt1361 = 12,

    [NativeName("STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_SRGB")]
    [SupportedApiProfile("vulkan")]
    Srgb = 13,

    [NativeName("STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_BT_2020_10_BIT")]
    [SupportedApiProfile("vulkan")]
    Bt2020X10Bit = 14,

    [NativeName("STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_BT_2020_12_BIT")]
    [SupportedApiProfile("vulkan")]
    Bt2020X12Bit = 15,

    [NativeName("STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_SMPTE_2084")]
    [SupportedApiProfile("vulkan")]
    Smpte2084 = 16,

    [NativeName("STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_SMPTE_428")]
    [SupportedApiProfile("vulkan")]
    Smpte428 = 17,

    [NativeName("STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_HLG")]
    [SupportedApiProfile("vulkan")]
    Hlg = 18,
}
